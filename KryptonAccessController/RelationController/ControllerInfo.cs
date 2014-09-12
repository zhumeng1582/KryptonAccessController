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
        AccessDataBase.Model.ControllerInfo modelControllerInfo = new AccessDataBase.Model.ControllerInfo();

        AccessDataBase.BLL.ExpansionBoardInfo bllExpansionBoardInfo = new AccessDataBase.BLL.ExpansionBoardInfo();
        AccessDataBase.Model.ExpansionBoardInfo modelExpansionBoardInfo = new AccessDataBase.Model.ExpansionBoardInfo();

        AccessDataBase.BLL.ExpansionBoardPointInfo bllExpansionBoardPointInof = new AccessDataBase.BLL.ExpansionBoardPointInfo();
        AccessDataBase.Model.ExpansionBoardPointInfo modelExpansionBoardPointInfo = new AccessDataBase.Model.ExpansionBoardPointInfo();

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
            //this.refreshDataGridView();
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
            modelControllerInfo.ControllerID = bllControllerInfo.GetMaxId();

            FormController formController = new FormController(modelControllerInfo, OpenMode.Add);
            formController.ShowDialog();

            refreshDataGridView();
        }
        /*
        public  void updateGridViewWithCheckBoxRow(object sender, DataGridViewCellEventArgs e)
        {
            if (kryptonDataGridView1.Rows.Count <= 0)
                return;
            AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
            int selectIndex = kryptonDataGridView1.CurrentRow.Index;

            string controllerID = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();

            AccessDataBase.Model.ControllerInfo modelControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerID));
            FormController formController = new FormController(modelControllerInfo, OpenMode.Update);
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

            AccessDataBase.Model.ControllerInfo modelControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerID));
            FormController formController = new FormController(modelControllerInfo,OpenMode.Update);
            formController.ShowDialog();

            refreshDataGridView();
        }
        
        #region 删除控制器信息
        private ReturnValue deleteControllerInfo(int controllerID)
        {
            bool ret = bllControllerInfo.Exists(controllerID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + controllerID + "的控制器不存在");
                return ReturnValue.NotExist;
            }

            ret = bllControllerInfo.Delete(controllerID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除控制器信息失败，控制器ID为：" + controllerID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除扩展板端口信息
        private ReturnValue deleteExpansionBoardPointInfo(int expansionBoardInfoID)
        {
            bool ret = bllExpansionBoardInfo.Exists(expansionBoardInfoID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + expansionBoardInfoID + "的扩展板不存在");
                return ReturnValue.NotExist;
            }

            ret = bllExpansionBoardPointInof.DeleteList("select ExpansionBoardPointID from ExpansionBoardPointInfo where ExpansionBoardID=" + expansionBoardInfoID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除扩展板端口信息失败，扩展板ID为：" + expansionBoardInfoID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除扩展板信息
        private ReturnValue deleteExpansionBoardInfo(int expansionBoardInfoID)
        {

            bool ret = bllExpansionBoardInfo.Exists(expansionBoardInfoID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + expansionBoardInfoID + "的扩展板不存在");
                return ReturnValue.NotExist;
            }
            
            ret = bllExpansionBoardInfo.Delete(expansionBoardInfoID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除扩展板信息失败，扩展板ID为：" + expansionBoardInfoID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除门单元
        private ReturnValue deleteDooorUnit(int doorUnitID)
        {
            bool ret = bllDoorUnitInfo.Exists(doorUnitID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + doorUnitID + "的门单元不存在");
                return ReturnValue.NotExist;
            }

            ret = bllDoorUnitInfo.Delete(doorUnitID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除门单元信息失败，门单元ID为：" + doorUnitID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除读卡器节假日工作模式信息
        private ReturnValue deleteReaderHoliday(int readerID)
        {

            bool ret = bllReaderHoliday.Exists(readerID);
            if (ret == false)
            {
                return ReturnValue.NotExist;
            }

            ret = bllReaderHoliday.DeleteList("select ReaderHolidayID from ReaderHoliday where ReaderID =" + readerID);

            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除读卡器节假日信息失败，读卡器ID为：" + readerID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除读卡器信息
        private ReturnValue deleteReaderInfo(int readerInfoID)
        {
            bool ret = bllReaderInfo.Exists(readerInfoID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + readerInfoID + "的读卡器不存在");
                return ReturnValue.NotExist;
            }

            ret = bllReaderInfo.Delete(readerInfoID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除读卡器信息失败，读卡器ID为：" + readerInfoID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除读卡器周工作模式信息
        private ReturnValue deleteReaderTimeAccess(int readerTimeAccessID)
        {
            bool ret = bllReaderTimeAccess.Exists(readerTimeAccessID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + readerTimeAccessID + " 的读卡器周工作模式不存在");
                return ReturnValue.NotExist;
            }
            
            ret = bllReaderTimeAccess.Delete(readerTimeAccessID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除读卡器周工作模式信息失败，读卡器周工作模式ID为：" + readerTimeAccessID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion

        #region 删除读卡器工作时区表
        private ReturnValue deleteReaderTimeZone(int readerTimeZoneID)
        {
            bool ret = bllReaderTimeZone.Exists(readerTimeZoneID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("ID为：" + readerTimeZoneID + "的读卡器工作时区不存在");
                return ReturnValue.NotExist;
            }
            
            ret = bllReaderTimeZone.Delete(readerTimeZoneID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("删除读卡器时区信息失败，时区信息ID为：" + readerTimeZoneID);
                return ReturnValue.Fail;
            }
            return ReturnValue.Success;
        }
        #endregion
        
        private void toolStripButtonDeleteControllerInfo_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.CurrentRow == null)
                return;
            if (MyMessageBox.MessageBoxOkCancel("控制器信息删除后不能恢复,是否删除?") == System.Windows.Forms.DialogResult.Cancel)
                return;

            int selectIndex = kryptonDataGridView1.CurrentRow.Index;
            string controllerIDStr = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();
            int controllerIDInt;
            
            if (int.TryParse(controllerIDStr, out controllerIDInt))
            {

                #region 删除控制器信息
                modelControllerInfo = bllControllerInfo.GetModel(controllerIDInt);
                if (modelControllerInfo == null)
                    return;
                deleteControllerInfo(controllerIDInt);
                #endregion

                #region 删除扩展板

                #region 删除扩展板1
                if (modelControllerInfo.ExpansionBoardID1.HasValue & modelControllerInfo.ExpansionBoardID1 != 0)
                {
                    deleteExpansionBoardPointInfo(modelControllerInfo.ExpansionBoardID1.Value);
                    deleteExpansionBoardInfo(modelControllerInfo.ExpansionBoardID1.Value);
                }
                #endregion

                #region 删除扩展板2
                if (modelControllerInfo.ExpansionBoardID2.HasValue & modelControllerInfo.ExpansionBoardID2 != 0)
                {
                    deleteExpansionBoardPointInfo(modelControllerInfo.ExpansionBoardID2.Value);
                    deleteExpansionBoardInfo(modelControllerInfo.ExpansionBoardID2.Value);
                }
                #endregion

                #region 删除扩展板3
                if (modelControllerInfo.ExpansionBoardID3.HasValue & modelControllerInfo.ExpansionBoardID3 != 0)
                {
                    deleteExpansionBoardPointInfo(modelControllerInfo.ExpansionBoardID3.Value);
                    deleteExpansionBoardInfo(modelControllerInfo.ExpansionBoardID3.Value);
                }
                #endregion

                #region 删除扩展4
                if (modelControllerInfo.ExpansionBoardID4.HasValue & modelControllerInfo.ExpansionBoardID4 != 0)
                {
                    deleteExpansionBoardPointInfo(modelControllerInfo.ExpansionBoardID4.Value);
                    deleteExpansionBoardInfo(modelControllerInfo.ExpansionBoardID4.Value);
                }
                #endregion

                #endregion

                #region 删除门单元1
                //删除门单元
                if (modelControllerInfo.DoorUnitID1.HasValue & modelControllerInfo.DoorUnitID1.Value != 0)
                {
                    modelDoorUnitInfo = bllDoorUnitInfo.GetModel(modelControllerInfo.DoorUnitID1.Value);
                    if (modelDoorUnitInfo == null)
                        return;
                    deleteDooorUnit(modelDoorUnitInfo.DoorUnitID);

                    //删除读卡器信息
                    if (modelDoorUnitInfo.ReadID1.HasValue & modelDoorUnitInfo.ReadID1.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID1.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);

                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);

                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }

                    }
                    if (modelDoorUnitInfo.ReadID2.HasValue & modelDoorUnitInfo.ReadID2.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID2.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);
                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);
                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }
                    }
                }

                #endregion

                #region 删除门单元2
                //删除门单元
                if (modelControllerInfo.DoorUnitID2.HasValue & modelControllerInfo.DoorUnitID2.Value != 0)
                {
                    modelDoorUnitInfo = bllDoorUnitInfo.GetModel(modelControllerInfo.DoorUnitID2.Value);
                    if (modelDoorUnitInfo == null)
                        return;
                    deleteDooorUnit(modelDoorUnitInfo.DoorUnitID);

                    //删除读卡器信息
                    if (modelDoorUnitInfo.ReadID1.HasValue & modelDoorUnitInfo.ReadID1.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID1.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);

                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);

                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }

                    }
                    if (modelDoorUnitInfo.ReadID2.HasValue & modelDoorUnitInfo.ReadID2.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID2.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);
                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);
                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }
                    }
                }
                #endregion

                #region 删除门单元3
                //删除门单元
                if (modelControllerInfo.DoorUnitID3.HasValue & modelControllerInfo.DoorUnitID3.Value != 0)
                {
                    modelDoorUnitInfo = bllDoorUnitInfo.GetModel(modelControllerInfo.DoorUnitID3.Value);
                    if (modelDoorUnitInfo == null)
                        return;
                    deleteDooorUnit(modelDoorUnitInfo.DoorUnitID);

                    //删除读卡器信息
                    if (modelDoorUnitInfo.ReadID1.HasValue & modelDoorUnitInfo.ReadID1.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID1.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);

                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);

                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }

                    }
                    if (modelDoorUnitInfo.ReadID2.HasValue & modelDoorUnitInfo.ReadID2.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID2.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);
                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);
                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }
                    }
                }
                #endregion

                #region 删除门单元4
                //删除门单元
                if (modelControllerInfo.DoorUnitID4.HasValue & modelControllerInfo.DoorUnitID4.Value != 0)
                {
                    modelDoorUnitInfo = bllDoorUnitInfo.GetModel(modelControllerInfo.DoorUnitID4.Value);
                    if (modelDoorUnitInfo == null)
                        return;
                    deleteDooorUnit(modelDoorUnitInfo.DoorUnitID);

                    //删除读卡器信息
                    if (modelDoorUnitInfo.ReadID1.HasValue & modelDoorUnitInfo.ReadID1.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID1.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);

                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);

                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }

                    }
                    if (modelDoorUnitInfo.ReadID2.HasValue & modelDoorUnitInfo.ReadID2.Value != 0)
                    {
                        modelReaderInfo = bllReaderInfo.GetModel(modelDoorUnitInfo.ReadID2.Value);
                        if (modelReaderInfo == null)
                            return;

                        deleteReaderHoliday(modelReaderInfo.ReaderID);
                        deleteReaderInfo(modelReaderInfo.ReaderID);
                        //删除读卡器周工作模式
                        if (modelReaderInfo.ReadTimeAccessID.HasValue & modelReaderInfo.ReadTimeAccessID.Value != 0)
                        {
                            modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);
                            if (modelReaderTimeAccess == null)
                                return;

                            deleteReaderTimeAccess(modelReaderTimeAccess.ReaderTimeAccessID);
                            deleteReaderTimeZone(modelReaderTimeAccess.Mon.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Tue.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Wed.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Thu.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Fri.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sat.Value);
                            deleteReaderTimeZone(modelReaderTimeAccess.Sun.Value);

                        }
                    }
                }
                #endregion

                
            }
            refreshDataGridView();
        }
        private void toolStripButtonDownLoadControllerInfo_Click(object sender, EventArgs e)
        {
            AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
            if (MyMessageBox.MessageBoxOkCancel("下载控制器信息至设备?") == System.Windows.Forms.DialogResult.Cancel)
                return;
            int selectIndex = kryptonDataGridView1.CurrentRow.Index;
            string controllerID = kryptonDataGridView1["ControllerID", selectIndex].Value.ToString().Trim();

            AccessDataBase.Model.ControllerInfo modelControllerInfo = bllControllerInfo.GetModel(int.Parse(controllerID));

            int doorUnitCounts =    (modelControllerInfo.DoorUnitEnable1 == true ? 1 : 0) +
                                    (modelControllerInfo.DoorUnitEnable2 == true ? 1 : 0) +
                                    (modelControllerInfo.DoorUnitEnable3 == true ? 1 : 0) +
                                    (modelControllerInfo.DoorUnitEnable4 == true ? 1 : 0);
            int expansionBoardCounts =
                (modelControllerInfo.ExpansionBoardEnable1 == true ? 1 : 0) +
                (modelControllerInfo.ExpansionBoardEnable2 == true ? 1 : 0) +
                (modelControllerInfo.ExpansionBoardEnable3 == true ? 1 : 0) +
                (modelControllerInfo.ExpansionBoardEnable4 == true ? 1 : 0);
           
            string data = 
                "ControllerID=" + modelControllerInfo.ControllerID+","+
                "ControllerType="+modelControllerInfo.ControllerType+","+
                "ControllerName='"+modelControllerInfo.ControllerName+"',"+
                "ControllerLocation='"+modelControllerInfo.ControllerLocation+"',"+
                "EncryptionType="+modelControllerInfo.CommunicateType+","+
                "ControllerVersion='"+modelControllerInfo.ControllerVersion+"',"+
                "ControllerMAC='"+modelControllerInfo.ControllerMAC+"',"+
                "ControllerIP='"+modelControllerInfo.ControllerIP+"',"+
                "ControllerSubnetMask='"+modelControllerInfo.ControllerSubnetMask+"',"+
                "ControllerGateway='"+modelControllerInfo.ControllerGateway+"',"+
                "ControllerPort="+modelControllerInfo.ControllerPort+","+
                "ControllerDNS='"+modelControllerInfo.ControllerDNS+"',"+
                "ControllerBUDNS='"+modelControllerInfo.ControllerBUDNS+"',"+
                "ControllerAddr485="+modelControllerInfo.ControllerAddr485+","+
                "ControllerBaudrate="+modelControllerInfo.ControllerBaudrate+","+
                "ControllerDataBits="+modelControllerInfo.ControllerDataBits+","+
                //"ControllerStopBits="+modelControllerInfo.ControllerStopBits+","+
                "ControllerStopBits=" + 1 + "," +
                "ControllerParityCheck='"+modelControllerInfo.ControllerParityCheck+"',"+
                "ControllerFlowControl='"+modelControllerInfo.ControllerFlowControl+"',"+
                "ControllerSAM="+modelControllerInfo.ControllerSAM+","+
                "ControllerSAMType="+modelControllerInfo.ControllerSAMType+","+
                "DoorUnitCounts=" + doorUnitCounts+ "," +
                "ExpansionBoardCounts=" + expansionBoardCounts;
            /*
             * 调用API函数
             */

        }

        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void ControllerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}