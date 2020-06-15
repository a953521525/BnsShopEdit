using System;

namespace MSSQL.BNS
{
    public class GoodsCore
    {
        public int GoodsId; //商品ID
        public String GoodsName; //商品名称
        public String GoodsAppGroupCode = "bnsgrnTH"; //商品应用组代码  固定为bnsgrnTH
        public short GoodsType = 3; //商品类型 未知 默认3
        public short DeliveryType = 1; //交货类型 未知 默认1
        public short SaleStatus = 2; //销售状态 1：不出售 2：出售 
        public DateTimeOffset EffectiveFrom = DateTimeOffset.UtcNow.ToLocalTime(); //有效时间起始，+08代表东八区，北京时间
        public DateTimeOffset EffectiveTo = DateTimeOffset.MaxValue.ToLocalTime(); //有效时间至
        public int SaleableQuantity = 0; //可销售数量 未知 默认0
        public short RefundUnitCode = 1; //退款单位代码 未知 默认1
        public byte IsRefundable = 0; //是否可退款 未知 默认0
        public byte IsAvailableRecurringPayment = 1; //有可用的定期付款 未知 默认1
        public String ChangerAdminAccount = "TestAdminAccount"; //更改管理账户 随意
        public String GoodsDescription = ""; //商品描述 随意
        public String GoodsData = "AAAAAAE="; //目前能看到的是对商品图标的影响，如果是AAAAAAE=的话，商品图标就是物品本身的图标；如果是AQAAAAE=，则被认为是组合商品，图标是一个箱子；AAACAAE=会在首页的推荐商品展示
        public int ParentGoodsId; //父商品ID 未知 默认null
        public short GoodsPurchaseType = 1; //商品采购类型 未知 默认1
        public int GoodsPurchaseCheckMask = 0;  //商品购买确认掩码 未知 默认0

        public GoodsCore(int GoodsId, String GoodsName, DateTimeOffset? EffectiveFrom, DateTimeOffset? EffectiveTo, String ChangerAdminAccount = "", String GoodsDescription = "")
        {
            if (GoodsId == 0)
            {
                throw new Exception("商品ID设置错误");
            }
            if (GoodsName == "" || GoodsName == null)
            {
                throw new Exception("商品名称设置错误");
            }
            if (null != EffectiveFrom)
                this.EffectiveFrom = EffectiveFrom.Value;
            if (null != EffectiveTo)
                this.EffectiveTo = EffectiveTo.Value;
            if (null != ChangerAdminAccount && ChangerAdminAccount.ToString() != "")
            {
                this.ChangerAdminAccount = ChangerAdminAccount;
            }

            if (null != GoodsDescription && GoodsDescription.ToString() != "")
            {
                this.GoodsDescription = GoodsDescription;
            }
            else
            {
                this.GoodsDescription = GoodsName;
            }

            this.GoodsId = GoodsId;
            this.GoodsName = GoodsName;
        }
        public GoodsCore(int GoodsId, String GoodsName, String GoodsAppGroupCode, short GoodsType, short DeliveryType, short SaleStatus, DateTimeOffset? EffectiveFrom, DateTimeOffset? EffectiveTo, int SaleableQuantity, short RefundUnitCode, byte IsRefundable, byte IsAvailableRecurringPayment, String ChangerAdminAccount, String GoodsDescription, String GoodsData, int ParentGoodsId, short GoodsPurchaseType, int GoodsPurchaseCheckMask)
        {
            this.GoodsId = GoodsId;
            this.GoodsName = GoodsName;
            this.GoodsAppGroupCode = GoodsAppGroupCode;
            this.GoodsType = GoodsType;
            this.DeliveryType = DeliveryType;
            this.SaleStatus = SaleStatus;
            this.EffectiveFrom = EffectiveFrom.Value;
            this.EffectiveTo = EffectiveTo.Value;
            this.SaleableQuantity = SaleableQuantity;
            this.RefundUnitCode = RefundUnitCode;
            this.IsRefundable = IsRefundable;
            this.IsAvailableRecurringPayment = IsAvailableRecurringPayment;
            this.ChangerAdminAccount = ChangerAdminAccount;
            this.GoodsDescription = GoodsDescription;
            this.GoodsData = GoodsData;
            this.ParentGoodsId = ParentGoodsId;
            this.GoodsPurchaseType = GoodsPurchaseType;
            this.GoodsPurchaseCheckMask = GoodsPurchaseCheckMask;
        }

    }

