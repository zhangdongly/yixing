using Sunisoft.IrisSkin;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using Yixing.UserControl;
using Yixing.UserControl.Youhua;
using Yixing.UserTool;
namespace Yixing
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建优化工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建优化工程ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建气动特性评估工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存优化工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为优化工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开优化工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开优化工程ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开气动特性评估工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看用户操作日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑用户权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汽动特性评估ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翼型优化设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFD计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFD绘图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优化过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优化后处理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助手册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qidong = new Yixing.UserControl.Qidong();
            this.youhua = new Yixing.UserControl.Youhua.Youhua();
            this.文件保存路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建优化工程ToolStripMenuItem,
            this.保存优化工程ToolStripMenuItem,
            this.另存为优化工程ToolStripMenuItem,
            this.打开优化工程ToolStripMenuItem,
            this.推出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建优化工程ToolStripMenuItem
            // 
            this.新建优化工程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建优化工程ToolStripMenuItem1,
            this.新建气动特性评估工程ToolStripMenuItem});
            this.新建优化工程ToolStripMenuItem.Name = "新建优化工程ToolStripMenuItem";
            this.新建优化工程ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.新建优化工程ToolStripMenuItem.Text = "新建";
            // 
            // 新建优化工程ToolStripMenuItem1
            // 
            this.新建优化工程ToolStripMenuItem1.Name = "新建优化工程ToolStripMenuItem1";
            this.新建优化工程ToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.新建优化工程ToolStripMenuItem1.Text = "新建优化工程";
            // 
            // 新建气动特性评估工程ToolStripMenuItem
            // 
            this.新建气动特性评估工程ToolStripMenuItem.Name = "新建气动特性评估工程ToolStripMenuItem";
            this.新建气动特性评估工程ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.新建气动特性评估工程ToolStripMenuItem.Text = "新建气动特性评估工程";
            // 
            // 保存优化工程ToolStripMenuItem
            // 
            this.保存优化工程ToolStripMenuItem.Name = "保存优化工程ToolStripMenuItem";
            this.保存优化工程ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.保存优化工程ToolStripMenuItem.Text = "保存";
            // 
            // 另存为优化工程ToolStripMenuItem
            // 
            this.另存为优化工程ToolStripMenuItem.Name = "另存为优化工程ToolStripMenuItem";
            this.另存为优化工程ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为优化工程ToolStripMenuItem.Text = "另存为";
            // 
            // 打开优化工程ToolStripMenuItem
            // 
            this.打开优化工程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开优化工程ToolStripMenuItem1,
            this.打开气动特性评估工程ToolStripMenuItem});
            this.打开优化工程ToolStripMenuItem.Name = "打开优化工程ToolStripMenuItem";
            this.打开优化工程ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开优化工程ToolStripMenuItem.Text = "打开";
            // 
            // 打开优化工程ToolStripMenuItem1
            // 
            this.打开优化工程ToolStripMenuItem1.Name = "打开优化工程ToolStripMenuItem1";
            this.打开优化工程ToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.打开优化工程ToolStripMenuItem1.Text = "打开优化工程";
            // 
            // 打开气动特性评估工程ToolStripMenuItem
            // 
            this.打开气动特性评估工程ToolStripMenuItem.Name = "打开气动特性评估工程ToolStripMenuItem";
            this.打开气动特性评估工程ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.打开气动特性评估工程ToolStripMenuItem.Text = "打开气动特性评估工程";
            // 
            // 推出ToolStripMenuItem
            // 
            this.推出ToolStripMenuItem.Name = "推出ToolStripMenuItem";
            this.推出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.推出ToolStripMenuItem.Text = "退出";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看权限ToolStripMenuItem,
            this.新增用户ToolStripMenuItem,
            this.查看用户ToolStripMenuItem,
            this.查看用户操作日志ToolStripMenuItem,
            this.编辑用户权限ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 查看权限ToolStripMenuItem
            // 
            this.查看权限ToolStripMenuItem.Name = "查看权限ToolStripMenuItem";
            this.查看权限ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看权限ToolStripMenuItem.Text = "查看权限";
            // 
            // 新增用户ToolStripMenuItem
            // 
            this.新增用户ToolStripMenuItem.Name = "新增用户ToolStripMenuItem";
            this.新增用户ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.新增用户ToolStripMenuItem.Text = "新增用户";
            // 
            // 查看用户ToolStripMenuItem
            // 
            this.查看用户ToolStripMenuItem.Name = "查看用户ToolStripMenuItem";
            this.查看用户ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看用户ToolStripMenuItem.Text = "查看用户";
            // 
            // 查看用户操作日志ToolStripMenuItem
            // 
            this.查看用户操作日志ToolStripMenuItem.Name = "查看用户操作日志ToolStripMenuItem";
            this.查看用户操作日志ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看用户操作日志ToolStripMenuItem.Text = "查看用户操作日志";
            // 
            // 编辑用户权限ToolStripMenuItem
            // 
            this.编辑用户权限ToolStripMenuItem.Name = "编辑用户权限ToolStripMenuItem";
            this.编辑用户权限ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.编辑用户权限ToolStripMenuItem.Text = "编辑用户权限";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.汽动特性评估ToolStripMenuItem,
            this.翼型优化设置ToolStripMenuItem,
            this.优化ToolStripMenuItem,
            this.文件保存路径ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 汽动特性评估ToolStripMenuItem
            // 
            this.汽动特性评估ToolStripMenuItem.Name = "汽动特性评估ToolStripMenuItem";
            this.汽动特性评估ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.汽动特性评估ToolStripMenuItem.Text = "CFD计算状态 ";
            // 
            // 翼型优化设置ToolStripMenuItem
            // 
            this.翼型优化设置ToolStripMenuItem.Name = "翼型优化设置ToolStripMenuItem";
            this.翼型优化设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.翼型优化设置ToolStripMenuItem.Text = "翼型优化参数";
            // 
            // 优化ToolStripMenuItem
            // 
            this.优化ToolStripMenuItem.Name = "优化ToolStripMenuItem";
            this.优化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.优化ToolStripMenuItem.Text = "优化过程显示";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cFD计算ToolStripMenuItem,
            this.cFD绘图ToolStripMenuItem,
            this.优化过程ToolStripMenuItem,
            this.优化后处理ToolStripMenuItem1});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // cFD计算ToolStripMenuItem
            // 
            this.cFD计算ToolStripMenuItem.Name = "cFD计算ToolStripMenuItem";
            this.cFD计算ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cFD计算ToolStripMenuItem.Text = "CFD计算";
            // 
            // cFD绘图ToolStripMenuItem
            // 
            this.cFD绘图ToolStripMenuItem.Name = "cFD绘图ToolStripMenuItem";
            this.cFD绘图ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cFD绘图ToolStripMenuItem.Text = "计算结果处理";
            // 
            // 优化过程ToolStripMenuItem
            // 
            this.优化过程ToolStripMenuItem.Name = "优化过程ToolStripMenuItem";
            this.优化过程ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.优化过程ToolStripMenuItem.Text = "优化过程";
            // 
            // 优化后处理ToolStripMenuItem1
            // 
            this.优化后处理ToolStripMenuItem1.Name = "优化后处理ToolStripMenuItem1";
            this.优化后处理ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.优化后处理ToolStripMenuItem1.Text = "优化后处理";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.帮助手册ToolStripMenuItem,
            this.联系我们ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 帮助手册ToolStripMenuItem
            // 
            this.帮助手册ToolStripMenuItem.Name = "帮助手册ToolStripMenuItem";
            this.帮助手册ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助手册ToolStripMenuItem.Text = "帮助手册";
            // 
            // 联系我们ToolStripMenuItem
            // 
            this.联系我们ToolStripMenuItem.Name = "联系我们ToolStripMenuItem";
            this.联系我们ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.联系我们ToolStripMenuItem.Text = "联系我们";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.toolStripSeparator6,
            this.toolStripLabel5,
            this.toolStripSeparator7,
            this.toolStripLabel6,
            this.toolStripSeparator8,
            this.toolStripLabel7,
            this.toolStripSeparator9,
            this.toolStripLabel8,
            this.toolStripSeparator10,
            this.toolStripLabel9,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(12, 28);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(946, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel4.Text = "气动特性分析";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel5.Image")));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel5.Text = "优化";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel6.Text = "P1";
            this.toolStripLabel6.Click += new System.EventHandler(this.toolStripLabel6_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel7.Text = "E";
            this.toolStripLabel7.Click += new System.EventHandler(this.toolStripLabel7_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel8.Text = "F";
            this.toolStripLabel8.Click += new System.EventHandler(this.toolStripLabel8_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel9.Image")));
            this.toolStripLabel9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel9.Text = "绘图";
            this.toolStripLabel9.Click += new System.EventHandler(this.toolStripLabel9_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel2.Text = "▇C";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel3.Text = "▇O";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "翼型几何特性分析";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.qidong);
            this.panel1.Location = new System.Drawing.Point(17, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 620);
            this.panel1.TabIndex = 2;
            // 
            // qidong
            // 
            this.qidong.Location = new System.Drawing.Point(0, 0);
            this.qidong.Name = "qidong";
            this.qidong.Size = new System.Drawing.Size(940, 600);
            this.qidong.TabIndex = 0;
            // 
            // youhua
            // 
            this.youhua.Location = new System.Drawing.Point(0, 0);
            this.youhua.Name = "youhua";
            this.youhua.Size = new System.Drawing.Size(930, 600);
            this.youhua.TabIndex = 0;
            // 
            // 文件保存路径ToolStripMenuItem
            // 
            this.文件保存路径ToolStripMenuItem.Name = "文件保存路径ToolStripMenuItem";
            this.文件保存路径ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.文件保存路径ToolStripMenuItem.Text = "文件保存路径";
            this.文件保存路径ToolStripMenuItem.Click += new System.EventHandler(this.文件保存路径ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "旋翼翼型优化设计与评估软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion      
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private Panel panel1;
        private Qidong qidong;
        private Youhua youhua;
        private ToolStripMenuItem 新增用户ToolStripMenuItem;
        private ToolStripMenuItem 查看用户ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 汽动特性评估ToolStripMenuItem;
        private ToolStripMenuItem 翼型优化设置ToolStripMenuItem;
        private ToolStripMenuItem 优化ToolStripMenuItem;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 新建优化工程ToolStripMenuItem;
        private ToolStripMenuItem 保存优化工程ToolStripMenuItem;
        private ToolStripMenuItem 另存为优化工程ToolStripMenuItem;
        private ToolStripMenuItem 查看用户操作日志ToolStripMenuItem;
        private ToolStripMenuItem 打开优化工程ToolStripMenuItem;
        private ToolStripMenuItem 编辑用户权限ToolStripMenuItem;
        private ToolStripMenuItem 帮助手册ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripLabel toolStripLabel6;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripLabel toolStripLabel7;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripLabel toolStripLabel8;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem 新建优化工程ToolStripMenuItem1;
        private ToolStripMenuItem 推出ToolStripMenuItem;
        private ToolStripMenuItem 新建气动特性评估工程ToolStripMenuItem;
        private ToolStripMenuItem 打开优化工程ToolStripMenuItem1;
        private ToolStripMenuItem 打开气动特性评估工程ToolStripMenuItem;
        private ToolStripMenuItem 联系我们ToolStripMenuItem;
        private ToolStripMenuItem 视图ToolStripMenuItem;
        private ToolStripMenuItem cFD计算ToolStripMenuItem;
        private ToolStripMenuItem cFD绘图ToolStripMenuItem;
        private ToolStripMenuItem 优化过程ToolStripMenuItem;
        private ToolStripMenuItem 优化后处理ToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripLabel4;
        private ToolStripButton toolStripLabel9;
        private ToolStripButton toolStripLabel5;
        private SkinEngine skinEngine1=new SkinEngine();
        private ToolStripMenuItem 文件保存路径ToolStripMenuItem;
        
    }
}
