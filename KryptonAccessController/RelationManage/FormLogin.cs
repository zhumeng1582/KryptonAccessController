
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.International;
using KryptonAccessController.ResourcesFile;
using KryptonAccessController.Common;
using System.Drawing;
namespace KryptonAccessController.RelationManage
{

    public partial class FormLogin : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        
        AccessDataBase.BLL.Manager bllManager = new AccessDataBase.BLL.Manager();


        public FormLogin(OpenMode openMode)
        {
            InitializeComponent();

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = GetResourcesFile.getSystemIco();

            initUserInterface();

            if (openMode == OpenMode.Unclock)
            {
                buttonCancel.Visible = false;
                comboBoxUserName.Enabled = false;
                buttonLogin.Location = new Point ((this.Width - buttonLogin.Width) / 2,buttonLogin.Location.Y);
            }
        }
        private void initUserInterface()
        {
            if (System.Globalization.CultureInfo.InstalledUICulture.Name == "zh-CN")
                return;

            this.Text = English.FormLoginText;
            labelUserName.Text = English.UserName;
            labelUserPassword.Text = English.UserPassword;
            labelFailInfo.Text = English.FailInfo;
            buttonLogin.Text = English.Login;
            buttonCancel.Text = English.Cancel;
        }
        private Boolean VerifyUserName()
        {
            if (string.IsNullOrEmpty(comboBoxUserName.Text.Trim()))
            {
                string text = "用户名不能为空";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;
            }

            if (RegexMatch.IsManagerName(comboBoxUserName.Text.Trim()) == false)
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

            if (string.IsNullOrEmpty(textBoxUserPassword.Text.Trim()))
            {
                string text = "密码不能为空";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;
            }

            if (RegexMatch.IsManagerPassword(textBoxUserPassword.Text.Trim()) == false)
            {
                string text = "密码格式无效";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;

            }
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (VerifyUserName() == false)
            {
                comboBoxUserName.Focus();
                return; 
            }
            if (VerifyPassword() == false)
            {
                textBoxUserPassword.Focus(); 
                return;
            }

            AccessDataBase.Model.Manager modelManager = new AccessDataBase.Model.Manager();
            modelManager.ManagerName = comboBoxUserName.Text.Trim();

            modelManager = bllManager.GetModelList("ManagerName='"+modelManager.ManagerName+"'")[0];
            //modelManager = bllManager.GetModel(1,"Admin");
            if (modelManager == null)
            {
            }
            else if (textBoxUserPassword.Text.Trim().Equals(modelManager.ManagerPassWord))
            {
                Admin.name = modelManager.ManagerName;
                Admin.password = modelManager.ManagerPassWord;
                this.Hide();
                FormMain AccessControl = new FormMain(modelManager);
                AccessControl.ShowDialog();
            }
            else
            {
                string text = "用户名或密码不对";
                labelFailInfo.Text = text;
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
            }
        }
        //初始化登录窗体的用户名控件
        private void initComboBoxUserName(KryptonComboBox comboBoxName)
        {

        }
        private void Ktypton1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Icon = GetResourcesFile.getSystemIco();
            initComboBoxUserName(comboBoxUserName);
            labelFailInfo.Text = "";
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void textBoxUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }

        }
    }
}