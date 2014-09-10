using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Threading;
namespace KryptonAccessController.Dll
{
    class DllC0402
    {
        //IP协议端口定义
        public static readonly string TCP_PORT = "1200";
        
        public static readonly string UDP_PORT = "1202";
        public static readonly string LOG_PORT = "1203";
        public static readonly string FTP_PORT1 = "1204";
        public static readonly string FTP_PORT2 = "1205";
        public static readonly string TIMEOUT = "20";
        public static readonly string PASSWORD = "123456";

        public static readonly string CARDINFOTABLENAME = "CardInfo";
        public static readonly string TIMEACCESSTABLENAME = "TimeAccess";
        public static readonly string TRRIGEREVENTTABLENAME = "TriggerEvent";
        public static readonly string BLACKCARDINFOTABLENAME = "BlackCardInfo";
        public static readonly string TIMEHOLIDAYTABLENAME = "TimeHoliday";
        public static readonly string Server = "server";
        //public static readonly string Contrldb = "contrldb.db";
        public static readonly string ControllerRelation = "ControllerRelation.db";


        //上传的实时数据长度定义
        //public static readonly string REAlDATALENREADCARD = 40;              //刷卡记录总长度
        public const string REAlDATALENREADCARD = "40";
        public const string REAlDATALENTRIGGERE = "35";              //刷卡记录总长度

        public static readonly int DOORNUMLEN = 7;                //门编号长度"2420101"
        public static readonly int CARDLEN = 6;                   //刷号长度"789568"
        public static readonly int SATELEN = 4;                   //状态长度"0025"
        public static readonly int TIMELEN = 19;                  //时间长度"2013-08-06 09:45:50"

        public static readonly int NORETURN = -2;                   //命令没有回应

        public const string CLOSE = "0";
        public const string OPEN = "1";
        public const string PERIODOPEN = "2";

        public const string REMOTEOPEN = "2111";
        public const string REMOTENORMALOPEN = "2121";
        public const string BUTTONOPEN = "3111";
        public const string ACARDOPEN = "8A11";

        public const string CCARDOPEN = "8C11";
        public const string CHOLIDAYOPEN = "8C21";

        public const string DCARDOPEN = "8D11";
        public const string DHOLIDAYOPEN = "8D21";

        public const string ALARMOPEN = "3311";

        public const string REMOTECLOSE = "2110";
        public const string REMOTENORMALCLOSE = "2120";
        public const string BUTTONCLOSE = "3110";
        public const string ACARDCLOSE = "8AF0";
        public const string CCARDCLOSE = "8CF0";
        public const string DCARDCLOSE = "8DF0";
        //public const string ALARMCLOSE = "3310";

        //private static readonly string dllpath = @"Dll\Mdoor.dll";
        private const string dllpath = @"Mdoor.dll";

        public static bool pingDevice(String IP)
        {
            int handle = testOnline(IP);
            if (handle >= 0)
            {
                disconnectDevice(handle);
                return true;
            }
            else
                return false;
        }
        //连接设备
        [DllImport(dllpath, EntryPoint = "Connect")]
        static extern int Connect(string Parameters);
        public static int connectDevice(string buffer)          
        {
            int ret=0;
            //CancellationTokenSource cts = new CancellationTokenSource();
           
            ret = Connect(buffer);

            return ret;
        }
        public static int testOnline(string ipaddress)
        {
            string param = "protocol=TCP,ipaddress=" + ipaddress + ",port=" + TCP_PORT + ",timeout=" + TIMEOUT + ",passwd=" + PASSWORD;  
            return DllC0402.connectDevice(param);
        }

