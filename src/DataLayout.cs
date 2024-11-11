using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class DataLayout : Swebui.Controls.SwebUserControl
    {
        public DataLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private string echart1Data_1 = "";
        private string echart1Data_2 = "";
        private string echart1Data_3 = "";
        private void DataLayout_Load(object sender, EventArgs e)
        {
            #region"雷达图"
            eCharts2.Option = @" {
      legend: {
        orient: 'vertical',
        right: '0px',
        bottom: '60px',
        icon: 'circle',
        data: ['矿山', '生料', '煤磨', '烧成', '产量'] ,
        textStyle: {
          color: '#2968a3' ,
          rich: { 
            value: {
              fontSize: 13,
              color: '#99d1ff',
              padding:[0,10,0,0]
            },
            value1: {
              fontSize: 14,
              fontWeight: 'bolder',
              color: '#1db6f0',
                padding:[0,10,0,0]
          },
            unit: {
              fontSize: 13,
              color: '#99d1ff'
          },
        },
        },
        formatter: function (value) {
          return '{value|'+value+'}{value1|0.3}{unit|km/h}';
        },
      
      },
      radar: [
        {
          splitLine: {
            lineStyle: {
              color: '#000'
            }
          }
        },
        {
          indicator: [  //绘制总的图形
            { text: '矿山', max: 100 },
            { text: '产量', max: 100 },
            { text: '煤磨', max: 100 },
            { text: '烧成', max: 100 },
            { text: '产量', max: 100 },
          ],
          nameGap: 6,
          center: ['30%', '50%'],
          radius: 105,
          name: {
            textStyle: {
              color: '#2968a3',
              fontSize: 14,
              fontWeight: 400,
            }
          },
          splitArea: {
            areaStyle: {
              color: ['none',
                'none', 'none',
                'none', 'none'],
            }
          },
          axisLine: {
            lineStyle: {
              color: '#cde6f5'
            },
          },
          splitLine: {
            lineStyle: {
              color: '#cde6f5' //网格的颜色
            },
          }
        }
      ],
      series: [
        {
          type: 'radar', //绘制总的图形不设置拐点
          radarIndex: 1,
          data: [
            {
              value: [90, 80, 70, 60, 50, 40],
              symbolSize: 7,
              lineStyle: {
                width: 2,
                color: '#29B8FF'
              },
              areaStyle: {
                normal: {
                  opacity: 0.75,
                  color: '#f8f7f7'
                }
              }
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 0,
              color: '#000',
              // show:false
            }
          },
          silent: true,
          z: 1 //图层是一层一层叠加，所以这个也是一级一级递增
        },
        {
          type: 'radar', //绘制第一个点
          radarIndex: 1,
          name: '矿山',
          silent: true,
          z: 2, //图层是一层一层叠加，所以这个也是一级一级递增
          data: [
            {
              value: [90, '', '', '', '', ''],
              symbolSize: 7,
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 2,
              color: '#A66CFE'
            }
          },
          lineStyle: {
            width: 0,
            labelLine: {
              show: false   //隐藏标示线
            }
          }
        },
        {
          type: 'radar',
          radarIndex: 1, //绘制第二个点
          name: '生料',
          silent: true,
          z: 3, //图层是一层一层叠加，所以这个也是一级一级递增
          data: [
            {
              value:  ['', 80, '', '', '', ''],
              symbolSize: 7,
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 2,
              color: '#FFA662'
            }
          },
          lineStyle: {
            width: 0,
            labelLine: {
              show: false   //隐藏标示线
            }
          },

        },
        {
          type: 'radar', //绘制第三个点
          radarIndex: 1,
          name: '煤磨',
          silent: true,
          z: 4, //图层是一层一层叠加，所以这个也是一级一级递增
          data: [
            {
              value: ['', '', 70, '', '', ''],
              symbolSize: 7,
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 2,
              color: '#5AA4FB'
            }
          },
          lineStyle: {
            width: 0,
            labelLine: {
              show: false   //隐藏标示线
            }
          },

        },
        {
          type: 'radar', //绘制第四个点
          radarIndex: 1,
          name: '烧成',
          silent: true,
          z: 5, //图层是一层一层叠加，所以这个也是一级一级递增
          data: [
            {
              value: ['', '', '', 60, '', ''],
              symbolSize: 7,
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 2,
              color: '#FF858B'
            }
          },
          lineStyle: {
            width: 0,
            labelLine: {
              show: false   //隐藏标示线
            }
          },

        },
        {
          type: 'radar', //绘制第五个点
          radarIndex: 1,
          name: '产量',
          silent: true,
          z: 6, //图层是一层一层叠加，所以这个也是一级一级递增
          data: [
            {
              value: ['', '', '', '', 50, ''],
              symbolSize: 7,
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 2,
              color: '#7AF16F'
            }
          },
          lineStyle: {
            width: 0,
            labelLine: {
              show: false   //隐藏标示线
            }
          },

        },
        {
          type: 'radar', //这个图层是为了盖住圆心，如果去掉，圆心的颜色为最后一个图层的颜色
          radarIndex: 1,
          name: '',
          silent: true,
          z: 7, //图层是一层一层叠加，所以这个也是一级一级递增
          data: [
            {
              value: ['', '', '', '', '', ''],
              symbolSize: 7,
            }
          ],
          itemStyle: {
            normal: {
              borderWidth: 2,
              color: '#ffffff'
            }
          },
          lineStyle: {
            width: 0,
            labelLine: {
              show: false   //隐藏标示线
            }
          },

        }
      ]
    }";
            #endregion

            #region" 折线图"      
            echart1Data_1 = GetRadomData();
            echart1Data_2 = GetRadomData();
            echart1Data_3 = GetRadomData();
            eCharts3.Option = @" {
    title: {
        text: '生成浓度排放',
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
        data:['粉尘1','粉尘2','粉尘3'],
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
            name: '粉尘1',
            type: 'line',
            data: " + echart1Data_1 + @"
        },
         {
            name: '粉尘2',
            type: 'line',
            data: " + echart1Data_2 + @"
        },
         {
            name: '粉尘3',
            type: 'line',
            data: " + echart1Data_3 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";

            #endregion


            #region "pie"
            eCharts4.Option = @" {
  tooltip: {
    trigger: 'item'
  },
  legend: {
    show: true,
    orient: 'vertical',
    right:5,
    bottom:70,
    textStyle:{
      color:'#98badb',  fontSize:12,
    },
    data: [
      {
        name: '年度计划完成率',
        itemStyle: { color: '#3f79e8' }
      },
      {
        name: '月度计划完成率',
        itemStyle: { color: '#7bf6f6' }
      }
    ]
  },
  series: [
    {center:['20 % ','50 % '],
      name: '月度计划完成率',
      type: 'pie',
      radius: ['20%', '25%'],
      avoidLabelOverlap: false,
      label: {
        show: false,
        position: 'center'
      },
      emphasis: {
        label: {
          show: true,
          fontSize: '13',
          fontWeight: 'bold',
          formatter:function(value){
            return '108%';
          },
           color: '#7bf6f6'
        }
      },
      labelLine: {
        show: false
      },
      data: [
        {
          value: 108,
          name: '月度计划完成率 ',
          itemStyle: {
            color: '#7bf6f6'
          }
        }
      ]
    },
    {center:['20 % ','50 % '],
      name: '年度计划完成率',
      type: 'pie',
      radius: ['30%', '35%'],
      avoidLabelOverlap: false,
      label: {
        show: false,
        position: 'center'
      },
      emphasis: {
        label: {
          show: true,
          fontSize: '13',
          fontWeight: 'bold',
          formatter:function(value){
            return '1108%';
          },
          position:'outside',
          color:'#3f79e8'
        }
      },
      labelLine: {
        show: false
      },
      data: [
        {
          value: 1180,
          name: '年度计划完成率 ',
          itemStyle: { color: '#3f79e8' }
        }
      ]
    }
  ]
}";
             eCharts5.Option = @" {
  tooltip: {
    trigger: 'item'
  },
  legend: {
    show: true,
    orient: 'vertical',
    right:5,
    bottom:70,
    textStyle:{
      color:'#98badb',  fontSize:12,
    },
    data: [
      {
        name: '年度计划完成率',
        itemStyle: { color: '#3f79e8' }
      },
      {
        name: '月度计划完成率',
        itemStyle: { color: '#7bf6f6' }
      }
    ]
  },
  series: [
    {center:['20 % ','50 % '],
      name: '月度计划完成率',
      type: 'pie',
      radius: ['20%', '25%'],
      avoidLabelOverlap: false,
      label: {
        show: false,
        position: 'center'
      },
      emphasis: {
        label: {
          show: true,
          fontSize: '13',
          fontWeight: 'bold',
          formatter:function(value){
            return '86%';
          },
           color: '#7bf6f6'
        }
      },
      labelLine: {
        show: false
      },
      data: [
        {
          value: 86,
          name: '月度计划完成率 ',
          itemStyle: {
            color: '#7bf6f6'
          }
        },   
     {
          value: 14,
          name: ' ',
          itemStyle: {
            color: '#172c67'
          }
        }
      ]
    },
    {center:['20 % ','50 % '],
      name: '年度计划完成率',
      type: 'pie',
      radius: ['30%', '35%'],
      avoidLabelOverlap: false,
      label: {
        show: false,
        position: 'center'
      },
      emphasis: {
        label: {
          show: true,
          fontSize: '13',
          fontWeight: 'bold',
          formatter:function(value){
            return '819%';
          },
          position:'outside',
          color:'#3f79e8'
        }
      },
      labelLine: {
        show: false
      },
      data: [
        {
          value: 819,
          name: '年度计划完成率 ',
          itemStyle: { color: '#3f79e8' }
        }
      ]
    }
  ]
}";
            #endregion
            timer1.Start();
        }
        private Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region"echart update"
            echart1Data_1 = GetRadomData(echart1Data_1);
            echart1Data_2 = GetRadomData(echart1Data_2);
            echart1Data_3 = GetRadomData(echart1Data_3);
            eCharts3.Option = @" {
    title: {
        text: '生产排放浓度',
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
        data:['粉尘1','粉尘2','粉尘3'],
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
            name: '粉尘1',
            type: 'line',
            data:" + echart1Data_1 + @" 
        },
         {
            name: '粉尘2',
            type: 'line',
            data: " + echart1Data_2 + @" },
         {
            name: '粉尘3',
            type: 'line',
            data: " + echart1Data_3 + @"
        }
        
    ],
    color:['#1e74eb','#05eeff','#a778ff']
}";
            #endregion

            #region"更新界面参数"

            ///窖头颗粒物
            dataLabs2.Value1 = Convert.ToDouble((random.Next(0, 99)*0.01)).ToString();
            ///窖尾颗粒物
            dataLabs3.Value1 = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ///厂区颗粒物
            dataLabs1.Value1 = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            ///NOX
            dataLabs4.Value1 = Convert.ToDouble((random.Next(0, 999) * 0.01)).ToString();
            ///其他颗粒物
            dataLabs5.Value1 = Convert.ToDouble((random.Next(0, 99) * 0.01)).ToString();
            #endregion
        }
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

        private void dataLabGroup2_Load(object sender, EventArgs e)
        {

        }
    }
}
