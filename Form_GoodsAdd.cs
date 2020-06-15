using MSSQL;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSSQL.BNS;
using System.Collections.Generic;

namespace BnsShop
{
    public partial class Form_GoodsAdd : Form
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
        private Bns bns = null; 
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public static void SetHintText(Control control, string text)
        {
            SendMessage(control.Handle, 0x1501, 0, text);
        }
        public Form_GoodsAdd(Bns bns)
        {
            InitializeComponent();
            this.bns = bns;
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
        private void Form3_Load(object sender, EventArgs e)
        {

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
            SetHintText(textBox_GoodsPrice, "物品价格");
            SetHintText(textBox_SaleStatus, "1:待上架,2:上架");
            //控件初始化文本
            textBox_ItemAdminAccount.Text = "AdminWeilai";
            textBox_GoodsAdminAccount.Text = "AdminWeilai";

            //初始化 combox
            List<ComBoBoxItem> list = new List<ComBoBoxItem>();
            foreach (TreeNode treeNode in Form1.form1.treeView_GoodsList.Nodes)
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
           
            //临时初始化文本
            textBox_ItemId.Text = "80493";
            textBox_GameItemId.Text = "80402";
            textBox_ItemQuantity.Text = "10";
            textBox_ItemName.Text = "测试项目";

            textBox_GoodsId.Text = "80500";
            textBox_GoodsName.Text = "测试商品";
            textBox_GoodsPrice.Text = "111";
            textBox_SaleStatus.Text = "2";
        }

        private void button_AddItemInList_Click(object sender, EventArgs e)
        {
            try
            {             
                if (ListViewFind(listView_Items, textBox_ItemId.Text,0) != -1)
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

                MessageBox.Show(ex.Message,"提示");
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
                int.TryParse(textBox_GoodsPrice.Text, out int Price);
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
                    string ItemDescription= item.SubItems[5].Text;
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
                MessageBox.Show("请选择一个项目进行删除","提示");
                return;
            }
            
            int index = selectedList[0].Index;
            listView_Items.Items.Remove(selectedList[0]);
            if ( listView_Items.Items.Count - 1 < index )
            {
                --index;
            }
            if (index != -1)
            {
                listView_Items.Items[index].Selected = true;
            }
            listView_Items.Focus();






        }
        private void comboBox_CategoryId_DropDown(object sender, EventArgs e)
        {
            if (comboBox_CategoryId.Items.Count == 0)
            {

               
            }
        }

        private void comboBox_CategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CategoryId.SelectedItem != null)
            {
                Console.WriteLine(((ComBoBoxItem)comboBox_CategoryId.SelectedItem).Value);
            }
        }
    }
}
