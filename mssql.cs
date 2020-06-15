using MSSQL.BNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MSSQL
{
    public class GameItemKey
    {
        private string encodechar;
        public Dictionary<string, int> dic = new Dictionary<string, int>();

        public GameItemKey()
        {
            encodechar = Range('A', 'Z') + Range('a', 'z') + Range('0', '9') + "+" + "/";
            for (int i = 100; i <= 1000000; i++)
            {
                dic.Add(GetGameItemKey(i), i);
            }
        }
        private string GetGameItemKey(int id)
        {

            int itemno = id * 16;
            string key = "";
            while (itemno >= 64)
            {

                key = key.Insert(0, encodechar[itemno % 64].ToString());
                itemno = (int)Math.Floor((decimal)(itemno / 64));
            }
            key = key.Insert(0, encodechar[itemno].ToString());
            while (key.Length < 4)
            {
                key = "A" + key;
            }
            key = "AA" + key + "==";
            return key;
        }

        private string Range(char min, char max)
        {
            string temp = "";
            for (int i = min; i <= max; ++i)
            {
                temp += (char)i;
            }
            return temp;
        }
    }
    public struct GoodsList
    {
        public String GoodsId;
        public String ItemId;
        public String GoodsName;
        public String SaleStatus;
        public String SalePrice;
    }

    public struct B_Categories
    {
        public String CategoryId;
        public String CategoryName;
        public String AppGroupCode;
        public String IsDisplayable;
        public String DisplayOrder;
        public String Changed;
        public String ChangerAdminAccount;
        public String CurrencyGroupId;
        public String ParentCategoryId;
        public String CategoryData;
        public B_Categories(String CategoryId, String CategoryName)
        {
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
            this.AppGroupCode="";
            this.IsDisplayable = "";
            this.DisplayOrder = "";
            this.Changed = "";
            this.ChangerAdminAccount = "";
            this.CurrencyGroupId = "";
            this.ParentCategoryId = "";
            this.CategoryData = "";
        }
    }

    public struct ItemList
    {
        public string ItemId;
        public string ItemName;
        public string ItemType;
        public string ItemQuantity;
        public string GameItemId;

        public ItemList(string ItemId, string ItemName, string ItemType, string ItemQuantity, string GameItemId)
        {
            this.ItemId = ItemId;
            this.ItemName = ItemName;
            this.ItemType = ItemType;
            this.ItemQuantity = ItemQuantity;
            this.GameItemId = GameItemId;
        }
        public ListViewItem toListViewItem()
        {
            ListViewItem list = new ListViewItem(ItemName);
            list.SubItems.Add(ItemId);
            list.SubItems.Add(GameItemId);
            list.SubItems.Add(ItemQuantity);
            return list;
        }
    }

    public class Bns
    {


        protected SqlConnection sqlCnt;


        public bool Connect(String connectStr)
        {
            try
            {
                sqlCnt = new SqlConnection(connectStr);
                sqlCnt.Open();
                return true;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlCnt.Close();
            }

        }

        public bool GetCategories(ref B_Categories[] Categories)
        {
            try
            {
                String sqlStr = "SELECT * FROM GoodsDb.dbo.Categories WHERE CategoryId <> 40 and ParentCategoryId <> 40 and CategoryData='{\"CategoryType\":[\"01\"]}' ORDER BY  ParentCategoryId ASC,  DisplayOrder ASC";
                sqlCnt.Open();
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(sqlStr, sqlCnt);
                DataSet myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, "strtable");
                DataTable myTable = myDataSet.Tables["strtable"];
                Categories = new B_Categories[myTable.Rows.Count];
                int i = 0;
                foreach (DataRow myRow in myTable.Rows)
                {
                    Categories[i].CategoryId = myRow[0].ToString();
                    Categories[i].CategoryName = myRow[1].ToString();
                    Categories[i].AppGroupCode = myRow[2].ToString();
                    Categories[i].IsDisplayable = myRow[3].ToString();
                    Categories[i].DisplayOrder = myRow[4].ToString();
                    Categories[i].Changed = myRow[5].ToString();
                    Categories[i].ChangerAdminAccount = myRow[6].ToString();
                    Categories[i].CurrencyGroupId = myRow[7].ToString();
                    Categories[i].ParentCategoryId = myRow[8].ToString();
                    Categories[i].CategoryData = myRow[9].ToString();
                    i++;
                    //Console.WriteLine(tempCategories[i].CategoryName);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                sqlCnt.Close();
            }

        }

        public bool GetGoodsByCategoryId(String CategoryId, ref GoodsList[] GL)
        {
            try
            {
                String sqlStr =
                                    "SELECT\n" +
                                    "	G.GoodsId,\n" +
                                    "	GD.GoodsDisplayName,\n" +
                                    "	GBP.SalePrice,\n" +
                                    "	G.SaleStatus\n" +
                                    "FROM\n" +
                                    "	GoodsDb.dbo.GoodsCategories AS GC WITH ( NOLOCK )\n" +
                                    "	INNER JOIN GoodsDb.dbo.Goods AS G WITH ( NOLOCK ) ON GC.GoodsId = G.GoodsId\n" +
                                    "	INNER JOIN GoodsDb.dbo.GoodsDisplay AS GD WITH ( NOLOCK ) ON GC.GoodsId = GD.GoodsId\n" +
                                    "	INNER JOIN GoodsDb.dbo.GoodsSalePricePolicies AS GBP WITH ( NOLOCK ) ON GC.GoodsId = GBP.GoodsId \n" +
                                    "WHERE\n" +
                                    "	G.EffectiveTo >= SYSDATETIMEOFFSET () \n" +
                                    "	AND GC.CategoryId = " + CategoryId + " \n" +
                                    "	AND GD.LanguageCode = 11 \n" +
                                    "	AND GBP.CurrencyGroupId = 71 \n" +
                                    "ORDER BY\n" +
                                    "	GoodsId DESC";
                sqlCnt.Open();
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(sqlStr, sqlCnt);
                DataSet myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, "strtable");
                DataTable myTable = myDataSet.Tables["strtable"];
                GL = new GoodsList[myTable.Rows.Count];
                int i = 0;
                decimal resMin1 = 0;
                foreach (DataRow myRow in myTable.Rows)
                {
                    GL[i].GoodsId = myRow[0].ToString();
                    GL[i].GoodsName = myRow[1].ToString();
                    Decimal.TryParse(myRow[2].ToString(), out resMin1);
                    GL[i].SalePrice = Convert.ToInt32(resMin1).ToString();
                    GL[i].SaleStatus = myRow[3].ToString();
                    i++;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlCnt.Close();
            }
        }

        public void GetItemListByGoodsId(int GoodsId, GameItemKey gameItemKey, ref ItemList[] itemLists)
        {
            try
            {
                String sqlStr = "SELECT\n" +
                                "	I.ItemId,\n" +
                                "	I.ItemName,\n" +
                                "	I.ItemType,\n" +
                                "	GI.ItemQuantity,\n" +
                                "	GIt.GameItemKey \n" +
                                "FROM\n" +
                                "	GoodsDb.dbo.GoodsItems AS GI WITH ( NOLOCK )\n" +
                                "	INNER JOIN GoodsDb.dbo.Items AS I WITH ( NOLOCK ) ON GI.ItemId = I.ItemId\n" +
                                "	INNER JOIN GoodsDb.dbo.GameItems AS GIt WITH ( NOLOCK ) ON GIt.ItemId = I.ItemId \n" +
                                "WHERE\n" +
                                "	GI.GoodsId = " + GoodsId.ToString();
                SqlCommand cmd = new SqlCommand(sqlStr, sqlCnt);
                sqlCnt.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                itemLists = new ItemList[dataSet.Tables[0].Rows.Count];
                int i = 0;
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    itemLists[i].ItemId = dataRow[0].ToString();
                    itemLists[i].ItemName = dataRow[1].ToString();
                    itemLists[i].ItemType = dataRow[2].ToString();
                    itemLists[i].ItemQuantity = dataRow[3].ToString();
                    Console.WriteLine(dataRow[4].ToString());
                    Console.WriteLine(gameItemKey.dic[dataRow[4].ToString()].ToString());
                    itemLists[i].GameItemId = gameItemKey.dic[dataRow[4].ToString()].ToString();

                    ++i;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                sqlCnt.Close();
            }
        }

        public bool AddGoods(GoodsCore goodsCore, GoodsSaleLimitCore goodsSaleLimitCore,
                             GoodsCategoryCore goodsCategoryCore, GoodsDisplayCore goodsDisplayCore,
                             GoodsSalePricePolicyCore goodsSalePricePolicyCore, GoodsBasicPriceCore goodsBasicPriceCore,
                             GoodsItemCore goodsItemCore, GoodsItemBasicPriceCore goodsItemBasicPriceCore, GoodsChangeCore goodsChangeCore)
        {
            int retCode = 0;
            try
            {
                AddGoodsCore(ref retCode, goodsCore);
                AddGoodsSaleLimitCore(ref retCode, goodsSaleLimitCore);
                AddGoodsCategoryCore(ref retCode, goodsCategoryCore);
                AddGoodsDisplayCore(ref retCode, goodsDisplayCore);
                AddGoodsSalePricePolicyCore(ref retCode, goodsSalePricePolicyCore);
                AddGoodsBasicPriceCore(ref retCode, goodsBasicPriceCore);
                AddGoodsItemCore(ref retCode, goodsItemCore);
                AddGoodsItemBasicPriceCore(ref retCode, goodsItemBasicPriceCore);
                AddGoodsChangeCore(ref retCode, goodsChangeCore);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void AddGoodsCore(ref int retCode, GoodsCore goodsCore)//添加商品代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsCore.GoodsId;
                sqlCmd.Parameters.Add("@GoodsName", SqlDbType.NVarChar).Value = goodsCore.GoodsName;
                sqlCmd.Parameters.Add("@GoodsAppGroupCode", SqlDbType.VarChar).Value = goodsCore.GoodsAppGroupCode;
                sqlCmd.Parameters.Add("@GoodsType", SqlDbType.SmallInt).Value = goodsCore.GoodsType;
                sqlCmd.Parameters.Add("@DeliveryType", SqlDbType.SmallInt).Value = goodsCore.DeliveryType;
                sqlCmd.Parameters.Add("@SaleStatus", SqlDbType.SmallInt).Value = goodsCore.SaleStatus;
                sqlCmd.Parameters.Add("@EffectiveFrom", SqlDbType.DateTimeOffset).Value = goodsCore.EffectiveFrom;
                sqlCmd.Parameters.Add("@EffectiveTo", SqlDbType.DateTimeOffset).Value = goodsCore.EffectiveTo;
                sqlCmd.Parameters.Add("@SaleableQuantity", SqlDbType.Int).Value = goodsCore.SaleableQuantity;
                sqlCmd.Parameters.Add("@RefundUnitCode", SqlDbType.SmallInt).Value = goodsCore.RefundUnitCode;
                sqlCmd.Parameters.Add("@IsRefundable", SqlDbType.Bit).Value = goodsCore.IsRefundable;
                sqlCmd.Parameters.Add("@IsAvailableRecurringPayment", SqlDbType.Bit).Value = goodsCore.IsAvailableRecurringPayment;
                sqlCmd.Parameters.Add("@ChangerAdminAccount", SqlDbType.VarChar).Value = goodsCore.ChangerAdminAccount;
                sqlCmd.Parameters.Add("@GoodsDescription", SqlDbType.NVarChar).Value = goodsCore.GoodsDescription;
                sqlCmd.Parameters.Add("@GoodsData", SqlDbType.VarChar).Value = goodsCore.GoodsData;
                sqlCmd.Parameters.Add("@ParentGoodsId", SqlDbType.Int).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@GoodsPurchaseType", SqlDbType.SmallInt).Value = goodsCore.GoodsPurchaseType;
                sqlCmd.Parameters.Add("@GoodsPurchaseCheckMask", SqlDbType.Int).Value = goodsCore.GoodsPurchaseCheckMask;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsSaleLimitCore(ref int retCode, GoodsSaleLimitCore goodsSaleLimitCore)//添加商品销售限额代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsSaleLimitCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsSaleLimitCore.GoodsId;
                sqlCmd.Parameters.Add("@SaleLimitType", SqlDbType.SmallInt).Value = goodsSaleLimitCore.SaleLimitType;
                sqlCmd.Parameters.Add("@SaleLimitValue", SqlDbType.Int).Value = goodsSaleLimitCore.SaleLimitValue;
                sqlCmd.Parameters.Add("@SaleLimitExternalKey", SqlDbType.VarChar).Value = DBNull.Value;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsCategoryCore(ref int retCode, GoodsCategoryCore goodsCategoryCore)//添加商品类别代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsCategoryCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsCategoryCore.GoodsId;
                sqlCmd.Parameters.Add("@CategoryId", SqlDbType.SmallInt).Value = goodsCategoryCore.CategoryId;
                sqlCmd.Parameters.Add("@DisplayOrder", SqlDbType.Int).Value = goodsCategoryCore.DisplayOrder;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsDisplayCore(ref int retCode, GoodsDisplayCore goodsDisplayCore)//添加商品显示代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsDisplayCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsDisplayCore.GoodsId;
                sqlCmd.Parameters.Add("@LanguageCode", SqlDbType.SmallInt).Value = goodsDisplayCore.LanguageCode;
                sqlCmd.Parameters.Add("@GoodsDisplayName", SqlDbType.NVarChar).Value = goodsDisplayCore.GoodsDisplayName;
                sqlCmd.Parameters.Add("@GoodsDisplayDescription", SqlDbType.NVarChar).Value = goodsDisplayCore.GoodsDisplayDescription;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsSalePricePolicyCore(ref int retCode, GoodsSalePricePolicyCore goodsSalePricePolicyCore)//添加商品销售价格政策代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsSalePricePolicyCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsSalePricePolicyCore.GoodsId;
                sqlCmd.Parameters.Add("@CurrencyGroupId", SqlDbType.SmallInt).Value = goodsSalePricePolicyCore.CurrencyGroupId;
                sqlCmd.Parameters.Add("@PricePolicyType", SqlDbType.SmallInt).Value = goodsSalePricePolicyCore.PricePolicyType;
                sqlCmd.Parameters.Add("@EffectiveFrom", SqlDbType.DateTimeOffset).Value = goodsSalePricePolicyCore.EffectiveFrom;
                sqlCmd.Parameters.Add("@EffectiveTo", SqlDbType.DateTimeOffset).Value = goodsSalePricePolicyCore.EffectiveTo;
                sqlCmd.Parameters.Add("@SalePrice", SqlDbType.Money).Value = goodsSalePricePolicyCore.SalePrice;
                sqlCmd.Parameters.Add("@DiscountValueType", SqlDbType.SmallInt).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@DiscountValue", SqlDbType.Money).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@DiscountKey", SqlDbType.VarChar).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@RewardValueType", SqlDbType.SmallInt).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@RewardValue", SqlDbType.Money).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@RewardTargetKey", SqlDbType.VarChar).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@RewardTargetKeyType", SqlDbType.SmallInt).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@GameGradeKey", SqlDbType.VarChar).Value = DBNull.Value;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsBasicPriceCore(ref int retCode, GoodsBasicPriceCore goodsBasicPriceCore)//添加商品基本价格代码 
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsBasicPriceCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsBasicPriceCore.GoodsId;
                sqlCmd.Parameters.Add("@CurrencyGroupId", SqlDbType.SmallInt).Value = goodsBasicPriceCore.CurrencyGroupId;
                sqlCmd.Parameters.Add("@BasicSalePrice", SqlDbType.Money).Value = goodsBasicPriceCore.BasicSalePrice;
                sqlCmd.Parameters.Add("@RefundFee", SqlDbType.Money).Value = goodsBasicPriceCore.RefundFee;


                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsItemCore(ref int retCode, GoodsItemCore goodsItemCore)//添加商品项目代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsItemCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsItemCore.GoodsId;
                sqlCmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = goodsItemCore.ItemId;
                sqlCmd.Parameters.Add("@ItemQuantity", SqlDbType.Int).Value = goodsItemCore.ItemQuantity;
                sqlCmd.Parameters.Add("@ItemExpirationType", SqlDbType.SmallInt).Value = goodsItemCore.ItemExpirationType;
                sqlCmd.Parameters.Add("@ItemExpireAt", SqlDbType.DateTimeOffset).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@ItemExpirationDuration", SqlDbType.Int).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@ItemData", SqlDbType.VarChar).Value = goodsItemCore.ItemData;
                sqlCmd.Parameters.Add("@DeliveryPriority", SqlDbType.Int).Value = goodsItemCore.DeliveryPriority;
                sqlCmd.Parameters.Add("@LimitedGameServerMask", SqlDbType.VarChar).Value = DBNull.Value;


                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsItemBasicPriceCore(ref int retCode, GoodsItemBasicPriceCore goodsItemBasicPriceCore)//添加商品项目基本价格代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsItemBasicPriceCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@GoodsId", SqlDbType.Int).Value = goodsItemBasicPriceCore.GoodsId;
                sqlCmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = goodsItemBasicPriceCore.ItemId;
                sqlCmd.Parameters.Add("@CurrencyGroupId", SqlDbType.SmallInt).Value = goodsItemBasicPriceCore.CurrencyGroupId;
                sqlCmd.Parameters.Add("@BasicSalePrice", SqlDbType.Money).Value = goodsItemBasicPriceCore.BasicSalePrice;
                sqlCmd.Parameters.Add("@BasicRefundPrice", SqlDbType.Money).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@BasicRefundPricePerSecond", SqlDbType.Money).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@BasicRefundPricePerHour", SqlDbType.Money).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@BasicRefundPricePerDay", SqlDbType.Money).Value = DBNull.Value;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public void AddGoodsChangeCore(ref int retCode, GoodsChangeCore goodsChangeCore)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGoodsChangeCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.Add("@ChangeId", SqlDbType.Int).Value = goodsChangeCore.ChangeId;
                sqlCmd.Parameters.Add("@ChangeType", SqlDbType.SmallInt).Value = goodsChangeCore.ChangeType;
                sqlCmd.Parameters.Add("@RegistrarAdminAccount", SqlDbType.VarChar).Value = goodsChangeCore.RegistrarAdminAccount;
                sqlCmd.Parameters.Add("@ChangeDescription", SqlDbType.NVarChar).Value = DBNull.Value;
                sqlCmd.Parameters.Add("@GoodsAppGroupCode", SqlDbType.VarChar).Value = goodsChangeCore.GoodsAppGroupCode;
                sqlCmd.Parameters.Add("@IsDisplayable", SqlDbType.Bit).Value = goodsChangeCore.IsDisplayable;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }
        }
        public bool SetGoodsPrice(string GoodsId,string Price)
        {
            try
            {
                string sqlStr = "UPDATE GoodsDb.dbo.GoodsItemBasicPrices SET BasicSalePrice =" + Price + " WHERE GoodsId = " + GoodsId +
                              "\nUPDATE GoodsDb.dbo.GoodsSalePricePolicies SET SalePrice=" + Price + " WHERE GoodsId = " + GoodsId;
                SqlCommand cmd = new SqlCommand(sqlStr, sqlCnt);
                sqlCnt.Open();
                int ret = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                if (ret == 0)
                {
                    return false;
                }
                int retCode = 0;
                GoodsChangeCore goodsChangeCore = new GoodsChangeCore(Convert.ToInt32(GoodsId), 2,"AdminiWeilai");
                AddGoodsChangeCore(ref retCode,goodsChangeCore);
                return true;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                sqlCnt.Close();
            }


        }
        public bool SetGoodsSaleStatus(string GoodsId,string SaleStatus)
        {
            try
            {
                string sqlStr = "UPDATE GoodsDb.dbo.Goods SET SaleStatus=" + SaleStatus + " WHERE GoodsId=" + GoodsId;
                SqlCommand cmd = new SqlCommand(sqlStr, sqlCnt);
                sqlCnt.Open();
                int ret = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                if (ret==0)
                {
                    return false;
                }
                int retCode = 0;
                GoodsChangeCore goodsChangeCore = new GoodsChangeCore(Convert.ToInt32(GoodsId), 2, "AdminiWeilai");
                AddGoodsChangeCore(ref retCode, goodsChangeCore);
                return true;
                
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                sqlCnt.Close();
            }
        }
        public bool IsGoodsByGoodsId(string GoodsId)
        {
            try
            {
                string sqlStr = "SELECT GoodsId FROM GoodsDb.dbo.Goods  WHERE GoodsId = " + GoodsId;
                //SqlCommand cmd = new SqlCommand(sqlStr, sqlCnt);
                sqlCnt.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStr, sqlCnt);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                sqlCnt.Close();
            }
        }

        //项目
        public bool AddItem(ItemCore itemCore, GameItemCore gameItemCore, ItemDisplayCore itemDisplayCore)
        {
            try
            {
                int retCode = 0;
                AddItemCore(ref retCode, itemCore);
                AddGameItemCore(ref retCode, gameItemCore);
                AddItemDisplayCore(ref retCode, itemDisplayCore);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void AddItemCore(ref int retCode, ItemCore itemCore)//添加项目代码
        {
            try
            {

                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddItemCore", sqlCnt)
                {

                    //添加参数
                    CommandType = CommandType.StoredProcedure//设置执行存储过程
                };
                sqlCmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = itemCore.@ItemId;
                sqlCmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = itemCore.@ItemName;
                sqlCmd.Parameters.Add("@ItemAppGroupCode", SqlDbType.VarChar).Value = itemCore.@ItemAppGroupCode;
                sqlCmd.Parameters.Add("@ItemType", SqlDbType.SmallInt).Value = itemCore.@ItemType;
                sqlCmd.Parameters.Add("@IsConsumable", SqlDbType.Bit).Value = itemCore.@IsConsumable;
                sqlCmd.Parameters.Add("@BasicPrice", SqlDbType.Money).Value = itemCore.@BasicPrice;
                sqlCmd.Parameters.Add("@BasicCurrencyGroupId", SqlDbType.SmallInt).Value = itemCore.@BasicCurrencyGroupId;
                sqlCmd.Parameters.Add("@ChangerAdminAccount", SqlDbType.VarChar).Value = itemCore.@ChangerAdminAccount;
                sqlCmd.Parameters.Add("@ItemDescription", SqlDbType.VarChar).Value = itemCore.@ItemDescription;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }
        }
        public void AddGameItemCore(ref int retCode, GameItemCore gameItemCore)//添加游戏项目代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddGameItemCore", sqlCnt)
                {
                    //添加参数
                    CommandType = CommandType.StoredProcedure//设置执行存储过程
                };
                sqlCmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = gameItemCore.@ItemId;
                sqlCmd.Parameters.Add("@GameItemKey", SqlDbType.NVarChar).Value = gameItemCore.GameItemKey;
                sqlCmd.Parameters.Add("@GameItemData", SqlDbType.VarChar).Value = gameItemCore.GameItemData;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }
        }
        public void AddItemDisplayCore(ref int retCode, ItemDisplayCore itemDisplayCore)//添加项目显示代码
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("GoodsDb.dbo.p_AddItemDisplayCore", sqlCnt)
                {

                    //添加参数
                    CommandType = CommandType.StoredProcedure//设置执行存储过程
                };
                sqlCmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = itemDisplayCore.@ItemId;
                sqlCmd.Parameters.Add("@LanguageCode", SqlDbType.NVarChar).Value = itemDisplayCore.LanguageCode;
                sqlCmd.Parameters.Add("@ItemDisplayName", SqlDbType.VarChar).Value = itemDisplayCore.ItemDisplayName;
                sqlCmd.Parameters.Add("@ItemDisplayDescription", SqlDbType.VarChar).Value = itemDisplayCore.ItemDisplayDescription;

                //添加返回值
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                sqlCmd.Parameters.Add(parReturn);
                //执行
                sqlCnt.Open();
                sqlCmd.ExecuteNonQuery();
                retCode = (int)parReturn.Value;
                if (retCode != 0)
                {
                    throw new Exception(sqlCmd.CommandText + " 执行出错");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // 断开
                sqlCnt.Close();
            }

        }
        public bool IsItemByItemId(string ItemId)
        {
            try
            {
                string sqlStr = "SELECT ItemId FROM GoodsDb.dbo.Items  WHERE ItemId = " + ItemId;
                //SqlCommand cmd = new SqlCommand(sqlStr, sqlCnt);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStr, sqlCnt);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

    }


}
