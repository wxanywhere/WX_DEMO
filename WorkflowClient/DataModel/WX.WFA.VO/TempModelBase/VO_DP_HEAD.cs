using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// 系统头包
    /// </summary>
    [Serializable]
    public partial class VO_DP_HEAD : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_DP_HEAD";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_DP_HEAD()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YHBH", typeof(String), false, false, (int)VO_DP_HEADIndex.YHBH, 38, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "GCID", typeof(String), false, false, (int)VO_DP_HEADIndex.GCID, 38, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "MKDZ", typeof(String), false, false, (int)VO_DP_HEADIndex.MKDZ, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DLRQ", typeof(Decimal), false, false, (int)VO_DP_HEADIndex.DLRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DLSJ", typeof(Decimal), false, false, (int)VO_DP_HEADIndex.DLSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "CZZT", typeof(Decimal), false, false, (int)VO_DP_HEADIndex.CZZT, 5, 0, 4);
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
                    _entityDesc.Add("YHBH", @"用户编号");
                    _entityDesc.Add("GCID", @"工程ID,采用UID32位");
                    _entityDesc.Add("MKDZ", @"MAC地址");
                    _entityDesc.Add("DLRQ", @"登录日期");
                    _entityDesc.Add("DLSJ", @"登录时间");
                    _entityDesc.Add("CZZT", @"操作状态");
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
        public VO_DP_HEAD()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_DP_HEAD(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_DP_HEAD(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_DP_HEAD(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 137;
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
                _entityDbIndeies.Add((int)VO_DP_HEADIndex.YHBH);
                _entityDbIndeies.Add((int)VO_DP_HEADIndex.GCID);
                _entityDbIndeies.Add((int)VO_DP_HEADIndex.MKDZ);
                _entityDbIndeies.Add((int)VO_DP_HEADIndex.DLRQ);
                _entityDbIndeies.Add((int)VO_DP_HEADIndex.DLSJ);
                _entityDbIndeies.Add((int)VO_DP_HEADIndex.CZZT);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_DP_HEADEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// 用户编号
        /// </summary>
        public String YHBH
        {
            get
            {
                return (String)GetValue((int)VO_DP_HEADIndex.YHBH, true);
            }
            set
            {
                SetValue((int)VO_DP_HEADIndex.YHBH, value);
            }
        }

        /// <summary>
        /// 工程ID,采用UID32位
        /// </summary>
        public String GCID
        {
            get
            {
                return (String)GetValue((int)VO_DP_HEADIndex.GCID, true);
            }
            set
            {
                SetValue((int)VO_DP_HEADIndex.GCID, value);
            }
        }

        /// <summary>
        /// MAC地址
        /// </summary>
        public String MKDZ
        {
            get
            {
                return (String)GetValue((int)VO_DP_HEADIndex.MKDZ, true);
            }
            set
            {
                SetValue((int)VO_DP_HEADIndex.MKDZ, value);
            }
        }

        /// <summary>
        /// 登录日期
        /// </summary>
        public Decimal DLRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_DP_HEADIndex.DLRQ, true);
            }
            set
            {
                SetValue((int)VO_DP_HEADIndex.DLRQ, value);
            }
        }

        /// <summary>
        /// 登录时间
        /// </summary>
        public Decimal DLSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_DP_HEADIndex.DLSJ, true);
            }
            set
            {
                SetValue((int)VO_DP_HEADIndex.DLSJ, value);
            }
        }

        /// <summary>
        /// 操作状态
        /// </summary>
        public Decimal CZZT
        {
            get
            {
                return (Decimal)GetValue((int)VO_DP_HEADIndex.CZZT, true);
            }
            set
            {
                SetValue((int)VO_DP_HEADIndex.CZZT, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_DP_HEADFactory
    /// </summary>
    [Serializable]
    public partial class VO_DP_HEADEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_DP_HEADEntityFactory()
            : base(VO_DP_HEAD.EntityName)
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
            IEntity2 toReturn = new VO_DP_HEAD();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_DP_HEAD(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_DP_HEAD.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_DP_HEAD>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_DP_HEAD的字段集合类
    /// </summary>
    public partial class VO_DP_HEADFields
    {

        /// <summary>
        /// 创建YHBH字段的实例
        /// 用户编号
        /// </summary>
        public static EntityField2 YHBH
        {
            get
            {
                return EntityFieldFactory.Create(VO_DP_HEADIndex.YHBH);
            }
        }

        /// <summary>
        /// 创建GCID字段的实例
        /// 工程ID,采用UID32位
        /// </summary>
        public static EntityField2 GCID
        {
            get
            {
                return EntityFieldFactory.Create(VO_DP_HEADIndex.GCID);
            }
        }

        /// <summary>
        /// 创建MKDZ字段的实例
        /// MAC地址
        /// </summary>
        public static EntityField2 MKDZ
        {
            get
            {
                return EntityFieldFactory.Create(VO_DP_HEADIndex.MKDZ);
            }
        }

        /// <summary>
        /// 创建DLRQ字段的实例
        /// 登录日期
        /// </summary>
        public static EntityField2 DLRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_DP_HEADIndex.DLRQ);
            }
        }

        /// <summary>
        /// 创建DLSJ字段的实例
        /// 登录时间
        /// </summary>
        public static EntityField2 DLSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_DP_HEADIndex.DLSJ);
            }
        }

        /// <summary>
        /// 创建CZZT字段的实例
        /// 操作状态
        /// </summary>
        public static EntityField2 CZZT
        {
            get
            {
                return EntityFieldFactory.Create(VO_DP_HEADIndex.CZZT);
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
        public static EntityField2 Create(VO_DP_HEADIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_DP_HEAD.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_DP_HEAD的字段索引
    /// </summary>
    public enum VO_DP_HEADIndex : int
    {

        /// <summary>
        /// 用户编号
        /// </summary>
        YHBH, 

        /// <summary>
        /// 工程ID,采用UID32位
        /// </summary>
        GCID, 

        /// <summary>
        /// MAC地址
        /// </summary>
        MKDZ, 

        /// <summary>
        /// 登录日期
        /// </summary>
        DLRQ, 

        /// <summary>
        /// 登录时间
        /// </summary>
        DLSJ, 

        /// <summary>
        /// 操作状态
        /// </summary>
        CZZT, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}