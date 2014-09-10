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

namespace KryptonAccessController.RelationController
{
    public partial class ControllerInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
        AccessDataBase.Model.ControllerInfo modeControllerInfo = new AccessDataBase.Model.ControllerInfo();

        AccessDataBase.Model.DoorUnitInfo modelDoorUnitInfo = new AccessDataBase.Model.DoorUnitInfo();
        AccessDataBase.Model.DoorUnitInfo[] arraryModelDoorUnitInfo = new AccessDataBase.Model.DoorUnitInfo[4];
        AccessDataBase.BLL.DoorUnitInfo bllDoorUnitInfo = new AccessDataBase.BLL.DoorUnitInfo();

        AccessDataBase.BLL.ReaderInfo bllReaderInfo = new AccessDataBase.BLL.ReaderInfo();
        AccessDataBase.Model.ReaderInfo modelReaderInfo = new AccessDataBase.Model.ReaderInfo();

        AccessDataBase.BLL.ReaderTimeAccess bllReaderTimeAccess = new AccessDataBase.BLL.ReaderTimeAccess();
        AccessDataBase.Model.ReaderTimeAccess modelReaderTimeAccess = new AccessDataBase.Model.ReaderTimeAccess();

        AccessDataBase.BLL.ReaderHoliday bllReaderHoliday = new AccessDataBase.BLL.ReaderHoliday();
        List<AccessDataBase.Model.ReaderHoliday> listModelReaderHoliday = new List<AccessDataBase.Model.ReaderHoliday>();
        AccessDataBase.Model.ReaderHoliday modelReaderHoliday = new AccessDataBase.Model.ReaderHoliday();

        AccessDataBase.BLL.ReaderTimeZone bllReaderTimeZone = new AccessDataBase.BLL.ReaderTimeZone();
        AccessDataBase.Model.ReaderTimeZone modelReaderTimeZone = new AccessDataBase.Model.ReaderTimeZone();


