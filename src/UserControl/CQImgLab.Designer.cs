using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class CQImgLab : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "cq-1.png";
            this.image1.Size = new System.Drawing.Size(61, 54);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // CQImgLab
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1});
            this.Size = new System.Drawing.Size(61, 72);

        }
        #endregion

        private Image image1;
        private Label label1;
    }
}