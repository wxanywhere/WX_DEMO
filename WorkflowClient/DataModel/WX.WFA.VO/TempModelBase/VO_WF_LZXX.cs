﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace WX.WFA.VO
{
    #region 实体

    /// <summary>
    /// ??????
    /// </summary>
    [Serializable]
    public partial class VO_WF_LZXX : CommonEntityBase
    {
        #region 类型成员申明

        /// <summary>
        /// 实体名称
        /// </summary>
        public const System.String EntityName = "VO_WF_LZXX";

        /// <summary>
        /// 实体数据库对应的索引
        /// </summary>
        private static List<int> _entityDbIndeies = null;

        #endregion

        #region 静态构造函数

        /// <summary>
        /// 静态构造函数 只初始化一次的数据
        /// </summary>
        static VO_WF_LZXX()
        {
            FieldInfoProviderCore fieldInfoProvider = FieldInfoProviderSingleton.GetInstance();
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SLGUID", typeof(String), true, false, (int)VO_WF_LZXXIndex.SLGUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HDID", typeof(Decimal), true, false, (int)VO_WF_LZXXIndex.HDID, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "YWLSH", typeof(Decimal), true, false, (int)VO_WF_LZXXIndex.YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZYID", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.ZYID, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QXHDID", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.QXHDID, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "QX_YWLSH", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.QX_YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HXHDID", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.HXHDID, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "HX_YWLSH", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.HX_YWLSH, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZYZT", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.ZYZT, 5, 0, 4);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "ZLC_GUID", typeof(String), false, false, (int)VO_WF_LZXXIndex.ZLC_GUID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JRRQ", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.JRRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JRSJ", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.JRSJ, 7, 0, 6);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JBID", typeof(String), false, false, (int)VO_WF_LZXXIndex.JBID, 40, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "LZSXW", typeof(String), false, false, (int)VO_WF_LZXXIndex.LZSXW, 256, 0, 0);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "LCRQ", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.LCRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "LCSJ", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.LCSJ, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JZRQ", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.JZRQ, 9, 0, 8);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "JZSJ", typeof(Decimal), false, false, (int)VO_WF_LZXXIndex.JZSJ, 10, 0, 9);
            fieldInfoProvider.AddElementFieldInfo(EntityName, "SXWID", typeof(String), false, false, (int)VO_WF_LZXXIndex.SXWID, 40, 0, 0);
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
                    _entityDesc.Add("SLGUID", @"????GUID");
                    _entityDesc.Add("HDID", @"????????????");
                    _entityDesc.Add("YWLSH", @"?????");
                    _entityDesc.Add("ZYID", @"????ID");
                    _entityDesc.Add("QXHDID", @"??????");
                    _entityDesc.Add("QX_YWLSH", @"?????????");
                    _entityDesc.Add("HXHDID", @"??????");
                    _entityDesc.Add("HX_YWLSH", @"?????????");
                    _entityDesc.Add("ZYZT", @"????(0???? 1????? 2??? 3???? 4??)");
                    _entityDesc.Add("ZLC_GUID", @"?????ID");
                    _entityDesc.Add("JRRQ", @"??????");
                    _entityDesc.Add("JRSJ", @"??????");
                    _entityDesc.Add("JBID", @"??ID");
                    _entityDesc.Add("LZSXW", @"???????");
                    _entityDesc.Add("LCRQ", @"??????");
                    _entityDesc.Add("LCSJ", @"??????");
                    _entityDesc.Add("JZRQ", @"??????");
                    _entityDesc.Add("JZSJ", @"??????");
                    _entityDesc.Add("SXWID", @"????UID");
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
        public VO_WF_LZXX()
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">实体字段集合</param>
        public VO_WF_LZXX(IEntityFields2 fields)
            : base(EntityName)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="validatorChange">实体验证修改接口</param>
        public VO_WF_LZXX(IValidatorChange validatorChange)
            : base(EntityName)
        {
            InitClassEmpty(validatorChange, CreateFields());
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">要填充数据的</param>
        /// <param name="context">此序列化的目标</param>
        protected VO_WF_LZXX(SerializationInfo info, StreamingContext context)
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
            base.Fields.SumStrLength = 535;
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
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.SLGUID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.HDID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.YWLSH);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.ZYID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.QXHDID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.QX_YWLSH);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.HXHDID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.HX_YWLSH);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.ZYZT);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.ZLC_GUID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.JRRQ);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.JRSJ);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.JBID);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.LZSXW);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.LCRQ);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.LCSJ);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.JZRQ);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.JZSJ);
                _entityDbIndeies.Add((int)VO_WF_LZXXIndex.SXWID);
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
            return EntityFactoryCache2.GetEntityFactory(typeof(VO_WF_LZXXEntityFactory));
        }

        #endregion

        #region 类型数据申明

        /// <summary>
        /// ????GUID
        /// </summary>
        public String SLGUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_LZXXIndex.SLGUID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.SLGUID, value);
            }
        }

        /// <summary>
        /// ????????????
        /// </summary>
        public Decimal HDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.HDID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.HDID, value);
            }
        }

        /// <summary>
        /// ?????
        /// </summary>
        public Decimal YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.YWLSH, value);
            }
        }

        /// <summary>
        /// ????ID
        /// </summary>
        public Decimal ZYID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.ZYID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.ZYID, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal QXHDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.QXHDID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.QXHDID, value);
            }
        }

        /// <summary>
        /// ?????????
        /// </summary>
        public Decimal QX_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.QX_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.QX_YWLSH, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal HXHDID
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.HXHDID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.HXHDID, value);
            }
        }

        /// <summary>
        /// ?????????
        /// </summary>
        public Decimal HX_YWLSH
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.HX_YWLSH, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.HX_YWLSH, value);
            }
        }

        /// <summary>
        /// ????(0???? 1????? 2??? 3???? 4??)
        /// </summary>
        public Decimal ZYZT
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.ZYZT, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.ZYZT, value);
            }
        }

        /// <summary>
        /// ?????ID
        /// </summary>
        public String ZLC_GUID
        {
            get
            {
                return (String)GetValue((int)VO_WF_LZXXIndex.ZLC_GUID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.ZLC_GUID, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal JRRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.JRRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.JRRQ, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal JRSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.JRSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.JRSJ, value);
            }
        }

        /// <summary>
        /// ??ID
        /// </summary>
        public String JBID
        {
            get
            {
                return (String)GetValue((int)VO_WF_LZXXIndex.JBID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.JBID, value);
            }
        }

        /// <summary>
        /// ???????
        /// </summary>
        public String LZSXW
        {
            get
            {
                return (String)GetValue((int)VO_WF_LZXXIndex.LZSXW, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.LZSXW, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal LCRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.LCRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.LCRQ, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal LCSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.LCSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.LCSJ, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal JZRQ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.JZRQ, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.JZRQ, value);
            }
        }

        /// <summary>
        /// ??????
        /// </summary>
        public Decimal JZSJ
        {
            get
            {
                return (Decimal)GetValue((int)VO_WF_LZXXIndex.JZSJ, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.JZSJ, value);
            }
        }

        /// <summary>
        /// ????UID
        /// </summary>
        public String SXWID
        {
            get
            {
                return (String)GetValue((int)VO_WF_LZXXIndex.SXWID, true);
            }
            set
            {
                SetValue((int)VO_WF_LZXXIndex.SXWID, value);
            }
        }

        #endregion
    }

    #endregion

    #region 实体工厂

    /// <summary>
    /// 实体工厂VO_WF_LZXXFactory
    /// </summary>
    [Serializable]
    public partial class VO_WF_LZXXEntityFactory : EntityFactoryBase2
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public VO_WF_LZXXEntityFactory()
            : base(VO_WF_LZXX.EntityName)
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
            IEntity2 toReturn = new VO_WF_LZXX();

            return toReturn;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="fields">字段集合接口</param>
        /// <returns>实体接口</returns>
        public override IEntity2 Create(IEntityFields2 fields)
        {
            IEntity2 toReturn = new VO_WF_LZXX(fields);
            return toReturn;
        }

        /// <summary>
        /// 创建实体字段集合
        /// </summary>
        /// <returns>实体字段集合接口</returns>
        public override IEntityFields2 CreateFields()
        {
            return EntityFieldsFactory.CreateEntityFieldsObject(VO_WF_LZXX.EntityName);
        }

        /// <summary>
        /// 创建实体集合
        /// </summary>
        /// <returns>实体集合接口</returns>
        public override IEntityCollection2 CreateEntityCollection()
        {
            return new VOCollection<VO_WF_LZXX>(this);
        }

        #endregion
    }

    #endregion

    #region 实体字段

    /// <summary>
    /// VO_WF_LZXX的字段集合类
    /// </summary>
    public partial class VO_WF_LZXXFields
    {

        /// <summary>
        /// 创建SLGUID字段的实例
        /// ????GUID
        /// </summary>
        public static EntityField2 SLGUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.SLGUID);
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
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.HDID);
            }
        }

        /// <summary>
        /// 创建YWLSH字段的实例
        /// ?????
        /// </summary>
        public static EntityField2 YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.YWLSH);
            }
        }

        /// <summary>
        /// 创建ZYID字段的实例
        /// ????ID
        /// </summary>
        public static EntityField2 ZYID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.ZYID);
            }
        }

        /// <summary>
        /// 创建QXHDID字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 QXHDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.QXHDID);
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
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.QX_YWLSH);
            }
        }

        /// <summary>
        /// 创建HXHDID字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 HXHDID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.HXHDID);
            }
        }

        /// <summary>
        /// 创建HX_YWLSH字段的实例
        /// ?????????
        /// </summary>
        public static EntityField2 HX_YWLSH
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.HX_YWLSH);
            }
        }

        /// <summary>
        /// 创建ZYZT字段的实例
        /// ????(0???? 1????? 2??? 3???? 4??)
        /// </summary>
        public static EntityField2 ZYZT
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.ZYZT);
            }
        }

        /// <summary>
        /// 创建ZLC_GUID字段的实例
        /// ?????ID
        /// </summary>
        public static EntityField2 ZLC_GUID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.ZLC_GUID);
            }
        }

        /// <summary>
        /// 创建JRRQ字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 JRRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.JRRQ);
            }
        }

        /// <summary>
        /// 创建JRSJ字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 JRSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.JRSJ);
            }
        }

        /// <summary>
        /// 创建JBID字段的实例
        /// ??ID
        /// </summary>
        public static EntityField2 JBID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.JBID);
            }
        }

        /// <summary>
        /// 创建LZSXW字段的实例
        /// ???????
        /// </summary>
        public static EntityField2 LZSXW
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.LZSXW);
            }
        }

        /// <summary>
        /// 创建LCRQ字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 LCRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.LCRQ);
            }
        }

        /// <summary>
        /// 创建LCSJ字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 LCSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.LCSJ);
            }
        }

        /// <summary>
        /// 创建JZRQ字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 JZRQ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.JZRQ);
            }
        }

        /// <summary>
        /// 创建JZSJ字段的实例
        /// ??????
        /// </summary>
        public static EntityField2 JZSJ
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.JZSJ);
            }
        }

        /// <summary>
        /// 创建SXWID字段的实例
        /// ????UID
        /// </summary>
        public static EntityField2 SXWID
        {
            get
            {
                return EntityFieldFactory.Create(VO_WF_LZXXIndex.SXWID);
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
        public static EntityField2 Create(VO_WF_LZXXIndex fieldIndex)
        {
            return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(VO_WF_LZXX.EntityName, (int)fieldIndex));
        }
    }

    #endregion

    #region 实体索引

    /// <summary>
    /// VO_WF_LZXX的字段索引
    /// </summary>
    public enum VO_WF_LZXXIndex : int
    {

        /// <summary>
        /// ????GUID
        /// </summary>
        SLGUID, 

        /// <summary>
        /// ????????????
        /// </summary>
        HDID, 

        /// <summary>
        /// ?????
        /// </summary>
        YWLSH, 

        /// <summary>
        /// ????ID
        /// </summary>
        ZYID, 

        /// <summary>
        /// ??????
        /// </summary>
        QXHDID, 

        /// <summary>
        /// ?????????
        /// </summary>
        QX_YWLSH, 

        /// <summary>
        /// ??????
        /// </summary>
        HXHDID, 

        /// <summary>
        /// ?????????
        /// </summary>
        HX_YWLSH, 

        /// <summary>
        /// ????(0???? 1????? 2??? 3???? 4??)
        /// </summary>
        ZYZT, 

        /// <summary>
        /// ?????ID
        /// </summary>
        ZLC_GUID, 

        /// <summary>
        /// ??????
        /// </summary>
        JRRQ, 

        /// <summary>
        /// ??????
        /// </summary>
        JRSJ, 

        /// <summary>
        /// ??ID
        /// </summary>
        JBID, 

        /// <summary>
        /// ???????
        /// </summary>
        LZSXW, 

        /// <summary>
        /// ??????
        /// </summary>
        LCRQ, 

        /// <summary>
        /// ??????
        /// </summary>
        LCSJ, 

        /// <summary>
        /// ??????
        /// </summary>
        JZRQ, 

        /// <summary>
        /// ??????
        /// </summary>
        JZSJ, 

        /// <summary>
        /// ????UID
        /// </summary>
        SXWID, 

        //__YDTF_用户代码区域_开始_实体索引
        
        //__YDTF_用户代码区域_结束_实体索引
    }

    #endregion
}