using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// ?????????
    /// </summary>
    [Serializable]
    public partial class VO_WF_SLXX_LS : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_SLXX_LS";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_SLXX_LS()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYID", typeof(String), false, false, (int)VO_WF_SLXX_LSIndex.DYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYBB", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.DYBB, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SLZT", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.SLZT, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QDRQ", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.QDRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QDSJ", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.QDSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "FLC_GUID", typeof(String), false, false, (int)VO_WF_SLXX_LSIndex.FLC_GUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "FLC_HDID", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.FLC_HDID, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "FLC_YWLSH", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.FLC_YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "GLC_GUID", typeof(String), false, false, (int)VO_WF_SLXX_LSIndex.GLC_GUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "GLC_HDID", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.GLC_HDID, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "GLC_YWLSH", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.GLC_YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDID", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.HDID, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDLX", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.HDLX, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HD_YWLSH", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.HD_YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JRRQ", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.JRRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JRSJ", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.JRSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JZRQ", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.JZRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JZSJ", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.JZSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QXHDID", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.QXHDID, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QX_YWLSH", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.QX_YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SLGUID", typeof(String), true, false, (int)VO_WF_SLXX_LSIndex.SLGUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SLZID", typeof(String), false, false, (int)VO_WF_SLXX_LSIndex.SLZID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZLC_GUID", typeof(String), false, false, (int)VO_WF_SLXX_LSIndex.ZLC_GUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZLC_HDID", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.ZLC_HDID, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZLC_YWLSH", typeof(Decimal), false, false, (int)VO_WF_SLXX_LSIndex.ZLC_YWLSH, 7, 0, 6);
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
                    _entityDesc.Add("DYID", @"GUID?32??????");
                    _entityDesc.Add("DYBB", @"??????0-99999999");
                    _entityDesc.Add("SLZT", @"????(1???2??  3?? 4?? 5??)");
                    _entityDesc.Add("QDRQ", @"????");
                    _entityDesc.Add("QDSJ", @"????");
                    _entityDesc.Add("FLC_GUID", @"?????GUID");
                    _entityDesc.Add("FLC_HDID", @"?????????????????");
                    _entityDesc.Add("FLC_YWLSH", @"??????????");
                    _entityDesc.Add("GLC_GUID", @"?????GUID");
                    _entityDesc.Add("GLC_HDID", @"?????????????????");
                    _entityDesc.Add("GLC_YWLSH", @"??????????");
                    _entityDesc.Add("HDID", @"????ID");
                    _entityDesc.Add("HDLX", @"??????");
                    _entityDesc.Add("HD_YWLSH", @"?????????");
                    _entityDesc.Add("JRRQ", @"????????");
                    _entityDesc.Add("JRSJ", @"????????");
                    _entityDesc.Add("JZRQ", @"????????");
                    _entityDesc.Add("JZSJ", @"????????");
                    _entityDesc.Add("QXHDID", @"????ID");
                    _entityDesc.Add("QX_YWLSH", @"?????????");
                    _entityDesc.Add("SLGUID", @"??GUID");
                    _entityDesc.Add("SLZID", @"???ID");
                    _entityDesc.Add("ZLC_GUID", @"?????GUID");
                    _entityDesc.Add("ZLC_HDID", @"?????????????????");
                    _entityDesc.Add("ZLC_YWLSH", @"??????????");
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
        public VO_WF_SLXX_LS()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_SLXX_LS(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_SLXX_LS(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_SLXX_LS(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 388;
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
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.DYID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.DYBB);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.SLZT);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.QDRQ);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.QDSJ);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.FLC_GUID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.FLC_HDID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.FLC_YWLSH);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.GLC_GUID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.GLC_HDID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.GLC_YWLSH);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.HDID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.HDLX);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.HD_YWLSH);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.JRRQ);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.JRSJ);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.JZRQ);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.JZSJ);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.QXHDID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.QX_YWLSH);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.SLGUID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.SLZID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.ZLC_GUID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.ZLC_HDID);
                _entityDbIndeies.Add((int)VO_WF_SLXX_LSIndex.ZLC_YWLSH);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_SLXX_LSEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// GUID?32??????
        /// </summary>
        public String DYID
        {
            get
            {
                return (String)GetValue((int)VO_WF_SLXX_LSIndex.DYID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.DYID, value);
            }
        }

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        public Decimal DYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.DYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.DYBB, value);
            }
        }

        /// <summary>
        /// ????(1???2??  3?? 4?? 5??)
        /// </summary>
        public Decimal SLZT
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.SLZT, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.SLZT, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal QDRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.QDRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.QDRQ, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal QDSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.QDSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.QDSJ, value);
            }
        }

        /// <summary>
        /// ?????GUID
        /// </summary>
        public String FLC_GUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_SLXX_LSIndex.FLC_GUID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.FLC_GUID, value);
            }
        }

        /// <summary>
        /// ?????????????????
        /// </summary>
        public Decimal FLC_HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.FLC_HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.FLC_HDID, value);
            }
        }

        /// <summary>
        /// ??????????
        /// </summary>
        public Decimal FLC_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.FLC_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.FLC_YWLSH, value);
            }
        }

        /// <summary>
        /// ?????GUID
        /// </summary>
        public String GLC_GUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_SLXX_LSIndex.GLC_GUID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.GLC_GUID, value);
            }
        }

        /// <summary>
        /// ?????????????????
        /// </summary>
        public Decimal GLC_HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.GLC_HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.GLC_HDID, value);
            }
        }

        /// <summary>
        /// ??????????
        /// </summary>
        public Decimal GLC_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.GLC_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.GLC_YWLSH, value);
            }
        }

        /// <summary>
        /// ????ID
        /// </summary>
        public Decimal HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.HDID, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal HDLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.HDLX, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.HDLX, value);
            }
        }

        /// <summary>
        /// ?????????
        /// </summary>
        public Decimal HD_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.HD_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.HD_YWLSH, value);
            }
        }

        /// <summary>
        /// ????????
        /// </summary>
        public Decimal JRRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.JRRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.JRRQ, value);
            }
        }

        /// <summary>
        /// ????????
        /// </summary>
        public Decimal JRSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.JRSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.JRSJ, value);
            }
        }

        /// <summary>
        /// ????????
        /// </summary>
        public Decimal JZRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.JZRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.JZRQ, value);
            }
        }

        /// <summary>
        /// ????????
        /// </summary>
        public Decimal JZSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.JZSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.JZSJ, value);
            }
        }

        /// <summary>
        /// ????ID
        /// </summary>
        public Decimal QXHDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.QXHDID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.QXHDID, value);
            }
        }

        /// <summary>
        /// ?????????
        /// </summary>
        public Decimal QX_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.QX_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.QX_YWLSH, value);
            }
        }

        /// <summary>
        /// ??GUID
        /// </summary>
        public String SLGUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_SLXX_LSIndex.SLGUID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.SLGUID, value);
            }
        }

        /// <summary>
        /// ???ID
        /// </summary>
        public String SLZID
        {
            get
            {
                return (String)GetValue((int)VO_WF_SLXX_LSIndex.SLZID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.SLZID, value);
            }
        }

        /// <summary>
        /// ?????GUID
        /// </summary>
        public String ZLC_GUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_SLXX_LSIndex.ZLC_GUID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.ZLC_GUID, value);
            }
        }

        /// <summary>
        /// ?????????????????
        /// </summary>
        public Decimal ZLC_HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.ZLC_HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.ZLC_HDID, value);
            }
        }

        /// <summary>
        /// ??????????
        /// </summary>
        public Decimal ZLC_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_SLXX_LSIndex.ZLC_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_SLXX_LSIndex.ZLC_YWLSH, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_SLXX_LSFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_SLXX_LSEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_SLXX_LSEntityFactory()
            : base(VO_WF_SLXX_LS.EntityName)
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
            IEntity2 toReturn = new VO_WF_SLXX_LS();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_SLXX_LS(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_SLXX_LS.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_SLXX_LS>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_SLXX_LS的字段集合类
    /// </summary>
    public partial class VO_WF_SLXX_LSFields
    {

        /// <summary>
        /// 创建DYID字段的实例
        /// GUID?32??????
        /// </summary>
        public static EntityField2 DYID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.DYID);
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
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.DYBB);
            }
        }

        /// <summary>
        /// 创建SLZT字段的实例
        /// ????(1???2??  3?? 4?? 5??)
        /// </summary>
        public static EntityField2 SLZT
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.SLZT);
            }
        }

        /// <summary>
        /// 创建QDRQ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 QDRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.QDRQ);
            }
        }

        /// <summary>
        /// 创建QDSJ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 QDSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.QDSJ);
            }
        }

        /// <summary>
        /// 创建FLC_GUID字段的实例
        /// ?????GUID
        /// </summary>
        public static EntityField2 FLC_GUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.FLC_GUID);
            }
        }

        /// <summary>
        /// 创建FLC_HDID字段的实例
        /// ?????????????????
        /// </summary>
        public static EntityField2 FLC_HDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.FLC_HDID);
            }
        }

        /// <summary>
        /// 创建FLC_YWLSH字段的实例
        /// ??????????
        /// </summary>
        public static EntityField2 FLC_YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.FLC_YWLSH);
            }
        }

        /// <summary>
        /// 创建GLC_GUID字段的实例
        /// ?????GUID
        /// </summary>
        public static EntityField2 GLC_GUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.GLC_GUID);
            }
        }

        /// <summary>
        /// 创建GLC_HDID字段的实例
        /// ?????????????????
        /// </summary>
        public static EntityField2 GLC_HDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.GLC_HDID);
            }
        }

        /// <summary>
        /// 创建GLC_YWLSH字段的实例
        /// ??????????
        /// </summary>
        public static EntityField2 GLC_YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.GLC_YWLSH);
            }
        }

        /// <summary>
        /// 创建HDID字段的实例
        /// ????ID
        /// </summary>
        public static EntityField2 HDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.HDID);
            }
        }

        /// <summary>
        /// 创建HDLX字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 HDLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.HDLX);
            }
        }

        /// <summary>
        /// 创建HD_YWLSH字段的实例
        /// ?????????
        /// </summary>
        public static EntityField2 HD_YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.HD_YWLSH);
            }
        }

        /// <summary>
        /// 创建JRRQ字段的实例
        /// ????????
        /// </summary>
        public static EntityField2 JRRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.JRRQ);
            }
        }

        /// <summary>
        /// 创建JRSJ字段的实例
        /// ????????
        /// </summary>
        public static EntityField2 JRSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.JRSJ);
            }
        }

        /// <summary>
        /// 创建JZRQ字段的实例
        /// ????????
        /// </summary>
        public static EntityField2 JZRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.JZRQ);
            }
        }

        /// <summary>
        /// 创建JZSJ字段的实例
        /// ????????
        /// </summary>
        public static EntityField2 JZSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.JZSJ);
            }
        }

        /// <summary>
        /// 创建QXHDID字段的实例
        /// ????ID
        /// </summary>
        public static EntityField2 QXHDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.QXHDID);
            }
        }

        /// <summary>
        /// 创建QX_YWLSH字段的实例
        /// ?????????
        /// </summary>
        public static EntityField2 QX_YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.QX_YWLSH);
            }
        }

        /// <summary>
        /// 创建SLGUID字段的实例
        /// ??GUID
        /// </summary>
        public static EntityField2 SLGUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.SLGUID);
            }
        }

        /// <summary>
        /// 创建SLZID字段的实例
        /// ???ID
        /// </summary>
        public static EntityField2 SLZID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.SLZID);
            }
        }

        /// <summary>
        /// 创建ZLC_GUID字段的实例
        /// ?????GUID
        /// </summary>
        public static EntityField2 ZLC_GUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.ZLC_GUID);
            }
        }

        /// <summary>
        /// 创建ZLC_HDID字段的实例
        /// ?????????????????
        /// </summary>
        public static EntityField2 ZLC_HDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.ZLC_HDID);
            }
        }

        /// <summary>
        /// 创建ZLC_YWLSH字段的实例
        /// ??????????
        /// </summary>
        public static EntityField2 ZLC_YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_SLXX_LSIndex.ZLC_YWLSH);
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
        public static EntityField2 Create(VO_WF_SLXX_LSIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_SLXX_LS.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_SLXX_LS的字段索引
    /// </summary>
    public enum VO_WF_SLXX_LSIndex : int
    {

        /// <summary>
        /// GUID?32??????
        /// </summary>
        DYID, 

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        DYBB, 

        /// <summary>
        /// ????(1???2??  3?? 4?? 5??)
        /// </summary>
        SLZT, 

        /// <summary>
        /// ????
        /// </summary>
        QDRQ, 

        /// <summary>
        /// ????
        /// </summary>
        QDSJ, 

        /// <summary>
        /// ?????GUID
        /// </summary>
        FLC_GUID, 

        /// <summary>
        /// ?????????????????
        /// </summary>
        FLC_HDID, 

        /// <summary>
        /// ??????????
        /// </summary>
        FLC_YWLSH, 

        /// <summary>
        /// ?????GUID
        /// </summary>
        GLC_GUID, 

        /// <summary>
        /// ?????????????????
        /// </summary>
        GLC_HDID, 

        /// <summary>
        /// ??????????
        /// </summary>
        GLC_YWLSH, 

        /// <summary>
        /// ????ID
        /// </summary>
        HDID, 

        /// <summary>
        /// ??????
        /// </summary>
        HDLX, 

        /// <summary>
        /// ?????????
        /// </summary>
        HD_YWLSH, 

        /// <summary>
        /// ????????
        /// </summary>
        JRRQ, 

        /// <summary>
        /// ????????
        /// </summary>
        JRSJ, 

        /// <summary>
        /// ????????
        /// </summary>
        JZRQ, 

        /// <summary>
        /// ????????
        /// </summary>
        JZSJ, 

        /// <summary>
        /// ????ID
        /// </summary>
        QXHDID, 

        /// <summary>
        /// ?????????
        /// </summary>
        QX_YWLSH, 

        /// <summary>
        /// ??GUID
        /// </summary>
        SLGUID, 

        /// <summary>
        /// ???ID
        /// </summary>
        SLZID, 

        /// <summary>
        /// ?????GUID
        /// </summary>
        ZLC_GUID, 

        /// <summary>
        /// ?????????????????
        /// </summary>
        ZLC_HDID, 

        /// <summary>
        /// ??????????
        /// </summary>
        ZLC_YWLSH, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}