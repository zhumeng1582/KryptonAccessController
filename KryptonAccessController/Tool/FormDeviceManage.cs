using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections; 
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using KryptonAccessController.Common;
using System.Text.RegularExpressions;
using KryptonAccessController.ResourcesFile;
using KryptonAccessController.OperationFile;
using KryptonAccessController.Dll;
using KryptonAccessController.Json;
namespace KryptonAccessController.Tool
{
    public partial class KryptonFormDeviceManage : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        public KryptonFormDeviceManage()
        {
            InitializeComponent();
            initUI();
            this.CenterToScreen();
            //this.StartPosition = FormStartPosition.CenterParent;
            
        }
        private void initUI()
        {
            
            
        }
        private void FormDeviceManage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Icon = GetResourcesFile.getSystemIco();

            readIpAddrToTextFile();
        }
        private void readIpAddrToTextFile()
        {
            TxtFile IpFile = new TxtFile("deviceIp.txt");
            ArrayList IpArrayList = IpFile.readFile();
            foreach (object o in IpArrayList)
            {
                kryptonComboBoxControllerIp.Items.Add(o.ToString());
            }
            if (kryptonComboBoxControllerIp.Items.Count == 0)
                kryptonComboBoxControllerIp.Items.Add("192.168.1.242");

            kryptonComboBoxControllerIp.SelectedIndex = 0;
        }

        private void writeIpAddrToTextFile(string ipaddress)
        {
            if (kryptonComboBoxControllerIp.Items.Contains(ipaddress))
            {
                kryptonComboBoxControllerIp.Items.Remove(ipaddress);
            }
            kryptonComboBoxControllerIp.Items.Insert(0, ipaddress);
            kryptonComboBoxControllerIp.SelectedIndex = 0;

            TxtFile IpFile = new TxtFile("deviceIp.txt");
            IpFile.clearFile();

            foreach (object o in kryptonComboBoxControllerIp.Items)
            {
                IpFile.writeFile(o.ToString());
            }
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            writeIpAddrToTextFile(ipaddress);

            int h = DllC0402.testOnline(ipaddress);
            if (h > 0)
            {
                DllC0402.disconnectDevice(h);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsOnline");
            }
            else
            {
                DllC0402.disconnectDevice(h);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetDeviceID_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1024;
            string Items = "DeviceID,";
            int ret = DllC0402.getDeviceParam(ipaddress, Buffer, BufferSize, Items);

            if (ret > 0)
            {
                textBoxControllerID.Text = Buffer.ToString().Substring(Items.Length, ret - Items.Length);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }

        }

        private void buttonSetDeviceID_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            string DeviceID = "DeviceID="+textBoxControllerID.Text.Trim();

            int ret = DllC0402.setDeviceParam(ipaddress, DeviceID);
            if (ret == 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceSetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        
        //分割函数开始
        public static string[] split(string strinput, string sp)
        {
            string tmp="";
            int strlen=0, splen=0;
            int found=0;
            string[] rt = null;
            try
            {
                if (strinput == null || sp == null || strinput.Length == 0 || sp.Length == 0)
                    return null;

                //初始化一个数组列表(当做动态数组)
                ArrayList tmp3 = new ArrayList();
                strlen = strinput.Length;
                splen = sp.Length;
                for (int i = 0; i < splen; i++)
                {
                    //查找分隔符
                    found = strinput.IndexOf(sp, i);
                    if (found >= 0)
                    {
                        tmp = "";
                        //取分隔符前的字符串
                        tmp = strinput.Substring(i, found - i);
                        //添加到数组列表
                        tmp3.Add(tmp);
                        i = found + splen - 1;
                    }
                    else
                    {
                        string tmp2 = "";
                        //取最后的字符串
                        tmp2 = strinput.Substring(i);
                        if (tmp2 != "")
                            tmp3.Add(tmp2);
                        break;
                    }
                }

                //将动态数组的维数设置成实际存在的元素个数，因为数组列表是以16的倍数递增维数的
                tmp3.TrimToSize();
                //转换数组列表为字符串数组，并返回。
                rt = (string[])tmp3.ToArray(typeof(String));
                tmp3.Clear();
            }
            catch (Exception e)
            {
                //Console.WriteLine("{0}", e.Message);
                throw e;
            }
            return rt;
        }

        

       

        

       

        

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            int ret = 0;// DllC0402.controlDevice(ipaddress, 0, RemoteControl.Restart, null);
            if (ret == 0)
            {
                MyMessageBox.MessageBoxOK("textRestartDeviceSucess");
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }

        private void buttonSetNewDeviceIP_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            string Items = "IP=" + textBoxNewControllerIp.Text.Trim();
            int ret = DllC0402.setDeviceParam(ipaddress, Items);
            if (ret == 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceSetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonSetMask_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            string Items = "Mask=" + textBoxControllerSubnetMask.Text.Trim();
            int ret = DllC0402.setDeviceParam(ipaddress, Items);
            if (ret == 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceSetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonSetGateway_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            string Items = "Gateway=" + textBoxControllerGateway.Text.Trim();
            int ret = DllC0402.setDeviceParam(ipaddress, Items);
            if (ret == 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceSetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonSetDNS_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            string Items = "DNS=" + textBoxControllerDNS.Text.Trim();
            int ret = DllC0402.setDeviceParam(ipaddress, Items);
            if (ret == 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceSetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonSetMAC_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            string Items = "MAC=" + textBoxControllerMAC.Text.Trim();
            int ret = DllC0402.setDeviceParam(ipaddress, Items);
            if (ret == 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceSetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetNewDeviceIP_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1
            
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1024;
            string Items = "IP";
            int ret = DllC0402.getDeviceParam(ipaddress, Buffer, BufferSize, Items);
            //int ret = dll.setDeviceParam(h, Items);
            if (ret > 0)
            {
                int startIndex = Items.Length + 1;
                textBoxNewControllerIp.Text = Buffer.ToString().Substring(startIndex, ret - startIndex);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetMask_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1

            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1024;
            string Items = "Mask";
            int ret = DllC0402.getDeviceParam(ipaddress, Buffer, BufferSize, Items);
            //int ret = dll.setDeviceParam(h, Items);
            if (ret > 0)
            {
                int startIndex = Items.Length + 1;
                textBoxControllerSubnetMask.Text = Buffer.ToString().Substring(startIndex, ret - startIndex);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetGateway_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1

            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1024;
            string Items = "Gateway";
            int ret = DllC0402.getDeviceParam(ipaddress, Buffer, BufferSize, Items);
            //int ret = dll.setDeviceParam(h, Items);
            if (ret > 0)
            {
                int startIndex = Items.Length + 1;
                textBoxControllerGateway.Text = Buffer.ToString().Substring(startIndex, ret - startIndex);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetDNS_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1

            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1024;
            string Items = "DNS";
            int ret = DllC0402.getDeviceParam(ipaddress, Buffer, BufferSize, Items);
            //int ret = dll.setDeviceParam(h, Items);
            if (ret > 0)
            {
                int startIndex = Items.Length + 1;
                textBoxControllerDNS.Text = Buffer.ToString().Substring(startIndex , ret - startIndex);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetMAC_Click(object sender, EventArgs e)
        {
            //MAC=00:17:61:01:88:27,IP=192.168.1.230,Mask=255.255.255.0,Gateway=192.168.1.1,DNS=192.168.1.1

            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1024;
            string Items = "MAC";
            int ret = DllC0402.getDeviceParam(ipaddress, Buffer, BufferSize, Items);
            if (ret > 0)
            {
                int startIndex = Items.Length + 1;
                textBoxControllerMAC.Text = Buffer.ToString().Substring(startIndex, ret - startIndex);
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonDelCardInfo_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            int ret = 0;// DllC0402.controlDevice(ipaddress, 0, RemoteControl.DelCardInfo, null);
            if (ret == 0)
            {

                MyMessageBox.MessageBoxOK("textDeleteCardInfoSucess");
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }

        private void buttonDelBlackCardInfo_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            int ret = 0;// DllC0402.controlDevice(ipaddress, 0, RemoteControl.DelCardInfo, null);
            if (ret == 0)
            {
                MyMessageBox.MessageBoxOK("textDeleteCardInfoSucess");
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }

        

        private void buttonCardInfoSum_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            int ret = DllC0402.getDeviceDataCount(ipaddress, DllC0402.CARDINFOTABLENAME, "", "");

            if (ret >= 0)
            {
                textBoxCardInfoSum.Text = ret.ToString();
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }
        private void buttonBlackCardSum_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            int ret = DllC0402.getDeviceDataCount(ipaddress, DllC0402.BLACKCARDINFOTABLENAME, "", "");

            if (ret >= 0)
            {
                textBoxBlackCardSum.Text = ret.ToString();
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

       

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            String Temp = "CardID='"+ textBoxCard.Text.Trim()+"'";
            StringBuilder Data = new StringBuilder(Temp);

            int ret = DllC0402.deleteDeviceData(ipaddress,DllC0402.CARDINFOTABLENAME, Data, "");

            if (ret >= 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeleteUserInfoSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }
        private void buttonDeleteBlackCard_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            String Temp = "CardID='" + textBoxBlackCard.Text.Trim() + "'";
            StringBuilder Data = new StringBuilder(Temp);

            int ret = DllC0402.deleteDeviceData(ipaddress, DllC0402.BLACKCARDINFOTABLENAME, Data, "");

            if (ret >= 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeleteBlackUserInfoSuccess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }


        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1000;
            string FieldNames = "CardID='" + textBoxSearchUserCardID.Text.Trim()+"'";

            int ret = DllC0402.getDeviceData(ipaddress, Buffer, BufferSize,DllC0402.CARDINFOTABLENAME, FieldNames);
            if (ret >= 0)
            {
                toolStripStatusLabel2.Text = Buffer.ToString();
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }
        private void buttonViewBlackCardID_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1000;
            string FieldNames = "CardID='" + textBoxViewBlackCardID.Text.Trim() + "'";

            int ret = DllC0402.getDeviceData(ipaddress, Buffer, BufferSize, DllC0402.BLACKCARDINFOTABLENAME, FieldNames);
            if (ret >= 0)
            {
                toolStripStatusLabel2.Text = Buffer.ToString();
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }

        }
        private void buttonSearchUserByUserName_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            StringBuilder Buffer = new StringBuilder(1024);
            int BufferSize = 1000;
            string FieldNames = "UserName='" + textBoxUserName.Text.Trim() + "'";

            int ret = DllC0402.getDeviceData(ipaddress, Buffer, BufferSize, DllC0402.CARDINFOTABLENAME, FieldNames);
            if (ret >= 0)
            {
                toolStripStatusLabel2.Text = Buffer.ToString();
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string Address = "255.255.255.255";
            StringBuilder Buffer = new StringBuilder(1024);
            int count = DllC0402.searchDevice(Address, Buffer);
            listBoxSearch.Items.Clear();
            if (count > 0)
            {
                string spli = "\r\n";
                string buffer = Buffer.ToString();
                string[] temp = buffer.Split(spli.ToCharArray());
                foreach (string str in temp)
                {
                    if (str.Contains("IP_FOUND_ACK,"))
                        listBoxSearch.Items.Add(str);
                }

            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }

        

        private void buttonSynchronizeTime_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();


            string deviceDate = "DeviceDate=" + DateTime.Now.Date.ToShortDateString() + ",";
            string deviceTime = "DeviceTime=" + DateTime.Now.ToLongTimeString() + ",";
            string deviceDateTime = deviceDate + deviceTime;

            int ret = DllC0402.setDeviceParam(ipaddress, deviceDateTime);
            if (ret == 0)
            {
                MyMessageBox.MessageBoxOK("textDeviceSetParaSucess");
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }

        private void buttonDeleteTriggerEvent_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            String Temp = "EventID='" + textBoxDeleteTriggerEvent.Text.Trim() + "'";
            StringBuilder Data = new StringBuilder(Temp);

            int ret = DllC0402.deleteDeviceData(ipaddress, DllC0402.TRRIGEREVENTTABLENAME, Data, "");

            if (ret >= 0)
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeleteBlackUserInfoSuccess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        private void buttonGetTriggerEvent_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            int ret = DllC0402.getDeviceDataCount(ipaddress, DllC0402.TRRIGEREVENTTABLENAME, "", "");

            if (ret >= 0)
            {
                textBoxGetTriggerEventSum.Text = ret.ToString();
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceGetParaSucess");
            }
            else
            {
                toolStripStatusLabel2.Text = MyMessageBox.getStringFromRes("textDeviceIsNotOnline");
            }
        }

        

        private void buttonDelTriggerEvent_Click(object sender, EventArgs e)
        {
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();

            int ret = 0;// DllC0402.controlDevice(ipaddress, 0, RemoteControl.DelTriggerEvent, null);
            if (ret == 0)
            {
                MyMessageBox.MessageBoxOK("textDeleteTriggerEventSucess");
            }
            else if (ret == -11)
            {
                MyMessageBox.MessageBoxOK("textParametersFormatError");
            }
            else
            {
                MyMessageBox.MessageBoxOK("textDeviceIsNotOnline");
            }
        }

        
        private void buttonSelectProgram_Click(object sender, EventArgs e)
        {
            //打开文件
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = fileDialog.FileName;
            }
        }
        private void buttonUpdateProgram_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.MessageBoxOkCancel("textAreYouSureToUpdateProgram") == DialogResult.OK)
            {
                string deviceIP = kryptonComboBoxControllerIp.Text.Trim();
                string filePath = textBoxFilePath.Text.Trim();
                string downLoadCmd = DllC0402.Server;

                if ((filePath == "") || (filePath == null))
                {
                    MyMessageBox.MessageBoxOK("textFilePathIsNull");
                    return;
                }
                DownLoadThread downLoadThread = new DownLoadThread(deviceIP, filePath, downLoadCmd, progressBar2);
                downLoadThread.DownLoadThreadRun();
                
            }
        }
        private void buttonSelectDataBase_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBoxDataBase.Text = fileDialog.FileName;
            }
        }

        private void buttonUpdateDataBase_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.MessageBoxOkCancel("textAreYouSureToUpdateProgram") == DialogResult.OK)
            {
                string deviceIP = kryptonComboBoxControllerIp.Text.Trim();
                string filePath = kryptonTextBoxDataBase.Text.Trim();
                string downLoadCmd = DllC0402.ControllerRelation;

                if ((filePath == "") || (filePath == null))
                { 
                    MyMessageBox.MessageBoxOK("textFilePathIsNull");
                    return;
                }

                DownLoadThread downLoadThread = new DownLoadThread(deviceIP, filePath, downLoadCmd, progressBar2);
                downLoadThread.DownLoadThreadRun();

            }
        }

        private void button_TestSetDeviceData_Click(object sender, EventArgs e)
        {
            //"ControllerID=241,ControllerType=1,ControllerName='Controller1',ControllerLocation='XXXXX',EncryptionType=0,ControllerVersion='Vxx.xx.xx-x',ControllerMAC='AA:BB:CC:DD:EE:FF',ControllerIP='192.168.1.241',ControllerSubnetMask='255.255.255.0',ControllerGateway='192.168.1.1',ControllerPort=1200,ControllerDNS='8.8.8.8',ControllerBUDNS='114.114.114.114',ControllerAddr485=0,ControllerBaudrate=115200,ControllerDataBits=8,ControllerStopBits=1,ControllerParityCheck='None',ControllerFlowControl='None',ControllerSAM=0,ControllerSAMType=0,DoorUnitCounts=2,ExpansionBoardCounts=0"
            string ipaddress = kryptonComboBoxControllerIp.Text.Trim();
            int ret = DllC0402.setDeviceData(ipaddress, "ControllerInfo",

               "ControllerID=241,ControllerType=1,ControllerName='Controller1',ControllerLocation='XXXXX',EncryptionType=0,ControllerVersion='Vxx.xx.xx-x',ControllerMAC='AA:BB:CC:DD:EE:FF',ControllerIP='192.168.1.241',ControllerSubnetMask='255.255.255.0',ControllerGateway='192.168.1.1',ControllerPort=1200,ControllerDNS='8.8.8.8',ControllerBUDNS='114.114.114.114',ControllerAddr485=0,ControllerBaudrate=115200,ControllerDataBits=8,ControllerStopBits=1,ControllerParityCheck='None',ControllerFlowControl='None',ControllerSAM=0,ControllerSAMType=0,DoorUnitCounts=2,ExpansionBoardCounts=0", "");
            //int ret = DllC0402.setDeviceData(ipaddress, "ControllerInfo", "ControllerID=241,ControllerType=1", "");

            if (ret >= 0)
            {
                MyMessageBox.MessageBoxOK("success");
            }
        }

        private void kryptonButtonTestSQLite_Click(object sender, EventArgs e)
        {

            KryptonAccessController.SQLite.Model.UserRelation.UserInfo modelUserInfo = new KryptonAccessController.SQLite.Model.UserRelation.UserInfo();
            KryptonAccessController.SQLite.BLL.UserRelation.UserInfo bllUserInfo = new KryptonAccessController.SQLite.BLL.UserRelation.UserInfo();

            modelUserInfo.UserID = bllUserInfo.GetMaxId();
            modelUserInfo.UserName = "张超";
            modelUserInfo.Photograph = null;
            modelUserInfo.UserGroupID1 = 0;
            modelUserInfo.UserGroupID2 = 0;
            modelUserInfo.UserGroupID3 = 0;
            modelUserInfo.FingerPosition0 = 0;
            modelUserInfo.FingerPosition1 = 0;
            modelUserInfo.FingerPrint0 = null;
            modelUserInfo.FingerPrint1 = null;
            modelUserInfo.SercurityAccessLevel = 0;
            modelUserInfo.PrimaryCardID = "AAAAAA";
            modelUserInfo.SecondCardID = "BBBBBB";
            bllUserInfo.Add(modelUserInfo);

        }

        private void kryptonButtonTestJson_Click(object sender, EventArgs e)
        {
            kryptonTextBoxTestJson.Text = TestJson.jsonSerialize();
        }

        private void kryptonButtonJson_Click(object sender, EventArgs e)
        {
            JsonObject json =  TestJson.jsonDeserialize(kryptonTextBoxTestJson.Text);
            kryptonTextBoxTestJson.Text ="key:"+ json.Key+",value:"+json.Value;
        }

    }
}
