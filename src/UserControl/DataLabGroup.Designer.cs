using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class DataLabGroup : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            // 
            // label1
            // 
            this.label1.FontSize = 14F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1});
            this.panel1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 74);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "data-6.png";
            this.image1.Size = new System.Drawing.Size(0, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // DataLabGroup
            // 
            this.BackgroundImage = "data-7.png";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel1});
            this.Size = new System.Drawing.Size(94, 104);

        }
        #endregion

        private Label label1;
        private Panel panel1;
        private Image image1;
    }
}