        private static object obj = new object();
        static ControllerInfo _instance = null;
        public static ControllerInfo getInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new ControllerInfo(); 
                    }
                }
            }
            return _instance;
        }
        private ControllerInfo()
        {
            InitializeComponent();
            //dataGridViewWithCheckBox1.updateGridviewRow += updateGridViewWithCheckBoxRow;
            initToolStripMenu();
            refreshDataGridView();

        }

        public void refreshDataGridView() 
        {
            kryptonDataGridView1.DataSource = bllControllerInfo.GetAllList().Tables[0];
            //DataTableCollection
        }
        public void initToolStripMenu()
        {
            toolStripControllerInfo.Items.Clear();

            ImageOperate.AddButtonItemToToolStrip(toolStripControllerInfo, "add.BMP", "Add", toolStripButtonAddControllerInfoInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripControllerInfo, "update.BMP", "Update", toolStripButtonUpdateUserInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripControllerInfo, "delete.BMP", "Del", toolStripButtonDeleteControllerInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripControllerInfo, "download.BMP", "save to device", toolStripButtonDownLoadControllerInfo_Click);
 
        }
        private void toolStripButtonAddControllerInfoInfo_Click(object sender, EventArgs e)
        {
            AccessDataBase.Model.ControllerInfo modeControllerInfo = new AccessDataBase.Model.ControllerInfo();

            AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
            modeControllerInfo.ControllerID = bllControllerInfo.GetMaxId();

            FormController formController = new FormController(modeControllerInfo, OpenMode.Add);
            formController.ShowDialog();
            this.refreshDataGridView();
        }
        /*
        public  void updateGridViewWithCheckBoxRow(object sender, DataGridViewCellEventArgs e)
        {
            if (kryptonDataGridView1.Rows.Count <= 0)
                return;
            AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
            int selectIndex = kryptonDataGridView1.CurrentRow.Index;

            string controllerID = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();

            AccessDataBase.Model.ControllerInfo modeControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerID));
            FormController formController = new FormController(modeControllerInfo, OpenMode.Update);
            formController.ShowDialog();

            this.refreshDataGridView();
        }*/
        private void toolStripButtonUpdateUserInfo_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.CurrentRow == null)
                return;

            AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
            int selectIndex = kryptonDataGridView1.CurrentRow.Index;

            string controllerID = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();

            AccessDataBase.Model.ControllerInfo modeControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerID));
            FormController formController = new FormController(modeControllerInfo,OpenMode.Update);
            formController.ShowDialog();

            this.refreshDataGridView();
        }
        private ReturnValue deleteReaderZone(int? readerTimeZoneID)
        {
            if (!readerTimeZoneID.HasValue)
                return ReturnValue.NotExist;
            if (!bllReaderTimeZone.Exists(readerTimeZoneID.Value))
                return ReturnValue.NotExist;
           
            if (bllReaderTimeZone.Delete(readerTimeZoneID.Value))
                return ReturnValue.Success;
            else
                return ReturnValue.Unkonwn;

        }
        private ReturnValue deleteReaderTimeAccess(int? readerTimeAccessID)
        {
            if (!readerTimeAccessID.HasValue)
                return ReturnValue.NotExist;
            if (!bllReaderTimeAccess.Exists(readerTimeAccessID.Value))
                return ReturnValue.NotExist;

            modelReaderTimeAccess = new AccessDataBase.Model.ReaderTimeAccess();
            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(readerTimeAccessID.Value);

            deleteReaderZone(modelReaderTimeAccess.Mon);
            deleteReaderZone(modelReaderTimeAccess.Thu);
            deleteReaderZone(modelReaderTimeAccess.Tue);
            deleteReaderZone(modelReaderTimeAccess.Wed);
            deleteReaderZone(modelReaderTimeAccess.Fri);
            deleteReaderZone(modelReaderTimeAccess.Sat);
            deleteReaderZone(modelReaderTimeAccess.Sun);

            if (bllReaderTimeAccess.Delete(modelReaderTimeAccess.ReaderTimeAccessID))
                return ReturnValue.Success;
            else
                return ReturnValue.Unkonwn;
        }
        private ReturnValue deleteReaderHoliday(int? readerID)
        {
            if (!readerID.HasValue)
                return ReturnValue.NotExist;
            if (!bllReaderInfo.Exists(readerID.Value))
                    return ReturnValue.NotExist;

            listModelReaderHoliday = bllReaderHoliday.GetModelList("ReaderID = " + readerID.Value);
            foreach (AccessDataBase.Model.ReaderHoliday modelReaderHoliday in listModelReaderHoliday)
            {
                bllReaderHoliday.Delete(modelReaderHoliday.ReaderHolidayID);
            }
            return ReturnValue.Success;
        }
        private ReturnValue deleteReader(int? readerID)
        {
            if (!readerID.HasValue)
                return ReturnValue.NotExist;
            if (!bllReaderInfo.Exists(readerID.Value))
                return ReturnValue.NotExist;

            modelReaderInfo = new AccessDataBase.Model.ReaderInfo();
            modelReaderInfo = bllReaderInfo.GetModel(readerID.Value);

            deleteReaderTimeAccess(modelReaderInfo.ReadTimeAccessID);
            deleteReaderHoliday(modelReaderInfo.ReaderID);

            if (bllReaderInfo.Delete(modelReaderInfo.ReaderID))
                return ReturnValue.Success;
            else
                return ReturnValue.Unkonwn;
        }
        private ReturnValue deleteDooorUnit(int? DoorUnitID)
        {
            if (!DoorUnitID.HasValue)
                return ReturnValue.NotExist;
            if (!bllDoorUnitInfo.Exists(DoorUnitID.Value))
                return ReturnValue.NotExist;

            modelDoorUnitInfo = new AccessDataBase.Model.DoorUnitInfo();
            modelDoorUnitInfo = bllDoorUnitInfo.GetModel(DoorUnitID.Value);

            if (bllDoorUnitInfo.Delete(modelDoorUnitInfo.DoorUnitID))
            {
                deleteReader(modelDoorUnitInfo.ReadID1);
                deleteReader(modelDoorUnitInfo.ReadID2);
                return ReturnValue.Success;
            }
            else
                return ReturnValue.Unkonwn;

            
        }

        private ReturnValue deleteControllerInfo(int controllerID)
        {

            if (!bllControllerInfo.Exists(controllerID))
                return ReturnValue.NotExist;

            modeControllerInfo = new AccessDataBase.Model.ControllerInfo();
            modeControllerInfo.ControllerID = controllerID;
            modeControllerInfo = bllControllerInfo.GetModel(modeControllerInfo.ControllerID);
 
            deleteDooorUnit(modeControllerInfo.DoorUnitID1);   
            deleteDooorUnit(modeControllerInfo.DoorUnitID2);  
            deleteDooorUnit(modeControllerInfo.DoorUnitID3); 
            deleteDooorUnit(modeControllerInfo.DoorUnitID4);
           
            if (bllControllerInfo.Delete(modeControllerInfo.ControllerID))
                return ReturnValue.Success;
            else
                return ReturnValue.Unkonwn;

            
        }
        private void toolStripButtonDeleteControllerInfo_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.CurrentRow == null)
                return;
            if (MyMessageBox.MessageBoxOkCancel("控制器信息删除后不能恢复,是否删除?") == System.Windows.Forms.DialogResult.Cancel)
                return;
            bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();

            int selectIndex = kryptonDataGridView1.CurrentRow.Index;
            string controllerIDStr = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();
            int controllerIDInt;
            modeControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerIDStr));

            if(int.TryParse(controllerIDStr,out controllerIDInt))
                deleteControllerInfo(controllerIDInt);

            this.refreshDataGridView();
        }
        private void toolStripButtonDownLoadControllerInfo_Click(object sender, EventArgs e)
        {
            AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
            if (MyMessageBox.MessageBoxOkCancel("下载控制器信息至设备?") == System.Windows.Forms.DialogResult.Cancel)
                return;
            int selectIndex = kryptonDataGridView1.CurrentRow.Index;
            string controllerID = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();

            AccessDataBase.Model.ControllerInfo modeControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerID));
            /*
             * 调用API函数
             */

        }

        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}