    public class GoodsSaleLimitCore
    {
        public int GoodsId;//商品ID
        public short SaleLimitType = 1; //销售限额类型 未知 默认1
        public int SaleLimitValue = 1; //销售限额值 未知 默认1
        public string SaleLimitExternalKey; //销售限额外部密钥 未知 默认null

        public GoodsSaleLimitCore(int GoodsId)
        {
            this.GoodsId = GoodsId;
        }
    }

    public class GoodsCategoryCore

    {
        public int GoodsId; //商品ID
        public short CategoryId; //类别ID 查询Categories定义的id或者自已通过服务添加category
        public int DisplayOrder = 1; //展示顺序，越大越靠前，如果相同的话可能是根据名字或者id来的？
        public GoodsCategoryCore(int GoodsId, short CategoryId, int DisplayOrder = 1)
        {
            this.GoodsId = GoodsId;
            this.CategoryId = CategoryId;
            if (CategoryId == 0)
            {
                throw new Exception("类别ID设置错误");

            }
            if (DisplayOrder > 1)
                this.DisplayOrder = DisplayOrder;
        }
    }

    public class GoodsDisplayCore
    {
        public int GoodsId; //商品ID
        public short LanguageCode = 11; //语言代码 显示语言，11代表泰语，必须有这个（可能跟这个是泰服端有关？）1代表韩语，2代表简体中文 默认11
        public string GoodsDisplayName; //商品显示名称 
        public string GoodsDisplayDescription; //商品显示描述
        public GoodsDisplayCore(int GoodsId, string GoodsDisplayName, string GoodsDisplayDescription)
        {
            this.GoodsId = GoodsId;
            this.GoodsDisplayName = GoodsDisplayName;
            if (GoodsDisplayDescription == "" || GoodsDisplayDescription == null)
            {
                this.GoodsDisplayDescription = GoodsDisplayName;
            }
            else
            {
                this.GoodsDisplayDescription = GoodsDisplayDescription;
            }

        }
    }

    public class GoodsSalePricePolicyCore
    {
        public int GoodsId; //商品ID
        public short CurrencyGroupId = 71; //货币组代码 默认使用71 代表神石 CurrencyGroupId要有对应的GoodsBasicPrice设置。假设这里我的GroupId是1，则下边的GoodsBasicPrice里必须有CurrencyGroupId的设置，否则报错
        public short PricePolicyType = 1; //价格政策类型 未知 默认1
        public DateTimeOffset EffectiveFrom = DateTimeOffset.UtcNow.ToLocalTime();//有效时间开始 同一个CurrencyGroupId如果有多个策略的话，各个策略的时间不能重叠但可以断开，比如第一个策略时间是2012-2015，则第二个是2013-2016就不行。但是 2017-2020就可以
        public DateTimeOffset EffectiveTo = DateTimeOffset.MaxValue.ToLocalTime();//有效时间结束
        public int SalePrice; //销售价格  商品的最终价格
        public short DiscountValueType; //折扣类型 未知 默认null
        public int DiscountValue; //折扣数值 未知 默认null
        public string DiscountKey;//折扣key 未知 默认null
        public short RewardValueType; //奖励数值类型 未知 默认 null
        public int RewardValue; //奖励数值 未知 默认 null
        public string RewardTargetKey;//奖励目标key 未知 默认null
        public short RewardTargetKeyType; //奖励目标key类型 未知 默认null
        public string GameGradeKey; //游戏等级key 未知 默认null

