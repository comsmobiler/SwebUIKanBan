using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class RMQLayout : Swebui.Controls.SwebUserControl
    {
        public RMQLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private string echart1Data_1 = "";
        private string echart1Data_2 = "";
        private string echart1Data_3 = "";
        private string echart2Data_1 = "";
        private string echart2Data_2 = "";
        private void RMQLayout_Load(object sender, EventArgs e)
        {
            echart1Data_1 = GetRadomData();
            echart1Data_2 = GetRadomData();
            echart1Data_3 = GetRadomData();
            echart2Data_1 = GetRadomData();
            echart2Data_2 = GetRadomData();
            //  eCharts1.Theme = eCharts2.Theme = EChartsTheme.Dark;
            //echart1
            eCharts1.Option = @" {
    title: {
        text: '三率值分析',
        textStyle:{
                    color:'#ffffff'
                }
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'cross',
            label: {
                backgroundColor: ['#1e74eb','#05eeff','#a778ff']
            }
        }
    },
    legend: {
        data:['KH','SM','IM'],
    right:10,
  textStyle:{
           color: '#87a7c4'
         } 
    },
    toolbox: {
        show: false,
        feature: {
            dataView: {readOnly: false},
            restore: {},
            saveAsImage: {}
        }
    },
    dataZoom: {
        show: false,
        start: 0,
        end: 100
    },
    xAxis: [
        {
            type: 'category',
            boundaryGap: true,
            data: (function (){
                var now = new Date();
                var res = [];
                var len = 10;
                while (len--) {
                    res.unshift(now.toLocaleTimeString().replace(/^\D*/,''));
                    now = new Date(now - 2000);
                }
                return res;
            })(),
    axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        }
        ],
    yAxis: [
        {
            type: 'value',
            scale: true,
            name: '',
            max: 30,
            min: 0,
            boundaryGap: [0.2, 0.2],
            axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        }  ],
    series: [
        {
            name: 'KH',
            type: 'line',
            data: " + echart1Data_1 + @"
        },
         {
            name: 'SM',
            type: 'line',
            data: " + echart1Data_2 + @"
        },
         {
            name: 'IM',
            type: 'line',
            data: " + echart1Data_3 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";

            //echart2
            eCharts2.Option = @" {
    title: {
        text: '生料粒度分析',
        textStyle:{
            color:'#ffffff'
            }
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'cross'
        }
    },
    legend: {
        data:['0.2mm','0.08mm'],
    right:10,
  textStyle:{
           color: '#87a7c4'
         } 
    },
    toolbox: {
        show: false,
        feature: {
            dataView: {readOnly: false},
            restore: {},
            saveAsImage: {}
        }
    },
    dataZoom: {
        show: false,
        start: 0,
        end: 100
    },
    xAxis: [
        {
            type: 'category',
            boundaryGap: true,
            data: (function (){
                var now = new Date();
                var res = [];
                var len = 10;
                while (len--) {
                    res.unshift(now.toLocaleTimeString().replace(/^\D*/,''));
                    now = new Date(now - 2000);
                }
                return res;
            })(),  axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        }],
    yAxis: [
        {
            type: 'value',
            scale: true,
            name: '',
            max: 30,
            min: 0,
            boundaryGap: [0.2, 0.2],
            axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        } ],
    series: [
        {
            name: '0.2mm',
            type: 'line',
            data: " + echart2Data_1 + @" },
         {
            name: '0.08mm',
            type: 'line',
            data: " + echart2Data_2 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region"echart update"
            echart1Data_1 = GetRadomData(echart1Data_1);
            echart1Data_2 = GetRadomData(echart1Data_2);
            echart1Data_3 = GetRadomData(echart1Data_3);
            eCharts1.Option = @" {
    title: {
        text: '动态数据',
        subtext: '纯属虚构',
     textStyle:{
            color:'#ffffff'
        }
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'cross',
            label: {
                backgroundColor: ['#1e74eb','#05eeff','#a778ff']
            }
        }
    },
    legend: {
        data:['KH','SM','IM'],
    right:10,
  textStyle:{
           color: '#87a7c4'
         } 
    },
    toolbox: {
        show: false,
        feature: {
            dataView: {readOnly: false},
            restore: {},
            saveAsImage: {}
        }
    },
    dataZoom: {
        show: false,
        start: 0,
        end: 100
    },
    xAxis: [
        {
            type: 'category',
            boundaryGap: true,
            data: (function (){
                var now = new Date();
                var res = [];
                var len = 10;
                while (len--) {
                    res.unshift(now.toLocaleTimeString().replace(/^\D*/,''));
                    now = new Date(now - 2000);
                }
                return res;
            })(),
    axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        }
        ],
    yAxis: [
        {
            type: 'value',
            scale: true,
            name: '',
            max: 30,
            min: 0,
            boundaryGap: [0.2, 0.2],    
            axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }  
        }],
    series: [
        {
            name: 'KH',
            type: 'line',
            data:" + echart1Data_1 + @" 
        },
         {
            name: 'SM',
            type: 'line',
            data: " + echart1Data_2 + @" },
         {
            name: 'IM',
            type: 'line',
            data: " + echart1Data_3 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";
            #endregion

            #region"echart2 update"

            echart2Data_1 = GetRadomData(echart2Data_1);
            echart2Data_2 = GetRadomData(echart2Data_2);
            eCharts2.Option = @" {
    title: {
        text: '生料粒度分析',
        textStyle:{
            color:'#ffffff'
        }
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'cross'
        }
    },
    legend: {
        data:['0.2mm','0.08mm'],
    right:10,
  textStyle:{
           color: '#87a7c4'
         } 
    },
    toolbox: {
        show: false,
        feature: {
            dataView: {readOnly: false},
            restore: {},
            saveAsImage: {}
        }
    },
    dataZoom: {
        show: false,
        start: 0,
        end: 100
    },
    xAxis: [
        {
            type: 'category',
            boundaryGap: true,
            data: (function (){
                var now = new Date();
                var res = [];
                var len = 10;
                while (len--) {
                    res.unshift(now.toLocaleTimeString().replace(/^\D*/,''));
                    now = new Date(now - 2000);
                }
                return res;
            })(),
    axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        }
        ],
    yAxis: [
        {
            type: 'value',
            scale: true,
            name: '',
            max: 30,
            min: 0,
            boundaryGap: [0.2, 0.2],
            axisLabel:{         
                textStyle: {
                    color: '#87a7c4'
                            }      
            }
        }],
    series: [
        {
            name: '0.2mm',
            type: 'line',
            data: " + echart2Data_1 + @"
        },
         {
            name: '0.08mm',
            type: 'line',
            data: " + echart2Data_2 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";
            #endregion
        }

        private Random random = new Random();

        private string GetRadomData(string str)
        {
            if (str.Contains("[") == true && str.Contains("]") == true)
            {
                int i = str.IndexOf(",");
                str = str.Remove(1, i);
                var a = random.Next(0, 30);
                str = str.Replace("]", "," + a.ToString() + "]");
            }
            return str;
        }
        private string GetRadomData()
        {
            string str = "[";
            for (int i = 0; i < 10; i++)
            {
                var a = random.Next(0, 30);
                if (i == 9)
                {
                    str += a.ToString() + "]";
                }
                else
                {
                    str += a.ToString() + ",";
                }
            }

            return str;
        }
    }
}