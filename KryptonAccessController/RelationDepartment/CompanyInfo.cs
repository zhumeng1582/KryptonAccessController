using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.WidgetThread;
using KryptonAccessController.Common;

namespace KryptonAccessController.RelationDepartment
{
    public partial class CompanyInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();

        private static object obj = new object();
        static CompanyInfo _instance = null;
        public static CompanyInfo getInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new CompanyInfo();
                    }
                }
            }
            return _instance;
        }

        private CompanyInfo()
        {
            InitializeComponent();
            initToolStripMenu();
            refreshDataGridView();
        }
        public void initToolStripMenu()
        {
            toolStripCompany.Items.Clear();
            ImageOperate.AddButtonItemToToolStrip(toolStripCompany, "add.BMP", "Add", toolStripButtonAddCompanyInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripCompany, "update.BMP", "Update", toolStripButtonUpdateCompanyInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripCompany, "delete.BMP", "Del", toolStripButtonDeleteCompanyInfo_Click);
            
        }
        public void refreshDataGridView()
        {
            DataTable dt = bllCompanyInfo.GetAllList().Tables[0];
            kryptonDataGridViewCompany.DataSource = dt;

        }

        private void toolStripButtonAddCompanyInfo_Click(object sender, EventArgs e)
        {
            AccessDataBase.Model.CompanyInfo modeCompanyInfo = new AccessDataBase.Model.CompanyInfo();
            AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();

            modeCompanyInfo.CompanyID = bllCompanyInfo.GetMaxId();

            FormCompany formCompany = new FormCompany(modeCompanyInfo, OpenMode.Add);
            formCompany.ShowDialog();
            this.refreshDataGridView();
        }

        private void toolStripButtonUpdateCompanyInfo_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewCompany.CurrentRow == null)
                return;

            AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();

            int selectIndex = kryptonDataGridViewCompany.CurrentRow.Index;
            string companyID = kryptonDataGridViewCompany["CompanyID", selectIndex].Value.ToString().Trim();

            AccessDataBase.Model.CompanyInfo modeCompanyInfo = bllCompanyInfo.GetModel(int.Parse(companyID));

            FormCompany formCompany = new FormCompany(modeCompanyInfo, OpenMode.Update);
            formCompany.ShowDialog();

            this.refreshDataGridView();
        }

        private void toolStripButtonDeleteCompanyInfo_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewCompany.CurrentRow == null)
                return;

            AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();

            int selectIndex = kryptonDataGridViewCompany.CurrentRow.Index;
            string companyID = kryptonDataGridViewCompany["CompanyID", selectIndex].Value.ToString().Trim();

            if(MyMessageBox.MessageBoxOkCancel("用户信息删除后不能恢复,是否删除?") == System.Windows.Forms.DialogResult.Cancel)
                return;

            if (bllCompanyInfo.Delete(int.Parse(companyID)))
                MyMessageBox.MessageBoxOK("删除成功");
            else
                MyMessageBox.MessageBoxOkCancel("删除失败");

            this.refreshDataGridView();
        }
    }
}