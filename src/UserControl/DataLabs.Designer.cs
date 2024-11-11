using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class DataLabs : Swebui.Controls.SwebUserControl
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
            this.image1 = new Swebui.Controls.Image();
            this.panel1 = new Swebui.Controls.Panel();
            this.nameLab = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.valueLab1 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.image3 = new Swebui.Controls.Image();
            this.panel8 = new Swebui.Controls.Panel();
            this.valueLab2 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.image2 = new Swebui.Controls.Image();
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "data-4.png";
            this.image1.Size = new System.Drawing.Size(35, 31);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.nameLab,
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 0);
            // 
            // nameLab
            // 
            this.nameLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(89)))));
            this.nameLab.Flex = 1;
            this.nameLab.FontSize = 15F;
            this.nameLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.nameLab.Name = "nameLab";
            this.nameLab.Padding = new Swebui.Controls.Padding(5F, 0F, 0F, 0F);
            this.nameLab.Size = new System.Drawing.Size(0, 14);
            this.nameLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel4});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 5F, 0F, 5F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5,
            this.panel6});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Swebui.Controls.Padding(5F, 0F, 0F, 0F);
            this.panel3.Size = new System.Drawing.Size(0, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Swebui.Controls.Padding(5F, 0F, 0F, 0F);
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.image2});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 14);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.valueLab1,
            this.label4});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 24);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 0);
            this.label2.Text = "实时";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // valueLab1
            // 
            this.valueLab1.FontSize = 15F;
            this.valueLab1.ForeColor = System.Drawing.Color.White;
            this.valueLab1.Name = "valueLab1";
            this.valueLab1.Size = new System.Drawing.Size(0, 0);
            this.valueLab1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(154)))), ((int)(((byte)(232)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "mg/m³";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.image3});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 14);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 0);
            this.label1.Text = "月均";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // image3
            // 
            this.image3.Name = "image3";
            this.image3.ResourceID = "data-5.png";
            this.image3.Size = new System.Drawing.Size(45, 8);
            this.image3.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.valueLab2,
            this.label6});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 24);
            // 
            // valueLab2
            // 
            this.valueLab2.FontSize = 15F;
            this.valueLab2.ForeColor = System.Drawing.Color.White;
            this.valueLab2.Name = "valueLab2";
            this.valueLab2.Size = new System.Drawing.Size(0, 0);
            this.valueLab2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(154)))), ((int)(((byte)(232)))));
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 0);
            this.label6.Text = "mg/m³";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // image2
            // 
            this.image2.Name = "image2";
            this.image2.ResourceID = "data-5.png";
            this.image2.Size = new System.Drawing.Size(45, 8);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // DataLabs
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(240, 67);

        }
        #endregion

        private Image image1;
        private Panel panel1;
        private Label nameLab;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private Image image2;
        private Panel panel6;
        private Label valueLab1;
        private Label label4;
        private Panel panel4;
        private Panel panel7;
        private Label label1;
        private Image image3;
        private Panel panel8;
        private Label valueLab2;
        private Label label6;
    }
}