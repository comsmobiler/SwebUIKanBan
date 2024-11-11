using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KanbanDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
 [System.ComponentModel.ToolboxItem(true)]
    partial class ObliqueLine : Swebui.Controls.SwebUserControl
    {
        public ObliqueLine() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private Point _Origin;

        public string LineDirection
        {
            set;
            get;
        } = "default";
        public int XOffset
        {
            set;
            get;
        } = 13;
        public int YOffset
        {
            set;
            get;
        } = 1;
        public System.Drawing.Color DotColor
        {
            set;
            get;
        } = System.Drawing.Color.FromArgb(60, 174, 251);
        public string AnimationName
        {
            set;
            get;
        }= "anDefault";
        private void ObliqueLine_Load(object sender, EventArgs e)
        {
            if (LineDirection == "default")
            {
                int i = 0;
                int j = 0;
                while (i <= Width && j <= Height)
                {
                    Label label = new Label() { Size = new System.Drawing.Size(3, 3), BackColor = DotColor};
                    label.Animation = AnimationName;
                    label.Location = new System.Drawing.Point(i, j);
                    this.Controls.Add(label);
                    i += XOffset;
                    j +=YOffset ;
                }

            }
            else
            {
                int i = Width;
                int j = 0;
                while (i>=0 && j <= Height)
                {
                    Label label = new Label() { Size = new System.Drawing.Size(3, 3), BackColor = DotColor };
                    label.Animation = AnimationName;
                    label.Location = new System.Drawing.Point(i, j);
                    this.Controls.Add(label);
                    i -= XOffset;
                    j += YOffset;
                }

            }
        }
    }
}
