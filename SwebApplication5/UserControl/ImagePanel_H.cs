using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class ImagePanel_H : Swebui.Controls.SwebUserControl
    {
        public ImagePanel_H() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
       
        public string Text
        {
            set => label1.Text=value;
            get => label1.Text;
        }
        public string SubText
        {
            set => label2.Text = value;
            get => label2.Text;
        }
        public Swebui.Controls.Margin TextMargin
        {
            set => panel1.Margin = value;
            get => panel1.Margin;
        }
   
        public System.Drawing.Size LabSize {
            get => panel1.Size;
            set => panel1.Size = value;
        }
    }
}