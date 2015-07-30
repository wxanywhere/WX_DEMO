using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.YXTJ
{
    public class VM_YXTJ : ViewModelBase
    {
        private const string _SerieName = "PieChart";
        private Chart _Chart = null;

        private WindowsFormsHost _D_Chart;
        public WindowsFormsHost D_Chart
        {
            get
            {
                if (_D_Chart == null)
                {
                    _D_Chart = new WindowsFormsHost();
                    _D_Chart.Child=CreatChart();
                    _Chart = (Chart)_D_Chart.Child;
                }

                return _D_Chart;
            }

        }

        private VO_WF_SLTJ_CX _D_QueryEntity;
        public VO_WF_SLTJ_CX D_QueryEntity
        {
            get
            {
                return _D_QueryEntity;
            }
            set
            {
                if (_D_QueryEntity != value)
                {
                    _D_QueryEntity = value;
                    OnPropertyChanged("D_QueryEntity");
                }
            }
        }

        private ICommand _CMD_YXTJ;
        public ICommand CMD_YXTJ
        {
            get
            {
                if (_CMD_YXTJ == null)
                {
                    _CMD_YXTJ = new RelayCommand(e =>
                    {
                        var asyncWorker = new BackgroundWorker();
                        asyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_GZLGL();
                            var vo = new VO_WF_SLTJ_CX();
                            args.Result = client.WFGL_SLTJ(vo);
                            //args.Result =new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR,VO_V_WF_SLYXXX[]>
                            //    (null,null,new VO_V_WF_SLYXXX[]{
                            //        new VO_V_WF_SLYXXX(){SLZT="开始",SLSL=100},
                            //        new VO_V_WF_SLYXXX(){SLZT="运行",SLSL=300},
                            //        new VO_V_WF_SLYXXX(){SLZT="挂起",SLSL=10},
                            //        new VO_V_WF_SLYXXX(){SLZT="结束",SLSL=800},
                            //        new VO_V_WF_SLYXXX(){SLZT="作废",SLSL=50}
                            //    });
                        };
                        asyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            try
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLTJ_CX[]>;
                                if (result.Item2 != null)
                                {
                                    MessageX.ShowError(result.Item2.TSXX);
                                }
                                else
                                {
                                  if (result.Item3 != null && result.Item3.Length>0)
                                  {
                                    var vos = new VO_V_WF_SLYXXX[]
                                    {
                                      new VO_V_WF_SLYXXX(){
                                        SLZT ="开始实例",
                                        SLSL = result.Item3[0].KSSL
                                      },
                                      new VO_V_WF_SLYXXX(){
                                        SLZT ="运行实例",
                                        SLSL = result.Item3[0].YXSL
                                      },
                                      new VO_V_WF_SLYXXX(){
                                        SLZT ="挂起实例",
                                        SLSL = result.Item3[0].GQSL
                                      },
                                      new VO_V_WF_SLYXXX(){
                                        SLZT ="结束实例",
                                        SLSL = result.Item3[0].JSSL
                                      },
                                      new VO_V_WF_SLYXXX(){
                                        SLZT ="作废实例",
                                        SLSL = result.Item3[0].ZFSL
                                      },
                                    };
                                    UpdateChart(vos);
                                  }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageX.ShowError(ex.Message);
                            }
                        };
                        asyncWorker.RunWorkerAsync();

                    });
                }

                return _CMD_YXTJ;
            }
        }

        private void UpdateChart(VO_V_WF_SLYXXX[] voes)
        {
            var totalNum = voes.Sum(a=>a.SLSL);
            var maxNum = voes.Max(a=>a.SLSL);
            _Chart.Legends[0].Title = String.Format("{0} - {1}","实例状态",totalNum);
            _Chart.Series.Clear();
            _Chart.Series.Add(_SerieName);
            _Chart.Series[_SerieName].YValueType = ChartValueType.Double;
            _Chart.Series[_SerieName].ChartType = SeriesChartType.Pie;

            for (var i = 0; i < voes.Length;i++ )
            {
                double ratio = (double)Decimal.Round((voes[i].SLSL / totalNum) * 100,2);
                _Chart.Series[_SerieName].Points.Add();
                _Chart.Series[_SerieName].Points[i].LegendText = String.Format("{0} - {1}", voes[i].SLZT,voes[i].SLSL);
                _Chart.Series[_SerieName].Points[i].YValues = new double[] { ratio };
                _Chart.Series[_SerieName].Points[i].AxisLabel = ratio + "%";
                _Chart.Series[_SerieName].Points[i].ToolTip = String.Format("{0} - {1}", voes[i].SLZT, voes[i].SLSL);
                if (voes[i].SLSL == maxNum)
                {
                    _Chart.Series[_SerieName].Points[i].CustomProperties = "Exploded=True";
                }
            }
        }

        private Chart CreatChart()
        {
            var chart = new Chart();
            chart.MouseClick += (o, e) =>
            {
                HitTestResult f = chart.HitTest(e.X, e.Y);
                int p = f.PointIndex;
                if (p > -1)
                {
                    string check = chart.Series[_SerieName].Points[p].CustomProperties;
                    if (check != ("Exploded=True"))
                    {
                        chart.Series[_SerieName].Points[p].CustomProperties = "Exploded=True";
                    }
                    else
                    {
                        chart.Series[_SerieName].Points[p].CustomProperties = "Exploded=none";
                    }

                }
            };
            var chartArea = new ChartArea();
            var legend = new Legend();
            chartArea.Area3DStyle.Enable3D = true;
            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(legend);
            chart.Palette = ChartColorPalette.Pastel;

            return chart;
        }

        public void Initialize()
        { 
            D_QueryEntity = new VO_WF_SLTJ_CX();
            D_Chart.UpdateLayout();
            CMD_YXTJ.Execute(null);
        }

        public override void InitializeSpecific()
        {
            Initialize();
        }

    }
}