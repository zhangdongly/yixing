using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.constant;
using Yixing.model;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.Dialog
{
    public partial class AddStatus : Form
    {
        //由构造函数传递过来，表示选中的翼型列表
        List<DCYixing> yxList = new List<DCYixing>();
        //用于记录传递过来需要更改的任意一个DC
        DCStatus ds;
        //用于记录哪些项可以编辑的对象
        StatusEditAble editAble = new StatusEditAble();

        Boolean isgjOpened = false;

        //用于判断是选中了迎角还是定升力系数
        Boolean isdyj = false;

        int znkey = 0;
        int gjkey = 0;
        int ztkey = 0;
        //记录单独状态的DIC 包括高级和转涅
        public Dictionary<int, DCStatus> ztDic = new Dictionary<int, DCStatus>();
        //记录单独转涅的DIC 包括高级和转涅
        public Dictionary<int, DCZhuannie> znDic = new Dictionary<int, DCZhuannie>();
        //记录单独高级的DIC 包括高级和转涅
        public Dictionary<int, DCGaoji> gjDic = new Dictionary<int, DCGaoji>();
        //上端传递过来的，该翼型的所有状态key的List
        List<int> ztList = new List<int>();
        //本页选中需要修改的状态key的List
        List<int> editztList = new List<int>();

        //新增时，需要将老的字典传递过来，
        //而根据最初始的逻辑，新生产的状态存放的dictionary，中的key，和原始的key是不同的
        //这个仅用于展示不做其他作用
        public Dictionary<int, DCStatus> oldztDic = new Dictionary<int, DCStatus>();

        //修改时专用，用作记录修改后的一个转涅对象
        DCZhuannie editZn = null;

        //修改时专用，用作记录修改后的一个高级对象
        DCGaoji editGj = null;

        //用于记录本类删除的 由父窗口传递过来的状态
        public List<int> delZtkey = new List<int>();

        public AddStatus()
        {
            InitializeComponent();
            this.radioButton4.Checked = true; 
            this.exListView2.SelectedIndexChanged -= new EventHandler(this.exListView2_SelectedIndexChanged);
        }

        public AddStatus(List<int> ztKeyList, Dictionary<int, DCStatus> ztDic_, Dictionary<int, DCZhuannie> znDic_, Dictionary<int, DCGaoji> gjDic_)
        {
            InitializeComponent();
            //编辑初始化，整个左边先不可用，需要选中后才可以
            this.panel1.Enabled = false;
           
            //将添加隐藏，将修改展现
            this.button12.Visible = false;
            this.button8.Visible = false;
            this.button5.Visible = false;
            this.button13.Visible = true;
            //修改按钮先不可用
            this.button13.Enabled = true;

            this.ztList = ztKeyList;
            this.ztDic = ztDic_;
            this.znDic = znDic_;
            this.gjDic = gjDic_;
            //需要两两比较 确定哪些项目不能编辑

            //编辑时的某些按钮的事件处理与添加时不一样 做出调整
            //this.checkBox1.CheckedChanged -= new System.EventHandler(this.checkBox2_CheckedChanged);
            //this.checkBox1.CheckedChanged += new System.EventHandler(this.znEdit_CheckedChanged);

            this.button2.Click -= new System.EventHandler(this.button3_Click);
            this.button2.Click += new System.EventHandler(this.gjEdit_Click);

            foreach (int ztKey in ztKeyList)
            {
                DCStatus dcs = ztDic[ztKey];
                this.addToList(dcs, ztKey);
            }

        }

        public AddStatus(List<DCYixing> yxList1,Dictionary<int, DCGaoji> gjDic)
        {
            InitializeComponent();
            this.radioButton4.Checked = true;
            yxList = yxList1;
            foreach(DCYixing yx in yxList){
                List<DCStatus> statusList = yx.dcList;
                if (statusList != null)
                {
                    foreach (DCStatus dc in statusList)
                    {
                        this.addToList(dc, dc.key, gjDic);
                    }
                } 
            }
            this.exListView2.SelectedIndexChanged -= new EventHandler(this.exListView2_SelectedIndexChanged);
        }

        private void addMethodAndStatus()
        {
            float mahe = 0;
            if (!float.TryParse(this.textBox2.Text, out mahe))
            {
                MessageBox.Show("马赫数不能为空，且必须为数字");
                return;
            }
            
            List<DCStatus> dcList = new List<DCStatus>();
            String dslxs = this.textBox3.Text;
            String dyj = "";
            float low = 0;
            float high = 0;
            float step = 0;
            //rd3 定升力系数 rd4 定迎角
            //rd5 单个  rd6 范围
            if (!radioButton3.Checked)
            {
                isdyj = true;
                if (radioButton5.Checked)
                {
                    float dyjf;
                    dyj = textBox8.Text;
                    if (!float.TryParse(this.textBox8.Text, out dyjf))
                    {
                        MessageBox.Show("定迎角不能为空，且必须为数字");
                        return;
                    }
                    dcList = setDcStatus(mahe, dyjf, 0f);
                    if (dcList.Count == 0)
                    {
                        MessageBox.Show("马赫数：" + mahe + " 定迎角：" + dyjf + " 存在重复状态，重复状态会被自动忽略，请修改定马赫数，或者定迎角度");
                    }
                }
                else
                {
                    try
                    {
                        low = float.Parse(this.textBox5.Text);
                        high = float.Parse(this.textBox4.Text);
                        
                        if (low > high)
                        {
                            float tem = low;
                            low = high;
                            high = tem;
                        }

                        step = float.Parse(this.textBox6.Text);
                        if (step <= 0.1 || step >= 4)
                        {
                            MessageBox.Show("步长的范围是0.1 - 4之间，请修正！");
                            return;
                        }

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("上限，下限，步长请输入数字");
                        return;
                    }
                    //
                    int count = 0;
                    int yxcount = this.yxList.Count;
                    for (float yl = low; yl <= high; yl += step)
                    {
                        count++;
                        List<DCStatus> dcList1 = setDcStatus(mahe, yl, 0f);
                        dcList.AddRange(dcList1);
                    }
                    //如果最终生产出来的list的长度小于循环次数 证明有些定迎角重复了被忽略掉了
                    if (dcList.Count < count*yxcount)
                    {
                        MessageBox.Show("按范围添加定迎角，存在重复状态，重复状态会被自动忽略");
                    }
                }
            }
            else
            {
                float slxs;
                if (!float.TryParse(dslxs, out slxs))
                {
                    MessageBox.Show("定升力系数不能为空，且必须为数字");
                    return;
                }
                isdyj = false;
                dcList = setDcStatus(mahe, 0f, slxs);
               

            }

            //如果需要处理的，状态为0条直接返回，不错操作
            //此处一般是由于状态重复导致发生的country=0
            //如果不做这个return，会导致CheckBox1的选中被取消
            if (dcList.Count == 0) return;

            foreach (DCStatus dc in dcList)
            {
                ztkey++;
                ztDic.Add(ztkey, dc);

                this.addToList(dc,ztkey);
            }
            isgjOpened = false;
        }

        //添加一跳记录到ListView2
        private void addToList(DCStatus dc, int key)
        {
            addToList(dc, key, gjDic);

            this.exListView2.sort();
        }

        //添加一跳记录到ListView2,
        private void addToList(DCStatus dc,int key,Dictionary<int,DCGaoji> gjDic_)
        {
            float mahe; float dyj; float dslxs;
            mahe = dc.mahe;
            dyj = dc.dyj;
            dslxs = dc.dslxs;
            EXListViewItem item = new EXListViewItem(mahe.ToString());

            //CheckBox c = new CheckBox();
            //c.Checked = true;
            //EXControlListViewSubItem exc = new EXControlListViewSubItem();
            //item.SubItems.Add(exc);
            //this.exListView2.AddControlToSubItem(c, exc);

            if (dc.isyj)
            {
                EXListViewSubItem sub = new EXListViewSubItem(dyj.ToString("0.000"));
                item.SubItems.Add(sub);
                EXListViewSubItem subflag = new EXListViewSubItem("1");
                item.SubItems.Add(subflag);
            }
            else
            {
                EXListViewSubItem sub = new EXListViewSubItem(dslxs.ToString("0.000"), Color.Red, Color.White);
                item.SubItems.Add(sub);
                EXListViewSubItem subflag = new EXListViewSubItem("2");
                item.SubItems.Add(subflag);
                
            }
            //CheckBox c = new CheckBox();
            //c.Checked = this.checkBox1.Checked;
            //EXControlListViewSubItem clv = new EXControlListViewSubItem();
            if (dc.lsgs == Constant.LSGS_ROE)
            {
                item.SubItems.Add("Roe");
            }
            else { item.SubItems.Add("Van Leer"); }

            if (dc.dlmx ==Constant.DLMX_SA)
            {
                item.SubItems.Add("Sa");
            }
            else
            {
                item.SubItems.Add("kw sst");
            }

            //处理转涅相关参数
            int znkey = dc.znKey;
            
            if (znkey!=0)
            {
                item.SubItems.Add("是");
            }
            else
            {
                item.SubItems.Add("否");
            }

            //处理高级相关参数
            int gjkey = dc.gjKey;
            
            if (gjkey!=0)
            {
                DCGaoji gj = gjDic_[gjkey];
                item.SubItems.Add(gj.cfl.ToString());
                if (gj.xzs!=0)
                    item.SubItems.Add(gj.xzs.ToString());
                else
                    item.SubItems.Add("无");
            }
            else
            {
                item.SubItems.Add("无");
                item.SubItems.Add("无");
            }
            //使用tag来保存对应的高级和转涅的配置
            item.Tag = key;
            this.exListView2.Items.Add(item);
        }

        private List<DCStatus> setDcStatus(float mahe, float dyj, float dslxs)
        { 
            List<DCStatus> dcList = new List<DCStatus>();
            DCStatus dc = new DCStatus();
            dc.mahe = mahe;
            dc.dslxs = dslxs;
            dc.dyj = dyj;
            if (isdyj)
                dc.isyj = true;
            else
                dc.isyj = false;

            //先验证当前添加的
            foreach (int skey in ztDic.Keys)
            {
                DCStatus olddc = ztDic[skey];
                if (olddc.mahe == mahe && olddc.dslxs == dslxs && !isdyj)
                {
                    MessageBox.Show("马赫数：" + mahe + "  定升力系数：" + dslxs + " 该条状态重复，请修改定升力系数，或者定马赫数");
                    return dcList;
                }
                if (dyj == 0)
                {
                    if (olddc.mahe == mahe && olddc.dyj == dyj && isdyj && olddc.isyj && olddc.dyj == 0)
                    {
                        return dcList;
                    }
                }
                else
                {
                    if (olddc.mahe == mahe && olddc.dyj == dyj && isdyj)
                    {
                        return dcList;
                    }
                }
            }

            //再验证老的传递过来的有没有
            foreach (DCYixing yx in yxList)
            {
                List<DCStatus> statusList = yx.dcList;
                if (statusList != null)
                {
                    foreach (DCStatus olddc in statusList)
                    {
                        if (olddc.mahe == mahe && olddc.dslxs == dslxs && !isdyj)
                        {
                            MessageBox.Show("马赫数：" + mahe + "  定升力系数：" + dslxs + " 该条状态重复，请修改定升力系数，或者定马赫数");
                            return dcList;
                        }
                        if (dyj == 0)
                        {
                            if (olddc.mahe == mahe && olddc.dyj == dyj && isdyj && olddc.isyj && olddc.dyj == 0)
                            {
                                return dcList;
                            }
                        }
                        else
                        {
                            if (olddc.mahe == mahe && olddc.dyj == dyj && isdyj)
                            {
                                return dcList;
                            }
                        }
                    }
                }
            }

            String lsgs = this.comboBox1.Text;
            if (lsgs.Equals("Roe"))
            {
                dc.lsgs = Constant.LSGS_ROE;
            }
            else
            {
                dc.lsgs = Constant.LSGS_LEER;
            }

            //这两个key用于从dic中取属性对象
            //转涅若选中才有这个key
            if (this.checkBox1.Checked)
            {
                dc.znKey = znkey;
                //如果选择了转涅，这个断流模型只能选择sst 所以值为7
                dc.dlmx = 7;

            }
            else
            {
                dc.znKey = 0;
                String dlmx = this.comboBox2.Text;
                if (dlmx.Equals("SA"))
                {
                    dc.dlmx = Constant.DLMX_SA;
                }
                else
                {
                    dc.dlmx = Constant.DLMX_SST;
                }
            }
            if (!isgjOpened)
            {
                gjkey++;
                DCGaoji gj = new DCGaoji();
                gj.cfl = 2;
                gj.onedd = 1000;
                gj.secdd = 1000;
                gj.thirdd = 600;
                if(dc.znKey!=0 )
                    gj.thirdd = 2500;
                gj.xzs = 0;
                gjDic.Add(gjkey, gj);
            }
            dc.gjKey = gjkey;

            if (yxList.Count > 0)
            {
                foreach (DCYixing yx in yxList)
                {
                    dc.yx = yx;
                    dcList.Add(dc);
                }
            }
            else
            {
                MessageBox.Show("添加状态时至少选中一个 翼型文件");
            }

            return dcList;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean znCheck = this.checkBox1.Checked;
            if (znCheck)
            {
                float fddls;
                float wnxb;

                if (!float.TryParse(this.txt_fddls.Text, out fddls))
                {
                    MessageBox.Show("风洞湍流度必须为数字");
                    return;
                }
                if (!float.TryParse(this.txt_wnxb.Text, out wnxb))
                {
                    MessageBox.Show("涡粘性比必须为数字");
                    return;
                }

                DCZhuannie zn = new DCZhuannie();
                znkey++;
                zn.fddls = fddls;
                zn.wnxb = wnxb;
                znDic.Add(znkey, zn);
            }

            if (this.yxList.Count > 0)
            {
                this.addMethodAndStatus();
            }
        }

        private void AddStatus_Load(object sender, EventArgs e)
        {
            //this.exListView2.Columns.Add("马赫数");
            //this.exListView2.Columns.Add("迎角/升力系数", 90);
            //this.exListView2.Columns.Add("转捩");
            //ImageList iList = new ImageList();
            //iList.ImageSize = new Size(1, 25);
            //this.exListView2.SmallImageList = iList;

            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            this.comboBox2.Text = this.comboBox2.Items[0].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = this.exListView2.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.exListView2.SelectedItems[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    DCStatus zt =null;
                    try
                    {
                        zt = ztDic[ztKey];
                    }catch(Exception ex){
                        //如果是由上级传过来的，直接remove掉item，然后记录返回给上级处理
                        this.delZtkey.Add(ztKey);
                        this.exListView2.Items.Remove(item);
                        continue;
                    }
                    
                    gjDic.Remove(zt.gjKey);
                    znDic.Remove(zt.znKey);
                    ztDic.Remove(ztKey);
                    int ztdicKey = zt.key;
                    DCYixing yx = zt.yx;
                    int yxkey = yx.key;
                    if (yx.key != 0)
                    {
                        List<DCStatus> ztList = yx.dcList;
                        if (ztList != null)
                        {
                            for (int j = 0; j < ztList.Count; j++)
                            {
                                DCStatus sta = ztList[j];
                                if (sta.key == ztdicKey)
                                {
                                    ztList.Remove(sta);
                                }

                            }
                        }
                    }
                }
                this.exListView2.Items.Remove(item);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            for (int i = this.exListView2.Items.Count - 1; i >= 0; i--)

            {
                ListViewItem item = this.exListView2.Items[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    DCStatus zt = null;
                    try
                    {
                        zt = ztDic[ztKey];
                    }
                    catch (Exception ex)
                    {
                        this.delZtkey.Add(ztKey);
                        this.exListView2.Items.Remove(item);
                        continue;
                    }
                    gjDic.Remove(zt.gjKey);
                    znDic.Remove(zt.znKey);
                    ztDic.Remove(ztKey);
                    int ztdicKey = zt.key;
                    DCYixing yx = zt.yx;
                    int yxkey = yx.key;
                    if (yx.key != 0)
                    {
                        List<DCStatus> ztList = yx.dcList;
                        if (ztList != null)
                        {
                            for (int j = 0; j < ztList.Count; j++)
                            {
                                DCStatus sta = ztList[j];
                                if (sta.key == ztdicKey)
                                {
                                    ztList.Remove(sta);
                                }

                            }
                        }
                    }
                }
                this.exListView2.Items.Remove(item);
            }
        }
        //点击转涅
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            //如果不断的选中取消只会导致key增大，而不会对象增多
            if (c.Checked)
            {
                this.panel4.Enabled = true;
                this.txt_fddls.Text = "0";
                this.txt_wnxb.Text = "0";
                this.comboBox2.Text = "kw sst";
            }
            else
            {
                this.panel4.Enabled = false;
                //取消的时候不removed，让其存在，影响不大，且有用
                //znDic.Remove(znkey);
            }
        }

        //修改时点击转涅
        private void znEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            //如果不断的选中取消只会导致key增大，而不会对象增多
            if (c.Checked)
            {
                float fddls;
                float wnxb;

                editZn = new DCZhuannie();
                if(editAble.fddld){
                     if (!float.TryParse(this.txt_fddls.Text, out fddls))
                    {
                        MessageBox.Show("风洞湍流度必须为数字");
                        return;
                    }
                    editZn.fddls = fddls;
                }
                if(editAble.wnxb){
                        if (!float.TryParse(this.txt_wnxb.Text, out wnxb))
                    {
                        MessageBox.Show("涡粘性比必须为数字");
                        return;
                    }
               
                    editZn.wnxb = wnxb;
                }
               
             } else { this.checkBox1.Checked = false; }
        }

        //点击高级
        private void button3_Click(object sender, EventArgs e)
        {
            DingChangGaoji dcgj;
            if (isgjOpened)
            {
                DCGaoji gjold = gjDic[gjkey];
                dcgj = new DingChangGaoji(gjold, new StatusEditAble());
            }
            else
            {
                DCGaoji gj = new DCGaoji();
                gj.cfl = 2;
                gj.onedd = 1000;
                gj.secdd = 1000;
                gj.thirdd = 600;
                if (this.checkBox1.Checked)
                    gj.thirdd = 2500;
                gj.xzs = 0;
                dcgj = new DingChangGaoji(gj, new StatusEditAble());
            }
            if (dcgj.ShowDialog() == DialogResult.OK)
            {
                isgjOpened = true;
                gjkey++;
                DCGaoji gj = new DCGaoji();
                gj.cfl = dcgj.cfl;
                gj.onedd = dcgj.onedd;
                gj.secdd = dcgj.secdd;
                gj.thirdd = dcgj.thirdd;
                gj.xzs = dcgj.xzs;
                gjDic.Add(gjkey, gj);
            }
        }

        //点击高级
        private void gjEdit_Click(object sender, EventArgs e)
        {
            
            DingChangGaoji gjDialog = new DingChangGaoji(editGj, editAble);

            //如果修改后点击确认，则需要循环将 需要改的zn全部改了
            if ( gjDialog.ShowDialog() == DialogResult.OK)
            {
                editGj  = new DCGaoji();
                editGj.cfl = gjDialog.cfl;
                editGj.onedd = gjDialog.onedd;
                editGj.secdd = gjDialog.secdd;
                editGj.thirdd = gjDialog.thirdd;
                editGj.xzs = gjDialog.xzs;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                this.textBox3.Enabled = false;
                this.textBox8.Enabled = false;
                this.radioButton6.Checked = true;
                this.panel8.Enabled = true;
                if (this.textBox6.Text.Trim().Equals(""))
                    this.textBox6.Text = "1";
                this.panel6.Enabled = true;
            }
            else
            {
                this.textBox3.Enabled = true;
                this.radioButton3.Checked = true;
                this.panel6.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                textBox8.Enabled = true;
                this.panel8.Enabled = false;
            }
            else
            {
                textBox8.Enabled = false;
                this.panel8.Enabled = true;
                if (this.textBox6.Text.Trim().Equals(""))
                    this.textBox6.Text = "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改时调用，将所有项的，可改项置为修改后的项
        private void changeAllstatus()
        {
            foreach (int ztKey in editztList)
            {
                DCStatus dcs = ztDic[ztKey];
                //修改常规项目
                if (editAble.mahe)
                {
                    String mahe = this.textBox2.Text;
                    float omh;
                    if (float.TryParse(mahe, out omh)) dcs.mahe = omh;
                    else MessageBox.Show("马赫不能为空，且必须为数字！");
                }

                if (editAble.dslxs)
                {
                    String dslxs = this.textBox3.Text;
                    float odslxs;
                    if (float.TryParse(dslxs, out odslxs)) dcs.dslxs = odslxs;
                    else MessageBox.Show("定升力系数不能为空，且必须为数字！");
                }

                if (editAble.dyj)
                {
                    String dyj = this.textBox8.Text;
                    float odyj;
                    if (float.TryParse(dyj, out odyj)) dcs.dyj = odyj;
                    else MessageBox.Show("定迎角不能为空，且必须为数字！");
                }

                if (editAble.lsgs)
                {
                    String lsgs = this.comboBox1.Text;
                    if (lsgs.Equals("Roe"))
                    {
                        dcs.lsgs = Constant.LSGS_ROE;
                    }
                    else
                    {
                        dcs.lsgs = Constant.LSGS_LEER;
                    }
                }

                if (editAble.dlmx)
                {
                    String dlmx = this.comboBox2.Text;
                    if (dlmx.Equals("SA"))
                    {
                        dcs.dlmx = Constant.DLMX_SA;
                    }
                    else
                    {
                        dcs.dlmx = Constant.DLMX_SST;
                    }

                }

                //这一块是修改转涅的东西
                int znkey = dcs.znKey;
                if (znkey != 0 && editZn!=null)
                {
                    DCZhuannie zn1 = znDic[znkey];
                    //如果应为返回的是各个项的值，所以还得判定，如果是可以修改的才改
                    if (editAble.fddld)
                    {
                        zn1.fddls = editZn.fddls;
                    }
                    if (editAble.wnxb)
                    {
                        zn1.wnxb = editZn.wnxb;
                    }
                }
                //如果原来没有转涅，这个地方添加了
                if (znkey == 0 && editZn != null)
                {
                    //先获取 最大的转涅的key，然后将这个加入到dic中，并修改状态的转涅key
                    int newznkey = 1;
                    foreach(int key in znDic.Keys){
                        if (key > newznkey)
                        {
                            newznkey = key;
                        }
                    }
                    newznkey++;

                    //必须要new一个 做clone，因为editzn会被多次修改
                    DCZhuannie zn1 = new DCZhuannie();
                    //如果应为返回的是各个项的值，所以还得判定，如果是可以修改的才改
                    if (editAble.fddld)
                    {
                        zn1.fddls = editZn.fddls;
                    }
                    if (editAble.wnxb)
                    {
                        zn1.wnxb = editZn.wnxb;
                    }

                    znDic.Add(newznkey, zn1);
                    dcs.znKey = newznkey;
                }

                //这一块是修改高级的东西
                int gjkey = dcs.gjKey;
                if (gjkey != 0 && editGj != null)
                {
                    DCGaoji gj = gjDic[gjkey];
                    if (editAble.cfl) gj.cfl = editGj.cfl;
                    if (editAble.onedd) gj.onedd = editGj.onedd;
                    if (editAble.secdd) gj.secdd = editGj.secdd;
                    if (editAble.thirdd) gj.thirdd = editGj.thirdd;
                    if (editAble.xzs) gj.xzs = editGj.xzs;
                }
                if (gjkey == 0 && editGj != null)
                {
                    //先获取 最大的转涅的key，然后将这个加入到dic中，并修改状态的转涅key
                    int newgjkey = 1;
                    foreach (int key in znDic.Keys)
                    {
                        if (key > newgjkey)
                        {
                            newgjkey = key;
                        }
                    }
                    newgjkey++;

                    DCGaoji gj = new DCGaoji();
                    if (editAble.cfl) gj.cfl = editGj.cfl;
                    if (editAble.onedd) gj.onedd = editGj.onedd;
                    if (editAble.secdd) gj.secdd = editGj.secdd;
                    if (editAble.thirdd) gj.thirdd = editGj.thirdd;
                    if (editAble.xzs) gj.xzs = editGj.xzs;

                    gjDic.Add(newgjkey, gj);
                    dcs.gjKey = newgjkey;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            editZn = null;
            if (this.checkBox1.Checked)
            {
                float fddls;
                float wnxb;

                editZn = new DCZhuannie();
                if (editAble.fddld)
                {
                    if (!float.TryParse(this.txt_fddls.Text, out fddls))
                    {
                        MessageBox.Show("风洞湍流度必须为数字");
                        return;
                    }
                    editZn.fddls = fddls;
                }
                if (editAble.wnxb)
                {
                    if (!float.TryParse(this.txt_wnxb.Text, out wnxb))
                    {
                        MessageBox.Show("涡粘性比必须为数字");
                        return;
                    }

                    editZn.wnxb = wnxb;
                }
            }
            //这个方法是修改所有的转涅和高级的
            this.changeAllstatus();
            //循环修改完成后将，editzn 和 editgj置为null，以便下次点击时处理
            //只能在此处置为null，其他地方修改会影响点击高级 转涅时候的 初始化
            editZn = null;
            editGj = null;

            this.exListView2.Items.Clear();

            foreach (int ztKey in ztList)
            {
                DCStatus dcs = ztDic[ztKey];
                this.addToList(dcs, ztKey);
            }

            //将左侧所有控件初始化为不可用状态
            foreach (Control c in this.panel1.Controls)
            {
                c.Enabled = false;
            }
        }

        private void exListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.exListView2.SelectedItems.Count == 0)
            {
                //修改按钮先不可用
                this.panel1.Enabled = false;
                this.button13.Enabled = false;
                return;
            }

            this.button13.Enabled = true;
            this.panel1.Enabled = true;

            //将左侧所有控件初始化为可用状态
            foreach (Control c in this.panel1.Controls)
            {
                c.Enabled = true;
            }

            //每次点击修改，先将记录需要修改数据的List清空
            editztList.Clear();

            for (int i = 0; i < this.exListView2.SelectedItems.Count; i++)
            {
                ListViewItem item = this.exListView2.SelectedItems[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    //随便选取一个状态出来，用于取值初始化，可以编辑的项目
                    ds = ztDic[ztKey];
                    editztList.Add(ztKey);
                }
            }

            Boolean canedit = false;

            //再定义一个对象用来存储哪一项可以编辑。

            CheckEdit ck = new CheckEdit(editztList, ztDic, znDic, gjDic);
            

            editAble = new StatusEditAble();

            if (!ck.checkmh())
            {
                editAble.mahe = false;
                this.textBox2.Enabled = false;
            }
            else
            {
                this.textBox2.Text = ds.mahe.ToString();
                canedit = true;
            }

            if (!ck.checkslxs())
            {
                editAble.dslxs = false;
                this.textBox3.Enabled = false;
                this.radioButton3.Enabled = false;
            }
            else
            {
                if (ds.dslxs != 0)
                {
                    this.textBox3.Text = ds.dslxs.ToString();
                }
                this.radioButton4.Checked = false;
                canedit = true;
            }

            if (!ck.checkdyj())
            {
                editAble.dyj = false;
                //this.radioButton4.Checked = false;
                this.radioButton4.Enabled = false;
                this.panel6.Enabled = false;
            }
            else
            {
                this.radioButton4.Checked = true;
                this.radioButton5.Checked = true;
                this.panel6.Enabled = true;
                this.textBox8.Text = ds.dyj.ToString();
                this.radioButton6.Enabled = false;
                this.panel8.Enabled = false;
                canedit = true;
            }

            if (!ck.checklsgs())
            {
                editAble.lsgs = false;
                this.comboBox1.Enabled = false;
            }
            else
            {
                if (ds.lsgs == Constant.LSGS_ROE)
                {
                    this.comboBox1.Text = "Roe";
                }
                else { this.comboBox1.Text = "Van Leer"; }
                canedit = true;
            }

            if (!ck.checkdlmx())
            {
                editAble.dlmx = false;
                this.comboBox2.Enabled = false;
            }
            else
            {
                if (ds.dlmx == Constant.DLMX_SA) { this.comboBox2.Text = "SA"; }
                else { this.comboBox2.Text = "kw sst"; }
                canedit = true;
            }

            editAble.fddld = ck.checkznfd();
            editAble.wnxb = ck.checkznwnxb();
            this.checkBox1.Checked = false;
            this.txt_wnxb.Text = "";
            this.txt_fddls.Text = "";
            if (!editAble.fddld && !editAble.wnxb)
            {
                this.checkBox1.Enabled = false;
                this.panel4.Enabled = false;
            }
            else
            {
                this.panel4.Enabled = true;
                //因为选中转涅的时候，端流模型只能是sst
                //所以如果端流模型不能编辑，那么转涅也不能编辑
                if (!editAble.dlmx)
                {
                    this.checkBox1.Enabled = false;
                }
                else
                {
                    Boolean checkClickAble = true;
                    this.checkBox1.Enabled = false;
                    int znkey2 = ds.znKey;
                    if (znkey2 != 0)
                    {
                        DCZhuannie zn = znDic[znkey2];
                        if (!editAble.fddld)
                        {
                            this.txt_fddls.Enabled = false;
                            checkClickAble = false;
                        }
                        else
                        {
                            this.checkBox1.Checked = true;
                            this.txt_fddls.Enabled = true;
                            this.txt_fddls.Text = zn.fddls.ToString();
                        }

                        if (!editAble.wnxb)
                        {
                            this.txt_wnxb.Enabled = false;
                            checkClickAble = false;
                        }
                        else
                        {
                            this.checkBox1.Checked = true;
                            this.txt_wnxb.Enabled = true;
                            this.txt_wnxb.Text = zn.wnxb.ToString();
                        }
                    }
                    if (checkClickAble)
                    {
                        this.checkBox1.Enabled = true;
                    }
                    canedit = true;
                }
            }

            int randomkey = editztList[0];
            DCStatus dcs = ztDic[randomkey];
            int gjkey = dcs.gjKey;
            if (gjkey != 0)
            {
                editGj = gjDic[gjkey];
            }

            editAble.cfl = ck.checkgjcfl();
            editAble.onedd = ck.checkgjonedd();
            editAble.secdd = ck.checkgjsecdd();
            editAble.thirdd = ck.checkgjthirdd();
            editAble.xzs = ck.checkgjxzs();
            if (!editAble.cfl && !editAble.onedd && !editAble.secdd && !editAble.thirdd && !editAble.xzs)
            {
                this.button2.Enabled = false;
            }
            else
            {
                canedit = true;
            }

            if (!canedit)
            {
                MessageBox.Show("选中的条目没有可编辑的项，请退出！");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.Enabled)
            {
                if (this.checkBox1.Checked)
                {
                    String text = this.comboBox2.Text;
                    if (!text.Equals("kw sst"))
                    {
                        this.comboBox2.Text = "kw sst";
                    }
                }
            } 
        }
    }
}
