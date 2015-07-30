using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// ???
    /// </summary>
    [Serializable]
    public partial class VO_WF_JB : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_JB";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_JB()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JBID", typeof(String), true, false, (int)VO_WF_JBIndex.JBID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYID", typeof(String), false, false, (int)VO_WF_JBIndex.DYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYBB", typeof(Decimal), false, false, (int)VO_WF_JBIndex.DYBB, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JBNR1", typeof(String), false, false, (int)VO_WF_JBIndex.JBNR1, 4000, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JBNR2", typeof(String), false, false, (int)VO_WF_JBIndex.JBNR2, 4000, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JBLX", typeof(Decimal), false, false, (int)VO_WF_JBIndex.JBLX, 5, 0, 4);
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
                    _entityDesc.Add("JBID", @"??UID??");
                    _entityDesc.Add("DYID", @"GUID?32??????");
                    _entityDesc.Add("DYBB", @"??????0-99999999");
                    _entityDesc.Add("JBNR1", @"????1");
                    _entityDesc.Add("JBNR2", @"????2");
                    _entityDesc.Add("JBLX", @"????");
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
        public VO_WF_JB()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_JB(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_JB(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_JB(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 8094;
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
                _entityDbIndeies.Add((int)VO_WF_JBIndex.JBID);
                _entityDbIndeies.Add((int)VO_WF_JBIndex.DYID);
                _entityDbIndeies.Add((int)VO_WF_JBIndex.DYBB);
                _entityDbIndeies.Add((int)VO_WF_JBIndex.JBNR1);
                _entityDbIndeies.Add((int)VO_WF_JBIndex.JBNR2);
                _entityDbIndeies.Add((int)VO_WF_JBIndex.JBLX);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_JBEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// ??UID??
        /// </summary>
        public String JBID
        {
            get
            {
                return (String)GetValue((int)VO_WF_JBIndex.JBID, true);
            }
            set
            {
                SetValue((int)VO_WF_JBIndex.JBID, value);
            }
        }

        /// <summary>
        /// GUID?32??????
        /// </summary>
        public String DYID
        {
            get
            {
                return (String)GetValue((int)VO_WF_JBIndex.DYID, true);
            }
            set
            {
                SetValue((int)VO_WF_JBIndex.DYID, value);
            }
        }

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        public Decimal DYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_JBIndex.DYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_JBIndex.DYBB, value);
            }
        }

        /// <summary>
        /// ????1
        /// </summary>
        public String JBNR1
        {
            get
            {
                return (String)GetValue((int)VO_WF_JBIndex.JBNR1, true);
            }
            set
            {
                SetValue((int)VO_WF_JBIndex.JBNR1, value);
            }
        }

        /// <summary>
        /// ????2
        /// </summary>
        public String JBNR2
        {
            get
            {
                return (String)GetValue((int)VO_WF_JBIndex.JBNR2, true);
            }
            set
            {
                SetValue((int)VO_WF_JBIndex.JBNR2, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal JBLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_JBIndex.JBLX, true);
            }
            set
            {
                SetValue((int)VO_WF_JBIndex.JBLX, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_JBFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_JBEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_JBEntityFactory()
            : base(VO_WF_JB.EntityName)
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
            IEntity2 toReturn = new VO_WF_JB();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_JB(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_JB.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_JB>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_JB的字段集合类
    /// </summary>
    public partial class VO_WF_JBFields
    {

        /// <summary>
        /// 创建JBID字段的实例
        /// ??UID??
        /// </summary>
        public static EntityField2 JBID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_JBIndex.JBID);
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
                return EntityFieldFactory.Create(VO_WF_JBIndex.DYID);
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
                return EntityFieldFactory.Create(VO_WF_JBIndex.DYBB);
            }
        }

        /// <summary>
        /// 创建JBNR1字段的实例
        /// ????1
        /// </summary>
        public static EntityField2 JBNR1
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_JBIndex.JBNR1);
            }
        }

        /// <summary>
        /// 创建JBNR2字段的实例
        /// ????2
        /// </summary>
        public static EntityField2 JBNR2
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_JBIndex.JBNR2);
            }
        }

        /// <summary>
        /// 创建JBLX字段的实例
        /// ????
        /// </summary>
        public static EntityField2 JBLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_JBIndex.JBLX);
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
        public static EntityField2 Create(VO_WF_JBIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_JB.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_JB的字段索引
    /// </summary>
    public enum VO_WF_JBIndex : int
    {

        /// <summary>
        /// ??UID??
        /// </summary>
        JBID, 

        /// <summary>
        /// GUID?32??????
        /// </summary>
        DYID, 

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        DYBB, 

        /// <summary>
        /// ????1
        /// </summary>
        JBNR1, 

        /// <summary>
        /// ????2
        /// </summary>
        JBNR2, 

        /// <summary>
        /// ????
        /// </summary>
        JBLX, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}