        public GoodsSalePricePolicyCore(int GoodsId, int SalePrice)
        {
            this.GoodsId = GoodsId;
            this.SalePrice = SalePrice;
        }
    }

    public class GoodsBasicPriceCore
    {
        public int GoodsId; //商品ID
        public short CurrencyGroupId = 71;//根据上面CurrencyGroupId 设置即可
        public int BasicSalePrice;//销售价格  //受到上面面的price policies的影响，如果在policies中设置了价格，并且在生效期内，则以policies中的价格为准
        public int RefundFee = 0;//退款 未知 默认0
        public GoodsBasicPriceCore(int GoodsId, int BasicSalePrice)
        {
            this.GoodsId = GoodsId;
            this.BasicSalePrice = BasicSalePrice;
        }
    }

    public class GoodsItemCore
    {
        public int GoodsId;//商品ID
        public int ItemId; //项目ID 根据添加的项目ID 填写
        public int ItemQuantity; //项目物品数量
        public short ItemExpirationType = 0;//项目过期类型，必须有，0应该代表的是不过期 
        public DateTimeOffset ItemExpireAt;//项目有效期 未知 默认为null 应该是不过期
        public int ItemExpirationDuration; //项目有效期 不明白 默认为 null
        public string ItemData = "AAAAAAEA"; //项目数据？ 固定AAAAAAEA即可，没发现有啥特别的。。。
        public int DeliveryPriority = 1;//发送优先级？ 默认1
        public string LimitedGameServerMask;// 有限的游戏服务掩码 未知 默认null

        public GoodsItemCore(int GoodsId, int ItemId, int GameItemId, int ItemQuantity)
        {
            this.GoodsId = GoodsId;
            if (ItemId == 0)
            {
                this.ItemId = GameItemId;
            }
            else
            {
                this.ItemId = ItemId;
            }


            if (ItemQuantity == 0)
            {
                throw new Exception("物品数量设置错误");

            }
            this.ItemQuantity = ItemQuantity;
        }

    }

    public class GoodsItemBasicPriceCore
    {
        public int GoodsId; //商品ID
        public int ItemId; //项目ID 根据添加的项目ID 填写
        public short CurrencyGroupId = 71; //根据上面CurrencyGroupId 设置即可
        public int BasicSalePrice; //基本价格 未知 根据上面SalePricePolicy价格设置 
        public int BasicRefundPrice;//基本退款价格 未知 默认null
        public int BasicRefundPricePerSecond; //默认 null
        public int BasicRefundPricePerHour; //默认null
        public int BasicRefundPricePerDay; //默认null

        public GoodsItemBasicPriceCore(int GoodsId, int ItemId, int BasicSalePrice)
        {
            this.GoodsId = GoodsId;
            this.ItemId = ItemId;
            this.BasicSalePrice = BasicSalePrice;
        }
    }

    public class GoodsChangeByChangeType
    {
        public int ChangeId; //商品ID
        public short ChangeType; //变更的类型
        public string RegistrarAdminAccount;
        public string ChangeDescription;
        public GoodsChangeByChangeType(int ChangeId, short ChangeType, string RegistrarAdminAccount, string ChangeDescription)
        {
            this.ChangeId = ChangeId;
            this.ChangeType = ChangeType;
            this.RegistrarAdminAccount = RegistrarAdminAccount;
            this.ChangeDescription = ChangeDescription;
        }

    }

