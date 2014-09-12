using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.ResourcesFile;
using KryptonAccessController.WidgetThread;
using KryptonAccessController.Common;
namespace KryptonAccessController.RelationController
{
    public partial class FormReaderInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.Model.ReaderInfo modelReaderInfo = new AccessDataBase.Model.ReaderInfo();
        AccessDataBase.BLL.ReaderInfo bllReaderInfo = new AccessDataBase.BLL.ReaderInfo();

        AccessDataBase.BLL.ReaderTimeAccess bllReaderTimeAccess = new AccessDataBase.BLL.ReaderTimeAccess();
        AccessDataBase.Model.ReaderTimeAccess modelReaderTimeAccess = new AccessDataBase.Model.ReaderTimeAccess();

        AccessDataBase.BLL.ReaderTimeZone bllReaderTimeZone = new AccessDataBase.BLL.ReaderTimeZone();
        AccessDataBase.Model.ReaderTimeZone[] arrarymodelReaderTimeZone = new AccessDataBase.Model.ReaderTimeZone[7];
        
        AccessDataBase.BLL.ReaderHoliday bllHoliday = new  AccessDataBase.BLL.ReaderHoliday();
        AccessDataBase.Model.ReaderHoliday modelHoliday = new AccessDataBase.Model.ReaderHoliday();
        List<AccessDataBase.Model.ReaderHoliday> listModelHoliday = new List<AccessDataBase.Model.ReaderHoliday>();
        

        private OpenMode openMode;

        public FormReaderInfo(AccessDataBase.Model.ReaderInfo modelReaderInfo, OpenMode openMode)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = GetResourcesFile.getSystemIco();

            this.modelReaderInfo = modelReaderInfo;
            this.openMode = openMode;
            for (int i = 0; i < 7; i++)
                arrarymodelReaderTimeZone[i] = new AccessDataBase.Model.ReaderTimeZone(); 

