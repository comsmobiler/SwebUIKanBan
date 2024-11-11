using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
  [System.ComponentModel.ToolboxItem(true)]
    partial class CQImgLab : Swebui.Controls.SwebUserControl
    {
        public CQImgLab() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string ImgResourceID
        {
            get => image1.ResourceID;
            set => image1.ResourceID = value;
        }
        public string Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
    }
}