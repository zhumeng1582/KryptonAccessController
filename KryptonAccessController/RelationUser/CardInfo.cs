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

namespace KryptonAccessController.RelationUser
{
    public partial class CardInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private AccessDataBase.BLL.CardInfo bllCardInfo = new AccessDataBase.BLL.CardInfo();
        private AccessDataBase.Model.CardInfo modeCardInfo = new AccessDataBase.Model.CardInfo();

        private static object obj = new object();
        static CardInfo _instance = null;
        public static CardInfo getInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new CardInfo();
                    }
                }
            }
            return _instance;
        }
        public CardInfo()
        {
            InitializeComponent();

            initToolStripMenu();
            refreshDataGridView();
        }

        public void refreshDataGridView()
        {
            DataTable dt = bllCardInfo.GetAllList().Tables[0];

            dataGridViewWithCheckBox1.DataSource = dt;
        }
        public void initToolStripMenu()
        {
            toolStripCardInfo.Items.Clear();
            ImageOperate.AddButtonItemToToolStrip(toolStripCardInfo, "add.BMP", "Add", toolStripButtonAddUserInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripCardInfo, "update.BMP", "Update", toolStripButtonUpdateUserInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripCardInfo, "delete.BMP", "Del", toolStripButtonDeleteUserInfo_Click);
            
        }
        public void toolStripButtonAddUserInfo_Click(object sender, EventArgs e)
        {
            modeCardInfo = null;
            FormCard formUser = new FormCard(modeCardInfo, OpenMode.Add);
            formUser.ShowDialog();

            this.refreshDataGridView();
        }
        public void toolStripButtonUpdateUserInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewWithCheckBox1.CurrentRow == null)
                return;

            int selectIndex = dataGridViewWithCheckBox1.CurrentRow.Index;
            string CardID = dataGridViewWithCheckBox1["CardID", selectIndex].Value.ToString().Trim();

            modeCardInfo = bllCardInfo.GetModel(CardID);

            FormCard formUser = new FormCard(modeCardInfo, OpenMode.Update);
            formUser.ShowDialog();

            this.refreshDataGridView();
        }
        public void toolStripButtonDeleteUserInfo_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.MessageBoxOkCancel("È·¶¨ÒªÉ¾³ý¿¨Æ¬£¿") == System.Windows.Forms.DialogResult.Cancel)
                return;

            if (dataGridViewWithCheckBox1.CurrentRow == null)
                return;

            int selectIndex = dataGridViewWithCheckBox1.CurrentRow.Index;
            string CardID = dataGridViewWithCheckBox1["CardID", selectIndex].Value.ToString().Trim();

            if (bllCardInfo.Delete(CardID) == false)
            {
                MyMessageBox.MessageBoxOK("É¾³ý¿¨Æ¬Ê§°Ü£¿");
            }

        }
    }
}