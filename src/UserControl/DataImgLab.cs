﻿using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
   [System.ComponentModel.ToolboxItem(true)]
    partial class DataImgLab : Swebui.Controls.SwebUserControl
    {
        public DataImgLab() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public  string ParamName
        {
            set => label1.Text = value;
            get => label1.Text;
        }
        public string Data
        {
            set => label2.Text = value;
            get => label2.Text;
        }
        public string Unit
        {
            set => label3.Text = value;
            get => label3.Text;
        }
        public string Percent
        {
            set => label4.Text=value;
            get => label4.Text;
        }
    }
}