using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class DotLine : Swebui.Controls.SwebUserControl
    {
        public DotLine() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        public string AnimationType
        {
            set;
            get;
        } = "toDown";
        public string MoveDirection
        {
            set; get;
        } = "vertical";
        private System.Drawing.Color _dotColor = System.Drawing.Color.FromArgb(60, 174, 251);
        public System.Drawing.Color DotColor
        {
            set => _dotColor = value;
            get => _dotColor;
        }
        public bool HaveArrow
        {
            set; get;
        } = false;
        private void Line_V_Load(object sender, EventArgs e)
        {
            switch (MoveDirection)
            {
                case "vertical":
                    if (this.Height / 13 > 0)
                    {
                        int i = this.Height / 13;
                        int x = 0;
                        if (Width > 3)
                            x = Width / 2;
                        if (AnimationType == "toTop" && HaveArrow == true)//在线条第一个点处添加向上箭头
                        {
                            FontIcon fontIcon = new FontIcon() { ForeColor = _dotColor, Size = new System.Drawing.Size(3, 1), Location = new System.Drawing.Point(x, 0) };
                            fontIcon.ResourceID = "caret-up";
                            this.Controls.Add(fontIcon);
                        }
                        for (int temp = 0; temp < i; temp++)
                        {

                            Label label = new Label() { Size = new System.Drawing.Size(3, 3), BackColor = _dotColor };
                            label.Animation = AnimationType;
                            label.Location = new System.Drawing.Point(x, temp * 13);
                            this.Controls.Add(label);
                        }
                        if (AnimationType == "toDown" && HaveArrow == true)//在线条最末尾处添加向下箭头
                        {
                            FontIcon fontIcon = new FontIcon() { ForeColor = _dotColor, Size = new System.Drawing.Size(3, 1), Location = new System.Drawing.Point(x, i * 13) };
                            fontIcon.ResourceID = "caret-down";
                            this.Controls.Add(fontIcon);
                        }
                    }
                    break;
                case "horizontal":
                    if (this.Width / 13 > 0)
                    {
                        int i = this.Width / 13;
                        int y = 0;
                        if (Height > 3)
                            y = Height / 2;
                        if (AnimationType == "toLeft" && HaveArrow == true)//在线条开始处添加左箭头
                        {
                            FontIcon fontIcon = new FontIcon() { ForeColor = _dotColor, Size = new System.Drawing.Size(5,5), Location = new System.Drawing.Point(0, y) };
                            fontIcon.ResourceID = "caret-left";
                            this.Controls.Add(fontIcon);
                        }
                        for (int temp = 0; temp < i; temp++)
                        {
                            Label label = new Label() { Size = new System.Drawing.Size(3, 3), BackColor = _dotColor };
                            label.Animation = AnimationType;
                            label.Location = new System.Drawing.Point(temp * 13, y);
                            this.Controls.Add(label);
                        }
                        if (AnimationType == "toRight" && HaveArrow == true)//在线条末尾处添加右箭头
                        {
                            FontIcon fontIcon = new FontIcon() { ForeColor = _dotColor, Size = new System.Drawing.Size(5,5), Location = new System.Drawing.Point(this.Width-5, y) };
                            fontIcon.ResourceID = "caret-right";
                            this.Controls.Add(fontIcon);
                        }
                    }
                    break;
            }

        }
    }
}