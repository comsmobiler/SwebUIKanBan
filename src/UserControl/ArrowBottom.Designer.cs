using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class ArrowBottom : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.AnimationItem animationItem1 = new Swebui.Controls.AnimationItem();
            this.animation1 = new Swebui.Controls.Animation();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.label3 = new Swebui.Controls.Label();
            // 
            // animation1
            // 
            this.animation1.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem1.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem1.Value = "10";
            animationItem1.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.animation1.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem1});
            this.animation1.Loop = -1;
            this.animation1.Name = "animation1";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.fontIcon1,
            this.label3});
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 69);
            // 
            // label1
            // 
            this.label1.Animation = "animation1";
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.label1.BorderRadius = 3;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 9F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 3);
            // 
            // label2
            // 
            this.label2.Animation = "animation1";
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.label2.BorderRadius = 3;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 3);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.fontIcon1.Location = new System.Drawing.Point(5, 36);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "angle-double-down";
            this.fontIcon1.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.fontIcon1.Size = new System.Drawing.Size(33, 33);
            // 
            // label3
            // 
            this.label3.Animation = "animation1";
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(251)))));
            this.label3.BorderRadius = 3;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 3);
            // 
            // ArrowBottom
            // 
            this.Components.AddRange(new Swebui.Controls.SwebComponent[] {
            this.animation1});
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexStart;
            this.Size = new System.Drawing.Size(43, 69);

        }
        #endregion
        private Animation animation1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private FontIcon fontIcon1;
        private Label label3;
    }
}