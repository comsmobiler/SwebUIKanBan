using Swebui;

namespace KanbanDemo
{
    partial class SwebForm1 : Swebui.Controls.SwebForm
    {
        #region "SwebForm Designer generated code "

        //SwebForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SwebForm Designer
        //It can be modified using the SwebForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.menuView1 = new Swebui.Controls.MenuView();
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 60);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.FontSize = 25F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(237)))));
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "HT CEMENT FACTORY";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.menuView1,
            this.tabPageView1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // menuView1
            // 
            this.menuView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.menuView1.Color = System.Drawing.Color.White;
            this.menuView1.DefaultIcon = "tasks";
            this.menuView1.FontSize = 15;
            this.menuView1.Name = "menuView1";
            this.menuView1.Size = new System.Drawing.Size(200, 0);
            this.menuView1.SubColor = System.Drawing.Color.White;
            this.menuView1.MenuItemClick += new Swebui.Controls.MenuViewItemClickEventHandler(this.menuView1_MenuItemClick);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.None;
            this.tabPageView1.Size = new System.Drawing.Size(100, 0);
            // 
            // SwebForm1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Load += new System.EventHandler(this.SwebForm1_Load);

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.MenuView menuView1;
        private Swebui.Controls.TabPageView tabPageView1;
        private Swebui.Controls.Label label1;
    }
}