using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class YSOLab : Swebui.Controls.SwebUserControl
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
            this.label1.Bold = true;
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(194)))), ((int)(((byte)(248)))));
            this.label1.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // YSOLab
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Size = new System.Drawing.Size(100, 35);

        }
        #endregion

        private Label label1;
        private Label label2;
    }
}