using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace YDTF.VO
{
    #region 实体

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class VO_SYS_HEAD : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_SYS_HEAD";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_SYS_HEAD()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "CZDM", typeof(Decimal), false, false, (int)VO_SYS_HEADIndex.CZDM, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "CZYH", typeof(Decimal), false, false, (int)VO_SYS_HEADIndex.CZYH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JGBM", typeof(String), false, false, (int)VO_SYS_HEADIndex.JGBM, 5, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "WKDZ", typeof(String), false, false, (int)VO_SYS_HEADIndex.WKDZ, 20, 0, 0);
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
                    _entityDesc.Add("CZDM", "操作代码：0");
                    _entityDesc.Add("CZYH", "操作员号");
                    _entityDesc.Add("JGBM", "见SYS");
                    _entityDesc.Add("WKDZ", "网卡地址：终端网卡地址");
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
        public VO_SYS_HEAD()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_SYS_HEAD(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_SYS_HEAD(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_SYS_HEAD(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 37;
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
                _entityDbIndeies.Add((int)VO_SYS_HEADIndex.CZDM);
                _entityDbIndeies.Add((int)VO_SYS_HEADIndex.CZYH);
                _entityDbIndeies.Add((int)VO_SYS_HEADIndex.JGBM);
                _entityDbIndeies.Add((int)VO_SYS_HEADIndex.WKDZ);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_SYS_HEADEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// 操作代码：0
        /// </summary>
        public Decimal CZDM
        {
            get
            {
                return (Decimal)GetValue((int)VO_SYS_HEADIndex.CZDM, true);
            }
            set
            {
                SetValue((int)VO_SYS_HEADIndex.CZDM, value);
            }
        }

        /// <summary>
        /// 操作员号
        /// </summary>
        public Decimal CZYH
        {
            get
            {
                return (Decimal)GetValue((int)VO_SYS_HEADIndex.CZYH, true);
            }
            set
            {
                SetValue((int)VO_SYS_HEADIndex.CZYH, value);
            }
        }

        /// <summary>
        /// 见SYS
        /// </summary>
        public String JGBM
        {
            get
            {
                return (String)GetValue((int)VO_SYS_HEADIndex.JGBM, true);
            }
            set
            {
                SetValue((int)VO_SYS_HEADIndex.JGBM, value);
            }
        }

        /// <summary>
        /// 网卡地址：终端网卡地址
        /// </summary>
        public String WKDZ
        {
            get
            {
                return (String)GetValue((int)VO_SYS_HEADIndex.WKDZ, true);
            }
            set
            {
                SetValue((int)VO_SYS_HEADIndex.WKDZ, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_SYS_HEADFactory
    /// </summary>
    [Serializable]
    public partial class VO_SYS_HEADEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_SYS_HEADEntityFactory()
            : base(VO_SYS_HEAD.EntityName)
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
            IEntity2 toReturn = new VO_SYS_HEAD();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_SYS_HEAD(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_SYS_HEAD.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_SYS_HEAD>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_SYS_HEAD的字段集合类
    /// </summary>
    public partial class VO_SYS_HEADFields
    {

        /// <summary>
        /// 创建CZDM字段的实例
        /// 操作代码：0
        /// </summary>
        public static EntityField2 CZDM
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_HEADIndex.CZDM);
            }
        }

        /// <summary>
        /// 创建CZYH字段的实例
        /// 操作员号
        /// </summary>
        public static EntityField2 CZYH
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_HEADIndex.CZYH);
            }
        }

        /// <summary>
        /// 创建JGBM字段的实例
        /// 见SYS
        /// </summary>
        public static EntityField2 JGBM
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_HEADIndex.JGBM);
            }
        }

        /// <summary>
        /// 创建WKDZ字段的实例
        /// 网卡地址：终端网卡地址
        /// </summary>
        public static EntityField2 WKDZ
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_HEADIndex.WKDZ);
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
        public static EntityField2 Create(VO_SYS_HEADIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_SYS_HEAD.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_SYS_HEAD的字段索引
    /// </summary>
    public enum VO_SYS_HEADIndex : int
    {

        /// <summary>
        /// 操作代码：0
        /// </summary>
        CZDM, 

        /// <summary>
        /// 操作员号
        /// </summary>
        CZYH, 

        /// <summary>
        /// 见SYS
        /// </summary>
        JGBM, 

        /// <summary>
        /// 网卡地址：终端网卡地址
        /// </summary>
        WKDZ, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}