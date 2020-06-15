namespace BnsShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public static Form1 form1 = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ItemQuantity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_ItemAdminAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ItemDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_GameItemId = new System.Windows.Forms.TextBox();
            this.textBox_ItemId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_SaleStatus = new System.Windows.Forms.TextBox();
            this.button_AddGoods = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_GoodsPrice = new System.Windows.Forms.TextBox();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_CategoryId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_GoodsDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_GoodsAdminAccount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoodsId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoodsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_GoodsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listView_GoodsList = new System.Windows.Forms.ListView();
            this.textBox_GoodsId = new System.Windows.Forms.TextBox();
            this.treeView_GoodsList = new System.Windows.Forms.TreeView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Pawd = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemToolStripMenuItem_DisplayAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_AddAndModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AddItemByGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AddItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AddGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_testClick = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_ItemList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_CategoryId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_ItemQuantity);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox_ItemAdminAccount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_ItemDescription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_ItemName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_GameItemId);
            this.groupBox1.Controls.Add(this.textBox_ItemId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(561, 399);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(611, 275);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目 修改/添加";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_ItemQuantity
            // 
            this.textBox_ItemQuantity.Location = new System.Drawing.Point(242, 105);
            this.textBox_ItemQuantity.Name = "textBox_ItemQuantity";
            this.textBox_ItemQuantity.Size = new System.Drawing.Size(100, 21);
            this.textBox_ItemQuantity.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 108);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 62;
            this.label17.Text = "数量:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ItemAdminAccount
            // 
            this.textBox_ItemAdminAccount.Location = new System.Drawing.Point(242, 21);
            this.textBox_ItemAdminAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemAdminAccount.Name = "textBox_ItemAdminAccount";
            this.textBox_ItemAdminAccount.Size = new System.Drawing.Size(100, 21);
            this.textBox_ItemAdminAccount.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "管理用户:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ItemDescription
            // 
            this.textBox_ItemDescription.Location = new System.Drawing.Point(71, 77);
            this.textBox_ItemDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemDescription.Name = "textBox_ItemDescription";
            this.textBox_ItemDescription.Size = new System.Drawing.Size(534, 21);
            this.textBox_ItemDescription.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 58;
            this.label8.Text = "项目描述:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(71, 49);
            this.textBox_ItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(534, 21);
            this.textBox_ItemName.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 56;
            this.label7.Text = "项目名称:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GameItemId
            // 
            this.textBox_GameItemId.Location = new System.Drawing.Point(71, 105);
            this.textBox_GameItemId.Name = "textBox_GameItemId";
            this.textBox_GameItemId.Size = new System.Drawing.Size(100, 21);
            this.textBox_GameItemId.TabIndex = 55;
            // 
            // textBox_ItemId
            // 
            this.textBox_ItemId.Location = new System.Drawing.Point(71, 21);
            this.textBox_ItemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemId.Name = "textBox_ItemId";
            this.textBox_ItemId.Size = new System.Drawing.Size(100, 21);
            this.textBox_ItemId.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "物品ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "项目ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 49;
            this.label16.Text = "    状态:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_SaleStatus
            // 
            this.textBox_SaleStatus.Location = new System.Drawing.Point(413, 105);
            this.textBox_SaleStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SaleStatus.Name = "textBox_SaleStatus";
            this.textBox_SaleStatus.Size = new System.Drawing.Size(100, 21);
            this.textBox_SaleStatus.TabIndex = 48;
            // 
            // button_AddGoods
            // 
            this.button_AddGoods.Location = new System.Drawing.Point(519, 103);
            this.button_AddGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddGoods.Name = "button_AddGoods";
            this.button_AddGoods.Size = new System.Drawing.Size(86, 23);
            this.button_AddGoods.TabIndex = 47;
            this.button_AddGoods.Text = "添加";
            this.button_AddGoods.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 46;
            this.label15.Text = "价格:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsPrice
            // 
            this.textBox_GoodsPrice.Location = new System.Drawing.Point(242, 105);
            this.textBox_GoodsPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsPrice.Name = "textBox_GoodsPrice";
            this.textBox_GoodsPrice.Size = new System.Drawing.Size(100, 21);
            this.textBox_GoodsPrice.TabIndex = 45;
            // 
            // Status
            // 
            this.Status.Text = "状态";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_CategoryId
            // 
            this.textBox_CategoryId.Location = new System.Drawing.Point(71, 168);
            this.textBox_CategoryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CategoryId.Name = "textBox_CategoryId";
            this.textBox_CategoryId.Size = new System.Drawing.Size(100, 21);
            this.textBox_CategoryId.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "类别ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsDescription
            // 
            this.textBox_GoodsDescription.Location = new System.Drawing.Point(71, 77);
            this.textBox_GoodsDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsDescription.Name = "textBox_GoodsDescription";
            this.textBox_GoodsDescription.Size = new System.Drawing.Size(534, 21);
            this.textBox_GoodsDescription.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "商品描述:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsAdminAccount
            // 
            this.textBox_GoodsAdminAccount.Location = new System.Drawing.Point(242, 21);
            this.textBox_GoodsAdminAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsAdminAccount.Name = "textBox_GoodsAdminAccount";
            this.textBox_GoodsAdminAccount.Size = new System.Drawing.Size(100, 21);
            this.textBox_GoodsAdminAccount.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "管理用户:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Price
            // 
            this.Price.Text = "价格";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoodsId
            // 
            this.GoodsId.Text = "商品ID";
            this.GoodsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoodsName
            // 
            this.GoodsName.Text = "商品名称";
            this.GoodsName.Width = 150;
            // 
            // textBox_GoodsName
            // 
            this.textBox_GoodsName.Location = new System.Drawing.Point(71, 49);
            this.textBox_GoodsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsName.Name = "textBox_GoodsName";
            this.textBox_GoodsName.Size = new System.Drawing.Size(534, 21);
            this.textBox_GoodsName.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "商品名称:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView_GoodsList
            // 
            this.listView_GoodsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GoodsName,
            this.GoodsId,
            this.Price,
            this.Status});
            this.listView_GoodsList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_GoodsList.FullRowSelect = true;
            this.listView_GoodsList.GridLines = true;
            this.listView_GoodsList.HideSelection = false;
            this.listView_GoodsList.Location = new System.Drawing.Point(196, 39);
            this.listView_GoodsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_GoodsList.MultiSelect = false;
            this.listView_GoodsList.Name = "listView_GoodsList";
            this.listView_GoodsList.Size = new System.Drawing.Size(359, 356);
            this.listView_GoodsList.TabIndex = 31;
            this.listView_GoodsList.UseCompatibleStateImageBehavior = false;
            this.listView_GoodsList.View = System.Windows.Forms.View.Details;
            this.listView_GoodsList.SelectedIndexChanged += new System.EventHandler(this.listView_GoodsList_SelectedIndexChanged);
            this.listView_GoodsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_GoodsList_MouseClick);
            // 
            // textBox_GoodsId
            // 
            this.textBox_GoodsId.Location = new System.Drawing.Point(71, 21);
            this.textBox_GoodsId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsId.Name = "textBox_GoodsId";
            this.textBox_GoodsId.Size = new System.Drawing.Size(100, 21);
            this.textBox_GoodsId.TabIndex = 33;
            // 
            // treeView_GoodsList
            // 
            this.treeView_GoodsList.Location = new System.Drawing.Point(20, 39);
            this.treeView_GoodsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_GoodsList.Name = "treeView_GoodsList";
            this.treeView_GoodsList.Size = new System.Drawing.Size(170, 635);
            this.treeView_GoodsList.TabIndex = 32;
            this.treeView_GoodsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_GoodsList_AfterSelect);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 32;
            this.label14.Text = "  商品ID:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_CategoryId);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox_SaleStatus);
            this.groupBox2.Controls.Add(this.button_AddGoods);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox_GoodsPrice);
            this.groupBox2.Controls.Add(this.textBox_CategoryId);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_GoodsDescription);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_GoodsAdminAccount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox_GoodsName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_GoodsId);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(561, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 356);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品 修改/添加";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Pawd
            // 
            this.textBox_Pawd.Location = new System.Drawing.Point(426, 10);
            this.textBox_Pawd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Pawd.Name = "textBox_Pawd";
            this.textBox_Pawd.Size = new System.Drawing.Size(129, 21);
            this.textBox_Pawd.TabIndex = 30;
            this.textBox_Pawd.Text = "FSmElsXuj3ls8Fq";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(250, 10);
            this.textBox_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(129, 21);
            this.textBox_User.TabIndex = 29;
            this.textBox_User.Text = "sa";
            // 
            // textBox_Host
            // 
            this.textBox_Host.Location = new System.Drawing.Point(58, 10);
            this.textBox_Host.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.Size = new System.Drawing.Size(129, 21);
            this.textBox_Host.TabIndex = 28;
            this.textBox_Host.Text = "192.168.48.128";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(569, 8);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 27;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pawd:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "User:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "Host:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemToolStripMenuItem_DisplayAllItem,
            this.toolStripMenuItem1,
            this.ToolStripMenuItem_AddAndModify,
            this.ToolStripMenuItem_AddItemByGoods,
            this.ToolStripMenuItem_AddItems,
            this.ToolStripMenuItem_AddGoods,
            this.ToolStripMenuItem_testClick});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 142);
            this.contextMenuStrip1.Text = "listView_GoodsList";
            // 
            // ItemToolStripMenuItem_DisplayAllItem
            // 
            this.ItemToolStripMenuItem_DisplayAllItem.Name = "ItemToolStripMenuItem_DisplayAllItem";
            this.ItemToolStripMenuItem_DisplayAllItem.Size = new System.Drawing.Size(164, 22);
            this.ItemToolStripMenuItem_DisplayAllItem.Text = "显示所有Item";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // ToolStripMenuItem_AddAndModify
            // 
            this.ToolStripMenuItem_AddAndModify.Enabled = false;
            this.ToolStripMenuItem_AddAndModify.Name = "ToolStripMenuItem_AddAndModify";
            this.ToolStripMenuItem_AddAndModify.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItem_AddAndModify.Text = "添加/修改";
            // 
            // ToolStripMenuItem_AddItemByGoods
            // 
            this.ToolStripMenuItem_AddItemByGoods.Name = "ToolStripMenuItem_AddItemByGoods";
            this.ToolStripMenuItem_AddItemByGoods.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItem_AddItemByGoods.Text = "往商品添加I项目";
            // 
            // ToolStripMenuItem_AddItems
            // 
            this.ToolStripMenuItem_AddItems.Name = "ToolStripMenuItem_AddItems";
            this.ToolStripMenuItem_AddItems.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItem_AddItems.Text = "添加新项目";
            // 
            // ToolStripMenuItem_AddGoods
            // 
            this.ToolStripMenuItem_AddGoods.Name = "ToolStripMenuItem_AddGoods";
            this.ToolStripMenuItem_AddGoods.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItem_AddGoods.Text = "添加新商品";
            // 
            // ToolStripMenuItem_testClick
            // 
            this.ToolStripMenuItem_testClick.Name = "ToolStripMenuItem_testClick";
            this.ToolStripMenuItem_testClick.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItem_testClick.Text = "testClick";
            // 
            // listView_ItemList
            // 
            this.listView_ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_ItemList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_ItemList.FullRowSelect = true;
            this.listView_ItemList.GridLines = true;
            this.listView_ItemList.HideSelection = false;
            this.listView_ItemList.Location = new System.Drawing.Point(196, 399);
            this.listView_ItemList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_ItemList.MultiSelect = false;
            this.listView_ItemList.Name = "listView_ItemList";
            this.listView_ItemList.Size = new System.Drawing.Size(359, 275);
            this.listView_ItemList.TabIndex = 35;
            this.listView_ItemList.UseCompatibleStateImageBehavior = false;
            this.listView_ItemList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "项目名称";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "项目ID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "物品ID";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数量";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_CategoryId
            // 
            this.comboBox_CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CategoryId.FormattingEnabled = true;
            this.comboBox_CategoryId.Location = new System.Drawing.Point(71, 105);
            this.comboBox_CategoryId.Name = "comboBox_CategoryId";
            this.comboBox_CategoryId.Size = new System.Drawing.Size(121, 20);
            this.comboBox_CategoryId.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.listView_ItemList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_GoodsList);
            this.Controls.Add(this.treeView_GoodsList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_Pawd);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.textBox_Host);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_SaleStatus;
        private System.Windows.Forms.Button button_AddGoods;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_GoodsPrice;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox textBox_CategoryId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_GoodsDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_GoodsAdminAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader GoodsId;
        private System.Windows.Forms.ColumnHeader GoodsName;
        private System.Windows.Forms.TextBox textBox_GoodsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView_GoodsList;
        private System.Windows.Forms.TextBox textBox_GoodsId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Pawd;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Host;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemToolStripMenuItem_DisplayAllItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddAndModify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddItemByGoods;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddItems;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddGoods;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_testClick;
        private System.Windows.Forms.ListView listView_ItemList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox_ItemQuantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_ItemAdminAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ItemDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_GameItemId;
        private System.Windows.Forms.TextBox textBox_ItemId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TreeView treeView_GoodsList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_CategoryId;
    }
}