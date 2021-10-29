using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class YSOLab : Swebui.Controls.SwebUserControl
    {
        public YSOLab() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public  string Value
        {
            set => label1.Text = value;
            get => label1.Text;
        }
        public string Unit
        {
            set => label2.Text = value;
            get => label2.Text;
        }
    }
}