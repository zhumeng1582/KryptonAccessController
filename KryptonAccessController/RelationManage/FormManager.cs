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

namespace KryptonAccessController.RelationManage
{
    public partial class FormManager : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private OpenMode openMode;
        private AccessDataBase.Model.Manager modelManager = new AccessDataBase.Model.Manager();
        private AccessDataBase.BLL.Manager bllManager = new AccessDataBase.BLL.Manager();
        
        public FormManager(AccessDataBase.Model.Manager modelManager,OpenMode openMode)
        {
            InitializeComponent();

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = GetResourcesFile.getSystemIco();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.modelManager = modelManager;
            this.openMode = openMode;
            if (openMode == OpenMode.Update)
            {
                kryptonTextBoxName.Text = modelManager.ManagerName;
                kryptonTextBoxName.Enabled = false;
            }
        }
        private Boolean VerifyUserName()
        {
            if (string.IsNullOrEmpty(kryptonTextBoxName.Text.Trim()))
            {
                string text = "用户名不能为空";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;
            }

            if (RegexMatch.IsManagerName(kryptonTextBoxName.Text.Trim()) == false)
            {
                string text = "用户名格式不对";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;
            }
            return true;
        }
        private Boolean VerifyPassword()
        {

            if (string.IsNullOrEmpty(kryptonTextBoxPassword.Text.Trim()))
            {
                string text = "密码不能为空";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;
            }

            if (RegexMatch.IsManagerPassword(kryptonTextBoxPassword.Text.Trim()) == false)
            {
                string text = "密码格式无效";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;

            }
            return true;
        }
        private void kryptonButtonOK_Click(object sender, EventArgs e)
        {
            if (VerifyUserName() == false)
            {
                kryptonTextBoxName.Focus();
                return; 
            }
            if (VerifyPassword() == false)
            {
                kryptonTextBoxPassword.Focus();
                return; 
            }
            modelManager.ManagerName = kryptonTextBoxName.Text.Trim();
            modelManager.ManagerPassWord = kryptonTextBoxPassword.Text.Trim();
            if (openMode == OpenMode.Add)
            {
                if (bllManager.GetModelList("ManagerName='" + modelManager.ManagerName + "'") != null)
                    MyMessageBox.MessageBoxOK("用户已经存在");
                else
                { 
                    bllManager.Add(modelManager);
                    this.Close();
                }
            }
            else if (openMode == OpenMode.Update)
            {
                bllManager.Update(modelManager);
                this.Close();
            }
        }

        private void kryptonButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}