using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// ????????
    /// </summary>
    [Serializable]
    public partial class VO_WF_TJXX : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_TJXX";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_TJXX()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SLGUID", typeof(String), true, false, (int)VO_WF_TJXXIndex.SLGUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDID", typeof(Decimal), true, false, (int)VO_WF_TJXXIndex.HDID, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YWLSH", typeof(Decimal), true, false, (int)VO_WF_TJXXIndex.YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JSID", typeof(String), false, false, (int)VO_WF_TJXXIndex.JSID, 20, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JSRQ", typeof(Decimal), false, false, (int)VO_WF_TJXXIndex.JSRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JSSJ", typeof(Decimal), false, false, (int)VO_WF_TJXXIndex.JSSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "TJRQ", typeof(Decimal), false, false, (int)VO_WF_TJXXIndex.TJRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "TJSJ", typeof(Decimal), false, false, (int)VO_WF_TJXXIndex.TJSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "WBCZYH", typeof(String), false, false, (int)VO_WF_TJXXIndex.WBCZYH, 64, 0, 0);
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
                    _entityDesc.Add("SLGUID", @"GUID?32??????");
                    _entityDesc.Add("HDID", @"????????????");
                    _entityDesc.Add("YWLSH", @"???????");
                    _entityDesc.Add("JSID", @"????ID");
                    _entityDesc.Add("JSRQ", @"????");
                    _entityDesc.Add("JSSJ", @"????");
                    _entityDesc.Add("TJRQ", @"????");
                    _entityDesc.Add("TJSJ", @"????");
                    _entityDesc.Add("WBCZYH", @"??????");
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
        public VO_WF_TJXX()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_TJXX(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_TJXX(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_TJXX(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 173;
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
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.SLGUID);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.HDID);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.YWLSH);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.JSID);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.JSRQ);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.JSSJ);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.TJRQ);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.TJSJ);
                _entityDbIndeies.Add((int)VO_WF_TJXXIndex.WBCZYH);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_TJXXEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// GUID?32??????
        /// </summary>
        public String SLGUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_TJXXIndex.SLGUID, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.SLGUID, value);
            }
        }

        /// <summary>
        /// ????????????
        /// </summary>
        public Decimal HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_TJXXIndex.HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.HDID, value);
            }
        }

        /// <summary>
        /// ???????
        /// </summary>
        public Decimal YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_TJXXIndex.YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.YWLSH, value);
            }
        }

        /// <summary>
        /// ????ID
        /// </summary>
        public String JSID
        {
            get
            {
                return (String)GetValue((int)VO_WF_TJXXIndex.JSID, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.JSID, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal JSRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_TJXXIndex.JSRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.JSRQ, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal JSSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_TJXXIndex.JSSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.JSSJ, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal TJRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_TJXXIndex.TJRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.TJRQ, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal TJSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_TJXXIndex.TJSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.TJSJ, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public String WBCZYH
        {
            get
            {
                return (String)GetValue((int)VO_WF_TJXXIndex.WBCZYH, true);
            }
            set
            {
                SetValue((int)VO_WF_TJXXIndex.WBCZYH, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_TJXXFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_TJXXEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_TJXXEntityFactory()
            : base(VO_WF_TJXX.EntityName)
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
            IEntity2 toReturn = new VO_WF_TJXX();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_TJXX(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_TJXX.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_TJXX>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_TJXX的字段集合类
    /// </summary>
    public partial class VO_WF_TJXXFields
    {

        /// <summary>
        /// 创建SLGUID字段的实例
        /// GUID?32??????
        /// </summary>
        public static EntityField2 SLGUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.SLGUID);
            }
        }

        /// <summary>
        /// 创建HDID字段的实例
        /// ????????????
        /// </summary>
        public static EntityField2 HDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.HDID);
            }
        }

        /// <summary>
        /// 创建YWLSH字段的实例
        /// ???????
        /// </summary>
        public static EntityField2 YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.YWLSH);
            }
        }

        /// <summary>
        /// 创建JSID字段的实例
        /// ????ID
        /// </summary>
        public static EntityField2 JSID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.JSID);
            }
        }

        /// <summary>
        /// 创建JSRQ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 JSRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.JSRQ);
            }
        }

        /// <summary>
        /// 创建JSSJ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 JSSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.JSSJ);
            }
        }

        /// <summary>
        /// 创建TJRQ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 TJRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.TJRQ);
            }
        }

        /// <summary>
        /// 创建TJSJ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 TJSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.TJSJ);
            }
        }

        /// <summary>
        /// 创建WBCZYH字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 WBCZYH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_TJXXIndex.WBCZYH);
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
        public static EntityField2 Create(VO_WF_TJXXIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_TJXX.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_TJXX的字段索引
    /// </summary>
    public enum VO_WF_TJXXIndex : int
    {

        /// <summary>
        /// GUID?32??????
        /// </summary>
        SLGUID, 

        /// <summary>
        /// ????????????
        /// </summary>
        HDID, 

        /// <summary>
        /// ???????
        /// </summary>
        YWLSH, 

        /// <summary>
        /// ????ID
        /// </summary>
        JSID, 

        /// <summary>
        /// ????
        /// </summary>
        JSRQ, 

        /// <summary>
        /// ????
        /// </summary>
        JSSJ, 

        /// <summary>
        /// ????
        /// </summary>
        TJRQ, 

        /// <summary>
        /// ????
        /// </summary>
        TJSJ, 

        /// <summary>
        /// ??????
        /// </summary>
        WBCZYH, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}