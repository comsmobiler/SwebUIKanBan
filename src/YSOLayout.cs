using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class YSOLayout : Swebui.Controls.SwebUserControl
    {
        public YSOLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private string echart1Data_1 = "";
        private string echart1Data_2 = "";
        private string echart1Data_3 = "";
        private void YSOLayout_Load(object sender, EventArgs e)
        {
            #region" 折线图"      
            echart1Data_1 = GetRadomData();
            echart1Data_2 = GetRadomData();
            echart1Data_3 = GetRadomData();
            eCharts1.Option = @" {
    title: {
        text: '',
        textStyle:{
            color:'#ffffff'
                },
        left:50
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'cross'
        }
    },
    legend: {
  right:50,
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
                var len = 30;
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
            name: 'NOx',
            type: 'line',
            data: " + echart1Data_1 + @"
        },
         {
            name: '窖头粉尘',
            type: 'line',
            data: " + echart1Data_2 + @"
        },
         {
            name: '窖尾粉尘',
            type: 'line',
            data: " + echart1Data_3 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";

            #endregion

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
        text: '',
     textStyle:{
            color:'#ffffff'
        },left:50
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'cross'
        }
    },
    legend: {
    right:50,
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
            name: 'NOx',
            type: 'line',
            data:" + echart1Data_1 + @" 
        },
         {
            name: '窖头粉尘',
            type: 'line',
            data: " + echart1Data_2 + @" },
         {
            name: '窖尾粉尘',
            type: 'line',
            data: " + echart1Data_3 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";
            #endregion
            #region"更新界面参数"
            ysoLab1.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString();
            ysoLab2.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString();
            ysoLab3.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString(); 
            ysoLab9.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString();
            ysoLab10.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString();
            ysoLab4.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString();
            ysoLab5.Value = Convert.ToDouble((random.Next(0, 99999) * 0.01)).ToString();

            ysoLab7.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab8.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab11.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab12.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab19.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab20.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();

            ysoLab13.Value = Convert.ToDouble((random.Next(0, 999) * 0.01)).ToString();
            ysoLab12.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab19.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab20.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab16.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ysoLab21.Value = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
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
            for (int i = 0; i < 31; i++)
            {
                var a = random.Next(0, 30);
                if (i == 30)
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