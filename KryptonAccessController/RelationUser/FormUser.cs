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

namespace KryptonAccessController.RelationUser
{
    public partial class FormUser : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private AccessDataBase.Model.UserInfo modelUserInfo = new AccessDataBase.Model.UserInfo();
        private AccessDataBase.BLL.UserInfo bllUserInfo = new AccessDataBase.BLL.UserInfo();

        private AccessDataBase.Model.CardInfo modelCardInfo1 = new AccessDataBase.Model.CardInfo();
        private AccessDataBase.Model.CardInfo modelCardInfo2 = new AccessDataBase.Model.CardInfo();
        private AccessDataBase.BLL.CardInfo bllCardInfo = new AccessDataBase.BLL.CardInfo();

        private AccessDataBase.Model.DepartmentInfo modelDepartmentInfo = new AccessDataBase.Model.DepartmentInfo();
        private List<AccessDataBase.Model.DepartmentInfo> listModelDepartment = new List<AccessDataBase.Model.DepartmentInfo>();
        private AccessDataBase.BLL.DepartmentInfo bllDepartmentInfo = new AccessDataBase.BLL.DepartmentInfo();
        
        private AccessDataBase.Model.CompanyInfo modelCompanyInfo = new AccessDataBase.Model.CompanyInfo();
        private AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();

