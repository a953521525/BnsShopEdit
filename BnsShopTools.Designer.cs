namespace BnsShop
{
    partial class Form_BnsShopTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public static Form_BnsShopTools form1 = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BnsShopTools));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoodsId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoodsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_GoodsList = new System.Windows.Forms.ListView();
            this.treeView_GoodsList = new System.Windows.Forms.TreeView();
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
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.comboBox_CategoryId = new System.Windows.Forms.ComboBox();
            this.button_DelItemInList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_Items = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_AddItemInList = new System.Windows.Forms.Button();
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
            this.textBox_GoodsAddPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_GoodsDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_GoodsAdminAccount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_GoodsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_GoodsId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox_modify = new System.Windows.Forms.GroupBox();
            this.button_ModifyGameItem = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_ModifyGameItem = new System.Windows.Forms.TextBox();
            this.button_ModifyItemCount = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_ModifyItemCount = new System.Windows.Forms.TextBox();
            this.button_DownGoods = new System.Windows.Forms.Button();
            this.button_UpGoods = new System.Windows.Forms.Button();
            this.button_ModifyPrice = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_ModifyPrice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_modify.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Text = "状态";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // treeView_GoodsList
            // 
            this.treeView_GoodsList.Location = new System.Drawing.Point(20, 39);
            this.treeView_GoodsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_GoodsList.Name = "treeView_GoodsList";
            this.treeView_GoodsList.Size = new System.Drawing.Size(170, 635);
            this.treeView_GoodsList.TabIndex = 32;
            this.treeView_GoodsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_GoodsList_AfterSelect);
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
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.comboBox_CategoryId);
            this.groupBox_Add.Controls.Add(this.button_DelItemInList);
            this.groupBox_Add.Controls.Add(this.label4);
            this.groupBox_Add.Controls.Add(this.listView_Items);
            this.groupBox_Add.Controls.Add(this.button_AddItemInList);
            this.groupBox_Add.Controls.Add(this.textBox_ItemQuantity);
            this.groupBox_Add.Controls.Add(this.label17);
            this.groupBox_Add.Controls.Add(this.textBox_ItemAdminAccount);
            this.groupBox_Add.Controls.Add(this.label9);
            this.groupBox_Add.Controls.Add(this.textBox_ItemDescription);
            this.groupBox_Add.Controls.Add(this.label8);
            this.groupBox_Add.Controls.Add(this.textBox_ItemName);
            this.groupBox_Add.Controls.Add(this.label7);
            this.groupBox_Add.Controls.Add(this.textBox_GameItemId);
            this.groupBox_Add.Controls.Add(this.textBox_ItemId);
            this.groupBox_Add.Controls.Add(this.label6);
            this.groupBox_Add.Controls.Add(this.label5);
            this.groupBox_Add.Controls.Add(this.label16);
            this.groupBox_Add.Controls.Add(this.textBox_SaleStatus);
            this.groupBox_Add.Controls.Add(this.button_AddGoods);
            this.groupBox_Add.Controls.Add(this.label15);
            this.groupBox_Add.Controls.Add(this.textBox_GoodsAddPrice);
            this.groupBox_Add.Controls.Add(this.label12);
            this.groupBox_Add.Controls.Add(this.textBox_GoodsDescription);
            this.groupBox_Add.Controls.Add(this.label13);
            this.groupBox_Add.Controls.Add(this.textBox_GoodsAdminAccount);
            this.groupBox_Add.Controls.Add(this.label11);
            this.groupBox_Add.Controls.Add(this.textBox_GoodsName);
            this.groupBox_Add.Controls.Add(this.label10);
            this.groupBox_Add.Controls.Add(this.textBox_GoodsId);
            this.groupBox_Add.Controls.Add(this.label14);
            this.groupBox_Add.Location = new System.Drawing.Point(558, 148);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(611, 526);
            this.groupBox_Add.TabIndex = 37;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "添加";
            // 
            // comboBox_CategoryId
            // 
            this.comboBox_CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CategoryId.FormattingEnabled = true;
            this.comboBox_CategoryId.Location = new System.Drawing.Point(71, 102);
            this.comboBox_CategoryId.Name = "comboBox_CategoryId";
            this.comboBox_CategoryId.Size = new System.Drawing.Size(121, 20);
            this.comboBox_CategoryId.TabIndex = 82;
            // 
            // button_DelItemInList
            // 
            this.button_DelItemInList.Location = new System.Drawing.Point(519, 252);
            this.button_DelItemInList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DelItemInList.Name = "button_DelItemInList";
            this.button_DelItemInList.Size = new System.Drawing.Size(86, 23);
            this.button_DelItemInList.TabIndex = 81;
            this.button_DelItemInList.Text = "删除项目";
            this.button_DelItemInList.UseVisualStyleBackColor = true;
            this.button_DelItemInList.Click += new System.EventHandler(this.button_DelItemInList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 12);
            this.label4.TabIndex = 80;
            this.label4.Text = "先添加项目到列表框里(可添加多个项目),完成后再添加商品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView_Items
            // 
            this.listView_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView_Items.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_Items.FullRowSelect = true;
            this.listView_Items.GridLines = true;
            this.listView_Items.HideSelection = false;
            this.listView_Items.Location = new System.Drawing.Point(3, 281);
            this.listView_Items.MultiSelect = false;
            this.listView_Items.Name = "listView_Items";
            this.listView_Items.Size = new System.Drawing.Size(597, 241);
            this.listView_Items.TabIndex = 79;
            this.listView_Items.UseCompatibleStateImageBehavior = false;
            this.listView_Items.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "项目ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "管理用户";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "物品ID";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "数量";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "项目名称";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "项目描述";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 120;
            // 
            // button_AddItemInList
            // 
            this.button_AddItemInList.Location = new System.Drawing.Point(427, 252);
            this.button_AddItemInList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddItemInList.Name = "button_AddItemInList";
            this.button_AddItemInList.Size = new System.Drawing.Size(86, 23);
            this.button_AddItemInList.TabIndex = 78;
            this.button_AddItemInList.Text = "添加项目";
            this.button_AddItemInList.UseVisualStyleBackColor = true;
            this.button_AddItemInList.Click += new System.EventHandler(this.button_AddItemInList_Click);
            // 
            // textBox_ItemQuantity
            // 
            this.textBox_ItemQuantity.Location = new System.Drawing.Point(242, 254);
            this.textBox_ItemQuantity.Name = "textBox_ItemQuantity";
            this.textBox_ItemQuantity.Size = new System.Drawing.Size(100, 21);
            this.textBox_ItemQuantity.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 257);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 76;
            this.label17.Text = "数量:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ItemAdminAccount
            // 
            this.textBox_ItemAdminAccount.Location = new System.Drawing.Point(242, 170);
            this.textBox_ItemAdminAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemAdminAccount.Name = "textBox_ItemAdminAccount";
            this.textBox_ItemAdminAccount.Size = new System.Drawing.Size(100, 21);
            this.textBox_ItemAdminAccount.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 74;
            this.label9.Text = "管理用户:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ItemDescription
            // 
            this.textBox_ItemDescription.Location = new System.Drawing.Point(71, 226);
            this.textBox_ItemDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemDescription.Name = "textBox_ItemDescription";
            this.textBox_ItemDescription.Size = new System.Drawing.Size(534, 21);
            this.textBox_ItemDescription.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 72;
            this.label8.Text = "项目描述:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(71, 198);
            this.textBox_ItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(534, 21);
            this.textBox_ItemName.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 70;
            this.label7.Text = "项目名称:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GameItemId
            // 
            this.textBox_GameItemId.Location = new System.Drawing.Point(71, 254);
            this.textBox_GameItemId.Name = "textBox_GameItemId";
            this.textBox_GameItemId.Size = new System.Drawing.Size(100, 21);
            this.textBox_GameItemId.TabIndex = 69;
            // 
            // textBox_ItemId
            // 
            this.textBox_ItemId.Location = new System.Drawing.Point(71, 170);
            this.textBox_ItemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ItemId.Name = "textBox_ItemId";
            this.textBox_ItemId.Size = new System.Drawing.Size(100, 21);
            this.textBox_ItemId.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "物品ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "项目ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 105);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 49;
            this.label16.Text = "    状态:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_SaleStatus
            // 
            this.textBox_SaleStatus.Location = new System.Drawing.Point(413, 102);
            this.textBox_SaleStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SaleStatus.Name = "textBox_SaleStatus";
            this.textBox_SaleStatus.Size = new System.Drawing.Size(100, 21);
            this.textBox_SaleStatus.TabIndex = 48;
            // 
            // button_AddGoods
            // 
            this.button_AddGoods.Location = new System.Drawing.Point(519, 100);
            this.button_AddGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddGoods.Name = "button_AddGoods";
            this.button_AddGoods.Size = new System.Drawing.Size(86, 23);
            this.button_AddGoods.TabIndex = 47;
            this.button_AddGoods.Text = "添加商品";
            this.button_AddGoods.UseVisualStyleBackColor = true;
            this.button_AddGoods.Click += new System.EventHandler(this.button_AddGoods_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 105);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 46;
            this.label15.Text = "价格:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsAddPrice
            // 
            this.textBox_GoodsAddPrice.Location = new System.Drawing.Point(242, 102);
            this.textBox_GoodsAddPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsAddPrice.Name = "textBox_GoodsAddPrice";
            this.textBox_GoodsAddPrice.Size = new System.Drawing.Size(100, 21);
            this.textBox_GoodsAddPrice.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "类别ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsDescription
            // 
            this.textBox_GoodsDescription.Location = new System.Drawing.Point(71, 74);
            this.textBox_GoodsDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsDescription.Name = "textBox_GoodsDescription";
            this.textBox_GoodsDescription.Size = new System.Drawing.Size(534, 21);
            this.textBox_GoodsDescription.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "商品描述:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsAdminAccount
            // 
            this.textBox_GoodsAdminAccount.Location = new System.Drawing.Point(242, 18);
            this.textBox_GoodsAdminAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsAdminAccount.Name = "textBox_GoodsAdminAccount";
            this.textBox_GoodsAdminAccount.Size = new System.Drawing.Size(100, 21);
            this.textBox_GoodsAdminAccount.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "管理用户:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsName
            // 
            this.textBox_GoodsName.Location = new System.Drawing.Point(71, 46);
            this.textBox_GoodsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsName.Name = "textBox_GoodsName";
            this.textBox_GoodsName.Size = new System.Drawing.Size(534, 21);
            this.textBox_GoodsName.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "商品名称:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_GoodsId
            // 
            this.textBox_GoodsId.Location = new System.Drawing.Point(71, 18);
            this.textBox_GoodsId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GoodsId.Name = "textBox_GoodsId";
            this.textBox_GoodsId.Size = new System.Drawing.Size(100, 21);
            this.textBox_GoodsId.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 32;
            this.label14.Text = "  商品ID:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_modify
            // 
            this.groupBox_modify.Controls.Add(this.button_ModifyGameItem);
            this.groupBox_modify.Controls.Add(this.label20);
            this.groupBox_modify.Controls.Add(this.textBox_ModifyGameItem);
            this.groupBox_modify.Controls.Add(this.button_ModifyItemCount);
            this.groupBox_modify.Controls.Add(this.label19);
            this.groupBox_modify.Controls.Add(this.textBox_ModifyItemCount);
            this.groupBox_modify.Controls.Add(this.button_DownGoods);
            this.groupBox_modify.Controls.Add(this.button_UpGoods);
            this.groupBox_modify.Controls.Add(this.button_ModifyPrice);
            this.groupBox_modify.Controls.Add(this.label18);
            this.groupBox_modify.Controls.Add(this.textBox_ModifyPrice);
            this.groupBox_modify.Location = new System.Drawing.Point(558, 39);
            this.groupBox_modify.Name = "groupBox_modify";
            this.groupBox_modify.Size = new System.Drawing.Size(611, 104);
            this.groupBox_modify.TabIndex = 38;
            this.groupBox_modify.TabStop = false;
            this.groupBox_modify.Text = "修改";
            // 
            // button_ModifyGameItem
            // 
            this.button_ModifyGameItem.Location = new System.Drawing.Point(179, 44);
            this.button_ModifyGameItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ModifyGameItem.Name = "button_ModifyGameItem";
            this.button_ModifyGameItem.Size = new System.Drawing.Size(86, 23);
            this.button_ModifyGameItem.TabIndex = 57;
            this.button_ModifyGameItem.Text = "修改";
            this.button_ModifyGameItem.UseVisualStyleBackColor = true;
            this.button_ModifyGameItem.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 52);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 56;
            this.label20.Text = "修改物品:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Visible = false;
            // 
            // textBox_ModifyGameItem
            // 
            this.textBox_ModifyGameItem.Location = new System.Drawing.Point(71, 46);
            this.textBox_ModifyGameItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ModifyGameItem.Name = "textBox_ModifyGameItem";
            this.textBox_ModifyGameItem.Size = new System.Drawing.Size(100, 21);
            this.textBox_ModifyGameItem.TabIndex = 55;
            this.textBox_ModifyGameItem.Visible = false;
            // 
            // button_ModifyItemCount
            // 
            this.button_ModifyItemCount.Location = new System.Drawing.Point(179, 71);
            this.button_ModifyItemCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ModifyItemCount.Name = "button_ModifyItemCount";
            this.button_ModifyItemCount.Size = new System.Drawing.Size(86, 23);
            this.button_ModifyItemCount.TabIndex = 54;
            this.button_ModifyItemCount.Text = "修改";
            this.button_ModifyItemCount.UseVisualStyleBackColor = true;
            this.button_ModifyItemCount.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 79);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 53;
            this.label19.Text = "修改数量:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Visible = false;
            // 
            // textBox_ModifyItemCount
            // 
            this.textBox_ModifyItemCount.Location = new System.Drawing.Point(71, 73);
            this.textBox_ModifyItemCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ModifyItemCount.Name = "textBox_ModifyItemCount";
            this.textBox_ModifyItemCount.Size = new System.Drawing.Size(100, 21);
            this.textBox_ModifyItemCount.TabIndex = 52;
            this.textBox_ModifyItemCount.Visible = false;
            // 
            // button_DownGoods
            // 
            this.button_DownGoods.Location = new System.Drawing.Point(363, 17);
            this.button_DownGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DownGoods.Name = "button_DownGoods";
            this.button_DownGoods.Size = new System.Drawing.Size(86, 23);
            this.button_DownGoods.TabIndex = 51;
            this.button_DownGoods.Text = "下架";
            this.button_DownGoods.UseVisualStyleBackColor = true;
            this.button_DownGoods.Click += new System.EventHandler(this.button_DownGoods_Click);
            // 
            // button_UpGoods
            // 
            this.button_UpGoods.Location = new System.Drawing.Point(271, 17);
            this.button_UpGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_UpGoods.Name = "button_UpGoods";
            this.button_UpGoods.Size = new System.Drawing.Size(86, 23);
            this.button_UpGoods.TabIndex = 50;
            this.button_UpGoods.Text = "上架";
            this.button_UpGoods.UseVisualStyleBackColor = true;
            this.button_UpGoods.Click += new System.EventHandler(this.button_UpGoods_Click);
            // 
            // button_ModifyPrice
            // 
            this.button_ModifyPrice.Location = new System.Drawing.Point(179, 17);
            this.button_ModifyPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ModifyPrice.Name = "button_ModifyPrice";
            this.button_ModifyPrice.Size = new System.Drawing.Size(86, 23);
            this.button_ModifyPrice.TabIndex = 49;
            this.button_ModifyPrice.Text = "修改";
            this.button_ModifyPrice.UseVisualStyleBackColor = true;
            this.button_ModifyPrice.Click += new System.EventHandler(this.button_ModifyPrice_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 48;
            this.label18.Text = "修改价格:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ModifyPrice
            // 
            this.textBox_ModifyPrice.Location = new System.Drawing.Point(71, 19);
            this.textBox_ModifyPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ModifyPrice.Name = "textBox_ModifyPrice";
            this.textBox_ModifyPrice.Size = new System.Drawing.Size(100, 21);
            this.textBox_ModifyPrice.TabIndex = 47;
            // 
            // Form_BnsShopTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 682);
            this.Controls.Add(this.groupBox_modify);
            this.Controls.Add(this.groupBox_Add);
            this.Controls.Add(this.listView_ItemList);
            this.Controls.Add(this.listView_GoodsList);
            this.Controls.Add(this.treeView_GoodsList);
            this.Controls.Add(this.textBox_Pawd);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.textBox_Host);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BnsShopTools";
            this.Text = "BnsShopTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox_modify.ResumeLayout(false);
            this.groupBox_modify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader GoodsId;
        private System.Windows.Forms.ColumnHeader GoodsName;
        private System.Windows.Forms.ListView listView_GoodsList;
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
        public System.Windows.Forms.TreeView treeView_GoodsList;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.ComboBox comboBox_CategoryId;
        private System.Windows.Forms.Button button_DelItemInList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_Items;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button_AddItemInList;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_SaleStatus;
        private System.Windows.Forms.Button button_AddGoods;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_GoodsAddPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_GoodsDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_GoodsAdminAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_GoodsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_GoodsId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox_modify;
        private System.Windows.Forms.Button button_ModifyGameItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_ModifyGameItem;
        private System.Windows.Forms.Button button_ModifyItemCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_ModifyItemCount;
        private System.Windows.Forms.Button button_DownGoods;
        private System.Windows.Forms.Button button_UpGoods;
        private System.Windows.Forms.Button button_ModifyPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_ModifyPrice;
    }
}