
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_CZYB : VOBase
      {
          private string _DQZTX = string.Empty;
          public string DQZTX
          {
              get
              {
                  return _DQZTX;
              }
              set
              {
                  if (_DQZTX!=value)
                  {
                      _DQZTX = value;
                      OnPropertyChanged("DQZTX");
                  }
              }
          }

          private DateTime _CJRQX;
          public DateTime CJRQX
          {
              get
              {
                  return _CJRQX;
              }
              set
              {
                  if (_CJRQX != value)
                  {
                      _CJRQX = value;
                      OnPropertyChanged("CJRQX");
                  }
              }
          }

          override public string this[string propertyName]
          {
              get
              {
                  string result = null;
                  if (this.IsEnableValidation)
                  {
                      if (propertyName == "CZYID")
                      {
                          if (string.IsNullOrWhiteSpace(CZYID))
                          {
                              result = "操作员ID不能为空！";
                          }
                          else if (!Regex.IsMatch(CZYID, "^[a-zA-Z0-9_]+$"))
                          {
                              result = "操作员ID只能由字母、数字或下划线组成！";
                          }
                          else if (CZYID.Length > this.GetFieldInfo(propertyName).MaxLength)
                          {
                              result = "操作员ID输入字符过长！";
                          }
                      }
                      if (propertyName == "MM")
                      {
                          if (string.IsNullOrWhiteSpace(MM))
                          {
                              result = "操作员密码不能为空！";
                          }
                          else if (MM.Length > this.GetFieldInfo(propertyName).MaxLength)
                          {
                              result = "操作员密码输入字符过长！";
                          }

                      }
                      if (propertyName == "XM")
                      {
                          if (string.IsNullOrWhiteSpace(XM))
                          {
                              result = "操作员姓名不能为空！";
                          }
                          else if (!Regex.IsMatch(XM, "^[a-zA-Z0-9_\u4e00-\u9fa5]+$"))
                          {
                              result = "操作员姓名只能由中文、字母、数字或下划线组成！";
                          }
                          else if (XM.Length > this.GetFieldInfo(propertyName).MaxLength)
                          {
                              result = "操作员姓名输入字符过长！";
                          }

                      }
                  }

                  this.UpdatreErrors(propertyName, result);
                  return result;
              }

          }
      }
  }