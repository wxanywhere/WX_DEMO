using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// ?????
    /// </summary>
    [Serializable]
    public partial class VO_WF_GZLZY : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_GZLZY";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_GZLZY()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZYID", typeof(Decimal), true, false, (int)VO_WF_GZLZYIndex.ZYID, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYID", typeof(String), true, false, (int)VO_WF_GZLZYIndex.DYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYBB", typeof(Decimal), true, false, (int)VO_WF_GZLZYIndex.DYBB, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QSHDID", typeof(Decimal), false, false, (int)VO_WF_GZLZYIndex.QSHDID, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZZHDID", typeof(Decimal), false, false, (int)VO_WF_GZLZYIndex.ZZHDID, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "TJJBID", typeof(String), false, false, (int)VO_WF_GZLZYIndex.TJJBID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZYLX", typeof(Decimal), false, false, (int)VO_WF_GZLZYIndex.ZYLX, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "TJLX", typeof(Decimal), false, false, (int)VO_WF_GZLZYIndex.TJLX, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZYMC", typeof(String), false, false, (int)VO_WF_GZLZYIndex.ZYMC, 40, 0, 0);
            //__YDTF_用户代码区域_开始_静态构造函数
            
            //__YDTF_用户代码区域_结束_静态构造函数
            fieldInfoProvider.ConstructFieldStructures(EntityName);
        }

        #endregion

        #region debug模式下使用

#if DEBUG

        /// <summary>
        /// 实体描述
        /// </summary>
        public static Dictionary<string, string> _entityDesc = null;
        /// <summary>
        /// 获取实体描述
        /// </summary>
        /// <returns>实体描述字典</returns>
        public static Dictionary<string, string> EntityDesc
        {
            get
            {
                if (_entityDesc == null)
                {
                    _entityDesc = new Dictionary<string, string>();
                    _entityDesc.Add("ZYID", @"????ID????");
                    _entityDesc.Add("DYID", @"GUID?32??????");
                    _entityDesc.Add("DYBB", @"??????0-99999999");
                    _entityDesc.Add("QSHDID", @"??ID");
                    _entityDesc.Add("ZZHDID", @"??ID");
                    _entityDesc.Add("TJJBID", @"??????ID");
                    _entityDesc.Add("ZYLX", @"?????0-?????????1-????????????");
                    _entityDesc.Add("TJLX", @"??????,0??1?????2????");
                    _entityDesc.Add("ZYMC", @"????");
                }
                return _entityDesc;
            }
        }

