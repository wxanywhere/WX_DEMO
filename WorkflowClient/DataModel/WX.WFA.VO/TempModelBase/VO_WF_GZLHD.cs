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
    public partial class VO_WF_GZLHD : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_GZLHD";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_GZLHD()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDID", typeof(Decimal), true, false, (int)VO_WF_GZLHDIndex.HDID, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYID", typeof(String), true, false, (int)VO_WF_GZLHDIndex.DYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "DYBB", typeof(Decimal), true, false, (int)VO_WF_GZLHDIndex.DYBB, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDMC", typeof(String), false, false, (int)VO_WF_GZLHDIndex.HDMC, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDLX", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.HDLX, 3, 0, 2);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JRLX", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.JRLX, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "LZLX", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.LZLX, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "X", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.X, 10, 2, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "Y", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.Y, 10, 2, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JRJBID", typeof(String), false, false, (int)VO_WF_GZLHDIndex.JRJBID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "LZJBID", typeof(String), false, false, (int)VO_WF_GZLHDIndex.LZJBID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDSX", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.HDSX, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDGQ", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.HDGQ, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "CSTX", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.CSTX, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "GQLX", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.GQLX, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZLCDYID", typeof(String), false, false, (int)VO_WF_GZLHDIndex.ZLCDYID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZLCDYBB", typeof(Decimal), false, false, (int)VO_WF_GZLHDIndex.ZLCDYBB, 9, 0, 8);
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
                    _entityDesc.Add("HDID", @"??ID,??");
                    _entityDesc.Add("DYID", @"GUID?32??????");
                    _entityDesc.Add("DYBB", @"??????0-99999999");
                    _entityDesc.Add("HDMC", @"????");
                    _entityDesc.Add("HDLX", @"?????0-?? 1-?? 2-???? 3-???? 4-???? 5-???? 6-?????");
                    _entityDesc.Add("JRLX", @"?????0-??XOR?? 1-AND?? 2-??");
                    _entityDesc.Add("LZLX", @"?????0-XOR?? 1-AND?? 2-?? 3-??");
                    _entityDesc.Add("X", @"??????");
                    _entityDesc.Add("Y", @"????Y??");
                    _entityDesc.Add("JRJBID", @"????ID");
                    _entityDesc.Add("LZJBID", @"????ID");
                    _entityDesc.Add("HDSX", @"????");
                    _entityDesc.Add("HDGQ", @"????????????1?=24??");
                    _entityDesc.Add("CSTX", @"??????????????????HDGQ??0????");
                    _entityDesc.Add("GQLX", @"?????0-? 1-?? 2-??");
                    _entityDesc.Add("ZLCDYID", @"?????GUID????");
                    _entityDesc.Add("ZLCDYBB", @"???????????");
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
        public VO_WF_GZLHD()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_GZLHD(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_GZLHD(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_GZLHD(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 292;
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
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.HDID);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.DYID);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.DYBB);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.HDMC);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.HDLX);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.JRLX);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.LZLX);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.X);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.Y);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.JRJBID);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.LZJBID);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.HDSX);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.HDGQ);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.CSTX);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.GQLX);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.ZLCDYID);
                _entityDbIndeies.Add((int)VO_WF_GZLHDIndex.ZLCDYBB);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_GZLHDEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// ??ID,??
        /// </summary>
        public Decimal HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.HDID, value);
            }
        }

        /// <summary>
        /// GUID?32??????
        /// </summary>
        public String DYID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLHDIndex.DYID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.DYID, value);
            }
        }

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        public Decimal DYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.DYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.DYBB, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public String HDMC
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLHDIndex.HDMC, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.HDMC, value);
            }
        }

        /// <summary>
        /// ?????0-?? 1-?? 2-???? 3-???? 4-???? 5-???? 6-?????
        /// </summary>
        public Decimal HDLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.HDLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.HDLX, value);
            }
        }

        /// <summary>
        /// ?????0-??XOR?? 1-AND?? 2-??
        /// </summary>
        public Decimal JRLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.JRLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.JRLX, value);
            }
        }

        /// <summary>
        /// ?????0-XOR?? 1-AND?? 2-?? 3-??
        /// </summary>
        public Decimal LZLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.LZLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.LZLX, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal X
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.X, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.X, value);
            }
        }

        /// <summary>
        /// ????Y??
        /// </summary>
        public Decimal Y
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.Y, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.Y, value);
            }
        }

        /// <summary>
        /// ????ID
        /// </summary>
        public String JRJBID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLHDIndex.JRJBID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.JRJBID, value);
            }
        }

        /// <summary>
        /// ????ID
        /// </summary>
        public String LZJBID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLHDIndex.LZJBID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.LZJBID, value);
            }
        }

        /// <summary>
        /// ????
        /// </summary>
        public Decimal HDSX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.HDSX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.HDSX, value);
            }
        }

        /// <summary>
        /// ????????????1?=24??
        /// </summary>
        public Decimal HDGQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.HDGQ, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.HDGQ, value);
            }
        }

        /// <summary>
        /// ??????????????????HDGQ??0????
        /// </summary>
        public Decimal CSTX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.CSTX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.CSTX, value);
            }
        }

        /// <summary>
        /// ?????0-? 1-?? 2-??
        /// </summary>
        public Decimal GQLX
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.GQLX, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.GQLX, value);
            }
        }

        /// <summary>
        /// ?????GUID????
        /// </summary>
        public String ZLCDYID
        {
            get
            {
                return (String)GetValue((int)VO_WF_GZLHDIndex.ZLCDYID, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.ZLCDYID, value);
            }
        }

        /// <summary>
        /// ???????????
        /// </summary>
        public Decimal ZLCDYBB
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_GZLHDIndex.ZLCDYBB, true);
            }
            set
            {
                SetValue((int)VO_WF_GZLHDIndex.ZLCDYBB, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_GZLHDFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_GZLHDEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_GZLHDEntityFactory()
            : base(VO_WF_GZLHD.EntityName)
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
            IEntity2 toReturn = new VO_WF_GZLHD();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_GZLHD(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_GZLHD.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_GZLHD>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_GZLHD的字段集合类
    /// </summary>
    public partial class VO_WF_GZLHDFields
    {

        /// <summary>
        /// 创建HDID字段的实例
        /// ??ID,??
        /// </summary>
        public static EntityField2 HDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.HDID);
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
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.DYID);
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
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.DYBB);
            }
        }

        /// <summary>
        /// 创建HDMC字段的实例
        /// ????
        /// </summary>
        public static EntityField2 HDMC
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.HDMC);
            }
        }

        /// <summary>
        /// 创建HDLX字段的实例
        /// ?????0-?? 1-?? 2-???? 3-???? 4-???? 5-???? 6-?????
        /// </summary>
        public static EntityField2 HDLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.HDLX);
            }
        }

        /// <summary>
        /// 创建JRLX字段的实例
        /// ?????0-??XOR?? 1-AND?? 2-??
        /// </summary>
        public static EntityField2 JRLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.JRLX);
            }
        }

        /// <summary>
        /// 创建LZLX字段的实例
        /// ?????0-XOR?? 1-AND?? 2-?? 3-??
        /// </summary>
        public static EntityField2 LZLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.LZLX);
            }
        }

        /// <summary>
        /// 创建X字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 X
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.X);
            }
        }

        /// <summary>
        /// 创建Y字段的实例
        /// ????Y??
        /// </summary>
        public static EntityField2 Y
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.Y);
            }
        }

        /// <summary>
        /// 创建JRJBID字段的实例
        /// ????ID
        /// </summary>
        public static EntityField2 JRJBID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.JRJBID);
            }
        }

        /// <summary>
        /// 创建LZJBID字段的实例
        /// ????ID
        /// </summary>
        public static EntityField2 LZJBID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.LZJBID);
            }
        }

        /// <summary>
        /// 创建HDSX字段的实例
        /// ????
        /// </summary>
        public static EntityField2 HDSX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.HDSX);
            }
        }

        /// <summary>
        /// 创建HDGQ字段的实例
        /// ????????????1?=24??
        /// </summary>
        public static EntityField2 HDGQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.HDGQ);
            }
        }

        /// <summary>
        /// 创建CSTX字段的实例
        /// ??????????????????HDGQ??0????
        /// </summary>
        public static EntityField2 CSTX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.CSTX);
            }
        }

        /// <summary>
        /// 创建GQLX字段的实例
        /// ?????0-? 1-?? 2-??
        /// </summary>
        public static EntityField2 GQLX
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.GQLX);
            }
        }

        /// <summary>
        /// 创建ZLCDYID字段的实例
        /// ?????GUID????
        /// </summary>
        public static EntityField2 ZLCDYID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.ZLCDYID);
            }
        }

        /// <summary>
        /// 创建ZLCDYBB字段的实例
        /// ???????????
        /// </summary>
        public static EntityField2 ZLCDYBB
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_GZLHDIndex.ZLCDYBB);
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
        public static EntityField2 Create(VO_WF_GZLHDIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_GZLHD.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_GZLHD的字段索引
    /// </summary>
    public enum VO_WF_GZLHDIndex : int
    {

        /// <summary>
        /// ??ID,??
        /// </summary>
        HDID, 

        /// <summary>
        /// GUID?32??????
        /// </summary>
        DYID, 

        /// <summary>
        /// ??????0-99999999
        /// </summary>
        DYBB, 

        /// <summary>
        /// ????
        /// </summary>
        HDMC, 

        /// <summary>
        /// ?????0-?? 1-?? 2-???? 3-???? 4-???? 5-???? 6-?????
        /// </summary>
        HDLX, 

        /// <summary>
        /// ?????0-??XOR?? 1-AND?? 2-??
        /// </summary>
        JRLX, 

        /// <summary>
        /// ?????0-XOR?? 1-AND?? 2-?? 3-??
        /// </summary>
        LZLX, 

        /// <summary>
        /// ??????
        /// </summary>
        X, 

        /// <summary>
        /// ????Y??
        /// </summary>
        Y, 

        /// <summary>
        /// ????ID
        /// </summary>
        JRJBID, 

        /// <summary>
        /// ????ID
        /// </summary>
        LZJBID, 

        /// <summary>
        /// ????
        /// </summary>
        HDSX, 

        /// <summary>
        /// ????????????1?=24??
        /// </summary>
        HDGQ, 

        /// <summary>
        /// ??????????????????HDGQ??0????
        /// </summary>
        CSTX, 

        /// <summary>
        /// ?????0-? 1-?? 2-??
        /// </summary>
        GQLX, 

        /// <summary>
        /// ?????GUID????
        /// </summary>
        ZLCDYID, 

        /// <summary>
        /// ???????????
        /// </summary>
        ZLCDYBB, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}