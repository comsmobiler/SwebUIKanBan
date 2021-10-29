using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class DataLabs : Swebui.Controls.SwebUserControl
    {
        public DataLabs() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string LabName
        {
            set => nameLab.Text = value;
            get => nameLab.Text;
        }
        public string Value1
        {
            set => valueLab1.Text = value;
            get => valueLab1.Text;
        }
        public string Value2
        {
            set => valueLab2.Text=value;
            get => valueLab2.Text;
        }
    }
}