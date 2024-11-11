using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
  [System.ComponentModel.ToolboxItem(true)]
    partial class ImagePanel_V_C : Swebui.Controls.SwebUserControl
    {
        public ImagePanel_V_C() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string Text
        {
            set
            {
                label1.Text = value;
            }
            get
            {
                return label1.Text;
            }
        }
        public string SubText
        {
            set
            {
                label2.Text = value;
            }
            get
            {
                return label2.Text;
            }
        }
    }
}