            if (openMode == OpenMode.Add)
            {
                showAddPara();
            }
            else if (openMode == OpenMode.Update)
            {
                this.modelReaderInfo = bllReaderInfo.GetModel(modelReaderInfo.ReaderID);
                showUpdatePara();
            }
        }
        
        private void showAddPara()
        {
            #region 读卡器基本参数
            kryptonTextBoxReaderID.Text = modelReaderInfo.ReaderID.ToString();

            #endregion 
            #region 读卡器周工作模式
            #region 读卡器工作时区
            #endregion
            #endregion
        }
        
        private Time1 getTimeFormReaderTimeZone(AccessDataBase.Model.ReaderTimeZone modelReaderTimeZone)
        {
            Time1 time = new Time1(0,0,0);
            int.TryParse(modelReaderTimeZone.TimeZone1.Substring(0, 2), out time.hour);
            int.TryParse(modelReaderTimeZone.TimeZone1.Substring(2, 2), out time.minute);
            return time;
        }
        private void showDateTimePickerFormReaderTimeZone(ref MyComponents.TimeMode ModeAccessTime , AccessDataBase.Model.ReaderTimeZone modelReaderTimeZone)
        {
            if (modelReaderTimeZone == null)
                return;
            ModeAccessTime.KryptonDateTimePickerAccessTime1.Value = Convert.ToDateTime(modelReaderTimeZone.TimeZone1);
            ModeAccessTime.KryptonDateTimePickerAccessTime2.Value = Convert.ToDateTime(modelReaderTimeZone.TimeZone2);
            ModeAccessTime.KryptonDateTimePickerAccessTime3.Value = Convert.ToDateTime(modelReaderTimeZone.TimeZone3);
            ModeAccessTime.KryptonDateTimePickerAccessTime4.Value = Convert.ToDateTime(modelReaderTimeZone.TimeZone4);
            ModeAccessTime.KryptonDateTimePickerAccessTime5.Value = Convert.ToDateTime(modelReaderTimeZone.TimeZone5);
            ModeAccessTime.KryptonDateTimePickerAccessTime6.Value = Convert.ToDateTime(modelReaderTimeZone.TimeZone6);
        }
        private void getReaderTimeZone( AccessDataBase.Model.ReaderTimeAccess modelReaderTimeAccess)
        {
            if (modelReaderTimeAccess.Mon.HasValue)
            {
                arrarymodelReaderTimeZone[0] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Mon.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime1, arrarymodelReaderTimeZone[0]);
            }
            if (modelReaderTimeAccess.Tue.HasValue)
            {
                arrarymodelReaderTimeZone[1] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Thu.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime2, arrarymodelReaderTimeZone[1]);
            }
            if (modelReaderTimeAccess.Tue.HasValue)
            {
                arrarymodelReaderTimeZone[2] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Tue.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime3, arrarymodelReaderTimeZone[2]);
            }
            if (modelReaderTimeAccess.Wed.HasValue)
            {
                arrarymodelReaderTimeZone[3] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Wed.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime4, arrarymodelReaderTimeZone[3]);
            }
            if (modelReaderTimeAccess.Fri.HasValue)
            {
                arrarymodelReaderTimeZone[4] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Fri.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime5, arrarymodelReaderTimeZone[4]);
            }
            if (modelReaderTimeAccess.Sat.HasValue)
            {
                arrarymodelReaderTimeZone[5] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Sat.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime6, arrarymodelReaderTimeZone[5]);
            }

            if (modelReaderTimeAccess.Sun.HasValue)
            {
                arrarymodelReaderTimeZone[6] = bllReaderTimeZone.GetModel(modelReaderTimeAccess.Sun.Value);
                showDateTimePickerFormReaderTimeZone(ref timeModeAccessTime7, arrarymodelReaderTimeZone[6]);
            }
        }
        private void showUpdatePara()
        {
            #region 基本参数
            kryptonTextBoxReaderID.Text = modelReaderInfo.ReaderID.ToString();
            kryptonTextBoxReaderID.Enabled = false;
            kryptonTextBoxReaderPointID.Text = modelReaderInfo.ReaderPointID.ToString();
            kryptonTextBoxReaderPointID.Enabled = false;
            kryptonComboBoxCommunicateType.SelectedIndex = modelReaderInfo.CommunicateType.Value;
            kryptonComboBoxCommunicateType_SelectedIndexChanged(null,null);
            #endregion

            #region TCP通讯参数
            if (modelReaderInfo.CommunicateType.Value == 1)
            {
                textBoxDeviceIP.Text = modelReaderInfo.ReaderIP.Trim();
                textBoxMask.Text = modelReaderInfo.ReaderSubnet.Trim();
                textBoxGateway.Text = modelReaderInfo.ReaderGateway.Trim();
                textBoxDNS.Text = modelReaderInfo.ReaderDNS == null ? "" : modelReaderInfo.ReaderDNS.Trim();
                kryptonTextBoxBackUpDNS.Text = modelReaderInfo.ReaderBuDNS == null ? "" : modelReaderInfo.ReaderBuDNS.Trim();
            }
            #endregion

            #region 485通讯参数
            if (modelReaderInfo.CommunicateType.Value == 2)
            {
                kryptonTextBoxControllerAddr485.Text = modelReaderInfo.ReaderAddr483.ToString();
                kryptonTextBoxControllerBaudrate.Text = modelReaderInfo.ReaderBaudrate.ToString();
                kryptonLabelControllerDataBits.Text = modelReaderInfo.ReaderDataBits.ToString();
                kryptonTextBoxControllerStopBits.Text = modelReaderInfo.ReaderStopBits.ToString();
                kryptonComboBoxControllerParityCheck.Text = modelReaderInfo.ReaderParityCheck.ToString();
                kryptonTextBoxControllerFlowControl.Text = modelReaderInfo.ReaderFlowControl.ToString();
            }
            #endregion
            #region 时间设置
            if (modelReaderInfo.ReadTimeAccessID.HasValue)
            {
                modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderInfo.ReadTimeAccessID.Value);
                getReaderTimeZone( modelReaderTimeAccess);
            }
            else 
            {
                modelReaderInfo.ReadTimeAccessID = bllReaderTimeAccess.GetMaxId();
                modelReaderTimeAccess.ReaderTimeAccessID = modelReaderInfo.ReadTimeAccessID.Value;
                getReaderTimeZone( modelReaderTimeAccess);
            }

            #endregion
        }
        private void FormReaderInfo_Load(object sender, EventArgs e)
        {
            initToolStripMenu();
            refreshDataGridView();
        }
        public void refreshDataGridView()
        {
            dataGridViewWithCheckBox1.DataSource = bllHoliday.GetModelList("ReaderID = " + modelReaderInfo.ReaderID);
            //dataGridViewWithCheckBox1.DataSource = bllHoliday.GetAllList().Tables[0];
        }
        public void initToolStripMenu()
        {

            toolStripReaderHoliday.Items.Clear();

            ImageOperate.AddButtonItemToToolStrip(toolStripReaderHoliday, "add.BMP", "Add", toolStripButtonAddReaderHolidayInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripReaderHoliday, "update.BMP", "Update", toolStripButtonUpdateHolidayInfo_Click);
            ImageOperate.AddButtonItemToToolStrip(toolStripReaderHoliday, "delete.BMP", "Del", toolStripButtonDeleteHolidayInfo_Click);
        }
        private void toolStripButtonAddReaderHolidayInfo_Click(object sender, EventArgs e)
        {
            int readerID;
            if (!int.TryParse(kryptonTextBoxReaderID.Text.ToString(), out readerID))
            {
                MyMessageBox.MessageBoxOK("请输入正确的读卡器ID");
                return;
            }
            modelReaderInfo.ReaderID = readerID;
            modelHoliday.ReaderHolidayStartDate = "2014-07-18";
            modelHoliday.ReaderHolidayStartDate = "2024-07-18";

            FormReaderHoliday formReaderHoliday = new FormReaderHoliday(OpenMode.Add, modelReaderInfo, modelHoliday);
            formReaderHoliday.ShowDialog();

            refreshDataGridView();
        }
        private void toolStripButtonUpdateHolidayInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewWithCheckBox1.CurrentRow == null)
                return;
            int selectIndex = dataGridViewWithCheckBox1.CurrentRow.Index;

            string holidayID = dataGridViewWithCheckBox1["ReaderHolidayID", selectIndex].Value.ToString().Trim();
            string readerID = dataGridViewWithCheckBox1["ReaderID", selectIndex].Value.ToString().Trim();

            modelReaderInfo.ReaderID = int.Parse(readerID);

            modelHoliday = bllHoliday.GetModel(int.Parse(holidayID));

            FormReaderHoliday formReaderHoliday = new FormReaderHoliday(OpenMode.Update, modelReaderInfo, modelHoliday);
            formReaderHoliday.ShowDialog();

            refreshDataGridView();
        }
        private void toolStripButtonDeleteHolidayInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewWithCheckBox1.CurrentRow == null)
                return;

            int selectIndex = dataGridViewWithCheckBox1.CurrentRow.Index;
            string holidayID = dataGridViewWithCheckBox1["ReaderHolidayID", selectIndex].Value.ToString().Trim();
            if (bllHoliday.Delete(int.Parse(holidayID)))
                MyMessageBox.MessageBoxOK("删除节假日成功");
            else
                MyMessageBox.MessageBoxOK("删除节假日失败");
            refreshDataGridView();

        }


        private void getModelReaderTimeZone(ref AccessDataBase.Model.ReaderTimeZone modelReaderTimeZone,ref MyComponents.TimeMode timeModeAccessTime)
        {
            modelReaderTimeZone.TimeZone1 = timeModeAccessTime.KryptonDateTimePickerAccessTime1.Value.ToShortTimeString();
            modelReaderTimeZone.OperateMode1 = timeModeAccessTime.KryptonComboBoxAccessTime1.SelectedIndex;

            modelReaderTimeZone.TimeZone2 = timeModeAccessTime.KryptonDateTimePickerAccessTime2.Value.ToShortTimeString();
            modelReaderTimeZone.OperateMode2 = timeModeAccessTime.KryptonComboBoxAccessTime2.SelectedIndex;

            modelReaderTimeZone.TimeZone3 = timeModeAccessTime.KryptonDateTimePickerAccessTime3.Value.ToShortTimeString();
            modelReaderTimeZone.OperateMode3 = timeModeAccessTime.KryptonComboBoxAccessTime3.SelectedIndex;

            modelReaderTimeZone.TimeZone4 = timeModeAccessTime.KryptonDateTimePickerAccessTime4.Value.ToShortTimeString();
            modelReaderTimeZone.OperateMode4 = timeModeAccessTime.KryptonComboBoxAccessTime4.SelectedIndex;

            modelReaderTimeZone.TimeZone5 = timeModeAccessTime.KryptonDateTimePickerAccessTime5.Value.ToShortTimeString();
            modelReaderTimeZone.OperateMode5 = timeModeAccessTime.KryptonComboBoxAccessTime5.SelectedIndex;

            modelReaderTimeZone.TimeZone6 = timeModeAccessTime.KryptonDateTimePickerAccessTime6.Value.ToShortTimeString();
            modelReaderTimeZone.OperateMode6 = timeModeAccessTime.KryptonComboBoxAccessTime6.SelectedIndex;
        }
        private void getModelReaderTimeZoneGroup()
        {
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[0], ref timeModeAccessTime1);
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[1], ref timeModeAccessTime2);
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[2], ref timeModeAccessTime3);
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[3], ref timeModeAccessTime4);
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[4], ref timeModeAccessTime5);
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[5], ref timeModeAccessTime6);
            getModelReaderTimeZone(ref arrarymodelReaderTimeZone[6], ref timeModeAccessTime7);
        }

        private void addReaderTimeAccess(ref AccessDataBase.Model.ReaderTimeAccess modelReaderTimeAccess)
        {
            modelReaderTimeAccess.ReaderTimeAccessName = "周工作模式" + modelReaderTimeAccess.ReaderTimeAccessID;

            getModelReaderTimeZoneGroup();

            foreach (AccessDataBase.Model.ReaderTimeZone readerTimeZone in arrarymodelReaderTimeZone)
            {
                readerTimeZone.ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(readerTimeZone);
            }
            modelReaderTimeAccess.Mon = arrarymodelReaderTimeZone[0].ReaderTimeZoneID;
            modelReaderTimeAccess.Tue = arrarymodelReaderTimeZone[1].ReaderTimeZoneID;
            modelReaderTimeAccess.Wed = arrarymodelReaderTimeZone[2].ReaderTimeZoneID;
            modelReaderTimeAccess.Thu = arrarymodelReaderTimeZone[3].ReaderTimeZoneID;
            modelReaderTimeAccess.Fri = arrarymodelReaderTimeZone[4].ReaderTimeZoneID;
            modelReaderTimeAccess.Sat = arrarymodelReaderTimeZone[5].ReaderTimeZoneID;
            modelReaderTimeAccess.Sun = arrarymodelReaderTimeZone[6].ReaderTimeZoneID;
        }
        private void addReaderInfo(ref AccessDataBase.Model.ReaderInfo modelReaderInfo)
        {
            if (bllReaderInfo.Exists(modelReaderInfo.ReaderID))
            {
                MyMessageBox.MessageBoxOK("读卡器ID已经存在");
                return;
            }
            modelReaderTimeAccess.ReaderTimeAccessID = bllReaderTimeAccess.GetMaxId();
            addReaderTimeAccess(ref modelReaderTimeAccess);

            modelReaderInfo.ReadTimeAccessID = modelReaderTimeAccess.ReaderTimeAccessID;
            bllReaderInfo.Add(modelReaderInfo);
        }
        private void updateReaderTimeAccess(ref AccessDataBase.Model.ReaderTimeAccess modelReaderTimeAccess)
        {
            if (bllReaderTimeAccess.Exists(modelReaderTimeAccess.ReaderTimeAccessID))
            {
                modelReaderTimeAccess = bllReaderTimeAccess.GetModel(modelReaderTimeAccess.ReaderTimeAccessID);
            }
            else
            {
                bllReaderTimeAccess.Add(modelReaderTimeAccess);
            }
            getModelReaderTimeZoneGroup();
            if (modelReaderTimeAccess.Mon.HasValue)
            {
                arrarymodelReaderTimeZone[0].ReaderTimeZoneID = modelReaderTimeAccess.Mon.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[0]);
            }
            else 
            {
                modelReaderTimeAccess.Mon = arrarymodelReaderTimeZone[0].ReaderTimeZoneID =  bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[0]);
            }

            if (modelReaderTimeAccess.Thu.HasValue)
            {
                arrarymodelReaderTimeZone[1].ReaderTimeZoneID = modelReaderTimeAccess.Thu.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[1]);
            }
            else 
            {
                modelReaderTimeAccess.Thu = arrarymodelReaderTimeZone[1].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[1]);
            }

            if (modelReaderTimeAccess.Tue.HasValue)
            {
                arrarymodelReaderTimeZone[2].ReaderTimeZoneID = modelReaderTimeAccess.Tue.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[2]);
            }
            else
            {
                modelReaderTimeAccess.Tue = arrarymodelReaderTimeZone[2].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[2]);
            }
            if (modelReaderTimeAccess.Wed.HasValue)
            {
                arrarymodelReaderTimeZone[3].ReaderTimeZoneID = modelReaderTimeAccess.Wed.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[3]);
            }
            else
            {
                modelReaderTimeAccess.Wed = arrarymodelReaderTimeZone[3].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[3]);
            }
            if (modelReaderTimeAccess.Fri.HasValue)
            {
                arrarymodelReaderTimeZone[4].ReaderTimeZoneID = modelReaderTimeAccess.Fri.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[4]);
            }
            else
            {
                modelReaderTimeAccess.Fri = arrarymodelReaderTimeZone[4].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[4]);
            }
            if (modelReaderTimeAccess.Sat.HasValue)
            {
                arrarymodelReaderTimeZone[5].ReaderTimeZoneID = modelReaderTimeAccess.Sat.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[5]);
            }
            else
            {
                modelReaderTimeAccess.Sat = arrarymodelReaderTimeZone[5].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[5]);
            }
            if (modelReaderTimeAccess.Sun.HasValue)
            {
                arrarymodelReaderTimeZone[6].ReaderTimeZoneID = modelReaderTimeAccess.Sun.Value;
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[6]);
            }
            else
            {
                modelReaderTimeAccess.Sun = arrarymodelReaderTimeZone[6].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[6]);
            }
            bllReaderTimeAccess.Update(modelReaderTimeAccess);
            
        }
        private void updateReaderInfo(ref AccessDataBase.Model.ReaderInfo modelReaderInfo)
        {
            modelReaderTimeAccess.ReaderTimeAccessID = bllReaderInfo.GetModel(modelReaderInfo.ReaderID).ReadTimeAccessID.HasValue ? 
                bllReaderInfo.GetModel(modelReaderInfo.ReaderID).ReadTimeAccessID.Value : bllReaderTimeAccess.GetMaxId();
            modelReaderTimeAccess.ReaderTimeAccessName = "";
            updateReaderTimeAccess(ref modelReaderTimeAccess);

            modelReaderInfo.ReadTimeAccessID = modelReaderTimeAccess.ReaderTimeAccessID;

            bllReaderInfo.Update(modelReaderInfo);
        }
        private void getReaderInfo(ref AccessDataBase.Model.ReaderInfo modelReaderInfo)
        {
            modelReaderInfo.CommunicateType = kryptonComboBoxCommunicateType.SelectedIndex;

            #region TCP通信参数
            modelReaderInfo.ReaderIP = textBoxDeviceIP.Text.ToString();
            modelReaderInfo.ReaderSubnet = textBoxMask.Text.ToString();
            modelReaderInfo.ReaderGateway = textBoxGateway.Text.ToString();
            modelReaderInfo.ReaderDNS = textBoxDNS.Text.ToString();
            modelReaderInfo.ReaderBuDNS = kryptonTextBoxBackUpDNS.Text.ToString();
            #endregion

            #region 485通信参数
            modelReaderInfo.ReaderAddr483 = int.Parse(kryptonTextBoxControllerAddr485.Text.ToString());
            modelReaderInfo.ReaderBaudrate = int.Parse(kryptonTextBoxControllerBaudrate.Text.ToString());
            modelReaderInfo.ReaderDataBits = int.Parse(kryptonTextBoxControllerDataBits.Text.ToString());
            modelReaderInfo.ReaderStopBits = int.Parse(kryptonTextBoxControllerStopBits.Text.ToString());
            modelReaderInfo.ReaderParityCheck = kryptonComboBoxControllerParityCheck.Text.ToString();
            modelReaderInfo.ReaderFlowControl = kryptonTextBoxControllerFlowControl.Text.ToString();
            #endregion
        }
        private void kryptonButtonReaderOK_Click(object sender, EventArgs e)
        {
            int readerID,readerPointID;
            bool ret = int.TryParse(kryptonTextBoxReaderID.Text.ToString(), out readerID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("读卡器ID不能为空");
                return;
            }

            ret = int.TryParse(kryptonTextBoxReaderPointID.Text.ToString(), out readerPointID);
            if (ret == false)
            {
                MyMessageBox.MessageBoxOK("读卡器端口ID不能为空");
                return;
            }
            if (openMode == OpenMode.Add)
            {
                #region 添加读卡器工作时区
                arrarymodelReaderTimeZone[0].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[0], ref timeModeAccessTime1);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[0]);

                arrarymodelReaderTimeZone[1].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[1], ref timeModeAccessTime2);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[1]);

                arrarymodelReaderTimeZone[2].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[2], ref timeModeAccessTime3);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[2]);

                arrarymodelReaderTimeZone[3].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[3], ref timeModeAccessTime4);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[3]);

                arrarymodelReaderTimeZone[4].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[4], ref timeModeAccessTime5);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[4]);

                arrarymodelReaderTimeZone[5].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[5], ref timeModeAccessTime6);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[5]);

                arrarymodelReaderTimeZone[6].ReaderTimeZoneID = bllReaderTimeZone.GetMaxId();
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[6], ref timeModeAccessTime7);
                bllReaderTimeZone.Add(arrarymodelReaderTimeZone[6]);
                #endregion

                #region 添加读卡器周工作模式
                modelReaderTimeAccess.ReaderTimeAccessID = bllReaderTimeAccess.GetMaxId();
                modelReaderTimeAccess.ReaderTimeAccessName = "";

                modelReaderTimeAccess.Mon = arrarymodelReaderTimeZone[0].ReaderTimeZoneID;
                modelReaderTimeAccess.Tue = arrarymodelReaderTimeZone[1].ReaderTimeZoneID;
                modelReaderTimeAccess.Wed = arrarymodelReaderTimeZone[2].ReaderTimeZoneID;
                modelReaderTimeAccess.Thu = arrarymodelReaderTimeZone[3].ReaderTimeZoneID;
                modelReaderTimeAccess.Fri = arrarymodelReaderTimeZone[4].ReaderTimeZoneID;
                modelReaderTimeAccess.Sat = arrarymodelReaderTimeZone[5].ReaderTimeZoneID;
                modelReaderTimeAccess.Sun = arrarymodelReaderTimeZone[6].ReaderTimeZoneID;
                bllReaderTimeAccess.Add(modelReaderTimeAccess);
                #endregion

                #region 添加读卡器
                modelReaderInfo.ReaderID = readerID;
                modelReaderInfo.ReaderPointID = readerPointID;
                modelReaderInfo.ReadTimeAccessID = modelReaderTimeAccess.ReaderTimeAccessID;
                getReaderInfo(ref modelReaderInfo);
                bllReaderInfo.Add(modelReaderInfo);
                #endregion
            }
            else
            {
                modelReaderInfo = bllReaderInfo.GetModel(readerID);
                if (modelReaderInfo == null)
                    return;
                #region 修改读卡器工作时区
                modelReaderTimeAccess.ReaderTimeAccessID = modelReaderInfo.ReadTimeAccessID.Value;

                arrarymodelReaderTimeZone[0].ReaderTimeZoneID = modelReaderTimeAccess.Mon.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[0], ref timeModeAccessTime1);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[0]);

                arrarymodelReaderTimeZone[1].ReaderTimeZoneID = modelReaderTimeAccess.Tue.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[1], ref timeModeAccessTime2);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[1]);

                arrarymodelReaderTimeZone[2].ReaderTimeZoneID = modelReaderTimeAccess.Wed.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[2], ref timeModeAccessTime3);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[2]);

                arrarymodelReaderTimeZone[3].ReaderTimeZoneID = modelReaderTimeAccess.Thu.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[3], ref timeModeAccessTime4);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[3]);

                arrarymodelReaderTimeZone[4].ReaderTimeZoneID = modelReaderTimeAccess.Fri.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[4], ref timeModeAccessTime5);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[4]);

                arrarymodelReaderTimeZone[5].ReaderTimeZoneID = modelReaderTimeAccess.Sat.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[5], ref timeModeAccessTime6);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[5]);

                arrarymodelReaderTimeZone[6].ReaderTimeZoneID = modelReaderTimeAccess.Sun.Value;
                getModelReaderTimeZone(ref arrarymodelReaderTimeZone[6], ref timeModeAccessTime7);
                bllReaderTimeZone.Update(arrarymodelReaderTimeZone[6]);
                #endregion

                #region 修改读卡器信息
                getReaderInfo(ref modelReaderInfo);
                bllReaderInfo.Update(modelReaderInfo);
                #endregion
            }
            this.Close();
        }

        private void kryptonButtonReaderCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonComboBoxCommunicateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonComboBoxCommunicateType.SelectedIndex == 0)
            {
                kryptonGroupBoxTCP.Panel.Enabled = false;
                kryptonGroupBoxRS485.Panel.Enabled = false;
            }
            else if (kryptonComboBoxCommunicateType.SelectedIndex == 1)
            {
                kryptonGroupBoxTCP.Panel.Enabled = true;
                kryptonGroupBoxRS485.Panel.Enabled = false;
            }
            else if (kryptonComboBoxCommunicateType.SelectedIndex == 2)
            {
                kryptonGroupBoxTCP.Panel.Enabled = false;
                kryptonGroupBoxRS485.Panel.Enabled = true;
            }
        }
    }
}