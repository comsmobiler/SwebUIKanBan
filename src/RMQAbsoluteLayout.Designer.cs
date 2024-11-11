using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class RMQAbsoluteLayout : Swebui.Controls.SwebUserControl
    {
        #region "SwebUserControl generated code "

        //SwebUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SwebUserControl
        //It can be modified using the SwebUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Swebui.Controls.Label();
            this.imagePanel_V3 = new KanbanDemo.ImagePanel_V();
            this.panel9 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.imagePanel_V1 = new KanbanDemo.ImagePanel_V();
            this.imagePanel_H1 = new KanbanDemo.ImagePanel_H();
            this.imagePanel_H2 = new KanbanDemo.ImagePanel_H();
            this.imagePanel_H3 = new KanbanDemo.ImagePanel_H();
            this.imagePanel_H4 = new KanbanDemo.ImagePanel_H();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.arrowBottom1 = new KanbanDemo.ArrowBottom();
            this.arrowBottom2 = new KanbanDemo.ArrowBottom();
            this.arrowBottom3 = new KanbanDemo.ArrowBottom();
            this.arrowBottom4 = new KanbanDemo.ArrowBottom();
            this.eCharts1 = new Swebui.Controls.ECharts();
            this.panel10 = new Swebui.Controls.Panel();
            this.arrowRight1 = new KanbanDemo.ArrowRight();
            this.imagePanel_V_C1 = new KanbanDemo.ImagePanel_V_C();
            this.arrowRight2 = new KanbanDemo.ArrowRight();
            this.imagePanel_V_C2 = new KanbanDemo.ImagePanel_V_C();
            this.eCharts2 = new Swebui.Controls.ECharts();
            this.panel11 = new Swebui.Controls.Panel();
            this.imagePanel_V2 = new KanbanDemo.ImagePanel_V();
            this.imagePanel_V4 = new KanbanDemo.ImagePanel_V();
            this.timer1 = new Swebui.Controls.Timer();
            this.line_V1 = new KanbanDemo.DotLine();
            this.dotLine1 = new KanbanDemo.DotLine();
            this.dotLine2 = new KanbanDemo.DotLine();
            this.dotLine3 = new KanbanDemo.DotLine();
            this.arrowBottom5 = new KanbanDemo.ArrowBottom();
            this.arrowBottom6 = new KanbanDemo.ArrowBottom();
            this.image1 = new Swebui.Controls.Image();
            this.image2 = new Swebui.Controls.Image();
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(4F, 0F, 0F, 0F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(231)))));
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 20F);
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(20F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(900, 24);
            this.label1.Text = "原料配料库";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // imagePanel_V3
            // 
            this.imagePanel_V3.BackgroundImage = "6.png";
            this.imagePanel_V3.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imagePanel_V3.FirstLabMargin = new Swebui.Controls.Margin(0F, 130F, 0F, 0F);
            this.imagePanel_V3.Location = new System.Drawing.Point(74, 234);
            this.imagePanel_V3.Margin = new Swebui.Controls.Margin(30F, 0F, 0F, 0F);
            this.imagePanel_V3.Name = "imagePanel_V3";
            this.imagePanel_V3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.imagePanel_V3.Padding = new Swebui.Controls.Padding(10F);
            this.imagePanel_V3.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.imagePanel_V3.Size = new System.Drawing.Size(125, 200);
            this.imagePanel_V3.SubText = "On-line analyzer";
            this.imagePanel_V3.Text = "原料成分在线分析仪";
            this.imagePanel_V3.ZIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.label7,
            this.label8,
            this.label9});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel9.Location = new System.Drawing.Point(264, 357);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(487, 60);
            this.panel9.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // label2
            // 
            this.label2.FontSize = 18F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(117)))), ((int)(((byte)(174)))));
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "石灰石";
            // 
            // label3
            // 
            this.label3.FontSize = 18F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(200)))));
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "硅质材料";
            // 
            // label4
            // 
            this.label4.FontSize = 18F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "铝制材料";
            // 
            // label5
            // 
            this.label5.FontSize = 18F;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "铁制材料";
            // 
            // label6
            // 
            this.label6.FontSize = 16F;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "98.3%";
            // 
            // label7
            // 
            this.label7.FontSize = 16F;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "0.1%";
            // 
            // label8
            // 
            this.label8.FontSize = 16F;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "0.3%";
            // 
            // label9
            // 
            this.label9.FontSize = 16F;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "0.5%";
            // 
            // imagePanel_V1
            // 
            this.imagePanel_V1.BackgroundImage = "5.png";
            this.imagePanel_V1.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imagePanel_V1.FirstLabMargin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.imagePanel_V1.Location = new System.Drawing.Point(727, 343);
            this.imagePanel_V1.Margin = new Swebui.Controls.Margin(30F, 0F, 0F, 0F);
            this.imagePanel_V1.Name = "imagePanel_V1";
            this.imagePanel_V1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.imagePanel_V1.Padding = new Swebui.Controls.Padding(10F);
            this.imagePanel_V1.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.imagePanel_V1.Size = new System.Drawing.Size(135, 200);
            this.imagePanel_V1.SubText = "On-line analyzer";
            this.imagePanel_V1.Text = "原料成分在线分析仪";
            this.imagePanel_V1.ZIndex = 10;
            // 
            // imagePanel_H1
            // 
            this.imagePanel_H1.BackgroundImage = "2.png";
            this.imagePanel_H1.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imagePanel_H1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.imagePanel_H1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.imagePanel_H1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.imagePanel_H1.LabSize = new System.Drawing.Size(0, 0);
            this.imagePanel_H1.Margin = new Swebui.Controls.Margin(60F, 0F, 0F, 0F);
            this.imagePanel_H1.Name = "imagePanel_H1";
            this.imagePanel_H1.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.imagePanel_H1.Size = new System.Drawing.Size(160, 0);
            this.imagePanel_H1.SubText = "0m";
            this.imagePanel_H1.Text = "石灰石";
            this.imagePanel_H1.TextMargin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            // 
            // imagePanel_H2
            // 
            this.imagePanel_H2.BackgroundImage = "2.png";
            this.imagePanel_H2.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imagePanel_H2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.imagePanel_H2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.imagePanel_H2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.imagePanel_H2.LabSize = new System.Drawing.Size(0, 0);
            this.imagePanel_H2.Margin = new Swebui.Controls.Margin(60F, 0F, 0F, 0F);
            this.imagePanel_H2.Name = "imagePanel_H2";
            this.imagePanel_H2.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.imagePanel_H2.Size = new System.Drawing.Size(160, 0);
            this.imagePanel_H2.SubText = "0m";
            this.imagePanel_H2.Text = "硅石";
            this.imagePanel_H2.TextMargin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            // 
            // imagePanel_H3
            // 
            this.imagePanel_H3.BackgroundImage = "2.png";
            this.imagePanel_H3.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imagePanel_H3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.imagePanel_H3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.imagePanel_H3.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.imagePanel_H3.LabSize = new System.Drawing.Size(0, 0);
            this.imagePanel_H3.Margin = new Swebui.Controls.Margin(60F, 0F, 0F, 0F);
            this.imagePanel_H3.Name = "imagePanel_H3";
            this.imagePanel_H3.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.imagePanel_H3.Size = new System.Drawing.Size(160, 0);
            this.imagePanel_H3.SubText = "0m";
            this.imagePanel_H3.Text = "粘土";
            this.imagePanel_H3.TextMargin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            // 
            // imagePanel_H4
            // 
            this.imagePanel_H4.BackgroundImage = "2.png";
            this.imagePanel_H4.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imagePanel_H4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.imagePanel_H4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.imagePanel_H4.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.imagePanel_H4.LabSize = new System.Drawing.Size(0, 0);
            this.imagePanel_H4.Margin = new Swebui.Controls.Margin(60F, 0F, 30F, 0F);
            this.imagePanel_H4.Name = "imagePanel_H4";
            this.imagePanel_H4.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.imagePanel_H4.Size = new System.Drawing.Size(160, 0);
            this.imagePanel_H4.SubText = "0m";
            this.imagePanel_H4.Text = "钢渣";
            this.imagePanel_H4.TextMargin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imagePanel_H1,
            this.imagePanel_H2,
            this.imagePanel_H3,
            this.imagePanel_H4});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Location = new System.Drawing.Point(26, 49);
            this.panel4.Name = "panel4";
            this.panel4.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.panel4.Size = new System.Drawing.Size(900, 118);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.arrowBottom1,
            this.arrowBottom2,
            this.arrowBottom3,
            this.arrowBottom4});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Location = new System.Drawing.Point(26, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 60);
            // 
            // arrowBottom1
            // 
            this.arrowBottom1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.arrowBottom1.Margin = new Swebui.Controls.Margin(60F, 0F, 0F, 0F);
            this.arrowBottom1.Name = "arrowBottom1";
            this.arrowBottom1.Size = new System.Drawing.Size(160, 69);
            // 
            // arrowBottom2
            // 
            this.arrowBottom2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.arrowBottom2.Margin = new Swebui.Controls.Margin(60F, 0F, 0F, 0F);
            this.arrowBottom2.Name = "arrowBottom2";
            this.arrowBottom2.Size = new System.Drawing.Size(160, 69);
            // 
            // arrowBottom3
            // 
            this.arrowBottom3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.arrowBottom3.Margin = new Swebui.Controls.Margin(60F, 0F, 0F, 0F);
            this.arrowBottom3.Name = "arrowBottom3";
            this.arrowBottom3.Size = new System.Drawing.Size(160, 69);
            // 
            // arrowBottom4
            // 
            this.arrowBottom4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.arrowBottom4.Margin = new Swebui.Controls.Margin(60F, 0F, 30F, 0F);
            this.arrowBottom4.Name = "arrowBottom4";
            this.arrowBottom4.Size = new System.Drawing.Size(160, 69);
            // 
            // eCharts1
            // 
            this.eCharts1.Flex = 1;
            this.eCharts1.Location = new System.Drawing.Point(944, 0);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Padding = new Swebui.Controls.Padding(5F, 10F, 5F, 10F);
            this.eCharts1.Size = new System.Drawing.Size(687, 417);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.arrowRight1,
            this.imagePanel_V_C1,
            this.arrowRight2,
            this.imagePanel_V_C2});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Location = new System.Drawing.Point(61, 557);
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 0F, 60F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(455, 248);
            // 
            // arrowRight1
            // 
            this.arrowRight1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.arrowRight1.Name = "arrowRight1";
            this.arrowRight1.Size = new System.Drawing.Size(43, 0);
            // 
            // imagePanel_V_C1
            // 
            this.imagePanel_V_C1.BackgroundImage = "3.png";
            this.imagePanel_V_C1.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.imagePanel_V_C1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.imagePanel_V_C1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.imagePanel_V_C1.Name = "imagePanel_V_C1";
            this.imagePanel_V_C1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.imagePanel_V_C1.Size = new System.Drawing.Size(199, 0);
            this.imagePanel_V_C1.SubText = "Rolling";
            this.imagePanel_V_C1.Text = "辊压机";
            // 
            // arrowRight2
            // 
            this.arrowRight2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.arrowRight2.Name = "arrowRight2";
            this.arrowRight2.Size = new System.Drawing.Size(43, 0);
            // 
            // imagePanel_V_C2
            // 
            this.imagePanel_V_C2.BackgroundImage = "4.png";
            this.imagePanel_V_C2.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.imagePanel_V_C2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.imagePanel_V_C2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.imagePanel_V_C2.Name = "imagePanel_V_C2";
            this.imagePanel_V_C2.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.imagePanel_V_C2.Size = new System.Drawing.Size(149, 0);
            this.imagePanel_V_C2.SubText = "Flour separator";
            this.imagePanel_V_C2.Text = "选粉机";
            this.imagePanel_V_C2.Load += new System.EventHandler(this.imagePanel_V_C2_Load);
            // 
            // eCharts2
            // 
            this.eCharts2.Flex = 1;
            this.eCharts2.Location = new System.Drawing.Point(533, 555);
            this.eCharts2.Name = "eCharts2";
            this.eCharts2.Padding = new Swebui.Controls.Padding(5F, 10F, 5F, 10F);
            this.eCharts2.Size = new System.Drawing.Size(731, 310);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imagePanel_V2,
            this.imagePanel_V4});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel11.Location = new System.Drawing.Point(1251, 567);
            this.panel11.Margin = new Swebui.Controls.Margin(20F, 0F, 0F, 0F);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(410, 205);
            // 
            // imagePanel_V2
            // 
            this.imagePanel_V2.BackgroundImage = "1.png";
            this.imagePanel_V2.FirstLabMargin = new Swebui.Controls.Margin(0F, 120F, 0F, 0F);
            this.imagePanel_V2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.imagePanel_V2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.imagePanel_V2.Margin = new Swebui.Controls.Margin(40F, 0F, 30F, 0F);
            this.imagePanel_V2.Name = "imagePanel_V2";
            this.imagePanel_V2.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.imagePanel_V2.Padding = new Swebui.Controls.Padding(10F);
            this.imagePanel_V2.Size = new System.Drawing.Size(135, 205);
            this.imagePanel_V2.SubText = "Raw material storehouse";
            this.imagePanel_V2.Text = "生料库";
            // 
            // imagePanel_V4
            // 
            this.imagePanel_V4.BackgroundImage = "1.png";
            this.imagePanel_V4.FirstLabMargin = new Swebui.Controls.Margin(0F, 120F, 0F, 0F);
            this.imagePanel_V4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.imagePanel_V4.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.imagePanel_V4.Margin = new Swebui.Controls.Margin(30F, 0F, 40F, 0F);
            this.imagePanel_V4.Name = "imagePanel_V4";
            this.imagePanel_V4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.imagePanel_V4.Padding = new Swebui.Controls.Padding(10F);
            this.imagePanel_V4.Size = new System.Drawing.Size(135, 205);
            this.imagePanel_V4.SubText = "Raw material storehouse";
            this.imagePanel_V4.Text = "生料库";
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Name = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // line_V1
            // 
            this.line_V1.AnimationType = "toDown";
            this.line_V1.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.line_V1.HaveArrow = false;
            this.line_V1.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.line_V1.Location = new System.Drawing.Point(58, 254);
            this.line_V1.MoveDirection = "vertical";
            this.line_V1.Name = "line_V1";
            this.line_V1.Size = new System.Drawing.Size(3, 439);
            // 
            // dotLine1
            // 
            this.dotLine1.AnimationType = "toLeft";
            this.dotLine1.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.dotLine1.HaveArrow = false;
            this.dotLine1.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.dotLine1.Location = new System.Drawing.Point(61, 254);
            this.dotLine1.MoveDirection = "horizontal";
            this.dotLine1.Name = "dotLine1";
            this.dotLine1.Size = new System.Drawing.Size(43, 3);
            // 
            // dotLine2
            // 
            this.dotLine2.AnimationType = "toTop";
            this.dotLine2.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.dotLine2.HaveArrow = false;
            this.dotLine2.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.dotLine2.Location = new System.Drawing.Point(435, 500);
            this.dotLine2.MoveDirection = "vertical";
            this.dotLine2.Name = "dotLine2";
            this.dotLine2.Size = new System.Drawing.Size(3, 60);
            // 
            // dotLine3
            // 
            this.dotLine3.AnimationType = "toRight";
            this.dotLine3.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.dotLine3.HaveArrow = false;
            this.dotLine3.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.dotLine3.Location = new System.Drawing.Point(435, 495);
            this.dotLine3.MoveDirection = "horizontal";
            this.dotLine3.Name = "dotLine3";
            this.dotLine3.Size = new System.Drawing.Size(1144, 3);
            // 
            // arrowBottom5
            // 
            this.arrowBottom5.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexStart;
            this.arrowBottom5.Location = new System.Drawing.Point(1353, 498);
            this.arrowBottom5.Name = "arrowBottom5";
            this.arrowBottom5.Size = new System.Drawing.Size(43, 69);
            // 
            // arrowBottom6
            // 
            this.arrowBottom6.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexStart;
            this.arrowBottom6.Location = new System.Drawing.Point(1558, 498);
            this.arrowBottom6.Name = "arrowBottom6";
            this.arrowBottom6.Size = new System.Drawing.Size(43, 69);
            // 
            // image1
            // 
            this.image1.BackColor = System.Drawing.Color.White;
            this.image1.Location = new System.Drawing.Point(104, 248);
            this.image1.Name = "image1";
            this.image1.ResourceID = "7.gif";
            this.image1.Size = new System.Drawing.Size(796, 17);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(264, 331);
            this.image2.Name = "image2";
            this.image2.ResourceID = "9.png";
            this.image2.Size = new System.Drawing.Size(155, 26);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // RMQAbsoluteLayout
            // 
            this.Components.AddRange(new Swebui.Controls.SwebComponent[] {
            this.timer1});
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.imagePanel_V3,
            this.panel9,
            this.imagePanel_V1,
            this.panel4,
            this.panel5,
            this.eCharts1,
            this.panel10,
            this.eCharts2,
            this.panel11,
            this.line_V1,
            this.dotLine1,
            this.dotLine2,
            this.dotLine3,
            this.arrowBottom5,
            this.arrowBottom6,
            this.image1,
            this.image2});
            this.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.Load += new System.EventHandler(this.RMQAbsoluteLayout_Load);

        }
        #endregion

        private Label label1;
        private ImagePanel_V imagePanel_V3;
        private Panel panel9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ImagePanel_V imagePanel_V1;
        private ImagePanel_H imagePanel_H1;
        private ImagePanel_H imagePanel_H2;
        private ImagePanel_H imagePanel_H3;
        private ImagePanel_H imagePanel_H4;
        private Panel panel4;
        private Panel panel5;
        private ArrowBottom arrowBottom1;
        private ArrowBottom arrowBottom2;
        private ArrowBottom arrowBottom3;
        private ArrowBottom arrowBottom4;
        private ECharts eCharts1;
        private Panel panel10;
        private ECharts eCharts2;
        private Panel panel11;
        private ImagePanel_V imagePanel_V2;
        private ImagePanel_V imagePanel_V4;
        private Timer timer1;
        private ArrowRight arrowRight1;
        private ImagePanel_V_C imagePanel_V_C1;
        private ArrowRight arrowRight2;
        private ImagePanel_V_C imagePanel_V_C2;
        private DotLine line_V1;
        private DotLine dotLine1;
        private DotLine dotLine2;
        private DotLine dotLine3;
        private ArrowBottom arrowBottom5;
        private ArrowBottom arrowBottom6;
        private Image image1;
        private Image image2;
    }
}