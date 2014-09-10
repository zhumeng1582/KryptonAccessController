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
using KryptonAccessController.AccessDataBase;

namespace KryptonAccessController.RelationController
{
    public partial class FormController : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private AccessDataBase.Model.ControllerInfo modelControllerInfo = new AccessDataBase.Model.ControllerInfo();
        private AccessDataBase.BLL.ControllerInfo bllControllerInfo = new AccessDataBase.BLL.ControllerInfo();
        //private AccessDataBase.Model.DoorUnitInfo modeDoorUnitInfo = new AccessDataBase.Model.DoorUnitInfo();
        private AccessDataBase.BLL.DoorUnitInfo bllDoorUnitInfo = new AccessDataBase.BLL.DoorUnitInfo();
        private AccessDataBase.Model.DoorUnitInfo[] arrayDoorUnitInfo = new AccessDataBase.Model.DoorUnitInfo[4];

        private AccessDataBase.BLL.ReaderInfo bllReaderInfo = new AccessDataBase.BLL.ReaderInfo();
        private AccessDataBase.Model.ReaderInfo[] arraryReaderInfo = new AccessDataBase.Model.ReaderInfo[8];
        
        private OpenMode openMode;
        public FormController(AccessDataBase.Model.ControllerInfo ModelControllerInfo, OpenMode openMode)
        {
            InitializeComponent();
            doorUnit1.KryptonButtonReaderUpdate1.Click += KryptonButtonReaderUpdateClick1;
            doorUnit1.KryptonButtonReaderUpdate2.Click += KryptonButtonReaderUpdateClick1;
            doorUnit1.KryptonCheckBoxReader1.CheckedChanged += KryptonCheckBoxReaderCheckedChanged1;
            doorUnit1.KryptonCheckBoxReader2.CheckedChanged += KryptonCheckBoxReaderCheckedChanged1;
            doorUnit2.KryptonButtonReaderUpdate1.Click += KryptonButtonReaderUpdateClick2;
            doorUnit2.KryptonButtonReaderUpdate2.Click += KryptonButtonReaderUpdateClick2;
            doorUnit2.KryptonCheckBoxReader1.CheckedChanged += KryptonCheckBoxReaderCheckedChanged2;
            doorUnit2.KryptonCheckBoxReader2.CheckedChanged += KryptonCheckBoxReaderCheckedChanged2;
            doorUnit3.KryptonButtonReaderUpdate1.Click += KryptonButtonReaderUpdateClick3;
            doorUnit3.KryptonButtonReaderUpdate2.Click += KryptonButtonReaderUpdateClick3;
            doorUnit3.KryptonCheckBoxReader1.CheckedChanged += KryptonCheckBoxReaderCheckedChanged3;
            doorUnit3.KryptonCheckBoxReader2.CheckedChanged += KryptonCheckBoxReaderCheckedChanged3;
            doorUnit4.KryptonButtonReaderUpdate1.Click += KryptonButtonReaderUpdateClick4;
            doorUnit4.KryptonButtonReaderUpdate2.Click += KryptonButtonReaderUpdateClick4;
            doorUnit4.KryptonCheckBoxReader1.CheckedChanged += KryptonCheckBoxReaderCheckedChanged4;
            doorUnit4.KryptonCheckBoxReader2.CheckedChanged += KryptonCheckBoxReaderCheckedChanged4;
            
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = GetResourcesFile.getSystemIco();

            this.modelControllerInfo = ModelControllerInfo;
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
        private void showAddPara()
        {
            #region 基本参数
            kryptonTextBoxControllerID.Text = modelControllerInfo.ControllerID.ToString();
            kryptonTextBoxControllerName.Text = "控制器" + modelControllerInfo.ControllerID.ToString();
            kryptonComboBoxControllerType.SelectedIndex = 0;
            kryptonTextBoxControllerLoaction.Text = "默认地址";
            kryptonTextBoxControllerVersion.Text = "V20140321";
            #endregion

            #region 通讯参数
            kryptonCheckBoxCommunicateTypeTCP.Checked = true;
            kryptonGroupBoxTCP.Enabled = true;

            kryptonCheckBoxCommunicateType485.Checked = false;
            kryptonGroupBox485.Enabled = false;

            textBoxNewDeviceIP.Text = "192.168.1.100";
            textBoxMask.Text = "255.255.255.0";
            textBoxGateway.Text = "192.168.1.1";
            textBoxMAC.Text = "";
            textBoxDNS.Text = "8.8.8.8" ;
            kryptonTextBoxBackUpDNS.Text = "192.168.1.1";
            ///添加RS485 参数
            #endregion 通讯参数

            #region 辅助单元
            kryptonComboBoxInputStateType0.SelectedIndex = 1;
            kryptonTextBoxAuxOutPutPoint.Text = "10";
            kryptonTextBoxFireSensing.Text = "10";
            kryptonTextBoxTamperSensing.Text = "11";
            kryptonTextBoxLowVoltage.Text = "12";
            kryptonTextBoxPowerOutage.Text = "13";
            #endregion 辅助单元

            #region 门单元1
            kryptonCheckBoxDoorUnitEnable1.Checked = true;
            doorUnit1.KryptonGroupBoxDoorUnit.Panel.Enabled = true;
            doorUnit1.KryptonTextBoxOutPoint.Text = "01";
            doorUnit1.KryptonTextBoxExitButton.Text = "01";
            doorUnit1.KryptonTextBoxDoorContact.Text = "02";
            doorUnit1.KryptonTextBoxDoorPosition.Text = "03";
            doorUnit1.KryptonTextBoxBreakGlass.Text = "04";
            doorUnit1.KryptonTextBoxReader1.Text = "01";
            doorUnit1.KryptonTextBoxReader2.Text = "01";
            #endregion 门单元1

            #region 门单元2
            kryptonCheckBoxDoorUnitEnable2.Checked = true;
            doorUnit2.KryptonGroupBoxDoorUnit.Panel.Enabled = true;
            doorUnit2.KryptonTextBoxOutPoint.Text = "02";
            doorUnit2.KryptonTextBoxExitButton.Text = "05";
            doorUnit2.KryptonTextBoxDoorContact.Text = "06";
            doorUnit2.KryptonTextBoxDoorPosition.Text = "07";
            doorUnit2.KryptonTextBoxBreakGlass.Text = "08";
            doorUnit2.KryptonTextBoxReader1.Text = "02";
            doorUnit2.KryptonTextBoxReader2.Text = "02";
            #endregion 门单元2

            #region 门单元3
            kryptonCheckBoxDoorUnitEnable3.Checked = false;
            doorUnit3.KryptonGroupBoxDoorUnit.Panel.Enabled = false;
            doorUnit3.KryptonTextBoxOutPoint.Text = "03";
            doorUnit3.KryptonTextBoxExitButton.Text = "11";
            doorUnit3.KryptonTextBoxDoorContact.Text = "12";
            doorUnit3.KryptonTextBoxDoorPosition.Text = "13";
            doorUnit3.KryptonTextBoxBreakGlass.Text = "14";
            doorUnit3.KryptonTextBoxReader1.Text = "03";
            doorUnit3.KryptonTextBoxReader2.Text = "03";
            #endregion 门单元3

            #region 门单元4
            kryptonCheckBoxDoorUnitEnable4.Checked = false;
            doorUnit4.KryptonGroupBoxDoorUnit.Panel.Enabled = false;
            doorUnit4.KryptonTextBoxOutPoint.Text = "04";
            doorUnit4.KryptonTextBoxExitButton.Text = "15";
            doorUnit4.KryptonTextBoxDoorContact.Text = "16";
            doorUnit4.KryptonTextBoxDoorPosition.Text = "17";
            doorUnit4.KryptonTextBoxBreakGlass.Text = "18";
            doorUnit4.KryptonTextBoxReader1.Text = "04";
            doorUnit4.KryptonTextBoxReader2.Text = "04";
            #endregion 门单元4

            #region 集成IO
            #endregion 集成IO

            #region 扩展IO1
            #endregion 扩展IO1

            #region 扩展IO2
            #endregion 扩展IO2

            #region 扩展IO3
            #endregion 扩展IO3

            #region 扩展IO4
            #endregion 扩展IO4
        }
        private void showDoorUnitControl(ref MyComponents.DoorUnit doorUnit,KryptonAccessController.AccessDataBase.Model.DoorUnitInfo modelDoorUnit)
        {
            doorUnit.KryptonComboBoxInputStateType.SelectedIndex = modelDoorUnit.InputStateType == 2 ? 0 : 1;
            doorUnit.KryptonTextBoxOutPoint.Text = modelDoorUnit.OutPutLockID.ToString();
            doorUnit.KryptonTextBoxExitButton.Text = modelDoorUnit.ExitButtonID.ToString();
            doorUnit.KryptonTextBoxDoorContact.Text = modelDoorUnit.DoorContactID.ToString();
            doorUnit.KryptonTextBoxDoorPosition.Text = modelDoorUnit.DoorPositionID.ToString();
            doorUnit.KryptonTextBoxBreakGlass.Text = modelDoorUnit.BreakGlassID.ToString();
            doorUnit.KryptonTextBoxReader1.Text = modelDoorUnit.ReadID1.ToString();
            doorUnit.KryptonTextBoxReader2.Text = modelDoorUnit.ReadID2.ToString();
        }
        private void showDoorUnitControlNull(ref MyComponents.DoorUnit doorUnit) 
        {
            doorUnit.KryptonTextBoxOutPoint.Text = null;
            doorUnit.KryptonTextBoxExitButton.Text = null;
            doorUnit.KryptonTextBoxDoorContact.Text = null;
            doorUnit.KryptonTextBoxDoorPosition.Text = null;
            doorUnit.KryptonTextBoxBreakGlass.Text = null;
            doorUnit.KryptonTextBoxReader1.Text = null;
            doorUnit.KryptonTextBoxReader2.Text = null;
        }
        private void showUpdatePara()
        {
            #region 基本参数
            kryptonTextBoxControllerID.Text = modelControllerInfo.ControllerID.ToString();
            kryptonTextBoxControllerName.Text = modelControllerInfo.ControllerName.Trim();
            kryptonComboBoxControllerType.SelectedIndex = modelControllerInfo.ControllerType.HasValue ? modelControllerInfo.ControllerType.Value - 1 : 0;
            kryptonTextBoxControllerLoaction.Text = modelControllerInfo.ControllerLocation.Trim();
            kryptonTextBoxControllerVersion.Text = modelControllerInfo.ControllerVersion.Trim();
            #endregion 基本参数

            #region 通讯参数
            if (modelControllerInfo.CommunicateType == 1)
            {
                kryptonCheckBoxCommunicateTypeTCP.Checked = true;
                textBoxNewDeviceIP.Text = modelControllerInfo.ControllerIP;
                textBoxMask.Text = modelControllerInfo.ControllerSubnetMask;
                textBoxGateway.Text = modelControllerInfo.ControllerGateway;
                textBoxMAC.Text = modelControllerInfo.ControllerMAC;
                textBoxDNS.Text = modelControllerInfo.ControllerDNS;
                kryptonTextBoxBackUpDNS.Text = modelControllerInfo.ControllerBUDNS;

                kryptonCheckBoxCommunicateType485.Checked = false;
                kryptonGroupBox485.Enabled = false;
            }
            else if (modelControllerInfo.CommunicateType == 2)
            {
                kryptonCheckBoxCommunicateTypeTCP.Checked = false;
                kryptonGroupBoxTCP.Enabled = false;

                kryptonCheckBoxCommunicateType485.Checked = true;
                kryptonTextBoxControllerAddr485.Text = modelControllerInfo.ControllerAddr485.ToString();
                kryptonTextBoxControllerBaudrate.Text = modelControllerInfo.ControllerBaudrate.ToString();
                kryptonTextBoxControllerDataBits.Text = modelControllerInfo.ControllerDataBits.ToString();
            }
            else
            {
                kryptonCheckBoxCommunicateTypeTCP.Checked = true;
                textBoxNewDeviceIP.Text = modelControllerInfo.ControllerIP;
                textBoxMask.Text = modelControllerInfo.ControllerSubnetMask;
                textBoxGateway.Text = modelControllerInfo.ControllerGateway;
                textBoxMAC.Text = modelControllerInfo.ControllerMAC;
                textBoxDNS.Text = modelControllerInfo.ControllerDNS;
                kryptonTextBoxBackUpDNS.Text = modelControllerInfo.ControllerBUDNS;

                kryptonCheckBoxCommunicateType485.Checked = true;
                kryptonCheckBoxCommunicateType485.Checked = true;
                kryptonTextBoxControllerAddr485.Text = modelControllerInfo.ControllerAddr485.ToString();
                kryptonTextBoxControllerBaudrate.Text = modelControllerInfo.ControllerBaudrate.ToString();
                kryptonTextBoxControllerDataBits.Text = modelControllerInfo.ControllerDataBits.ToString();

            }
            #endregion 通讯参数

            #region 辅助单元
            kryptonComboBoxInputStateType0.SelectedIndex = modelControllerInfo.InputStateType == 2 ? 0 : 1;
            kryptonTextBoxAuxOutPutPoint.Text = modelControllerInfo.AuxOutPutPointID.ToString();
            kryptonTextBoxFireSensing.Text = modelControllerInfo.FireSensingID.ToString();
            kryptonTextBoxTamperSensing.Text = modelControllerInfo.TamperSensingID.ToString();
            kryptonTextBoxLowVoltage.Text = modelControllerInfo.LowVoltageID.ToString();
            kryptonTextBoxPowerOutage.Text = modelControllerInfo.PowerOutageID.ToString();
            #endregion 辅助单元

            #region 门单元1
            kryptonCheckBoxDoorUnitEnable1.Checked = modelControllerInfo.DoorUnitEnable1;
            
            if (modelControllerInfo.DoorUnitID1.HasValue)
            {
                List<KryptonAccessController.AccessDataBase.Model.DoorUnitInfo> listDoorUnitInfo = bllDoorUnitInfo.GetModelList("DoorUnitID = " + modelControllerInfo.DoorUnitID1.Value);
                if (listDoorUnitInfo.Count >0)
                {
                    arrayDoorUnitInfo[0] = listDoorUnitInfo[0];
                    showDoorUnitControl(ref doorUnit1, arrayDoorUnitInfo[0]);
                }
                
            }
            else 
            {
                kryptonCheckBoxDoorUnitEnable1.Checked = false;
                showDoorUnitControlNull(ref doorUnit1);
            }
            #endregion 门单元1

            #region 门单元2
            kryptonCheckBoxDoorUnitEnable2.Checked = modelControllerInfo.DoorUnitEnable2;

            if (modelControllerInfo.DoorUnitID2.HasValue)
            {
                List<KryptonAccessController.AccessDataBase.Model.DoorUnitInfo> listDoorUnitInfo = bllDoorUnitInfo.GetModelList("DoorUnitID = " + modelControllerInfo.DoorUnitID2.Value);
                if (listDoorUnitInfo.Count > 0)
                {
                    arrayDoorUnitInfo[1] = listDoorUnitInfo[0];
                    showDoorUnitControl(ref doorUnit2, arrayDoorUnitInfo[1]);
                }
            }
            else
            {
                kryptonCheckBoxDoorUnitEnable2.Checked = false;
                showDoorUnitControlNull(ref doorUnit2);
            }
            #endregion 门单元2

            #region 门单元3
            kryptonCheckBoxDoorUnitEnable3.Checked = modelControllerInfo.DoorUnitEnable3;

            if (modelControllerInfo.DoorUnitID3.HasValue)
            {
                List<KryptonAccessController.AccessDataBase.Model.DoorUnitInfo> listDoorUnitInfo = bllDoorUnitInfo.GetModelList("DoorUnitID = " + modelControllerInfo.DoorUnitID3.Value);
                if (listDoorUnitInfo.Count>0)
                {
                    arrayDoorUnitInfo[2] = listDoorUnitInfo[0];
                    showDoorUnitControl(ref doorUnit3, arrayDoorUnitInfo[2]);
                }
            }
            else
            {
                kryptonCheckBoxDoorUnitEnable3.Checked = false;
                showDoorUnitControlNull(ref doorUnit3);
            }
            #endregion 门单元3

            #region 门单元4
             kryptonCheckBoxDoorUnitEnable4.Checked = modelControllerInfo.DoorUnitEnable4;

             if (modelControllerInfo.DoorUnitID4.HasValue)
             {
                 List<KryptonAccessController.AccessDataBase.Model.DoorUnitInfo> listDoorUnitInfo = bllDoorUnitInfo.GetModelList("DoorUnitID = " + modelControllerInfo.DoorUnitID4.Value);
                 if (listDoorUnitInfo.Count > 0)
                 {
                     arrayDoorUnitInfo[3] = listDoorUnitInfo[0];
                     showDoorUnitControl(ref doorUnit4, arrayDoorUnitInfo[3]);
                 }
             }
             else
             {
                 kryptonCheckBoxDoorUnitEnable4.Checked = false;
                 showDoorUnitControlNull(ref doorUnit4);
             }
            #endregion 门单元4

            #region 集成IO
            #endregion 集成IO

            #region 扩展IO1
            #endregion 扩展IO1

            #region 扩展IO2
            #endregion 扩展IO2

            #region 扩展IO3
            #endregion 扩展IO3

            #region 扩展IO4
            #endregion 扩展IO4

        }

        private void kryptonButtonControllerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 从视图控件中获取门单元信息
        /// </summary>
        /// <param name="doorUnit"></param>
        /// <returns>门单元信息</returns>
        private void getModelDoorUnitInfo(ref AccessDataBase.Model.DoorUnitInfo modelDoorUnitInfo, MyComponents.DoorUnit doorUnit)
        {
            //modelDoorUnitInfo.DoorUnitID;
            modelDoorUnitInfo.OutPutLockID = int.Parse(doorUnit.KryptonTextBoxOutPoint.Text.ToString());
            //modelDoorUnitInfo.OutPutTimeLeng;
            //modelDoorUnitInfo.OpenDoorOverTimeLen;
            //modelDoorUnitInfo.AccessCapacityEnable;
            //modelDoorUnitInfo.AccessCapacityMax;
            //modelDoorUnitInfo.AccessCapacityMin;

            modelDoorUnitInfo.ReadID1 = int.Parse(doorUnit.KryptonTextBoxReader1.Text.ToString());
            modelDoorUnitInfo.ReadIDEnable1 = doorUnit.KryptonCheckBoxReader1.Checked;
            modelDoorUnitInfo.ReadID2 = int.Parse(doorUnit.KryptonTextBoxReader2.Text.ToString());
            modelDoorUnitInfo.ReadIDEnable2 = doorUnit.KryptonCheckBoxReader2.Checked;

            modelDoorUnitInfo.InputStateType = doorUnit.KryptonComboBoxInputStateType.SelectedIndex;
            
            modelDoorUnitInfo.ExitButtonID = int.Parse(doorUnit.KryptonTextBoxExitButton.Text.ToString());
            //modelDoorUnitInfo.ExitButtonMode;
            //modelDoorUnitInfo.ExtiButtonEnable;

            modelDoorUnitInfo.DoorContactID = int.Parse(doorUnit.KryptonTextBoxDoorContact.Text.ToString());
            //modelDoorUnitInfo.DoorContactMode;
            //modelDoorUnitInfo.DoorPositionEnable;

            modelDoorUnitInfo.DoorPositionID = int.Parse(doorUnit.KryptonTextBoxDoorPosition.Text.ToString());
            //modelDoorUnitInfo.DoorPositionMode;
            //modelDoorUnitInfo.DoorPositionEnable;

            modelDoorUnitInfo.BreakGlassID = int.Parse(doorUnit.KryptonTextBoxBreakGlass.Text.ToString());
            //modelDoorUnitInfo.BreakGlassMode;
            //modelDoorUnitInfo.DoorContactEnable;
            //modelDoorUnitInfo.ElectronicMapID;
            //modelDoorUnitInfo.PositionX;
            //modelDoorUnitInfo.PositionY;
            //modelDoorUnitInfo.StateImageOpen;
            //modelDoorUnitInfo.StateImageClose;
            //modelDoorUnitInfo.StateImageAlarmOpen;
            //modelDoorUnitInfo.StateImageAlarmClose;
        }
        /// <summary>
        /// 从视图控件中获取控制器信息
        /// </summary>
        /// <param name="modelControllerInfo"></param>
        private void getModelControllerInfo(ref AccessDataBase.Model.ControllerInfo modelControllerInfo,FormController formController)
        {
            #region 控制器信息
            modelControllerInfo.ControllerID = int.Parse(formController.kryptonTextBoxControllerID.Text.Trim());
            modelControllerInfo.ControllerName = formController.kryptonTextBoxControllerName.Text.Trim();
            modelControllerInfo.ControllerType = formController.kryptonComboBoxControllerType.SelectedIndex + 1;
            modelControllerInfo.ControllerLocation = formController.kryptonTextBoxControllerLoaction.Text.Trim();
            modelControllerInfo.ControllerVersion = formController.kryptonTextBoxControllerVersion.Text.ToString();

            ///TCP通信参数
            modelControllerInfo.ControllerIP = formController.textBoxNewDeviceIP.Text.Trim();
            modelControllerInfo.ControllerSubnetMask = formController.textBoxMask.Text.Trim();
            modelControllerInfo.ControllerGateway = formController.textBoxGateway.Text.Trim();
            modelControllerInfo.ControllerMAC = formController.textBoxMAC.Text;
            modelControllerInfo.ControllerDNS = formController.textBoxDNS.Text;
            modelControllerInfo.ControllerBUDNS = formController.kryptonTextBoxBackUpDNS.Text;

            ///RS485通信参数

            #endregion 控制器信息

            #region 辅助单元
            modelControllerInfo.AuxOutPutPointID = int.Parse(formController.kryptonTextBoxAuxOutPutPoint.Text.ToString());
            modelControllerInfo.InputStateType = formController.kryptonComboBoxInputStateType0.SelectedIndex + 1;

            modelControllerInfo.FireSensingEnable = true;
            modelControllerInfo.FireSensingID = int.Parse(formController.kryptonTextBoxFireSensing.Text.ToString());

            modelControllerInfo.TamperSensingEnable = true;
            modelControllerInfo.TamperSensingID = int.Parse(formController.kryptonTextBoxTamperSensing.Text.ToString());

            modelControllerInfo.LowVoltageEnable = true;
            modelControllerInfo.LowVoltageID = int.Parse(formController.kryptonTextBoxLowVoltage.Text.ToString());

            modelControllerInfo.PowerOutageEnable = true;
            modelControllerInfo.PowerOutageID = int.Parse(formController.kryptonTextBoxPowerOutage.Text.ToString());
            #endregion
        }



        private ReturnValue addDoorUnitInfo(ref AccessDataBase.Model.DoorUnitInfo modelDoorUnitInfo)
        {
            if (modelDoorUnitInfo.ReadIDEnable1 & modelDoorUnitInfo.ReadID1.HasValue)
            {
                if (!bllReaderInfo.Exists(modelDoorUnitInfo.ReadID1.Value))
                {
                    MyMessageBox.MessageBoxOK("ID号为：" + modelDoorUnitInfo.ReadID1.Value + "的读卡器不存在，请先增加一个读卡器信息");
                    return ReturnValue.Exist;
                }
                List<AccessDataBase.Model.DoorUnitInfo> listModelDoorUnitInfo = bllDoorUnitInfo.GetModelList("ReadID1 = " + modelDoorUnitInfo.ReadID1.Value + "or ReadID2 = " + modelDoorUnitInfo.ReadID1.Value);
                if (listModelDoorUnitInfo.Count > 0)
                {
                    MyMessageBox.MessageBoxOK("ID号为：" + modelDoorUnitInfo.ReadID1.Value + "的读卡器已经被使用，请重新选择一个读卡器");
                    return ReturnValue.NotAvailable;
                }
            }
            if (modelDoorUnitInfo.ReadIDEnable2 & modelDoorUnitInfo.ReadID2.HasValue)
            {
                if (!bllReaderInfo.Exists(modelDoorUnitInfo.ReadID2.Value))
                {
                    MyMessageBox.MessageBoxOK("ID号为：" + modelDoorUnitInfo.ReadID2.Value + "的读卡器不存在，请先增加一个读卡器信息");
                    return ReturnValue.Exist;
                } 
                List<AccessDataBase.Model.DoorUnitInfo> listModelDoorUnitInfo = bllDoorUnitInfo.GetModelList("ReadID1 = " + modelDoorUnitInfo.ReadID2.Value + "or ReadID2 = " + modelDoorUnitInfo.ReadID2.Value);
                if (listModelDoorUnitInfo.Count > 0)
                {
                    MyMessageBox.MessageBoxOK("ID号为：" + modelDoorUnitInfo.ReadID2.Value + "的读卡器已经被使用，请重新选择一个读卡器");
                    return ReturnValue.NotAvailable;
                }
            }
            bllDoorUnitInfo.Add(modelDoorUnitInfo);
            return ReturnValue.Success;

        }
        private void addAllDoorUnitInfo(ref AccessDataBase.Model.DoorUnitInfo[] modelDoorUnitInfo)
        {
            if (modelControllerInfo.DoorUnitEnable1)
            {
                arrayDoorUnitInfo[0].DoorUnitID = bllDoorUnitInfo.GetMaxId();
                getModelDoorUnitInfo(ref arrayDoorUnitInfo[0], this.doorUnit1);
                addDoorUnitInfo(ref arrayDoorUnitInfo[0]);
            }
            if (modelControllerInfo.DoorUnitEnable2)
            {
                arrayDoorUnitInfo[1].DoorUnitID = bllDoorUnitInfo.GetMaxId();
                getModelDoorUnitInfo(ref arrayDoorUnitInfo[1], this.doorUnit2);
                addDoorUnitInfo(ref arrayDoorUnitInfo[1]);
            }
            if (modelControllerInfo.DoorUnitEnable3)
            {
                arrayDoorUnitInfo[2].DoorUnitID = bllDoorUnitInfo.GetMaxId();
                getModelDoorUnitInfo(ref arrayDoorUnitInfo[2], this.doorUnit3);
                addDoorUnitInfo(ref arrayDoorUnitInfo[2]);
            }
            if (modelControllerInfo.DoorUnitEnable4)
            {
                arrayDoorUnitInfo[3].DoorUnitID = bllDoorUnitInfo.GetMaxId();
                getModelDoorUnitInfo(ref arrayDoorUnitInfo[3], this.doorUnit4);
                addDoorUnitInfo(ref arrayDoorUnitInfo[3]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelControllerInfo"></param>
        private void addControllerInfo(ref AccessDataBase.Model.ControllerInfo modelControllerInfo) 
        {
            if (bllControllerInfo.Exists(modelControllerInfo.ControllerID))
            {
                MyMessageBox.MessageBoxOK("控制器已经存在");
                return;
            }
            getModelControllerInfo(ref modelControllerInfo,this);


            modelControllerInfo.DoorUnitEnable1 = this.kryptonCheckBoxDoorUnitEnable1.Checked;
            modelControllerInfo.DoorUnitEnable2 = this.kryptonCheckBoxDoorUnitEnable2.Checked;
            modelControllerInfo.DoorUnitEnable3 = this.kryptonCheckBoxDoorUnitEnable3.Checked;
            modelControllerInfo.DoorUnitEnable4 = this.kryptonCheckBoxDoorUnitEnable4.Checked;

            addAllDoorUnitInfo(ref arrayDoorUnitInfo);

            
            modelControllerInfo.DoorUnitID1 = arrayDoorUnitInfo[0].DoorUnitID;
            modelControllerInfo.DoorUnitID2 = arrayDoorUnitInfo[1].DoorUnitID;
            modelControllerInfo.DoorUnitID3 = arrayDoorUnitInfo[2].DoorUnitID;
            modelControllerInfo.DoorUnitID4 = arrayDoorUnitInfo[3].DoorUnitID;
            bllControllerInfo.Add(modelControllerInfo);
        }
        
        private void kryptonButtonControllerOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                arrayDoorUnitInfo[i] = new AccessDataBase.Model.DoorUnitInfo(); 
            }
            if (openMode == OpenMode.Update)
            {
                if (bllControllerInfo.Update(modelControllerInfo))
                    this.Close();
            }
            else if (openMode == OpenMode.Add)
            {
                addControllerInfo(ref modelControllerInfo);
                this.Close();
            }

        }

        private void kryptonCheckBoxCommunicateTypeTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBoxCommunicateTypeTCP.Checked == true)
                kryptonGroupBoxTCP.Enabled = true;
            else
                kryptonGroupBoxTCP.Enabled = false;
        }

