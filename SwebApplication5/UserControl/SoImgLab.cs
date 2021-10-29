using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class SoImgLab : Swebui.Controls.SwebUserControl
    {
        public SoImgLab() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public System.Drawing.Color LabBackColor
        {
            set => label1.BackColor = value;
            get => label1.BackColor;
        }
        public string LabText
        {
            set => label1.Text = value;
            get => label1.Text;
        }
        public float LabFontSize
        {
            set => label1.FontSize = value;
            get => label1.FontSize;
        }
        public System.Drawing.Color LabForeColor{
            set => label1.ForeColor = value;
            get => label1.ForeColor;
        
        }
    }
}