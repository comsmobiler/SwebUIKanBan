using Swebui.Controls;
using System;

namespace SwebApplication5
{
    partial class ImagePanel_V : Swebui.Controls.SwebUserControl
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
            this.label2 = new Swebui.Controls.Label();
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 80F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 1);
            // 
            // ImagePanel_V
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Padding = new Swebui.Controls.Padding(10F);
            this.Size = new System.Drawing.Size(120, 200);

        }
        #endregion
        private Label label1;
        private Label label2;
    }
}