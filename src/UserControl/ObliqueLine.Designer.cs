using Swebui.Controls;
using System;

namespace KanbanDemo
{
    partial class ObliqueLine : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.AnimationItem animationItem5 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem6 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem7 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem8 = new Swebui.Controls.AnimationItem();
            this.anDefault = new Swebui.Controls.Animation();
            this.anReverse = new Swebui.Controls.Animation();
            this.anDefault1 = new Swebui.Controls.Animation();
            this.anReverse1 = new Swebui.Controls.Animation();
            // 
            // anDefault
            // 
            this.anDefault.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem1.Duration = 1000;
            animationItem1.Easing = Swebui.Controls.AnimationEasing.Steps;
            animationItem1.Value = "10";
            animationItem1.ValueType = Swebui.Controls.AnimationValueType.X;
            animationItem2.Duration = 1000;
            animationItem2.Value = "1";
            animationItem2.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.anDefault.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem1,
            animationItem2});
            this.anDefault.Loop = -1;
            this.anDefault.Name = "anDefault";
            // 
            // anReverse
            // 
            this.anReverse.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem3.Duration = 1000;
            animationItem3.Value = "-13";
            animationItem4.Duration = 1000;
            animationItem4.Value = "1";
            animationItem4.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.anReverse.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem3,
            animationItem4});
            this.anReverse.Loop = -1;
            this.anReverse.Name = "anReverse";
            // 
            // anDefault1
            // 
            this.anDefault1.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem5.Duration = 1000;
            animationItem5.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem5.Value = "20";
            animationItem5.ValueType = Swebui.Controls.AnimationValueType.X;
            animationItem6.Duration = 1000;
            animationItem6.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem6.Value = "13";
            animationItem6.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.anDefault1.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem5,
            animationItem6});
            this.anDefault1.Loop = -1;
            this.anDefault1.Name = "anDefault1";
            // 
            // anReverse1
            // 
            this.anReverse1.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem7.Duration = 1000;
            animationItem7.Value = "-20";
            animationItem8.Duration = 1000;
            animationItem8.Value = "13";
            animationItem8.ValueType = Swebui.Controls.AnimationValueType.Y;
            this.anReverse1.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem7,
            animationItem8});
            this.anReverse1.Loop = -1;
            this.anReverse1.Name = "anReverse1";
            // 
            // ObliqueLine
            // 
            this.Components.AddRange(new Swebui.Controls.SwebComponent[] {
            this.anDefault,
            this.anReverse,
            this.anDefault1,
            this.anReverse1});
            this.Size = new System.Drawing.Size(30, 40);
            this.Load += new System.EventHandler(this.ObliqueLine_Load);

        }
        #endregion

        private Animation anDefault;
        private Animation anReverse;
        private Animation anDefault1;
        private Animation anReverse1;
    }
}