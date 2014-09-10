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
using KryptonAccessController.OperationFile;
using KryptonAccessController.Common;
using KryptonAccessController.Dll;
namespace KryptonAccessController.Tool
{
    class DownLoadThread
    {
        private BackgroundWorker backgroundWorker;
        private string deviceIP = null;
        private string filePath = null;
        private string downLoadCmd = null;
        private string endFlag = "EOF";
        private System.Windows.Forms.ProgressBar progressBar;

        private Boolean isCompletedDownLoad = false;
        public DownLoadThread(string deviceIP, string filePath, string downLoadCmd, ProgressBar progressBar)
        {
            this.deviceIP = deviceIP;
            this.filePath = filePath;
            this.downLoadCmd = downLoadCmd;
            this.progressBar = progressBar;

            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownLoadThreadDoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DownLoadThreadProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DownLoadThreadRunWorkerCompleted);
            

        }
        public void DownLoadThreadRun()
        {
            if (backgroundWorker.IsBusy != true)
                backgroundWorker.RunWorkerAsync();
        }
        private void waiteDownLoadCompleted(int FTPHandle2)
        {
            
        }

        private void DownLoadThreadDoWork(object sender, DoWorkEventArgs e)
        {

            int handle = DllC0402.setDeviceStringCmd(deviceIP, downLoadCmd, "");

            if (handle < 0)
                return;
            System.Threading.Thread.Sleep(50);
            DllC0402.disconnectDevice(handle);

            int FTPHandle1 = DllC0402.connectFTP1(deviceIP);
            if (FTPHandle1 < 0)
                return;
            ///发送数据库
            FileStream read = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buff = new byte[1024];
            long fileLen = read.Length, lenCurrent = 0;
            int len = 0;

            isCompletedDownLoad = false;
            while ((len = read.Read(buff, 0, 1024)) != 0)
            {
                lenCurrent += len;
                DllC0402.setDevicStringData(FTPHandle1, buff, len, "");
                backgroundWorker.ReportProgress((int)((lenCurrent * 100 / fileLen)));
            }
            DllC0402.setDevicStringData(FTPHandle1, endFlag, "");

            ///判断数据库是否发送成功
            StringBuilder Buffer = new StringBuilder(1024);
            int flag = DllC0402.getRTLog(FTPHandle1, Buffer, 25);
            if (flag <= 0)
                return;
            else if (Buffer.ToString().Substring(0, flag).Equals(fileLen.ToString()))
            {
                isCompletedDownLoad = true;
            }

            
            DllC0402.disconnectDevice(FTPHandle1);
            
        }
        private void DownLoadThreadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void DownLoadThreadRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            Thread.Sleep(100);

            if (e.Cancelled == true)
            {
                MyMessageBox.MessageBoxOK("UpdateProgramCancelled");
            }
            else if (e.Error != null)
            {
                MyMessageBox.MessageBoxOK("UpdateProgramError");
            }
            else if (isCompletedDownLoad == true)
            {
                progressBar.Value = 100;
                MyMessageBox.MessageBoxOK("UpdateProgramFinished");
            }
            else
            {
                MyMessageBox.MessageBoxOK("UpdateProgramError");
            }

            progressBar.Value = 0;
        }
    }
}
