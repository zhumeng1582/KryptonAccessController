using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.Common;
using KryptonAccessController.ResourcesFile;

namespace KryptonAccessController.RelationUser
{
    public partial class FormCard : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private OpenMode openMode;
        private AccessDataBase.Model.CardInfo modelCardInfo = new AccessDataBase.Model.CardInfo();
        private AccessDataBase.BLL.CardInfo bllCardInfo = new AccessDataBase.BLL.CardInfo();
        public FormCard(AccessDataBase.Model.CardInfo cardInfo, OpenMode openMode)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = GetResourcesFile.getSystemIco();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.modelCardInfo = cardInfo;
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
            //kryptonTextBoxCardID.Text = modelCardInfo.CardID;
        }
        /// <summary>
        /// 显示更新参数
        /// </summary>
        private void showUpdatePara()
        {
            kryptonTextBoxCardID.Text = modelCardInfo.CardID;
            kryptonTextBoxCardVersion.Text = modelCardInfo.CardVersion != null ? modelCardInfo.CardVersion.Trim() : "";
            kryptonComboBoxCardType.Text = (modelCardInfo.CardType.HasValue ? modelCardInfo.CardType.Value : 0).ToString();
            kryptonComboBoxCardLevel.Text = modelCardInfo.CardLevel != null ? modelCardInfo.CardLevel.Trim() : "";
            kryptonTextBoxCardPassword.Text = modelCardInfo.CardPassword != null ? modelCardInfo.CardPassword.Trim() : "";
            if (RegexMatch.IsDate(modelCardInfo.CardIssueDateTime))
                kryptonDateTimePickerCardIssueDateTime.Value = Convert.ToDateTime(modelCardInfo.CardIssueDateTime);
            if (RegexMatch.IsDate(modelCardInfo.CardValidDateTime))
                kryptonDateTimePickerCardValidDateTime.Value = Convert.ToDateTime(modelCardInfo.CardValidDateTime);
        }
        private void kryptonButtonOK_Click(object sender, EventArgs e)
        {
            int cardType = 0;
            string dateMatch;
            modelCardInfo.CardID = kryptonTextBoxCardID.Text.Trim();
            modelCardInfo.CardVersion = kryptonTextBoxCardVersion.Text.Trim();

            if (int.TryParse(kryptonComboBoxCardType.Text.Trim(), out cardType))
                modelCardInfo.CardType = cardType;

            modelCardInfo.CardLevel = kryptonComboBoxCardLevel.Text.Trim();
            modelCardInfo.CardPassword = kryptonTextBoxCardPassword.Text.Trim();

            dateMatch = kryptonDateTimePickerCardIssueDateTime.Value.ToShortDateString();
            if (RegexMatch.IsDate(dateMatch))
                modelCardInfo.CardIssueDateTime = dateMatch;

            dateMatch = kryptonDateTimePickerCardValidDateTime.Value.ToShortDateString();
            if (RegexMatch.IsDate(dateMatch))
                modelCardInfo.CardValidDateTime = dateMatch;

            if (openMode == OpenMode.Add)
            {
                if (bllCardInfo.Add(modelCardInfo) == false)
                    MyMessageBox.MessageBoxOK("添加卡片失败");
                else
                    this.Close();
            }
            else if (openMode == OpenMode.Update)
            {
                if (bllCardInfo.Update(modelCardInfo) == false)
                    MyMessageBox.MessageBoxOK("修改卡片失败");
                else
                    this.Close();
            }
        }

        private void kryptonButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}