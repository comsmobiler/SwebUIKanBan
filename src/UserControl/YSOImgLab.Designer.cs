using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class YSOImgLab : Swebui.Controls.SwebUserControl
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
            // 
            // label1
            // 
            this.label1.FontSize = 14F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // YSOImgLab
            // 
            this.BackgroundImage = "cq-1.png";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Size = new System.Drawing.Size(61, 54);

        }
        #endregion

        private Label label1;
    }
}