#endif

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_GZLZY()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_GZLZY(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_GZLZY(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_GZLZY(SerializationInfo info, StreamingContext context)
            : base(info, context)
		{
		}

        /// <summary>
        /// 初始化类型
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        /// <param name="fields">字段集合</param>
        protected void InitClassEmpty(IValidatorChange validatorChange, IEntityFields2 fields)
        {
            OnInitializing();
            base.Fields = fields;
            base.Fields.SumStrLength = 160;
            base.IsNew = true;
            base.ValidatorChange = validatorChange;
            InitClassMembers();
            OnInitialized();
        }

        /// <summary>
        /// 初始化类型成员
        /// </summary>
        protected void InitClassMembers()
        {
            PerformDependencyInjection();
            OnInitClassMembersComplete();
        }

        #endregion

        #region 方法

        /// <summary>
        /// 获取实体数据库对应的索引
        /// </summary>
        /// <returns>索引集合</returns>
        public override List<int> GetEntityDbIndeies()
        {
            if (_entityDbIndeies == null)
            {
                _entityDbIndeies = new List<int>();
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.ZYID);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.DYID);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.DYBB);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.QSHDID);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.ZZHDID);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.TJJBID);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.ZYLX);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.TJLX);
                _entityDbIndeies.Add((int)VO_WF_GZLZYIndex.ZYMC);
            }
            return _entityDbIndeies;
        }
        
        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>字段集合接口</returns>
        protected override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(EntityName);
        }

        /// <summary>
        /// 创建类型默认值提供者
        /// 描述:当属性值为null返回默认值
        /// </summary>
        /// <returns>类型默认值提供者接口</returns>
        protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
        {
            return new TypeDefaultValue();
        }

        /// <summary>
        /// 创建实体工厂
        /// </summary>
        /// <returns>实体工厂接口</returns>
        protected override IEntityFactory2 CreateEntityFactory()
        {
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_GZLZYEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// ????ID????
        /// </summary>
        public Decimal ZYID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLZYIndex.ZYID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.ZYID, value);
            }
        }

        /// <summary>
        /// GUID?32??????
        /// </summary>
        public String DYID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLZYIndex.DYID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.DYID, value);
            }
        }

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        public Decimal DYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLZYIndex.DYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.DYBB, value);
            }
        }

        /// <summary>
        /// ??ID
        /// </summary>
        public Decimal QSHDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLZYIndex.QSHDID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.QSHDID, value);
            }
        }

        /// <summary>
        /// ??ID
        /// </summary>
        public Decimal ZZHDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLZYIndex.ZZHDID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.ZZHDID, value);
            }
        }

        /// <summary>
        /// ??????ID
        /// </summary>
        public String TJJBID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLZYIndex.TJJBID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.TJJBID, value);
            }
        }

        /// <summary>
        /// ?????0-?????????1-????????????
        /// </summary>
        public Decimal ZYLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLZYIndex.ZYLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.ZYLX, value);
            }
        }

        /// <summary>
        /// ??????,0??1?????2????
        /// </summary>
        public Decimal TJLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLZYIndex.TJLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.TJLX, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public String ZYMC
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLZYIndex.ZYMC, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLZYIndex.ZYMC, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_GZLZYFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_GZLZYEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_GZLZYEntityFactory()
            : base(VO_WF_GZLZY.EntityName)
        {
        }

        #endregion

        #region 方法

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <returns>实体接口</returns>
        public override IEntity2 Create()
        {
            IEntity2 toReturn = new VO_WF_GZLZY();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_GZLZY(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_GZLZY.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_GZLZY>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_GZLZY的字段集合类
    /// </summary>
    public partial class VO_WF_GZLZYFields
    {

        /// <summary>
        /// 创建ZYID字段的实例
        /// ????ID????
        /// </summary>
        public static EntityField2 ZYID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.ZYID);
            }
        }

        /// <summary>
        /// 创建DYID字段的实例
        /// GUID?32??????
        /// </summary>
        public static EntityField2 DYID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.DYID);
            }
        }

        /// <summary>
        /// 创建DYBB字段的实例
        /// ??????0-99999999
        /// </summary>
        public static EntityField2 DYBB
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.DYBB);
            }
        }

        /// <summary>
        /// 创建QSHDID字段的实例
        /// ??ID
        /// </summary>
        public static EntityField2 QSHDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.QSHDID);
            }
        }

        /// <summary>
        /// 创建ZZHDID字段的实例
        /// ??ID
        /// </summary>
        public static EntityField2 ZZHDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.ZZHDID);
            }
        }

        /// <summary>
        /// 创建TJJBID字段的实例
        /// ??????ID
        /// </summary>
        public static EntityField2 TJJBID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.TJJBID);
            }
        }

        /// <summary>
        /// 创建ZYLX字段的实例
        /// ?????0-?????????1-????????????
        /// </summary>
        public static EntityField2 ZYLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.ZYLX);
            }
        }

        /// <summary>
        /// 创建TJLX字段的实例
        /// ??????,0??1?????2????
        /// </summary>
        public static EntityField2 TJLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.TJLX);
            }
        }

        /// <summary>
        /// 创建ZYMC字段的实例
        /// ????
        /// </summary>
        public static EntityField2 ZYMC
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLZYIndex.ZYMC);
            }
        }

    }

    #endregion

    #region 实体字段工厂

    /// <summary>
    /// 实体字段工厂
    /// </summary>
    public partial class EntityFieldFactory
    {
        /// <summary>
        /// 创建实体字段
        /// </summary>
        /// <param name="fieldIndex">字段索引</param>
        /// <returns>实体字段</returns>
        public static EntityField2 Create(VO_WF_GZLZYIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_GZLZY.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_GZLZY的字段索引
    /// </summary>
    public enum VO_WF_GZLZYIndex : int
    {

        /// <summary>
        /// ????ID????
        /// </summary>
        ZYID, 

        /// <summary>
        /// GUID?32??????
        /// </summary>
        DYID, 

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        DYBB, 

        /// <summary>
        /// ??ID
        /// </summary>
        QSHDID, 

        /// <summary>
        /// ??ID
        /// </summary>
        ZZHDID, 

        /// <summary>
        /// ??????ID
        /// </summary>
        TJJBID, 

        /// <summary>
        /// ?????0-?????????1-????????????
        /// </summary>
        ZYLX, 

        /// <summary>
        /// ??????,0??1?????2????
        /// </summary>
        TJLX, 

        /// <summary>
        /// ????
        /// </summary>
        ZYMC, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}