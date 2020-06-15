using MSSQL;
using MSSQL.BNS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BnsShop
{
    public partial class Form_BnsShopTools : Form
    {
        class ComBoBoxItem
        {
            public ComBoBoxItem(string value, string name)
            {
                Name = name;
                Value = value;
            }
            public string Name { get; private set; }
            public string Value { get; private set; }
        }
        private  Bns bns = new Bns();
        private List<ComBoBoxItem> list = new List<ComBoBoxItem>();
        private static string g_CategoryId = "";
        GameItemKey gameItemKey = new GameItemKey();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public static void SetHintText(Control control, string text)
        {
            SendMessage(control.Handle, 0x1501, 0, text);
        }
        public string AssemblyFileVersion()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            else
            {
                return ((AssemblyFileVersionAttribute)attributes[0]).Version.Substring(0,3);
            }
        }
        private int ListViewFind(ListView listView, string FindStr, int col)
        {
            int index = 0;
            foreach (ListViewItem item in listView.Items)
            {

                if (item.SubItems[col].Text == FindStr)
                {
                    return index;
                }
                ++index;
            }
            return -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置窗口名字
            string Version = AssemblyFileVersion();
            this.Text = this.Text + " " + Version;
            //控件初始化默认提示 
            SetHintText(textBox_ItemId, "为空自动设置");
            SetHintText(textBox_ItemName, "项目名称");
            SetHintText(textBox_ItemAdminAccount, "更改管理用户名");
            SetHintText(textBox_ItemDescription, "项目描述,为空自动设置");
            SetHintText(textBox_GameItemId, "物品代码");
            SetHintText(textBox_ItemQuantity, "物品数量");

            SetHintText(textBox_GoodsId, "商品代码");
            SetHintText(textBox_GoodsName, "商品名称");
            SetHintText(textBox_GoodsAdminAccount, "更改管理用户名");
            SetHintText(textBox_GoodsDescription, "商品描述,为空自动设置");
            SetHintText(textBox_GoodsAddPrice, "物品价格");
            SetHintText(textBox_SaleStatus, "1:待上架,2:上架");
            //控件初始化文本
            textBox_ItemAdminAccount.Text = "AdminWeilai";
            textBox_GoodsAdminAccount.Text = "AdminWeilai";

            ////临时初始化文本
            //textBox_ItemId.Text = "80493";
            //textBox_GameItemId.Text = "80402";
            //textBox_ItemQuantity.Text = "10";
            //textBox_ItemName.Text = "测试项目";

            //textBox_GoodsId.Text = "80500";
            //textBox_GoodsName.Text = "测试商品";
            //textBox_GoodsAddPrice.Text = "111";
            //textBox_SaleStatus.Text = "2";

        }
        public void SetCategoriesInTreeView()
        {
            B_Categories[] Categories = null;
            try
            {
                bns.GetCategories(ref Categories);
                foreach (B_Categories cg in Categories)
                {
                    if (cg.ParentCategoryId == "48")
                    {
                        TreeNode tn = treeView_GoodsList.Nodes.Add(cg.CategoryId, cg.CategoryName + "[" + cg.CategoryId + "]");
                        tn.Name = cg.CategoryId;
                        foreach (B_Categories cg2 in Categories)
                        {
                            if (cg2.ParentCategoryId == cg.CategoryId)
                            {
                                TreeNode tn2 = tn.Nodes.Add(cg2.CategoryId, cg2.CategoryName + "[" + cg2.CategoryId + "]");
                                tn2.Name = cg2.CategoryId;


                            }
                        }
                    }
                }
                treeView_GoodsList.ExpandAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }


        }
        private void SetGoodsInListView(string CategoryId)
        {
            GoodsList[] goodsList = null;
            try
            {
                bns.GetGoodsByCategoryId(CategoryId, ref goodsList);
                listView_GoodsList.Items.Clear();
                foreach (GoodsList gl in goodsList)
                {
                    ListViewItem lvi = new ListViewItem(gl.GoodsName);
                    lvi.SubItems.Add(gl.GoodsId);
                    lvi.SubItems.Add(gl.SalePrice);
                    lvi.SubItems.Add(gl.SaleStatus);
                    if (gl.SaleStatus == "1")
                    {
                        lvi.BackColor = Color.Red;
                    }
                    listView_GoodsList.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }
        }
        private void SetCategoriesInComboBox()
        {
            //初始化 combox
            
            foreach (TreeNode treeNode in treeView_GoodsList.Nodes)
            {
                list.Add(new ComBoBoxItem(treeNode.Name, treeNode.Text));
                if (treeNode.Nodes.Count > 0)
                {
                    foreach (TreeNode ChildTreeNode in treeNode.Nodes)
                    {
                        list.Add(new ComBoBoxItem(ChildTreeNode.Name, ChildTreeNode.Text));
                    }
                }
            }
            comboBox_CategoryId.DataSource = list;
            comboBox_CategoryId.DisplayMember = "Name";
        }
        private void SetComboBoxSelectedIndexByTreeView()
        {
            TreeNode treeNode = treeView_GoodsList.SelectedNode;
            if (treeNode!=null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (treeNode.Text == list[i].Name)
                    {
                        comboBox_CategoryId.SelectedIndex = i;
                        return;
                    }
                }
                
            }
        }
        private ListViewItem GetSelectedItemByListView(ListView lisetView)
        {
            ListView.SelectedListViewItemCollection listViewItem = lisetView.SelectedItems;
            if (listViewItem.Count>0)
            {
                return listViewItem[0];
            }
            return null;
        }
        public Form_BnsShopTools()
        {
            InitializeComponent();
            
        }


       

        private void treeView_GoodsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeView_GoodsList.SelectedNode;
            if (treeNode.Nodes != null)
            {
                g_CategoryId = treeNode.Name;
                Console.WriteLine(g_CategoryId);
                SetGoodsInListView(g_CategoryId);
                SetComboBoxSelectedIndexByTreeView();
            }


        }
        private void listView_GoodsList_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ListView.SelectedListViewItemCollection listViewItemCollection = listView_GoodsList.SelectedItems;
                if (listViewItemCollection != null)
                {
                    contextMenuStrip1.Show((Control)sender, e.X, e.Y);
                }

            }

        }
        private void listView_GoodsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listView_GoodsList.SelectedItems;
            if (selectedList.Count > 0)
            {
                int.TryParse(selectedList[0].SubItems[1].Text, out int GoodsId);
                try
                {
                    ItemList[] itemList = null;
                    bns.GetItemListByGoodsId(GoodsId, gameItemKey, ref itemList);
                    listView_ItemList.Items.Clear();
                    for (int i = 0; i < itemList.Length; i++)
                    {
                        listView_ItemList.Items.Add(itemList[i].toListViewItem());
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            string sqlCntStr = " data source = " + textBox_Host.Text + "; user id = " + textBox_User.Text + "; password = " + textBox_Pawd.Text + "; ";
            try
            {
                bns.Connect(sqlCntStr);
                MessageBox.Show("连接成功", "提示1");
                SetCategoriesInTreeView();
                SetCategoriesInComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button_AddItemInList_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewFind(listView_Items, textBox_ItemId.Text, 0) != -1)
                {
                    MessageBox.Show("列表中已存在相同的项目ID", "提示");
                    return;
                }
                if (!bns.IsItemByItemId(textBox_ItemId.Text))
                {
                    throw new ArgumentException("数据库已存在相同的项目ID");
                }
                ListViewItem listViewItem = new ListViewItem(textBox_ItemId.Text);
                listViewItem.SubItems.Add(textBox_ItemAdminAccount.Text);
                listViewItem.SubItems.Add(textBox_GameItemId.Text);
                listViewItem.SubItems.Add(textBox_ItemQuantity.Text);
                listViewItem.SubItems.Add(textBox_ItemName.Text);
                listViewItem.SubItems.Add(textBox_ItemDescription.Text);

                listView_Items.Items.Add(listViewItem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }



        }
        private void button_AddGoods_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Items.Items.Count == 0)
                {
                    throw new ArgumentException("至少添加一个项目");
                }
                if (!bns.IsGoodsByGoodsId(textBox_GoodsId.Text))
                {
                    throw new ArgumentException("数据库已存在相同的商品ID");
                }

                int retCode = 0;
                int.TryParse(textBox_GoodsId.Text, out int GoodsId);
                int.TryParse(textBox_SaleStatus.Text, out int SaleStatus);
                int.TryParse(textBox_GoodsAddPrice.Text, out int Price);
                short.TryParse(((ComBoBoxItem)comboBox_CategoryId.SelectedItem).Value, out short CategoryId);
                string GoodsName = textBox_GoodsName.Text;
                string GoodsDescription = textBox_GoodsDescription.Text;
                string GoodsAdminAccount = textBox_GoodsAdminAccount.Text;
                //添加商品
                GoodsCore goodsCore = new GoodsCore(GoodsId, GoodsName, null, null, GoodsAdminAccount, GoodsDescription);
                GoodsSaleLimitCore goodsSaleLimitCore = new GoodsSaleLimitCore(GoodsId);
                GoodsCategoryCore goodsCategoryCore = new GoodsCategoryCore(GoodsId, CategoryId);
                GoodsDisplayCore goodsDisplayCore = new GoodsDisplayCore(GoodsId, GoodsName, GoodsDescription);
                GoodsSalePricePolicyCore goodsSalePricePolicyCore = new GoodsSalePricePolicyCore(GoodsId, Price);
                GoodsBasicPriceCore goodsBasicPriceCore = new GoodsBasicPriceCore(GoodsId, Price);
                GoodsChangeCore goodsChangeCore = new GoodsChangeCore(GoodsId, 2, textBox_GoodsAdminAccount.Text);

                bns.AddGoodsCore(ref retCode, goodsCore);
                bns.AddGoodsSaleLimitCore(ref retCode, goodsSaleLimitCore);
                bns.AddGoodsCategoryCore(ref retCode, goodsCategoryCore);
                bns.AddGoodsDisplayCore(ref retCode, goodsDisplayCore);
                bns.AddGoodsSalePricePolicyCore(ref retCode, goodsSalePricePolicyCore);
                bns.AddGoodsBasicPriceCore(ref retCode, goodsBasicPriceCore);
                bns.AddGoodsChangeCore(ref retCode, goodsChangeCore);
                //添加项目
                foreach (ListViewItem item in listView_Items.Items)
                {
                    int.TryParse(item.SubItems[0].Text, out int ItemId);
                    int.TryParse(item.SubItems[2].Text, out int GameItemId);
                    int.TryParse(item.SubItems[3].Text, out int ItemQuantity);
                    string ItemName = item.SubItems[4].Text;
                    string ItemDescription = item.SubItems[5].Text;
                    string ItemAdminAccount = item.SubItems[2].Text;
                    ItemCore itemCore = new ItemCore(ItemId, GameItemId, ItemName, ItemAdminAccount, ItemDescription);
                    GameItemCore gameItemCore = new GameItemCore(ItemId, GameItemId);
                    ItemDisplayCore itemDisplayCore = new ItemDisplayCore(ItemId, GameItemId, ItemName, ItemDescription);
                    GoodsItemCore goodsItemCore = new GoodsItemCore(GoodsId, ItemId, GameItemId, ItemQuantity);
                    GoodsItemBasicPriceCore goodsItemBasicPriceCore = new GoodsItemBasicPriceCore(GoodsId, ItemId, Price);
                    bns.AddItemCore(ref retCode, itemCore);
                    bns.AddGameItemCore(ref retCode, gameItemCore);
                    bns.AddItemDisplayCore(ref retCode, itemDisplayCore);
                    bns.AddGoodsItemCore(ref retCode, goodsItemCore);
                    bns.AddGoodsItemBasicPriceCore(ref retCode, goodsItemBasicPriceCore);
                }


                MessageBox.Show("商品添加成功", "提示");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }

        }
        private void button_DelItemInList_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listView_Items.SelectedItems;
            if (selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("请选择一个项目进行删除", "提示");
                return;
            }

            int index = selectedList[0].Index;
            listView_Items.Items.Remove(selectedList[0]);
            if (listView_Items.Items.Count - 1 < index)
            {
                --index;
            }
            if (index != -1)
            {
                listView_Items.Items[index].Selected = true;
            }
            listView_Items.Focus();






        }

        private void button_ModifyPrice_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = GetSelectedItemByListView(listView_GoodsList);
            try
            {
                if (listViewItem == null)
                {
                    throw new ArgumentException("请选择一个商品进行修改");
                }
                string GoodsId = listViewItem.SubItems[1].Text;
                string Price = textBox_ModifyPrice.Text;

                if (bns.SetGoodsPrice(GoodsId, Price))
                {
                    SetGoodsInListView(g_CategoryId);
                    MessageBox.Show("商品ID：" + listViewItem.SubItems[1].Text + " 价格修改成功", "提示");
                }
                else
                {
                    MessageBox.Show("商品ID：" + listViewItem.SubItems[1].Text + " 价格修改失败", "提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"提示");
            }
            
        }

        private void button_UpGoods_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = GetSelectedItemByListView(listView_GoodsList);
            try
            {
                if(listViewItem == null)
                {
                    throw new ArgumentException("请选择一个商品进行上架");
                }
                if (bns.SetGoodsSaleStatus(listViewItem.SubItems[1].Text,"2"))
                {
                    SetGoodsInListView(g_CategoryId);
                    MessageBox.Show("商品ID：" + listViewItem.SubItems[1].Text + " 上架成功","提示");
                }
                else
                {
                    MessageBox.Show("商品ID：" + listViewItem.SubItems[1].Text + " 上架失败", "提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"提示");
            }
        }

        private void button_DownGoods_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = GetSelectedItemByListView(listView_GoodsList);
            try
            {
                if(listViewItem == null)
                {
                    throw new ArgumentException("请选择一个商品进行下架");
                }
                if (bns.SetGoodsSaleStatus(listViewItem.SubItems[1].Text, "1"))
                {
                    SetGoodsInListView(g_CategoryId);
                    MessageBox.Show("商品ID：" + listViewItem.SubItems[1].Text + " 下架成功", "提示");
                }
                else
                {
                    MessageBox.Show("商品ID：" + listViewItem.SubItems[1].Text + " 下架失败", "提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }
        }
    }

}
