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
    public partial class VO_WF_GZLDY : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_GZLDY";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_GZLDY()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYID", typeof(String), true, false, (int)VO_WF_GZLDYIndex.DYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYBB", typeof(Decimal), true, false, (int)VO_WF_GZLDYIndex.DYBB, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYMC", typeof(String), false, false, (int)VO_WF_GZLDYIndex.DYMC, 100, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYRQ", typeof(Decimal), false, false, (int)VO_WF_GZLDYIndex.DYRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYSJ", typeof(Decimal), false, false, (int)VO_WF_GZLDYIndex.DYSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYZT", typeof(Decimal), false, false, (int)VO_WF_GZLDYIndex.DYZT, 3, 0, 2);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYSM", typeof(String), false, false, (int)VO_WF_GZLDYIndex.DYSM, 200, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QYRQ", typeof(Decimal), false, false, (int)VO_WF_GZLDYIndex.QYRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QYSJ", typeof(Decimal), false, false, (int)VO_WF_GZLDYIndex.QYSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "NBCZYH", typeof(String), false, false, (int)VO_WF_GZLDYIndex.NBCZYH, 64, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "WBCZYH", typeof(String), false, false, (int)VO_WF_GZLDYIndex.WBCZYH, 64, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "PZID", typeof(String), false, false, (int)VO_WF_GZLDYIndex.PZID, 40, 0, 0);
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
                    _entityDesc.Add("DYMC", @"??????");
                    _entityDesc.Add("DYRQ", @"????");
                    _entityDesc.Add("DYSJ", @"????");
                    _entityDesc.Add("DYZT", @"?????0-??? 1-??? 2-??");
                    _entityDesc.Add("DYSM", @"????");
                    _entityDesc.Add("QYRQ", @"????");
                    _entityDesc.Add("QYSJ", @"????");
                    _entityDesc.Add("NBCZYH", @"??????");
                    _entityDesc.Add("WBCZYH", @"??????");
                    _entityDesc.Add("PZID", @"??GUID????");
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
        public VO_WF_GZLDY()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_GZLDY(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_GZLDY(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_GZLDY(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 552;
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
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYID);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYBB);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYMC);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYRQ);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYSJ);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYZT);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.DYSM);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.QYRQ);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.QYSJ);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.NBCZYH);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.WBCZYH);
                _entityDbIndeies.Add((int)VO_WF_GZLDYIndex.PZID);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_GZLDYEntityFactory));
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
                return (String)GetValue((int)VO_WF_GZLDYIndex.DYID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYID, value);
            }
        }

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        public Decimal DYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLDYIndex.DYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYBB, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public String DYMC
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLDYIndex.DYMC, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYMC, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal DYRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLDYIndex.DYRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYRQ, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal DYSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLDYIndex.DYSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYSJ, value);
            }
        }

        /// <summary>
        /// ?????0-??? 1-??? 2-??
        /// </summary>
        public Decimal DYZT
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLDYIndex.DYZT, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYZT, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public String DYSM
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLDYIndex.DYSM, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.DYSM, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal QYRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLDYIndex.QYRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.QYRQ, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal QYSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLDYIndex.QYSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.QYSJ, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public String NBCZYH
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLDYIndex.NBCZYH, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.NBCZYH, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public String WBCZYH
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLDYIndex.WBCZYH, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.WBCZYH, value);
            }
        }

        /// <summary>
        /// ??GUID????
        /// </summary>
        public String PZID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLDYIndex.PZID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLDYIndex.PZID, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_GZLDYFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_GZLDYEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_GZLDYEntityFactory()
            : base(VO_WF_GZLDY.EntityName)
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
            IEntity2 toReturn = new VO_WF_GZLDY();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_GZLDY(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_GZLDY.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_GZLDY>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_GZLDY的字段集合类
    /// </summary>
    public partial class VO_WF_GZLDYFields
    {

        /// <summary>
        /// 创建DYID字段的实例
        /// GUID?32??????
        /// </summary>
        public static EntityField2 DYID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYID);
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
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYBB);
            }
        }

        /// <summary>
        /// 创建DYMC字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 DYMC
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYMC);
            }
        }

        /// <summary>
        /// 创建DYRQ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 DYRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYRQ);
            }
        }

        /// <summary>
        /// 创建DYSJ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 DYSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYSJ);
            }
        }

        /// <summary>
        /// 创建DYZT字段的实例
        /// ?????0-??? 1-??? 2-??
        /// </summary>
        public static EntityField2 DYZT
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYZT);
            }
        }

        /// <summary>
        /// 创建DYSM字段的实例
        /// ????
        /// </summary>
        public static EntityField2 DYSM
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.DYSM);
            }
        }

        /// <summary>
        /// 创建QYRQ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 QYRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.QYRQ);
            }
        }

        /// <summary>
        /// 创建QYSJ字段的实例
        /// ????
        /// </summary>
        public static EntityField2 QYSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.QYSJ);
            }
        }

        /// <summary>
        /// 创建NBCZYH字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 NBCZYH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.NBCZYH);
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
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.WBCZYH);
            }
        }

        /// <summary>
        /// 创建PZID字段的实例
        /// ??GUID????
        /// </summary>
        public static EntityField2 PZID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLDYIndex.PZID);
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
        public static EntityField2 Create(VO_WF_GZLDYIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_GZLDY.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_GZLDY的字段索引
    /// </summary>
    public enum VO_WF_GZLDYIndex : int
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
        /// ??????
        /// </summary>
        DYMC, 

        /// <summary>
        /// ????
        /// </summary>
        DYRQ, 

        /// <summary>
        /// ????
        /// </summary>
        DYSJ, 

        /// <summary>
        /// ?????0-??? 1-??? 2-??
        /// </summary>
        DYZT, 

        /// <summary>
        /// ????
        /// </summary>
        DYSM, 

        /// <summary>
        /// ????
        /// </summary>
        QYRQ, 

        /// <summary>
        /// ????
        /// </summary>
        QYSJ, 

        /// <summary>
        /// ??????
        /// </summary>
        NBCZYH, 

        /// <summary>
        /// ??????
        /// </summary>
        WBCZYH, 

        /// <summary>
        /// ??GUID????
        /// </summary>
        PZID, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}