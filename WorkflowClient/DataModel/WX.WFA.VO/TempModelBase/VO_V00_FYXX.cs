using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// 分页信息(用于数据库查询)
    /// </summary>
    [Serializable]
    public partial class VO_V00_FYXX : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_V00_FYXX";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_V00_FYXX()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YMQISY", typeof(Decimal), false, false, (int)VO_V00_FYXXIndex.YMQISY, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "MYJLDX", typeof(Decimal), false, false, (int)VO_V00_FYXXIndex.MYJLDX, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SJJLTS", typeof(Decimal), false, false, (int)VO_V00_FYXXIndex.SJJLTS, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZYS", typeof(Decimal), false, false, (int)VO_V00_FYXXIndex.ZYS, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JLZS", typeof(Decimal), false, false, (int)VO_V00_FYXXIndex.JLZS, 7, 0, 6);
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
                    _entityDesc.Add("YMQISY", "页面起始索引（第几页）");
                    _entityDesc.Add("MYJLDX", "每页记录大小");
                    _entityDesc.Add("SJJLTS", "实际记录条数");
                    _entityDesc.Add("ZYS", "总页数");
                    _entityDesc.Add("JLZS", "记录总数");
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
        public VO_V00_FYXX()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_V00_FYXX(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_V00_FYXX(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_V00_FYXX(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 35;
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
                _entityDbIndeies.Add((int)VO_V00_FYXXIndex.YMQISY);
                _entityDbIndeies.Add((int)VO_V00_FYXXIndex.MYJLDX);
                _entityDbIndeies.Add((int)VO_V00_FYXXIndex.SJJLTS);
                _entityDbIndeies.Add((int)VO_V00_FYXXIndex.ZYS);
                _entityDbIndeies.Add((int)VO_V00_FYXXIndex.JLZS);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_V00_FYXXEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// 页面起始索引（第几页）
        /// </summary>
        public Decimal YMQISY
        {
            get
            {
                return (Decimal)GetValue((int)VO_V00_FYXXIndex.YMQISY, true);
            }
            set
            {
                SetValue((int)VO_V00_FYXXIndex.YMQISY, value);
            }
        }

        /// <summary>
        /// 每页记录大小
        /// </summary>
        public Decimal MYJLDX
        {
            get
            {
                return (Decimal)GetValue((int)VO_V00_FYXXIndex.MYJLDX, true);
            }
            set
            {
                SetValue((int)VO_V00_FYXXIndex.MYJLDX, value);
            }
        }

        /// <summary>
        /// 实际记录条数
        /// </summary>
        public Decimal SJJLTS
        {
            get
            {
                return (Decimal)GetValue((int)VO_V00_FYXXIndex.SJJLTS, true);
            }
            set
            {
                SetValue((int)VO_V00_FYXXIndex.SJJLTS, value);
            }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public Decimal ZYS
        {
            get
            {
                return (Decimal)GetValue((int)VO_V00_FYXXIndex.ZYS, true);
            }
            set
            {
                SetValue((int)VO_V00_FYXXIndex.ZYS, value);
            }
        }

        /// <summary>
        /// 记录总数
        /// </summary>
        public Decimal JLZS
        {
            get
            {
                return (Decimal)GetValue((int)VO_V00_FYXXIndex.JLZS, true);
            }
            set
            {
                SetValue((int)VO_V00_FYXXIndex.JLZS, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_V00_FYXXFactory
    /// </summary>
    [Serializable]
    public partial class VO_V00_FYXXEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_V00_FYXXEntityFactory()
            : base(VO_V00_FYXX.EntityName)
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
            IEntity2 toReturn = new VO_V00_FYXX();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_V00_FYXX(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_V00_FYXX.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_V00_FYXX>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_V00_FYXX的字段集合类
    /// </summary>
    public partial class VO_V00_FYXXFields
    {

        /// <summary>
        /// 创建YMQISY字段的实例
        /// 页面起始索引（第几页）
        /// </summary>
        public static EntityField2 YMQISY
        {
            get
            {
                return EntityFieldFactory.Create(VO_V00_FYXXIndex.YMQISY);
            }
        }

        /// <summary>
        /// 创建MYJLDX字段的实例
        /// 每页记录大小
        /// </summary>
        public static EntityField2 MYJLDX
        {
            get
            {
                return EntityFieldFactory.Create(VO_V00_FYXXIndex.MYJLDX);
            }
        }

        /// <summary>
        /// 创建SJJLTS字段的实例
        /// 实际记录条数
        /// </summary>
        public static EntityField2 SJJLTS
        {
            get
            {
                return EntityFieldFactory.Create(VO_V00_FYXXIndex.SJJLTS);
            }
        }

        /// <summary>
        /// 创建ZYS字段的实例
        /// 总页数
        /// </summary>
        public static EntityField2 ZYS
        {
            get
            {
                return EntityFieldFactory.Create(VO_V00_FYXXIndex.ZYS);
            }
        }

        /// <summary>
        /// 创建JLZS字段的实例
        /// 记录总数
        /// </summary>
        public static EntityField2 JLZS
        {
            get
            {
                return EntityFieldFactory.Create(VO_V00_FYXXIndex.JLZS);
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
        public static EntityField2 Create(VO_V00_FYXXIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_V00_FYXX.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_V00_FYXX的字段索引
    /// </summary>
    public enum VO_V00_FYXXIndex : int
    {

        /// <summary>
        /// 页面起始索引（第几页）
        /// </summary>
        YMQISY, 

        /// <summary>
        /// 每页记录大小
        /// </summary>
        MYJLDX, 

        /// <summary>
        /// 实际记录条数
        /// </summary>
        SJJLTS, 

        /// <summary>
        /// 总页数
        /// </summary>
        ZYS, 

        /// <summary>
        /// 记录总数
        /// </summary>
        JLZS, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}