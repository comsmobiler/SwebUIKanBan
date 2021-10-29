using Swebui.Controls;
using System;

namespace SwebApplication5
{
    partial class ImagePanel_H : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.panel1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            // 
            // ImagePanel_H
            // 
            this.BackgroundImage = "2.png";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.Size = new System.Drawing.Size(200, 144);

        }
        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}