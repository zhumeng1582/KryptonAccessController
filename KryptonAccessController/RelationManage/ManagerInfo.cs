using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.WidgetThread;
using KryptonAccessController.ResourcesFile;
using KryptonAccessController.Common;

namespace KryptonAccessController.RelationManage
{
    public partial class ManagerInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.Model.Manager modeManagerInfo = new AccessDataBase.Model.Manager();
        AccessDataBase.BLL.Manager bllManagerInfo = new AccessDataBase.BLL.Manager();

        private static object obj = new object();
        static ManagerInfo _instance = null;
        public static ManagerInfo getInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new ManagerInfo();
                    }
                }
            }
            return _instance;
        }
        private ManagerInfo()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = GetResourcesFile.getSystemIco();

            initToolStripMenu();
            refreshDataGridView();
        }

        public void refreshDataGridView()
        {
            DataTable dt = bllManagerInfo.GetAllList().Tables[0];

            dataGridViewWithCheckBox1.DataSource = dt;
        }

        public void initToolStripMenu()
        {
            toolStripManagerInfo.Items.Clear();
            ImageOperate.AddButtonItemToToolStrip(toolStripManagerInfo, "add.BMP", "Add", toolStripButtonAddUserInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripManagerInfo, "update.BMP", "Update", toolStripButtonUpdateUserInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripManagerInfo, "delete.BMP", "Del", toolStripButtonDeleteUserInfo_Click);
            
        }
        public void toolStripButtonAddUserInfo_Click(object sender, EventArgs e)
        {
            FormManager formController = new FormManager(modeManagerInfo, OpenMode.Add);
            formController.ShowDialog();
            this.refreshDataGridView();
        }
        public void toolStripButtonUpdateUserInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewWithCheckBox1.CurrentRow == null)
                return;

            int selectIndex = dataGridViewWithCheckBox1.CurrentRow.Index;
            string managerName = dataGridViewWithCheckBox1["ManagerName", selectIndex].Value.ToString().Trim();

            modeManagerInfo = bllManagerInfo.GetModelList("ManagerName = '" + managerName + "'")[0];

            FormManager formController = new FormManager(modeManagerInfo, OpenMode.Update);
            formController.ShowDialog();
            this.refreshDataGridView();
        }
        public void toolStripButtonDeleteUserInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewWithCheckBox1.CurrentRow == null)
                return;

            int selectIndex = dataGridViewWithCheckBox1.CurrentRow.Index;
            string managerName = dataGridViewWithCheckBox1["ManagerName", selectIndex].Value.ToString().Trim();
            
            modeManagerInfo = bllManagerInfo.GetModelList("ManagerName = '" + managerName + "'")[0];
            if (bllManagerInfo.Delete(modeManagerInfo.ManagerID, modeManagerInfo.ManagerName) == false)
            {
                
                MyMessageBox.MessageBoxOK("É¾³ýÓÃ»§Ê§°Ü£¿");
            }
        }

    }
}