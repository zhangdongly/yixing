﻿using System;
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

        Boolean isznOpened = false;
        Boolean isgjOpened = false;
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

        //修改时专用，用作记录修改后的一个转涅对象
        DCZhuannie editZn = null;

        //修改时专用，用作记录修改后的一个高级对象
        DCGaoji editGj = null;

        public AddStatus()
        {
            InitializeComponent();
        }

        public AddStatus(List<int> ztKeyList, Dictionary<int, DCStatus> ztDic_, Dictionary<int, DCZhuannie> znDic_, Dictionary<int, DCGaoji> gjDic_)
        {
            InitializeComponent();
            //将添加隐藏，将修改展现
            this.button12.Visible = false;
            this.button13.Visible = true;

            this.ztList = ztKeyList;
            this.ztDic = ztDic_;
            this.znDic = znDic_;
            this.gjDic = gjDic_;
            //需要两两比较 确定哪些项目不能编辑
            
            foreach (int ztKey in ztKeyList)
            {
                DCStatus dcs = ztDic[ztKey];
                this.addToList(dcs,ztKey);
            }

        }

        public AddStatus(List<DCYixing> yxList1)
        {
            InitializeComponent();
            yxList = yxList1;
        }

        private void addMethodAndStatus()
        {
            float mahe = 0;
            if (!float.TryParse(this.textBox2.Text, out mahe))
            {
                MessageBox.Show("马赫数不能为空，且必须为数字");
                return;
            }
            mahe.ToString("0:0.0000");
            List<DCStatus> dcList = new List<DCStatus>();
            String dslxs = textBox3.Text;
            String dyj = "";
            float low = 0;
            float high = 0;
            float step = 0;
            //rd3 定升力系数 rd4 定迎角
            //rd5 单个  rd6 范围
            if (!radioButton3.Checked)
            {
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
                }
                else
                {
                    try
                    {
                        low = float.Parse(this.textBox5.Text);
                        high = float.Parse(this.textBox4.Text);
                        step = float.Parse(this.textBox6.Text);

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("上限，下限，步长请输入数字");
                    }
                    for (float yl = low; yl <= high; yl += step)
                    {
                        dcList = setDcStatus(mahe, yl, 0f);
                    }
                }
            }
            else
            {
                float slxs;
                if (!float.TryParse(this.textBox3.Text, out slxs))
                {
                    MessageBox.Show("定升力系数不能为空，且必须为数字");
                    return;
                }
                dcList = setDcStatus(mahe, 0f, slxs);
               

            }
            foreach (DCStatus dc in dcList)
            {
                ztkey++;
                ztDic.Add(ztkey, dc);

                this.addToList(dc,ztkey);
            }

            isznOpened = false;
            isgjOpened = false;
        }
        //添加一跳记录到ListView2
        private void addToList(DCStatus dc,int key)
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

            if (dyj > 0)
            {
                item.SubItems.Add(dyj.ToString());
            }
            else
            {
                item.SubItems.Add(dslxs.ToString());
            }
            //CheckBox c = new CheckBox();
            //c.Checked = this.checkBox1.Checked;
            //EXControlListViewSubItem clv = new EXControlListViewSubItem();
            item.SubItems.Add(dc.lsgs.ToString());
           

            if (dc.dlmx != 0f)
            {
                item.SubItems.Add(dc.dlmx.ToString());
            }
            else
            {
                item.SubItems.Add("无");
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
                DCGaoji gj = gjDic[gjkey];
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
            if (this.checkBox1.Checked && isznOpened)
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
                gj.cfl = 1000;
                gj.onedd = 1000;
                gj.secdd = 1000;
                gj.thirdd = 1500;
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
                    DCStatus zt = ztDic[ztKey];
                    gjDic.Remove(zt.gjKey);
                    znDic.Remove(zt.znKey);
                    ztDic.Remove(ztKey);

                }
                this.exListView2.Items.Remove(item);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.exListView2.Items.Clear();
            //清除所有缓存数据，并将key置为0
            gjDic.Clear();
            znDic.Clear();
            ztDic.Clear();
            ztkey = 0;
            znkey = 0;
            gjkey = 0;
        }
        //点击转涅
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            //如果不断的选中取消只会导致key增大，而不会对象增多
            if (c.Checked)
            {
                zhuannie z;
                if (isznOpened)
                {
                    DCZhuannie zn = znDic[znkey];
                    z = new zhuannie(zn.fddls, zn.wnxb);
                }
                else
                {
                    z = new zhuannie();
                }

                this.comboBox2.Text = "kw sst";
                z.ShowDialog();
                //若点击确定，则修改数据，若没有则取消本次选中
                if (z.sure)
                {
                    //若是打开过并且点了确定，才算
                    isznOpened = true;
                    //先加一次在作为key来存对象
                    znkey++;
                    DCZhuannie zn = new DCZhuannie();
                    zn.fddls = z.fddls;
                    zn.wnxb = z.wnxb;
                    znDic.Add(znkey, zn);
                }
                else { this.checkBox2.Checked = false; }
            }
            else
            {
                this.comboBox2.Enabled = true;
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
                int znKey = ds.znKey;
                DCZhuannie zn=null;
                if (znKey != 0)
                {
                    zn = this.znDic[znKey];
                }
                zhuannie z = new zhuannie(zn, editAble);
                z.ShowDialog();
                //如果修改后点击确认，则需要循环将 需要改的zn全部改了
                if (z.sure)
                {
                    editZn = new DCZhuannie();
                    editZn.fddls = z.fddls;
                    editZn.wnxb = z.wnxb;
                }
            }
        }

        //点击高级
        private void button3_Click(object sender, EventArgs e)
        {
            DingChangGaoji dcgj = new DingChangGaoji();
            dcgj.ShowDialog();
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

        //点击高级
        private void gjEdit_Click(object sender, EventArgs e)
        {
            int gjKey = ds.gjKey;
            DCGaoji gj = null;
            if (gjKey != 0)
            {
                gj = this.gjDic[gjKey];
            }
            DingChangGaoji gjDialog = new DingChangGaoji(gj, editAble);

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
                this.radioButton5.Checked = true;
                this.panel6.Enabled = true;
            }
            else
            {
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
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //这个方法是修改所有的转涅和高级的
            this.changeAllstatus();
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
            }
            else
            {
                if (ds.dslxs != 0)
                {
                    this.radioButton4.Checked = false;
                    this.textBox3.Text = ds.dslxs.ToString();
                }
                canedit = true;
            }

            if (!ck.checkdyj() && this.radioButton3.Checked)
            {
                editAble.dyj = false;
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
            if (!editAble.fddld && !editAble.wnxb)
            {
                this.checkBox1.Enabled = false;
            }
            else
            {
                //因为选中转涅的时候，端流模型只能是sst
                //所以如果端流模型不能编辑，那么转涅也不能编辑
                if (!editAble.dlmx)
                {
                    this.checkBox1.Enabled = false;
                }
                else
                {
                    this.checkBox1.CheckedChanged -= new System.EventHandler(this.checkBox2_CheckedChanged);
                    this.checkBox1.CheckedChanged += new System.EventHandler(this.znEdit_CheckedChanged);
                    canedit = true;
                }

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
                this.button2.Click -= new System.EventHandler(this.button3_Click);
                this.button2.Click += new System.EventHandler(this.gjEdit_Click);
                canedit = true;
            }

            if (!canedit)
            {
                MessageBox.Show("选中的条目没有可编辑的项，请退出！");
            }
        }
    }
}