        //断开设备
        [DllImport(dllpath, EntryPoint = "Disconnect")]
        static extern void Disconnect(int handle);
        public static void disconnectDevice(int handle)          
        {
            Disconnect(handle);
        }
        //设置设备参数
        [DllImport(dllpath, EntryPoint = "SetDeviceParam")]
        static extern int SetDeviceParam(int handle,string ItemValues);
        public static int setDeviceParam(string ipaddress, string ItemValues)          
        {
            int handle=0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return SetDeviceParam(handle, ItemValues);
                else 
                    return NORETURN; 
            }
            finally 
            { 
                disconnectDevice(handle);
            }
        }
        //获取设备参数
        [DllImport(dllpath, EntryPoint = "GetDeviceParam")]
        static extern int GetDeviceParam(int handle, StringBuilder Buffer, int BufferSize, String Items);
        public static int getDeviceParam(string ipaddress, StringBuilder Buffer, int BufferSize, String Items)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return GetDeviceParam(handle, Buffer, BufferSize, Items);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }
        
        //设置设备参数
        [DllImport(dllpath, EntryPoint = "SetDeviceData")]
        static extern int SetDeviceData(int handle, string tablename, string data, string options);
        public static int setDeviceData(string ipaddress,string tablename,string data,string options)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return SetDeviceData(handle, tablename, data, options);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }
    
        //设置设备密码
        [DllImport(dllpath, EntryPoint = "SetPassword")]
        static extern int SetPassword(int handle,string Passwd);
        public static int setPassword(string ipaddress, string Passwd)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return SetPassword(handle, Passwd);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }

        //下发文件
        [DllImport(dllpath, EntryPoint = "SetDeviceFileData")]
        static extern int SetDeviceFileData(int handle,string Parameters, string filename, string options);
        public static int setDeviceFileData(string ipaddress, string Parameters, string filename, string options)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return SetDeviceFileData(handle, Parameters, filename, options);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }
        public static int connectLOG(string Ip)
        {
            string param = "protocol=TCP,ipaddress=" + Ip + ",port=" + DllC0402.LOG_PORT + ",timeout=" + DllC0402.TIMEOUT + ",";
            return DllC0402.connectDevice(param);
        }
        //开启实时监控
        [DllImport(dllpath, EntryPoint = "SetRTLogCMD")]
        static extern int SetRTLogCMD(int handle);
        public static int setRTLogCMD(string ipaddress)
        { 
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return SetRTLogCMD(handle);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }

        //实时监控
        [DllImport(dllpath, EntryPoint = "GetRTLog")]
        static extern int GetRTLog(int handle, StringBuilder Buffer, int BufferSize);
        public static int getRTLog(int handle, StringBuilder Buffer, int BufferSize)
        {
            return GetRTLog(handle, Buffer, BufferSize);
        }
        [DllImport(dllpath, EntryPoint = "GetDeviceDataCount")]
        static extern int GetDeviceDataCount(int handle, string TableName,string Filter,string Options);
        public static int getDeviceDataCount(string ipaddress, string TableName, string Filter, string Options)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return GetDeviceDataCount(handle, TableName, Filter, Options);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }

        [DllImport(dllpath, EntryPoint = "DeleteDeviceData")]
        static extern int DeleteDeviceData(int handle, string TableName, StringBuilder Data, string Options);
        public static int deleteDeviceData(string ipaddress, string TableName, StringBuilder Data, string Options)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return DeleteDeviceData( handle,TableName,  Data,Options);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }
       
        [DllImport(dllpath, EntryPoint = "GetDeviceData")]
        static extern int GetDeviceData(int handle, StringBuilder Buffer, int BufferSize, string TableName, string FieldNames, string Filter, string Options);
        public static int getDeviceData(string ipaddress, StringBuilder Buffer, int BufferSize, string TableName, string FieldNames)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return GetDeviceData( handle,  Buffer,  BufferSize,  TableName,  FieldNames,"",  "");
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
        }
        [DllImport(dllpath, EntryPoint = "SearchDevice")]
        static extern int SearchDevice(string CommType, string Address, StringBuilder Buffer);
        public static int searchDevice( string Address, StringBuilder Buffer)
        {
            return SearchDevice("TCP",  Address,  Buffer);
        }
        
        public static int connectFTP1(string Ip)
        {
            string param = "protocol=TCP,ipaddress=" + Ip + ",port=" + DllC0402.FTP_PORT1 + ",timeout=" + DllC0402.TIMEOUT + ",";
            return DllC0402.connectDevice(param);
        }
        public static int connectFTP2(string Ip)
        {
            string param = "protocol=TCP,ipaddress=" + Ip + ",port=" + DllC0402.FTP_PORT2 + ",timeout=" + DllC0402.TIMEOUT + ",";
            return DllC0402.connectDevice(param);
        }

        [DllImport(dllpath, EntryPoint = "SetDevicStringData")]
        static extern int SetDevicStringData(int handle,byte[] text, int textSize, string Options);

        public static int setDevicStringData(int handle, byte[] text, int textSize, string Options)
        {
            return SetDevicStringData(handle, text,textSize, Options);
        }
        
        public static int setDevicStringData(int handle, string text,string Options)
        {
            Byte[] byteArray = System.Text.Encoding.Default.GetBytes(text);
            int len = byteArray.Length;

            return  SetDevicStringData(handle, byteArray, byteArray.Length, Options);
            //if (ret == 0)
            //{
            //    StringBuilder Buffer= new StringBuilder(4);
            //    ret = getRTLog(handle, Buffer, 4);

            //    string lenStr = Buffer.ToString().Substring(0,ret);

            //    if(int.TryParse(lenStr,out len))
            //        if (len == int.Parse(lenStr))
            //            return 0;
            //}
        }

        [DllImport(dllpath, EntryPoint = "SetDeviceStringCmd")]
        static extern int SetDeviceStringCmd(int handle, String FileName, string Options);
        public static int setDeviceStringCmd(string ipaddress, String FileName, string Options)
        {
            int handle = 0;
            try
            {
                handle = testOnline(ipaddress);
                if (handle > 0)
                    return SetDeviceStringCmd(handle, FileName, Options);
                else
                    return NORETURN;
            }
            finally
            {
                disconnectDevice(handle);
            }
            
        }
    }
}
