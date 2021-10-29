using Swebui.Controls;
using System;

namespace SwebApplication5
{
    partial class DotLine : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.AnimationItem animationItem2 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem3 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem4 = new Swebui.Controls.AnimationItem();
            this.toDown = new Swebui.Controls.Animation();
            this.toRight = new Swebui.Controls.Animation();
            this.toTop = new Swebui.Controls.Animation();
            this.toLeft = new Swebui.Controls.Animation();
            // 
            // toDown
            // 
            this.toDown.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem1.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem1.Value = "10";
            animationItem1.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.toDown.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem1});
            this.toDown.Loop = -1;
            this.toDown.Name = "toDown";
            // 
            // toRight
            // 
            this.toRight.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem2.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem2.Value = "10";
            animationItem2.ValueType = Swebui.Controls.AnimationValueType.X;
            this.toRight.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem2});
            this.toRight.Loop = -1;
            this.toRight.Name = "toRight";
            // 
            // toTop
            // 
            this.toTop.Direction = Swebui.Controls.AnimationDirection.Reverse;
            this.toTop.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem3.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem3.Value = "10";
            animationItem3.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.toTop.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem3});
            this.toTop.Loop = -1;
            this.toTop.Name = "toTop";
            // 
            // toLeft
            // 
            this.toLeft.Direction = Swebui.Controls.AnimationDirection.Reverse;
            this.toLeft.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem4.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem4.Value = "10";
            animationItem4.ValueType = Swebui.Controls.AnimationValueType.X;
            this.toLeft.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem4});
            this.toLeft.Loop = -1;
            this.toLeft.Name = "toLeft";
            // 
            // DotLine
            // 
            this.Components.AddRange(new Swebui.Controls.SwebComponent[] {
            this.toDown,
            this.toTop,
            this.toRight,
            this.toLeft});
            this.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.Size = new System.Drawing.Size(3, 0);
            this.Load += new System.EventHandler(this.Line_V_Load);

        }
        #endregion

        private Animation toDown;
        private Animation toRight;
        private Animation toTop;
        private Animation toLeft;
    }
}