using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using KryptonAccessController.Dll;
using System.Windows.Forms;

namespace KryptonAccessController.RelationRealTimeMoni
{
    class RealTimeMonitor
    {
        private Thread real;
        private int readTimeMonitorHandle = 0;
        private bool isrealwatch = false;
        private string ipAddress;

        private FormRealTimeMoni formRealTimeMoni;

        public RealTimeMonitor(FormRealTimeMoni formRealTimeMoni,string ipAddress)
        {
            this.formRealTimeMoni = formRealTimeMoni;
            this.ipAddress = ipAddress;
        }


        public void remoteControlToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        public void delAccessPointToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        public delegate void addReadCardRealWatchData(ListView lv,string buffer);
        
        public void openRealTimeMonitorPort()
        {
            int ret = DllC0402.setRTLogCMD(ipAddress);
            if (ret != 0)
                return;
            readTimeMonitorHandle = DllC0402.connectLOG(ipAddress);
            if (readTimeMonitorHandle <= 0)
                return;

            isrealwatch = true;

            real = new Thread(realWatch);
            real.IsBackground = true;
            real.Start(readTimeMonitorHandle);
        }
        public void closeRealTimeMonitorPort()
        {
            isrealwatch = false;

            DllC0402.disconnectDevice(readTimeMonitorHandle);
        }

        private void realWatch(object h)
        {
            int handle = Convert.ToInt32(h);
            StringBuilder Buffer = new StringBuilder(1024);
            addReadCardRealWatchData addReadCardRealWatchDataToListView = formRealTimeMoni.addReadCardRealWatchDataToListView;
            
            while (isrealwatch == true)
            {

                int flag = DllC0402.getRTLog(handle, Buffer, 5);
                if (flag <= 0)
                    continue;
                string strCount = Buffer.ToString().Substring(0, 4);
                int intCount = int.Parse(strCount);

                flag = DllC0402.getRTLog(handle, Buffer, intCount);
                if (flag <= 0)
                    continue;
                formRealTimeMoni.Invoke(addReadCardRealWatchDataToListView,formRealTimeMoni.listView1, Buffer.ToString());
            }
        }
    }
}
