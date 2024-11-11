using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class PCQCLayout : Swebui.Controls.SwebUserControl
    {
        public PCQCLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void PCQCLayout_Load(object sender, EventArgs e)
        {
            #region"echart"
            eCharts1.Option = @"{
    title: {
            text: '原煤成分分析',
            textStyle:{
                        color:'#ffffff'
                    }
    },
    legend: {
        data: ['原煤成分分析'],
        show:false
    },
    radar: {
        // shape: 'circle',
        indicator: [
              { name: 'Mar', max: 10000,color:'#ffffff'},
            { name: 'St', max: 10000,color:'#ffffff'},
            { name: 'Mad', max: 10000,color:'#ffffff'},
            { name: 'Aad', max: 30000,color:'#ffffff'},
            { name: 'vad）', max: 30000,color:'#ffffff'},
            { name: 'Qnet.ad', max: 30000,color:'#ffffff'},
            { name: 'Qnet.ar', max: 30000,color:'#ffffff'}
          
        ],
        axisLine:{
            lineStyle:{
                color:'#3088e4'
            }
        },
        splitLine:{
            lineStyle:{
                color:'#3088e4'
            }
        },
        splitArea:false
    },
    series: [{
        name: '预算 vs 开销（Budget vs spending）',
        type: 'radar',
        data: [
            {
                value: [4200, 3000, 5500, 5700, 24000, 12100],
                name: '预算分配（Allocated Budget）'
            }
        ],  
        areaStyle:{
          color:  '#17305f'
        },
        itemStyle:{
            color:'#1e73ea'
        }
    }]
}";
            #endregion        }
        }
    }
}