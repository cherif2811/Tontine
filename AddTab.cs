using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace suivibouteilles
{
    class AddTab
    {
        public void AddTabControl(DevExpress.XtraTab.XtraTabControl xtraTabParent, string xtraItemName, string icon, UserControl userControl)
        {
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = "Test";
            xtraTabPage.Text = xtraItemName;
            //xtraTabPage.Image = Bitmap.FromFile(@"..\..\LOGISCO_COLLEGE_Version_1._0._1.Properties.Resources." + icon);
            xtraTabPage.Dock = DockStyle.Fill;
            xtraTabPage.Controls.Add(userControl);
            xtraTabParent.TabPages.Add(xtraTabPage);
        }
    }
}