        private void kryptonCheckBoxCommunicateType485_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBoxCommunicateType485.Checked == true)
                kryptonGroupBox485.Enabled = true;
            else
                kryptonGroupBox485.Enabled = false;
        }

        private void openReadInfoDialog(int readerID,OpenMode openMode)
        {
            AccessDataBase.Model.ReaderInfo modelReaderInfo = new AccessDataBase.Model.ReaderInfo();
            modelReaderInfo.ReaderID = readerID;
            FormReaderInfo formReaderInfo = new FormReaderInfo(modelReaderInfo,openMode);
            formReaderInfo.Show();
        }

        private void KryptonButtonReaderUpdateClick1(object sender, EventArgs e)
        {
            switch (((KryptonButton)sender).Name)
            {
                case "kryptonButtonReaderUpdate1": openReadInfoDialog(int.Parse(doorUnit1.KryptonTextBoxReader1.Text.Trim()), OpenMode.Update); break;
                case "kryptonButtonReaderUpdate2": openReadInfoDialog(int.Parse(doorUnit1.KryptonTextBoxReader2.Text.Trim()), OpenMode.Update); break;
                default: break;
            }
        }
        private void KryptonButtonReaderUpdateClick2(object sender, EventArgs e)
        {
            switch (((KryptonButton)sender).Name)
            {
                case "kryptonButtonReaderUpdate1": openReadInfoDialog(int.Parse(doorUnit2.KryptonTextBoxReader1.Text.Trim()), OpenMode.Update); break;
                case "kryptonButtonReaderUpdate2": openReadInfoDialog(int.Parse(doorUnit2.KryptonTextBoxReader2.Text.Trim()), OpenMode.Update); break;
                default: break;
            }
        }
        private void KryptonButtonReaderUpdateClick3(object sender, EventArgs e)
        {
            switch (((KryptonButton)sender).Name)
            {
                case "kryptonButtonReaderUpdate1": openReadInfoDialog(int.Parse(doorUnit3.KryptonTextBoxReader1.Text.Trim()), OpenMode.Update); break;
                case "kryptonButtonReaderUpdate2": openReadInfoDialog(int.Parse(doorUnit3.KryptonTextBoxReader2.Text.Trim()), OpenMode.Update); break;
                default: break;

            }
        }
        private void KryptonButtonReaderUpdateClick4(object sender, EventArgs e)
        {
            switch (((KryptonButton)sender).Name)
            {
                case "kryptonButtonReaderUpdate1": openReadInfoDialog(int.Parse(doorUnit4.KryptonTextBoxReader1.Text.Trim()), OpenMode.Update); break;
                case "kryptonButtonReaderUpdate2": openReadInfoDialog(int.Parse(doorUnit4.KryptonTextBoxReader2.Text.Trim()), OpenMode.Update); break;
                default: break;

            }
        }
        private void kryptonComboBoxControllerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((kryptonComboBoxControllerType.SelectedIndex == 0) || (kryptonComboBoxControllerType.SelectedIndex == 2))
            {
                kryptonCheckBoxDoorUnitEnable1.Checked = true;
                kryptonCheckBoxDoorUnitEnable1.Enabled = true;

                kryptonCheckBoxDoorUnitEnable2.Checked = true;
                kryptonCheckBoxDoorUnitEnable2.Enabled = true;

                kryptonCheckBoxDoorUnitEnable3.Checked = false;
                kryptonCheckBoxDoorUnitEnable3.Enabled = false;

                kryptonCheckBoxDoorUnitEnable4.Checked = false;
                kryptonCheckBoxDoorUnitEnable4.Enabled = false;
            }
            else if (kryptonComboBoxControllerType.SelectedIndex == 1)
            {
                kryptonCheckBoxDoorUnitEnable1.Checked = true;
                kryptonCheckBoxDoorUnitEnable1.Enabled = true;

                kryptonCheckBoxDoorUnitEnable2.Checked = true;
                kryptonCheckBoxDoorUnitEnable2.Enabled = true;

                kryptonCheckBoxDoorUnitEnable3.Checked = true;
                kryptonCheckBoxDoorUnitEnable3.Enabled = true;

                kryptonCheckBoxDoorUnitEnable4.Checked = true;
                kryptonCheckBoxDoorUnitEnable4.Enabled = true;
            }
            
        }

        private void kryptonCheckBoxDoorUnitEnable_CheckedChanged(object sender, EventArgs e)
        {
            switch (((KryptonCheckBox)sender).Name)
            {
                case "kryptonCheckBoxDoorUnitEnable1": doorUnit1.KryptonGroupBoxDoorUnit.Panel.Enabled = kryptonCheckBoxDoorUnitEnable1.Checked; break;
                case "kryptonCheckBoxDoorUnitEnable2": doorUnit2.KryptonGroupBoxDoorUnit.Panel.Enabled = kryptonCheckBoxDoorUnitEnable2.Checked; break;
                case "kryptonCheckBoxDoorUnitEnable3": doorUnit3.KryptonGroupBoxDoorUnit.Panel.Enabled = kryptonCheckBoxDoorUnitEnable3.Checked; break;
                case "kryptonCheckBoxDoorUnitEnable4": doorUnit4.KryptonGroupBoxDoorUnit.Panel.Enabled = kryptonCheckBoxDoorUnitEnable4.Checked; break;
                default: break;
            }
        }
        private void KryptonCheckBoxReaderCheckedChanged1(object sender, EventArgs e)
        {
            switch (((KryptonCheckBox)sender).Name)
            {
                case "kryptonCheckBoxReader1": 
                    doorUnit1.KryptonButtonReaderUpdate1.Enabled = doorUnit1.KryptonCheckBoxReader1.Checked ;
                    doorUnit1.KryptonButtonReaderAdd1.Enabled = doorUnit1.KryptonCheckBoxReader1.Checked;
                    break;
                case "kryptonCheckBoxReader2":
                    doorUnit1.KryptonButtonReaderUpdate2.Enabled = doorUnit1.KryptonCheckBoxReader2.Checked;
                    doorUnit1.KryptonButtonReaderAdd2.Enabled = doorUnit1.KryptonCheckBoxReader2.Checked;
                    break;
                default: break;
            }
        }
        private void KryptonCheckBoxReaderCheckedChanged2(object sender, EventArgs e)
        {
            switch (((KryptonCheckBox)sender).Name)
            {
                case "kryptonCheckBoxReader1":
                    doorUnit2.KryptonButtonReaderUpdate1.Enabled = doorUnit2.KryptonCheckBoxReader1.Checked;
                    doorUnit2.KryptonButtonReaderAdd1.Enabled = doorUnit2.KryptonCheckBoxReader1.Checked;
                    break;
                case "kryptonCheckBoxReader2":
                    doorUnit2.KryptonButtonReaderUpdate2.Enabled = doorUnit2.KryptonCheckBoxReader2.Checked;
                    doorUnit2.KryptonButtonReaderAdd2.Enabled = doorUnit2.KryptonCheckBoxReader2.Checked;
                    break;
                default: break;
            }
        }
        private void KryptonCheckBoxReaderCheckedChanged3(object sender, EventArgs e)
        {
            switch (((KryptonCheckBox)sender).Name)
            {
                case "kryptonCheckBoxReader1":
                    doorUnit3.KryptonButtonReaderUpdate1.Enabled = doorUnit3.KryptonCheckBoxReader1.Checked;
                    doorUnit3.KryptonButtonReaderAdd1.Enabled = doorUnit3.KryptonCheckBoxReader1.Checked;
                    break;
                case "kryptonCheckBoxReader2":
                    doorUnit3.KryptonButtonReaderUpdate2.Enabled = doorUnit3.KryptonCheckBoxReader2.Checked;
                    doorUnit3.KryptonButtonReaderAdd2.Enabled = doorUnit3.KryptonCheckBoxReader2.Checked;
                    break;
                default: break;
            }
        }
        private void KryptonCheckBoxReaderCheckedChanged4(object sender, EventArgs e)
        {
            switch (((KryptonCheckBox)sender).Name)
            {
                case "kryptonCheckBoxReader1":
                    doorUnit4.KryptonButtonReaderUpdate1.Enabled = doorUnit4.KryptonCheckBoxReader1.Checked;
                    doorUnit4.KryptonButtonReaderAdd1.Enabled = doorUnit4.KryptonCheckBoxReader1.Checked;
                    break;
                case "kryptonCheckBoxReader2":
                    doorUnit4.KryptonButtonReaderUpdate2.Enabled = doorUnit4.KryptonCheckBoxReader2.Checked;
                    doorUnit4.KryptonButtonReaderAdd2.Enabled = doorUnit4.KryptonCheckBoxReader2.Checked;
                    break;
                default: break;
            }
        }
    }
}