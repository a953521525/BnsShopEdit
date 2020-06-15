using MSSQL;
using MSSQL.BNS;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BnsShop
{
    public partial class Form1 : Form
    {
        
        private  Bns bns = new Bns();

        GameItemKey gameItemKey = new GameItemKey();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public static void SetHintText(Control control, string text)
        {
            SendMessage(control.Handle, 0x1501, 0, text);
        }


        public Form1()
        {
            InitializeComponent();
            form1 = this;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

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
                    listView_GoodsList.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }
        }
       
        private void treeView_GoodsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeView_GoodsList.SelectedNode;
            if (treeNode.Nodes != null)
            {
                string CategoryId = treeNode.Name;
                Console.WriteLine(CategoryId);
                SetGoodsInListView(CategoryId);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button_AddGoodsAndItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("111111aaaa1111111111", "提示");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_GoodsAdd form_GoodsAdd = new Form_GoodsAdd(bns);
            form_GoodsAdd.Show();
            //bns.IsItemCountByItemId("80999");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }



        
    }
}
