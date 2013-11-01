using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yixing.model.database;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.UserControl.DataSourceOperate
{
    public class Search : System.Windows.Forms.UserControl
    {

        public Search()
        {
            this.InitializeComponent();
        }
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private UserTool.EXListView exListView1;
        private System.Windows.Forms.Panel panel1;
        private object[] conditions = new object[] { "Ma", "Re", "Alpha", "Cl", "Cd", "Cm", "K", "thickness" };
        private object[] operators = new object[] { ">", ">=", "<", "<=", "=" };
        private object[] linkOperators = new object[] { "或", "与" };
        private String SQL_PRE = "select name,max_thickness,re,ma,alpha,cl,cd,cm,k,cal_result.gmt_create,cal_result.user_create,airfoil.id from airfoil,cal_result where cal_result.airfoil_id=airfoil.id";
        private String LAST_SQL = "";
        private Panel panel2;
        private Label label1;
        private EXListView exListView2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private ImageList iList;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.exListView2);
            this.panel1.Location = new System.Drawing.Point(34, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 423);
            this.panel1.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(576, 394);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "翼型生成";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(427, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "翼型几何外形";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "压力分布";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(135, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "厚度弯度分布";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 34);
            this.panel4.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(423, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(299, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exListView2
            // 
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView2.Location = new System.Drawing.Point(3, 3);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(851, 351);
            this.exListView2.TabIndex = 0;
            this.exListView2.UseCompatibleStateImageBehavior = false;
            this.exListView2.View = System.Windows.Forms.View.Details;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.exListView1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(861, 122);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(698, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 118);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(38, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(26, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 16);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "在结果中检索";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "重点翼型";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "一般翼型";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView1.Location = new System.Drawing.Point(103, 3);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(589, 118);
            this.exListView1.TabIndex = 3;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 118);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "检索条件";
            // 
            // Search
            // 
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(924, 574);
            this.Load += new System.EventHandler(this.Search_Load);
           
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            
            this.iList = new ImageList();
            this.iList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iList.ImageSize = new System.Drawing.Size(1, 30);
            this.iList.TransparentColor = System.Drawing.Color.Transparent;
            this.exListView1.SmallImageList = iList;
            this.exListView1.Columns.Add("", 5);
            this.exListView1.Columns.Add("", 50);
            this.exListView1.Columns.Add("", 100);
            this.exListView1.Columns.Add("");
            this.exListView1.Columns.Add("");
            this.exListView1.Columns.Add("");
            this.exListView1.Columns.Add("");
            this.exListView1.Columns.Add("");
            this.addExpression(true);
            this.addResultHeader();
            ParentForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyPress);


        }

        private void addResultHeader()
        {
            this.exListView2.SmallImageList = iList;
            this.exListView2.Columns.Add("翼型名称", 100);
            this.exListView2.Columns.Add("厚度", 50);
            this.exListView2.Columns.Add("Re(万)", 50);
            this.exListView2.Columns.Add("Ma", 50);
            this.exListView2.Columns.Add("Alpha", 50);
            this.exListView2.Columns.Add("Cl", 100);
            this.exListView2.Columns.Add("Cd", 100);
            this.exListView2.Columns.Add("Cm", 100);
            this.exListView2.Columns.Add("K", 50);
            this.exListView2.Columns.Add("创建时间", 100);
            this.exListView2.Columns.Add("创建人", 100);
            this.exListView2.Columns.Add("选择", 50);
            initData();
        }

        private void initData()
        {
            String SQL = SQL_PRE;
            initDataBySQL(SQL);


        }

        private void initDataBySQL(String SQL)
        {
            DataSet ds = DataBaseUtil.GetDataSet(CommandType.Text, SQL, null);
            addData2Table(ds);
        }

        public void addData2Table(DataSet ds)
        {
            this.exListView2.Items.Clear();
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                String name = mDr[0].ToString();
                if (String.IsNullOrWhiteSpace(name))
                {
                    name = ""+(this.exListView2.Items.Count + 1);
                }
                EXListViewItem item = new EXListViewItem(name);                               
                    for (int i = 1; i < 11; i++)
                    {
                        if (i == 6 || i == 7)
                        {
                            item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(mDr[i].ToString())));
                        }
                        else
                        {
                            item.SubItems.Add(mDr[i].ToString());
                        }
                    }
                    CheckBox checkBox = new CheckBox();
                    checkBox.Tag = item;
                    checkBox.Click += new EventHandler(this.select_Click);
                    item.Tag = mDr[11].ToString();
                    EXControlListViewSubItem check = new EXControlListViewSubItem();
                    item.SubItems.Add(check);
                    this.exListView2.AddControlToSubItem(checkBox, check);
                    this.exListView2.Items.Add(item);
                
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            EXListViewItem item = (EXListViewItem)c.Tag;
            item.Selected = c.Checked ;
        }

        public void addData2Table(DAirfoil da)
        {
            if (da.dCalResultList != null)
            {
                foreach (DCalResult dc in da.dCalResultList)
                {
                    EXListViewItem item = new EXListViewItem(da.name);
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(da.maxThickness)));
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.re)));
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.ma)));
                    item.SubItems.Add(string.Format("{0:00.00}", Convert.ToDouble(dc.alpha)));
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.cl)));
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.cd)));
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.cm)));
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.k)));
                    item.SubItems.Add(dc.gmtCreate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(dc.manageUser);
                    CheckBox checkBox = new CheckBox();
                    checkBox.Tag = item;
                    EXControlListViewSubItem check = new EXControlListViewSubItem();
                    item.SubItems.Add(check);
                    this.exListView2.AddControlToSubItem(checkBox, check);
                    this.exListView2.Items.Add(item);
                }
            }
        }

        private void addExpression(Boolean isFirst)
        {

            EXListViewItem item;
            if (isFirst)
            {
                item = new EXListViewItem("");
                item.SubItems.Add("");
            }
            else
            {

                item = new EXListViewItem(" ");
                ComboBox link = new ComboBox();
                link.Items.AddRange(this.linkOperators);
                link.Text = (String)this.linkOperators[0];
                EXControlListViewSubItem linkItem = new EXControlListViewSubItem();
                item.SubItems.Add(linkItem);
                this.exListView1.AddControlToSubItem(link, linkItem);

            }

            ComboBox c = new ComboBox();

            c.Items.AddRange(this.conditions);
            c.Text = (String)conditions[0];

            EXControlListViewSubItem status = new EXControlListViewSubItem();

            item.SubItems.Add(status);
            this.exListView1.AddControlToSubItem(c, status);

            ComboBox operate = new ComboBox();
            operate.Items.AddRange(this.operators);
            operate.Text = (String)operators[0];

            EXControlListViewSubItem oper = new EXControlListViewSubItem();
            item.SubItems.Add(oper);
            this.exListView1.AddControlToSubItem(operate, oper);

            TextBox t = new TextBox();

            EXControlListViewSubItem text = new EXControlListViewSubItem();
            item.SubItems.Add(text);
            this.exListView1.AddControlToSubItem(t, text);

            Button add = new Button();
            add.Text = "添加";
            add.Tag = item;
            add.Click += new EventHandler(this.add_Click);
            add.Size = new System.Drawing.Size(123, 23);
            EXControlListViewSubItem addItem = new EXControlListViewSubItem();
            item.SubItems.Add(addItem);
            this.exListView1.AddControlToSubItem(add, addItem);

            if (!isFirst)
            {
                Button delete = new Button();
                delete.Text = "删除";
                delete.Tag = item;
                delete.Click += new EventHandler(this.del_Click);
                delete.Size = new System.Drawing.Size(123, 23);
                EXControlListViewSubItem deleteItem = new EXControlListViewSubItem();
                item.SubItems.Add(deleteItem);
                this.exListView1.AddControlToSubItem(delete, deleteItem);

            }

            this.exListView1.Items.Add(item);

        }

        private void del_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            EXListViewItem item = (EXListViewItem)b.Tag;
            this.exListView1.Items.Remove(item);
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.addExpression(false);
        }

        private void addData2Table(String[] data)
        {
            EXListViewItem item = new EXListViewItem(data[0]);
            for (int i = 1; i < data.Length; i++)
            {
                if (i == 6 || i == 7)
                {
                    item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(data[i])));
                }
                else
                {
                    item.SubItems.Add(data[i]);
                }
            }
            CheckBox checkBox = new CheckBox();
            checkBox.Tag = item;
            EXControlListViewSubItem check = new EXControlListViewSubItem();
            item.SubItems.Add(check);
            this.exListView2.AddControlToSubItem(checkBox, check);
            this.exListView2.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlStr = " ";
            foreach (EXListViewItem item in this.exListView1.Items)
            {
                if (item.Index == 0)
                {
                    sqlStr += " and (";
                }
                else
                {
                    EXControlListViewSubItem subitem = (EXControlListViewSubItem)item.SubItems[1];
                    ComboBox b = (ComboBox)subitem.MyControl;
                    if ("或".Equals(b.Text))
                    {
                        sqlStr += " or ";
                    }
                    else
                    {
                        sqlStr += " and ";
                    }
                }

                EXControlListViewSubItem param = (EXControlListViewSubItem)item.SubItems[2];
                ComboBox p = (ComboBox)param.MyControl;

                EXControlListViewSubItem operate = (EXControlListViewSubItem)item.SubItems[3];
                ComboBox o = (ComboBox)operate.MyControl;

                EXControlListViewSubItem value = (EXControlListViewSubItem)item.SubItems[4];
                TextBox v = (TextBox)value.MyControl;

                if (String.IsNullOrWhiteSpace(v.Text))
                {
                    MessageBox.Show("检索值不能为空");
                    return;
                }

                if ("thickness".Equals(p.Text))
                {
                    sqlStr += "max_thickness" + o.Text + v.Text;
                }
                else
                {
                    sqlStr += p.Text + o.Text + v.Text;
                }
      

            }
            sqlStr += ")";
           
            if (this.checkBox3.Checked)
            {
                sqlStr = LAST_SQL + sqlStr;
            }

            LAST_SQL = sqlStr;

            MessageBox.Show(SQL_PRE + sqlStr);
            this.initDataBySQL(SQL_PRE + sqlStr);
        }

        private void Search_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                foreach (EXListViewItem item in this.exListView2.Items)
                {
                    EXControlListViewSubItem sumItem = (EXControlListViewSubItem)item.SubItems[item.SubItems.Count - 1];
                    CheckBox c = (CheckBox)sumItem.MyControl;
                    c.Checked = true;
                    item.Selected = true;
                }
            }
        }

        /**
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            MessageBox.Show(keyData.ToString());
            MessageBox.Show(((Keys)Shortcut.CtrlA).ToString());

            if (keyData == (Keys)Shortcut.CtrlA)
            {
              
                foreach (EXListViewItem item in this.exListView2.Items)
                {
                    EXControlListViewSubItem sumItem = (EXControlListViewSubItem)item.SubItems[item.SubItems.Count - 1];
                    CheckBox c = (CheckBox)sumItem.MyControl;
                    c.Checked = true;
                }
            }
            if (keyData == (Keys.Control | Keys.A))
            {
                MessageBox.Show("Ctr+A");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
         * */

        public List<int> getSelectedAirfoil()
        {
            List<int> selectedAirfoil = new List<int>();
            foreach (EXListViewItem item in this.exListView2.Items)
            {
                if (item.Selected)
                {
                    selectedAirfoil.Add(Convert.ToInt32(item.Tag));
                }
            }
            return selectedAirfoil;
        }

       
    }
}
