using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebApplication5
{
    partial class SwebForm1 : Swebui.Controls.SwebForm
    {
        public SwebForm1() : base()
        {
            InitializeComponent();
        }

        private void menuView1_MenuItemClick(object sender, MenuViewItemClickEventArgs e)
        {
            if (e.Item != null && e.Item.Tag != null)
            {
                var existTagControl = this.tabPageView1.Controls.Find(e.Item.Id);
                if (existTagControl != null)
                {
                    this.tabPageView1.PageIndex = this.tabPageView1.Controls.IndexOf(existTagControl);
                }
                else
                {
                    TabPageControl tagControl = new TabPageControl();
                    tagControl.Name = e.Item.Id;
                    tagControl.Padding = new Padding(20);
                    tagControl.Border = new Border(0,0, 0, 0);
                    Type menuType = e.Item.Tag as Type;
                    SwebControl menuControl = Activator.CreateInstance(menuType) as SwebControl;
                    menuControl.Flex = 1;
                ////    menuControl.BackColor = System.Drawing.Color.White;
                    tagControl.Controls.Add(menuControl);

                    this.tabPageView1.Controls.Add(tagControl);
                    this.tabPageView1.PageIndex = this.tabPageView1.Controls.Count - 1;
                }
            }
         
        }

        private void SwebForm1_Load(object sender, EventArgs e)
        {
            TabPageControl tagControl = new TabPageControl();
            SwebControl menuControl = new DataLayout();
            menuControl.Flex = 1;
            tagControl.Controls.Add(menuControl);
            this.tabPageView1.Controls.Add(tagControl);
            this.tabPageView1.PageIndex = 0;


           var demoItem = new MenuItem("Data", "数据概况") { Tag = typeof(DataLayout) };
            var demoItem1 = new MenuItem("YSO", "窖系统运行") { Tag = typeof(YSOLayout) };
            var demoItem2 = new MenuItem("SO", "系统运行情况") { Tag = typeof(SOLayout) };
            var demoItem3 = new MenuItem("RMQL", "生料质量控制") { Tag = typeof(RMQAbsoluteLayout) };
            var demoItem4 = new MenuItem("CQC", "熟料质量控制") { Tag = typeof(CQCLayout) };
            var demoItem5 = new MenuItem("PCQC", "煤粉质量控制") { Tag = typeof(PCQCLayout) };
            this.menuView1.Items.Add(demoItem);
            this.menuView1.Items.Add(demoItem1);
            this.menuView1.Items.Add(demoItem2);
            this.menuView1.Items.Add(demoItem3);
            this.menuView1.Items.Add(demoItem4);
            this.menuView1.Items.Add(demoItem5);


            menuView1.DefaultSelectedItem = menuView1.Items[0];
        }
    }
}