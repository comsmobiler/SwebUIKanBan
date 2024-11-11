using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class ImagePanel_V_C : Swebui.Controls.SwebUserControl
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // ImagePanel_V_C
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Size = new System.Drawing.Size(120, 200);

        }
        #endregion

        private Label label1;
        private Label label2;
    }
}