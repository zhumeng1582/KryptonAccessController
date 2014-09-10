using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.ResourcesFile;
using KryptonAccessController.Common;

namespace KryptonAccessController.RelationDepartment
{
    public partial class FormCompany : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private AccessDataBase.Model.CompanyInfo modelCompanyInfo = new AccessDataBase.Model.CompanyInfo();
        private AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();
        private OpenMode openMode;
        public FormCompany(AccessDataBase.Model.CompanyInfo companyInfo, OpenMode openMode)
        {
            InitializeComponent();

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = GetResourcesFile.getSystemIco();

            this.modelCompanyInfo = companyInfo;
            this.openMode = openMode;
            
            if (openMode == OpenMode.Add)
            {
                kryptonTextBoxCompanyID.Text = companyInfo.CompanyID.ToString();
            }
            else if (openMode == OpenMode.Update)
            {
                kryptonTextBoxCompanyID.Text = companyInfo.CompanyID.ToString();
                kryptonTextBoxCompanyName.Text = companyInfo.CompanyName.ToString();
                kryptonTextBoxCompanyDes.Text = companyInfo.CompanyDes.ToString();
                kryptonTextBoxCompanyAddr.Text = companyInfo.CompanyAddress.ToString();
                kryptonTextBoxTelPhone1.Text = companyInfo.CompanyTel1.ToString();
                kryptonTextBoxTelPhone2.Text = companyInfo.CompanyTel2.ToString();
            }
        }

        private void kryptonButtonCompanyOK_Click(object sender, EventArgs e)
        {
            modelCompanyInfo.CompanyID = int.Parse(kryptonTextBoxCompanyID.Text);
            if (!String.IsNullOrEmpty(kryptonTextBoxCompanyName.Text.Trim()))
                modelCompanyInfo.CompanyName = kryptonTextBoxCompanyName.Text.Trim();
            else
                MyMessageBox.MessageBoxOK("公司名不能为空");

            modelCompanyInfo.CompanyDes = kryptonTextBoxCompanyDes.Text.Trim();
            modelCompanyInfo.CompanyAddress = kryptonTextBoxCompanyAddr.Text.Trim();
            modelCompanyInfo.CompanyTel1 = kryptonTextBoxTelPhone1.Text.Trim();
            modelCompanyInfo.CompanyTel2 = kryptonTextBoxTelPhone2.Text.Trim();


            if (openMode == OpenMode.Add)
            {
                if (bllCompanyInfo.Exists(modelCompanyInfo.CompanyID) == true)
                    MyMessageBox.MessageBoxOK("公司信息以经存在");
                else if (bllCompanyInfo.Add(modelCompanyInfo))
                    MyMessageBox.MessageBoxOK("添加公司信息成功");
                else 
                    MyMessageBox.MessageBoxOK("添加公司信息失败");
            }
            else if (openMode == OpenMode.Update)
            {
                if (bllCompanyInfo.Update(modelCompanyInfo))
                    MyMessageBox.MessageBoxOK("修改公司信息成功");
                else
                    MyMessageBox.MessageBoxOK("修改公司信息失败");
            }
            this.Close();
        }

        private void kryptonButtonCompanyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}