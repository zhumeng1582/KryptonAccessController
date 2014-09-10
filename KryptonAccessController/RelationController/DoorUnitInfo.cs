using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.WidgetThread;

namespace KryptonAccessController.RelationController
{
    public partial class DoorUnitInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.BLL.DoorUnitInfo bllDoorUnitInfo = new AccessDataBase.BLL.DoorUnitInfo();
        AccessDataBase.Model.DoorUnitInfo modelDoorUnitInfo = new AccessDataBase.Model.DoorUnitInfo();

        private static object obj = new object();
        static DoorUnitInfo _instance = null;
        public static DoorUnitInfo getInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new DoorUnitInfo();
                    }
                }
            }
            return _instance;
        }

        private DoorUnitInfo()
        {
            InitializeComponent();
            refreshDataGridView();
            initToolStripMenu();

        }

        public void refreshDataGridView()
        {
            kryptonDataGridView1.DataSource = bllDoorUnitInfo.GetAllList().Tables[0];
        }
        public void initToolStripMenu()
        {
            toolStripDoorInfo.Items.Clear();

            ImageOperate.AddButtonItemToToolStrip(toolStripDoorInfo, "add.BMP", "Add", toolStripButtonAddDoorInfoInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripDoorInfo, "update.BMP", "Update", toolStripButtonUpdateDoorInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripDoorInfo, "delete.BMP", "Del", toolStripButtonDeleteDoorInfo_Click);  
        }
        private void toolStripButtonAddDoorInfoInfo_Click(object sender, EventArgs e)
        { }
        private void toolStripButtonUpdateDoorInfo_Click(object sender, EventArgs e)
        { }
        private void toolStripButtonDeleteDoorInfo_Click(object sender, EventArgs e)
        { }

    }
}