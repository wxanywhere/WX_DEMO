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
    public partial class VO_WF_GZLBL : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_GZLBL";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_GZLBL()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "BLMC", typeof(String), true, false, (int)VO_WF_GZLBLIndex.BLMC, 200, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYID", typeof(String), true, false, (int)VO_WF_GZLBLIndex.DYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYBB", typeof(Decimal), true, false, (int)VO_WF_GZLBLIndex.DYBB, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ID", typeof(Decimal), false, false, (int)VO_WF_GZLBLIndex.ID, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "BLFW", typeof(Decimal), false, false, (int)VO_WF_GZLBLIndex.BLFW, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "BLLX", typeof(Decimal), false, false, (int)VO_WF_GZLBLIndex.BLLX, 3, 0, 2);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JBID", typeof(String), false, false, (int)VO_WF_GZLBLIndex.JBID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SMXX", typeof(String), false, false, (int)VO_WF_GZLBLIndex.SMXX, 512, 0, 0);
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
                    _entityDesc.Add("BLMC", @"????,??");
                    _entityDesc.Add("DYID", @"GUID?32??????");
                    _entityDesc.Add("DYBB", @"??????0-99999999");
                    _entityDesc.Add("ID", @"<?>");
                    _entityDesc.Add("BLFW", @"?????0-???? 1-???? 2-????");
                    _entityDesc.Add("BLLX", @"?????0-SQL???1-??????2-??");
                    _entityDesc.Add("JBID", @"?SQL???ID????");
                    _entityDesc.Add("SMXX", @"????");
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
        public VO_WF_GZLBL()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_GZLBL(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_GZLBL(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_GZLBL(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 816;
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
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.BLMC);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.DYID);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.DYBB);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.ID);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.BLFW);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.BLLX);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.JBID);
                _entityDbIndeies.Add((int)VO_WF_GZLBLIndex.SMXX);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_GZLBLEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// ????,??
        /// </summary>
        public String BLMC
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLBLIndex.BLMC, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.BLMC, value);
            }
        }

        /// <summary>
        /// GUID?32??????
        /// </summary>
        public String DYID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLBLIndex.DYID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.DYID, value);
            }
        }

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        public Decimal DYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLBLIndex.DYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.DYBB, value);
            }
        }

        /// <summary>
        /// <?>
        /// </summary>
        public Decimal ID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLBLIndex.ID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.ID, value);
            }
        }

        /// <summary>
        /// ?????0-???? 1-???? 2-????
        /// </summary>
        public Decimal BLFW
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLBLIndex.BLFW, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.BLFW, value);
            }
        }

        /// <summary>
        /// ?????0-SQL???1-??????2-??
        /// </summary>
        public Decimal BLLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLBLIndex.BLLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.BLLX, value);
            }
        }

        /// <summary>
        /// ?SQL???ID????
        /// </summary>
        public String JBID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLBLIndex.JBID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.JBID, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public String SMXX
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLBLIndex.SMXX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLBLIndex.SMXX, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_GZLBLFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_GZLBLEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_GZLBLEntityFactory()
            : base(VO_WF_GZLBL.EntityName)
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
            IEntity2 toReturn = new VO_WF_GZLBL();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_GZLBL(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_GZLBL.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_GZLBL>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_GZLBL的字段集合类
    /// </summary>
    public partial class VO_WF_GZLBLFields
    {

        /// <summary>
        /// 创建BLMC字段的实例
        /// ????,??
        /// </summary>
        public static EntityField2 BLMC
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.BLMC);
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
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.DYID);
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
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.DYBB);
            }
        }

        /// <summary>
        /// 创建ID字段的实例
        /// <?>
        /// </summary>
        public static EntityField2 ID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.ID);
            }
        }

        /// <summary>
        /// 创建BLFW字段的实例
        /// ?????0-???? 1-???? 2-????
        /// </summary>
        public static EntityField2 BLFW
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.BLFW);
            }
        }

        /// <summary>
        /// 创建BLLX字段的实例
        /// ?????0-SQL???1-??????2-??
        /// </summary>
        public static EntityField2 BLLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.BLLX);
            }
        }

        /// <summary>
        /// 创建JBID字段的实例
        /// ?SQL???ID????
        /// </summary>
        public static EntityField2 JBID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.JBID);
            }
        }

        /// <summary>
        /// 创建SMXX字段的实例
        /// ????
        /// </summary>
        public static EntityField2 SMXX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLBLIndex.SMXX);
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
        public static EntityField2 Create(VO_WF_GZLBLIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_GZLBL.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_GZLBL的字段索引
    /// </summary>
    public enum VO_WF_GZLBLIndex : int
    {

        /// <summary>
        /// ????,??
        /// </summary>
        BLMC, 

        /// <summary>
        /// GUID?32??????
        /// </summary>
        DYID, 

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        DYBB, 

        /// <summary>
        /// <?>
        /// </summary>
        ID, 

        /// <summary>
        /// ?????0-???? 1-???? 2-????
        /// </summary>
        BLFW, 

        /// <summary>
        /// ?????0-SQL???1-??????2-??
        /// </summary>
        BLLX, 

        /// <summary>
        /// ?SQL???ID????
        /// </summary>
        JBID, 

        /// <summary>
        /// ????
        /// </summary>
        SMXX, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}