    public class ItemCore
    {
        public int ItemId;//项目ID
        public string ItemName; //项目名称
        public string ItemAppGroupCode = "bnsgrnTH"; //项目应用组代码 固定 bnsgrnTH
        public short ItemType = 3;//项目类型 未知 默认3
        public byte IsConsumable = 0;//是否消耗品 未知 默认0
        public int BasicPrice = 0;//基本价格 默认0
        public short BasicCurrencyGroupId = 69;// 固定69，改成其他的，购买物品后到不了商品盒。69代表收费神石，70是免费神石，71是神石。不知道不同的类别意义在哪里
        public string ChangerAdminAccount;//修改管理账户 随意
        public string ItemDescription; //项目描述
        public ItemCore(int ItemId, int GameItemId, string ItemName, string ChangerAdminAccount, string ItemDescription)
        {

            if (ItemName == "" || ItemName == null)
            {
                throw new Exception("商品名称设置错误");
            }
            if (ChangerAdminAccount == "" || ChangerAdminAccount == null)
            {
                throw new Exception("管理用户设置错误");
            }

            if (ItemId == 0)
            {
                this.ItemId = GameItemId;
            }
            else
            {
                this.ItemId = ItemId;
            }
            this.ItemName = ItemName;
            this.ChangerAdminAccount = ChangerAdminAccount;
            if (ItemDescription == "" || ItemDescription == null)
            {
                this.ItemDescription = ItemName;
            }
            else
            {
                this.ItemDescription = ItemDescription;
            }


        }

    }

    public class GameItemCore
    {
        static string encodechar = Range('A', 'Z') + Range('a', 'z') + Range('0', '9') + "+" + "/";
        public int ItemId;//项目ID
        public string GameItemKey; //游戏项目Key 通过物品ID用算法生生成
        public string GameItemData = "AAAAAAAAAAA="; // 固定AAAAAAAAAAA=

        public GameItemCore(int ItemId, int GameItemId)
        {

            if (GameItemId == 0)
            {
                throw new Exception("物品ID设置错误");
            }
            if (ItemId == 0)
            {
                this.ItemId = GameItemId;
            }
            else
            {
                this.ItemId = ItemId;
            }
            GameItemKey = GetGameItemKey(GameItemId);
        }
        public string GetGameItemKey(int id)
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
        public string GetGameItemKey()
        {

            int itemno = ItemId * 16;
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
        public string Reverse(string str)
        {
            string temp = "";
            for (int i = str.Length; i >= 0; --i)
            {
                temp += str[i];
            }
            return temp;

        }
        static string Range(char min, char max)
        {
            string temp = "";
            for (int i = min; i <= max; ++i)
            {
                temp += (char)i;
            }
            return temp;
        }

    }

    public class ItemDisplayCore
    {
        public int ItemId;//项目ID
        public short LanguageCode = 11; //语言代码 默认11
        public string ItemDisplayName; //项目显示名称
        public string ItemDisplayDescription; //项目描述
        public ItemDisplayCore(int ItemId, int GameItemId, string ItemDisplayName, string ItemDisplayDescription)
        {
            this.ItemId = ItemId;
            this.ItemDisplayName = ItemDisplayName;
            if (ItemId == 0)
            {
                this.ItemId = GameItemId;
            }
            else
            {
                this.ItemId = ItemId;
            }
            if (ItemDisplayDescription == "" || ItemDisplayDescription == null)
            {
                this.ItemDisplayDescription = ItemDisplayName;
            }
            else
            {
                this.ItemDisplayDescription = ItemDisplayDescription;
            }

        }
    }

    public class GoodsChangeCore
    {
        public int ChangeId;
        public short ChangeType;
        public string RegistrarAdminAccount;
        public string ChangeDescription;
        public string GoodsAppGroupCode;
        public byte IsDisplayable;

        public GoodsChangeCore(int ChangeId, short ChangeType, string RegistrarAdminAccount, string GoodsAppGroupCode = "bnsgrnTH", byte IsDisplayable = 1)
        {
            this.ChangeId = ChangeId;
            this.ChangeType = ChangeType;
            this.RegistrarAdminAccount = RegistrarAdminAccount;
            this.GoodsAppGroupCode = GoodsAppGroupCode;
            this.IsDisplayable = IsDisplayable;
        }
    }
}