        private OpenMode openMode;
        public FormUser(AccessDataBase.Model.UserInfo userInfo, OpenMode openMode)
        {
            InitializeComponent();
            InitComboBoxCompany();
            InitComboBoxDepartment();

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = GetResourcesFile.getSystemIco();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.modelUserInfo = userInfo;

            this.openMode = openMode;
            if (openMode == OpenMode.Add)
            {
                showAddPara();
            }
            else if (openMode == OpenMode.Update)
            {
                showUpdatePara();
            }

        }
        /// <summary>
        /// 显示添加参数
        /// </summary>
        private void showAddPara()
        {
            #region 基本信息
            kryptonTextBoxUserID.Text = modelUserInfo.UserID.ToString();
            #endregion
            
            #region 个人信息
            kryptonComboBoxCompany.SelectedIndex = 0;
            kryptonComboBoxDepartment.SelectedIndex = 0;
            #endregion

            #region 卡片信息1
            #endregion

            #region 卡片信息2
            #endregion
        }
        /// <summary>
        /// 显示更新参数
        /// </summary>
        private void showUpdatePara()
        {
            #region 基本信息
            kryptonTextBoxUserID.Text = modelUserInfo.UserID.ToString();
            kryptonTextBoxUserName.Text = modelUserInfo.UserName.ToString();
            #endregion

            #region 个人信息
            int departmentID = modelUserInfo.DepartmentID.HasValue ? modelUserInfo.DepartmentID.Value : 0;
            modelDepartmentInfo = bllDepartmentInfo.GetModel(departmentID);
            kryptonComboBoxDepartment.SelectedText = modelDepartmentInfo.DepartmentName;

            modelCompanyInfo = bllCompanyInfo.GetModelList("CompanyName='" + modelDepartmentInfo.CompanyName + "'")[0];
            kryptonComboBoxCompany.SelectedText = modelCompanyInfo.CompanyName;

            #endregion

            #region 卡片信息1
            if (!string.IsNullOrEmpty(modelUserInfo.PrimaryCardID.Trim()))
                modelCardInfo1 = bllCardInfo.GetModel(modelUserInfo.PrimaryCardID.Trim());
            if (modelCardInfo1 != null)
            {
                kryptonTextBoxCardID1.Text = modelUserInfo.PrimaryCardID;
                kryptonTextBoxCardVersion1.Text = modelCardInfo1.CardVersion != null ? modelCardInfo1.CardVersion.Trim() :"";
                kryptonTextBoxCardType1.Text = (modelCardInfo1.CardType.HasValue ?modelCardInfo1.CardType.Value: 0).ToString()  ;
                kryptonTextBoxCardLevel1.Text = modelCardInfo1.CardLevel != null ? modelCardInfo1.CardLevel.Trim() : "";
                kryptonTextBoxCardPassword1.Text = modelCardInfo1.CardPassword != null ? modelCardInfo1.CardPassword.Trim() : "";
                if (RegexMatch.IsDate(modelCardInfo1.CardIssueDateTime))
                    kryptonDateTimePickerCardIssueDateTime1.Value = Convert.ToDateTime(modelCardInfo1.CardIssueDateTime);
                if (RegexMatch.IsDate(modelCardInfo1.CardValidDateTime))
                kryptonDateTimePickerCardValidDateTime1.Value = Convert.ToDateTime(modelCardInfo1.CardValidDateTime);

            }
            #endregion

            #region 卡片信息2
            if (!string.IsNullOrEmpty(modelUserInfo.SecondCardID.Trim()))
                modelCardInfo2 = bllCardInfo.GetModel(modelUserInfo.SecondCardID.Trim());
            if (modelCardInfo2 != null)
            {
                kryptonTextBoxCardID2.Text = modelUserInfo.SecondCardID;
                kryptonTextBoxCardVersion2.Text = modelCardInfo2.CardVersion != null ? modelCardInfo2.CardVersion.Trim() : "";
                kryptonTextBoxCardType2.Text = (modelCardInfo2.CardType.HasValue ? modelCardInfo2.CardType.Value : 0).ToString();
                kryptonTextBoxCardLevel2.Text = modelCardInfo2.CardLevel != null ? modelCardInfo2.CardLevel.Trim() : "";
                kryptonTextBoxCardPassword2.Text = modelCardInfo2.CardPassword != null ? modelCardInfo2.CardPassword.Trim() : "";
                if (RegexMatch.IsDate(modelCardInfo2.CardIssueDateTime))
                    kryptonDateTimePickerCardIssueDateTime2.Value = Convert.ToDateTime(modelCardInfo2.CardIssueDateTime);
                if (RegexMatch.IsDate(modelCardInfo2.CardValidDateTime))
                    kryptonDateTimePickerCardValidDateTime2.Value = Convert.ToDateTime(modelCardInfo2.CardValidDateTime);

            }
            #endregion

            #region 生物信息
            pictureBoxPhotograph.Image = MyImageOperate.getImageByByte(modelUserInfo.Photograph);
            pictureBoxFingerPrint1.Image = MyImageOperate.getImageByByte(modelUserInfo.FingerPrint0);
            pictureBoxFingerPrint2.Image = MyImageOperate.getImageByByte(modelUserInfo.FingerPrint1);
            #endregion
        }
        private void InitComboBoxCompany() 
        {
            AccessDataBase.BLL.CompanyInfo bllCompanyInfo = new AccessDataBase.BLL.CompanyInfo();
            DataTable dt = bllCompanyInfo.GetAllList().Tables[0];

            kryptonComboBoxCompany.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                kryptonComboBoxCompany.Items.Add(row["CompanyName"]);
            }
        }
        private void InitComboBoxDepartment()
        {
            bllDepartmentInfo = new AccessDataBase.BLL.DepartmentInfo();
            listModelDepartment = bllDepartmentInfo.GetModelList("1=1");

            kryptonComboBoxDepartment.Items.Clear();
            foreach (AccessDataBase.Model.DepartmentInfo modelDepartment in listModelDepartment)
            {
                kryptonComboBoxDepartment.Items.Add(modelDepartment.DepartmentName);
            }

        }
        private void kryptonButtonOK_Click(object sender, EventArgs e)
        {
            int cardType = 0;
            string dateMatch;
            #region 基本信息
            modelUserInfo.UserID = int.Parse(kryptonTextBoxUserID.Text);
            modelUserInfo.UserName = kryptonTextBoxUserName.Text.Trim();
            modelUserInfo.DepartmentID = bllDepartmentInfo.GetModelList("DepartmentName='" + kryptonComboBoxDepartment.Text.Trim() + "'")[0].DepartmentID;
            #endregion
            #region 个人信息
            //modelUserInfo.DepartmentID =
            #endregion
            #region 卡片信息1
            if (kryptonCheckBoxCardInfo1.Enabled == true)
            {
                modelCardInfo1.CardID = kryptonTextBoxCardID1.Text.Trim();
                modelUserInfo.PrimaryCardID = modelCardInfo1.CardID;
                if (string.IsNullOrEmpty(modelUserInfo.PrimaryCardID))
                {
                    MyMessageBox.MessageBoxOK("卡1号不能为空");
                    return;
                }
                modelCardInfo1.CardVersion = kryptonTextBoxCardVersion1.Text.Trim();

                if (int.TryParse(kryptonTextBoxCardType1.Text.Trim(), out cardType))
                    modelCardInfo1.CardType = cardType;

                modelCardInfo1.CardLevel = kryptonTextBoxCardLevel1.Text.Trim();
                modelCardInfo1.CardPassword = kryptonTextBoxCardPassword1.Text.Trim();

                dateMatch = kryptonDateTimePickerCardIssueDateTime1.Value.ToShortDateString();
                if (RegexMatch.IsDate(dateMatch))
                    modelCardInfo1.CardIssueDateTime = dateMatch;

                dateMatch = kryptonDateTimePickerCardValidDateTime1.Value.ToShortDateString();
                if (RegexMatch.IsDate(dateMatch))
                    modelCardInfo1.CardValidDateTime = dateMatch;
            }
            else
            {
                modelUserInfo.PrimaryCardID = null;
            }
            #endregion
            #region 卡片信息2
            if (kryptonCheckBoxCardInfo1.Enabled == true)
            {
                modelCardInfo2.CardID = kryptonTextBoxCardID2.Text.Trim();
                modelUserInfo.SecondCardID = modelCardInfo2.CardID;
                if (string.IsNullOrEmpty(modelUserInfo.SecondCardID))
                {
                    MyMessageBox.MessageBoxOK("卡2号不能为空");
                    return;
                }
                modelCardInfo2.CardVersion = kryptonTextBoxCardVersion2.Text.Trim();

                if (int.TryParse(kryptonTextBoxCardType2.Text.Trim(), out cardType))
                    modelCardInfo2.CardType = cardType;

                modelCardInfo2.CardLevel = kryptonTextBoxCardLevel2.Text.Trim();
                modelCardInfo2.CardPassword = kryptonTextBoxCardPassword2.Text.Trim();

                dateMatch = kryptonDateTimePickerCardIssueDateTime2.Value.ToShortDateString();
                if (RegexMatch.IsDate(dateMatch))
                    modelCardInfo2.CardIssueDateTime = dateMatch;

                dateMatch = kryptonDateTimePickerCardValidDateTime2.Value.ToShortDateString();
                if (RegexMatch.IsDate(dateMatch))
                    modelCardInfo2.CardValidDateTime = dateMatch;
            }
            else
            {
                modelUserInfo.SecondCardID = null;
            }
            #endregion
            #region 生物信息
            modelUserInfo.FingerPosition0 = (kryptonComboBox2.SelectedIndex + 1) + kryptonComboBox1.SelectedIndex;
            modelUserInfo.FingerPosition1 = (kryptonComboBox3.SelectedIndex + 1) + kryptonComboBox4.SelectedIndex;
            modelUserInfo.FingerPrint0 = MyImageOperate.getByteByImage(pictureBoxFingerPrint1.Image);
            modelUserInfo.FingerPrint1 = MyImageOperate.getByteByImage(pictureBoxFingerPrint2.Image);
            modelUserInfo.Photograph = MyImageOperate.getByteByImage(pictureBoxPhotograph.Image);
            #endregion

            if (this.openMode == OpenMode.Add)
            {
                if ((kryptonCheckBoxCardInfo1.Enabled == true)&&(bllCardInfo.Exists(modelCardInfo1.CardID)))
                    MyMessageBox.MessageBoxOK("卡1已经存在，不能添加");
                else if ((kryptonCheckBoxCardInfo2.Enabled == true) && (bllCardInfo.Exists(modelCardInfo2.CardID)))
                    MyMessageBox.MessageBoxOK("卡2已经存在，不能添加");
                else if (bllUserInfo.Exists(modelUserInfo.UserID))
                    MyMessageBox.MessageBoxOK("用户信息已经存在，不能添加");
                else if (bllCardInfo.Add(modelCardInfo1) == false)
                    MyMessageBox.MessageBoxOK("添加卡1失败");
                else if (bllCardInfo.Add(modelCardInfo2) == false)
                    MyMessageBox.MessageBoxOK("添加卡2失败");
                else if (bllUserInfo.Add(modelUserInfo) == false)
                    MyMessageBox.MessageBoxOK("添加用户信息失败");
                else
                    this.Close();
            }
            else if (this.openMode == OpenMode.Update)
            {
                if ((kryptonCheckBoxCardInfo1.Enabled == true) && (bllCardInfo.Update(modelCardInfo1) == false))
                    MyMessageBox.MessageBoxOK("修改卡1失败");
                else if ((kryptonCheckBoxCardInfo2.Enabled == true) && (bllCardInfo.Update(modelCardInfo2) == false))
                    MyMessageBox.MessageBoxOK("修改卡2信息失败");
                else if (bllUserInfo.Update(modelUserInfo) == false)
                    MyMessageBox.MessageBoxOK("修改用户信息失败");
                this.Close();
            }


        }

        private void kryptonButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButtonReadFingerPrint1_Click(object sender, EventArgs e)
        {
            string pictureFilePath = null;
            OpenFileDialog FileDialog = new OpenFileDialog();

            FileDialog.Filter = "*.BMP,*.JPG;*.GIF,*.PNG|*.BMP;*.JPG;*.GIF;*.PNG";
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureFilePath = FileDialog.FileName.ToString(); //获得文件路径 
                Image a = Image.FromFile(pictureFilePath);

                double scanle = Convert.ToDouble(pictureBoxFingerPrint1.Width) / a.Width;
                // PublicClass.scaleImage(a, scanle);
                pictureBoxFingerPrint1.Image = MyImageOperate.scaleImage(a, scanle);

            }
        }

        private void kryptonButtonReadFingerPrint2_Click(object sender, EventArgs e)
        {
            string pictureFilePath = null;
            OpenFileDialog FileDialog = new OpenFileDialog();

            FileDialog.Filter = "*.BMP,*.JPG;*.GIF,*.PNG|*.BMP;*.JPG;*.GIF;*.PNG";
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureFilePath = FileDialog.FileName.ToString(); //获得文件路径 
                Image a = Image.FromFile(pictureFilePath);

                double scanle = Convert.ToDouble(pictureBoxFingerPrint2.Width) / a.Width;
                // PublicClass.scaleImage(a, scanle);
                pictureBoxFingerPrint2.Image = MyImageOperate.scaleImage(a, scanle);

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPhotograph_Click(object sender, EventArgs e)
        {
            string pictureFilePath = null;
            OpenFileDialog FileDialog = new OpenFileDialog();

            FileDialog.Filter = "*.BMP,*.JPG;*.GIF,*.PNG|*.BMP;*.JPG;*.GIF;*.PNG";
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureFilePath = FileDialog.FileName.ToString(); //获得文件路径 
                Image a = Image.FromFile(pictureFilePath);

                double scanle = Convert.ToDouble(pictureBoxPhotograph.Width) / a.Width;
                // PublicClass.scaleImage(a, scanle);
                pictureBoxPhotograph.Image = MyImageOperate.scaleImage(a, scanle);

            }
        }

        private void kryptonCheckBoxCardInfo1_CheckedChanged(object sender, EventArgs e)
        {

            kryptonGroupBoxPrimaryCard.Panel.Enabled = kryptonCheckBoxCardInfo1.Checked;
        }

        private void kryptonCheckBoxCardInfo2_CheckedChanged(object sender, EventArgs e)
        {
            kryptonGroupBoxSecondCardInfo.Panel.Enabled = kryptonCheckBoxCardInfo2.Checked;
        }
    }
}