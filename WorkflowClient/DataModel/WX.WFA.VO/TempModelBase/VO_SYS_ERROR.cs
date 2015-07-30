using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class VO_SYS_ERROR : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_SYS_ERROR";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_SYS_ERROR()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "TSXX", typeof(String), false, false, (int)VO_SYS_ERRORIndex.TSXX, 200, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JGBM", typeof(String), false, false, (int)VO_SYS_ERRORIndex.JGBM, 5, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QDRQ", typeof(Decimal), false, false, (int)VO_SYS_ERRORIndex.QDRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YWBH", typeof(String), false, false, (int)VO_SYS_ERRORIndex.YWBH, 8, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YHBH", typeof(String), true, false, (int)VO_SYS_ERRORIndex.YHBH, 10, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YCXM", typeof(String), false, false, (int)VO_SYS_ERRORIndex.YCXM, 50, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "CZYH", typeof(Decimal), false, false, (int)VO_SYS_ERRORIndex.CZYH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SQLCODE", typeof(Decimal), false, false, (int)VO_SYS_ERRORIndex.SQLCODE, 7, 0, 6);
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
                    _entityDesc.Add("TSXX", "提示信息(客户查看信息)");
                    _entityDesc.Add("JGBM", "机构编码");
                    _entityDesc.Add("QDRQ", "启动日期");
                    _entityDesc.Add("YWBH", "业务编号");
                    _entityDesc.Add("YHBH", "用户编号");
                    _entityDesc.Add("YCXM", "源程序名(文件名->行号)");
                    _entityDesc.Add("CZYH", "操作员号");
                    _entityDesc.Add("SQLCODE", "SQL返回码");
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
        public VO_SYS_ERROR()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_SYS_ERROR(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_SYS_ERROR(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_SYS_ERROR(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 296;
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
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.TSXX);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.JGBM);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.QDRQ);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.YWBH);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.YHBH);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.YCXM);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.CZYH);
                _entityDbIndeies.Add((int)VO_SYS_ERRORIndex.SQLCODE);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_SYS_ERROREntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// 提示信息(客户查看信息)
        /// </summary>
        public String TSXX
        {
            get
            {
                return (String)GetValue((int)VO_SYS_ERRORIndex.TSXX, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.TSXX, value);
            }
        }

        /// <summary>
        /// 机构编码
        /// </summary>
        public String JGBM
        {
            get
            {
                return (String)GetValue((int)VO_SYS_ERRORIndex.JGBM, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.JGBM, value);
            }
        }

        /// <summary>
        /// 启动日期
        /// </summary>
        public Decimal QDRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_SYS_ERRORIndex.QDRQ, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.QDRQ, value);
            }
        }

        /// <summary>
        /// 业务编号
        /// </summary>
        public String YWBH
        {
            get
            {
                return (String)GetValue((int)VO_SYS_ERRORIndex.YWBH, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.YWBH, value);
            }
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        public String YHBH
        {
            get
            {
                return (String)GetValue((int)VO_SYS_ERRORIndex.YHBH, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.YHBH, value);
            }
        }

        /// <summary>
        /// 源程序名(文件名->行号)
        /// </summary>
        public String YCXM
        {
            get
            {
                return (String)GetValue((int)VO_SYS_ERRORIndex.YCXM, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.YCXM, value);
            }
        }

        /// <summary>
        /// 操作员号
        /// </summary>
        public Decimal CZYH
        {
            get
            {
                return (Decimal)GetValue((int)VO_SYS_ERRORIndex.CZYH, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.CZYH, value);
            }
        }

        /// <summary>
        /// SQL返回码
        /// </summary>
        public Decimal SQLCODE
        {
            get
            {
                return (Decimal)GetValue((int)VO_SYS_ERRORIndex.SQLCODE, true);
            }
            set
            {
                SetValue((int)VO_SYS_ERRORIndex.SQLCODE, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_SYS_ERRORFactory
    /// </summary>
    [Serializable]
    public partial class VO_SYS_ERROREntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_SYS_ERROREntityFactory()
            : base(VO_SYS_ERROR.EntityName)
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
            IEntity2 toReturn = new VO_SYS_ERROR();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_SYS_ERROR(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_SYS_ERROR.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_SYS_ERROR>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_SYS_ERROR的字段集合类
    /// </summary>
    public partial class VO_SYS_ERRORFields
    {

        /// <summary>
        /// 创建TSXX字段的实例
        /// 提示信息(客户查看信息)
        /// </summary>
        public static EntityField2 TSXX
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.TSXX);
            }
        }

        /// <summary>
        /// 创建JGBM字段的实例
        /// 机构编码
        /// </summary>
        public static EntityField2 JGBM
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.JGBM);
            }
        }

        /// <summary>
        /// 创建QDRQ字段的实例
        /// 启动日期
        /// </summary>
        public static EntityField2 QDRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.QDRQ);
            }
        }

        /// <summary>
        /// 创建YWBH字段的实例
        /// 业务编号
        /// </summary>
        public static EntityField2 YWBH
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.YWBH);
            }
        }

        /// <summary>
        /// 创建YHBH字段的实例
        /// 用户编号
        /// </summary>
        public static EntityField2 YHBH
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.YHBH);
            }
        }

        /// <summary>
        /// 创建YCXM字段的实例
        /// 源程序名(文件名->行号)
        /// </summary>
        public static EntityField2 YCXM
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.YCXM);
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
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.CZYH);
            }
        }

        /// <summary>
        /// 创建SQLCODE字段的实例
        /// SQL返回码
        /// </summary>
        public static EntityField2 SQLCODE
        {
            get
            {
                return EntityFieldFactory.Create(VO_SYS_ERRORIndex.SQLCODE);
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
        public static EntityField2 Create(VO_SYS_ERRORIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_SYS_ERROR.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_SYS_ERROR的字段索引
    /// </summary>
    public enum VO_SYS_ERRORIndex : int
    {

        /// <summary>
        /// 提示信息(客户查看信息)
        /// </summary>
        TSXX, 

        /// <summary>
        /// 机构编码
        /// </summary>
        JGBM, 

        /// <summary>
        /// 启动日期
        /// </summary>
        QDRQ, 

        /// <summary>
        /// 业务编号
        /// </summary>
        YWBH, 

        /// <summary>
        /// 用户编号
        /// </summary>
        YHBH, 

        /// <summary>
        /// 源程序名(文件名->行号)
        /// </summary>
        YCXM, 

        /// <summary>
        /// 操作员号
        /// </summary>
        CZYH, 

        /// <summary>
        /// SQL返回码
        /// </summary>
        SQLCODE, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}