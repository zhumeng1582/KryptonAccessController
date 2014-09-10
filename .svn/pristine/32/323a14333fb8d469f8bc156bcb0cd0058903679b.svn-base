using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;

namespace KryptonAccessController.Dll
{
    class Dll530_S_A
    {

        IntPtr m_hComm;
        int m_CommPort, m_BandRate;
        private const string dllpath = @"All.dll";

        public Dll530_S_A()
        {
            m_hComm = IntPtr.Zero;
            m_CommPort = 0;
            m_BandRate = 0;
        }

        public IntPtr GetHComm()
        {
            return m_hComm;
        }

        [DllImport(dllpath, EntryPoint = "API_GetSysComm")]
        static extern int API_GetSysComm(ref byte buffer);
        public int GetSysComm(ref byte buffer)          //获得系统串口
        {
            return API_GetSysComm(ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_OpenComm")]
        static extern IntPtr API_OpenComm(int nCom, int nBaudrate);
        public int OpenComm(int com, int bp) //打开串口
        {
            if (IntPtr.Zero != m_hComm)
                return 1;
            if (com < 1 || com > 8)
                return 3;
            m_hComm = API_OpenComm(com, bp);
            if (IntPtr.Zero == m_hComm)
                return 2;

            m_CommPort = com;
            m_BandRate = bp;
            return 0;
        }

        [DllImport(dllpath, EntryPoint = "API_CloseComm")]
        static extern bool API_CloseComm(IntPtr commHandle);
        public int CloseComm()      //关闭串口
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            bool ret = API_CloseComm(m_hComm);
            if (!ret)
                return 2;

            m_hComm = IntPtr.Zero;
            return 0;
        }

        [DllImport(dllpath, EntryPoint = "API_SetBaudrate")]
        static extern int API_SetBaudrate(IntPtr commHandle, int DeviceAddress, byte newBaud, ref byte buffer);
        public int SetBaudrate(int DeviceAddress, byte newBaud, ref byte buffer)     //设置波特率
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_SetBaudrate(m_hComm, DeviceAddress, newBaud, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ControlBuzzer")]
        static extern int API_ControlBuzzer(IntPtr commHandle, int DeviceAddress, byte freq, byte duration, ref byte buffer);
        public int ControlBuzzer(int DeviceAddress, byte freq, byte duration, ref byte buffer)     //设置波特率
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ControlBuzzer(m_hComm, DeviceAddress, freq, duration, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_GetVersionNum")]
        static extern int API_GetVersionNum(IntPtr commHandle, int DeviceAddress, ref byte VersionNum);
        public int GetVersionNum(int DeviceAddress, ref byte VersionNum)                 //读取版本号
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_GetVersionNum(m_hComm,DeviceAddress, ref VersionNum);
        }

        [DllImport(dllpath, EntryPoint = "API_GetSerNum")]
        static extern int API_GetSerNum (IntPtr commHandle, int DeviceAddress,ref byte buffer);
        public int GetSerNum(int DeviceAddress, ref byte buffer)                 //读取序列号
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_GetSerNum(m_hComm, DeviceAddress, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_SetDeviceAddress")]
        static extern int API_SetDeviceAddress(IntPtr commHandle, int DeviceAddress,byte newAddr, ref byte buffer);
        public int SetDeviceAddress(int DeviceAddress, byte newAddr, ref byte buffer)                 //设置设备地址
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_SetDeviceAddress(m_hComm, DeviceAddress,newAddr, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_SetSerNum")]
        static extern int  API_SetSerNum (IntPtr commHandle, int DeviceAddress,ref byte newValue,ref byte buffer);
        public int SetSerNum(int DeviceAddress, ref byte newValue, ref byte buffer)                 //设置序列号
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_SetSerNum(m_hComm, DeviceAddress,ref newValue, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_WriteUserInfo")]
        static extern int API_WriteUserInfo(IntPtr commHandle, int DeviceAddress, int num_blk, int num_length,ref byte user_info);
        public int WriteUserInfo(int DeviceAddress, int num_blk, int num_length, ref byte buffer)                 //设置用户信息
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_WriteUserInfo(m_hComm, DeviceAddress,num_blk, num_length, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ReadUserInfo")]
        static extern int API_ReadUserInfo(IntPtr commHandle, int DeviceAddress, int num_blk, int num_length,ref byte buffer);
        public int ReadUserInfo(int DeviceAddress, int num_blk, int num_length, ref byte buffer)                 //读取用户信息
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ReadUserInfo(m_hComm, DeviceAddress,num_blk, num_length, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ControlLED")]
        static extern int API_ControlLED(IntPtr commHandle, int DeviceAddress,byte freq,byte duration,ref byte buffer);
        public int ControlLED(int DeviceAddress, byte freq, byte duration, ref byte buffer)                 //设置LED
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ControlLED(m_hComm, DeviceAddress, freq, duration, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_Inventory")]
        static extern int API_ISO15693_Inventory(IntPtr commHandle, int deviceAddress, byte flag, byte afi, byte datalen, ref byte pData, ref byte nrOfCard, ref byte pBuffer);
        public int ISO15693_Inventory(int DeviceAddress, byte flag, byte afi, byte datalen, ref byte pData, ref byte nrOfCard, ref byte pBuffer)                 //设置LED
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_Inventory(m_hComm, DeviceAddress, flag, afi, datalen, ref pData, ref nrOfCard, ref pBuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_Read")]
        static extern int API_ISO15693_Read(IntPtr commHandle, int DeviceAddress, byte flags, byte blk_add, byte num_blk, ref byte uid, ref byte returnlen, ref byte buffer);
        public int ISO15693_Read(int DeviceAddress,byte flags, byte blk_add, byte num_blk, ref byte uid, ref byte returnlen, ref byte buffer)                 //设置LED
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_Read(m_hComm, DeviceAddress, flags, blk_add, num_blk, ref uid, ref returnlen, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_GetMulSecurity")]
        static extern int API_ISO15693_GetMulSecurity(IntPtr commHandle, int deviceAddress,byte flag, byte blkAddr, byte blkNum,ref byte uid,ref byte flags,ref byte returnlen,ref byte pBuffer);
        public int ISO15693_GetMulSecurity(int deviceAddress,byte flag, byte blkAddr, byte blkNum,ref byte uid,ref byte flags,ref byte returnlen,ref byte pBuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_GetMulSecurity(m_hComm,deviceAddress,flag, blkAddr, blkNum,ref uid,ref flags,ref returnlen,ref pBuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_Write")]
        static extern int API_ISO15693_Write(IntPtr commHandle, int DeviceAddress, byte flags, byte blk_add, byte num_blk, ref byte uid, ref byte data);
        public int ISO15693_Write( int DeviceAddress, byte flags, byte blk_add, byte num_blk, ref byte uid, ref byte data)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_Write(m_hComm,DeviceAddress, flags, blk_add, num_blk, ref uid, ref data);
        }


        [DllImport(dllpath, EntryPoint = "API_ISO15693_GetSysInfo")]
        static extern int API_ISO15693_GetSysInfo(IntPtr commHandle, int deviceAddress,byte flag,ref byte uid,ref byte buffer);
        public int ISO15693_GetSysInfo(  int deviceAddress,byte flag,ref byte uid,ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_GetSysInfo(m_hComm, deviceAddress,flag,ref uid,ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_StayQuiet")]
        static extern int API_ISO15693_StayQuiet(IntPtr commHandle,int DeviceAddress,byte flags,ref byte uid,ref byte buffer);
        public int ISO15693_StayQuiet(int deviceAddress, byte flag, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_StayQuiet(m_hComm, deviceAddress, flag, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_Select")]
        static extern int API_ISO15693_Select(IntPtr commHandle,int DeviceAddress,byte flags,ref byte uid,ref byte buffer);
        public int ISO15693_Select(int deviceAddress, byte flag, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_Select(m_hComm, deviceAddress, flag, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_ResetToReady")]
        static extern int API_ISO15693_ResetToReady(IntPtr commHandle, int DeviceAddress, byte flags, ref byte uid, ref byte buffer);
        public int ISO15693_ResetToReady(int deviceAddress, byte flag, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_ResetToReady(m_hComm, deviceAddress, flag, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_WriteAFI")]
        static extern int API_ISO15693_WriteAFI(IntPtr commHandle,int DeviceAddress,byte flags,byte afi,ref byte uid,ref byte buffer);
        public int ISO15693_WriteAFI(int deviceAddress, byte flags, byte afi, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_WriteAFI(m_hComm, deviceAddress, flags, afi, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_WriteDSFID")]
        static extern int API_ISO15693_WriteDSFID(IntPtr commHandle,int DeviceAddress,byte flags,byte DSFID,ref byte uid,ref byte buffer);
        public int ISO15693_WriteDSFID(int deviceAddress, byte flags, byte DSFID, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_WriteDSFID(m_hComm, deviceAddress, flags, DSFID, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_LockAFI")]
        static extern int API_ISO15693_LockAFI(IntPtr commHandle, int DeviceAddress, byte flags, ref byte uid, ref byte buffer);
        public int ISO15693_LockAFI(int deviceAddress, byte flags, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_LockAFI(m_hComm, deviceAddress, flags,  ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_LockDSFID")]
        static extern int API_ISO15693_LockDSFID(IntPtr commHandle, int DeviceAddress, byte flags, ref byte uid, ref byte buffer);
        public int ISO15693_LockDSFID(int deviceAddress, byte flags, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_LockDSFID(m_hComm, deviceAddress, flags, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_Lock")]
        static extern int API_ISO15693_Lock(IntPtr commHandle,int DeviceAddress,byte flags,byte num_blk,ref byte uid,ref byte buffer);
        public int ISO15693_Lock(int DeviceAddress, byte flags, byte num_blk, ref byte uid, ref byte buffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_Lock(m_hComm, DeviceAddress, flags, num_blk, ref uid, ref buffer);
        }

        [DllImport(dllpath, EntryPoint = "API_ISO15693_TransCmd")]
        static extern int API_ISO15693_TransCmd(IntPtr commHandle, int DeviceAddress,ref byte cmd, int cmdSize,ref byte returnlen,ref byte pbuffer);
        public int ISO15693_TransCmd(int DeviceAddress, ref byte cmd, int cmdSize, ref byte returnlen, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_ISO15693_TransCmd(m_hComm, DeviceAddress, ref cmd, cmdSize, ref returnlen, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Request")]
        static extern int API_MF_Request(IntPtr commHandle, int DeviceAddress, byte inf_mode, ref byte pbuffer);
        public int MF_Request(int DeviceAddress, byte inf_mode, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Request(m_hComm, DeviceAddress, inf_mode, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Anticoll")]
        static extern int API_MF_Anticoll(IntPtr commHandle, int DeviceAddress,ref byte flag, ref byte pbuffer);
        public int MF_Anticoll(int DeviceAddress, ref byte flag, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Anticoll(m_hComm, DeviceAddress, ref flag, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Select")]
        static extern int API_MF_Select(IntPtr commHandle, int DeviceAddress, ref byte uid, ref byte pbuffer);
        public int MF_Select(int DeviceAddress, ref byte uid, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Select(m_hComm, DeviceAddress, ref uid, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Halt")]
        static extern int API_MF_Halt(IntPtr commHandle, int DeviceAddress);
        public int MF_Halt(int DeviceAddress)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Halt(m_hComm, DeviceAddress);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_GET_SNR")]
        static extern int API_MF_GET_SNR(IntPtr commHandle, int DeviceAddress,byte mode ,byte cmd,ref byte flag, ref byte pbuffer);
        public int MF_GET_SNR(int DeviceAddress,byte mode ,byte cmd,ref byte flag, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_GET_SNR(m_hComm, DeviceAddress, mode, cmd, ref flag, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Read")]
        static extern int API_MF_Read(IntPtr commHandle, int DeviceAddress, byte mode, byte blk_add,byte num_blk, ref byte snr, ref byte pbuffer);
        public int MF_Read(int DeviceAddress, byte mode, byte blk_add, byte num_blk, ref byte snr, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Read(m_hComm, DeviceAddress, mode, blk_add, num_blk, ref snr, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Write")]
        static extern int API_MF_Write(IntPtr commHandle, int DeviceAddress, byte mode, byte blk_add, byte num_blk, ref byte key, ref byte pbuffer);
        public int MF_Write(int DeviceAddress, byte mode, byte blk_add, byte num_blk, ref byte key, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Write(m_hComm, DeviceAddress, mode, blk_add, num_blk, ref key, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_InitVal")]
        static extern int API_MF_InitVal(IntPtr commHandle, int DeviceAddress, byte mode, byte sec_num, ref byte key, int value, ref byte pbuffer);
        public int MF_InitVal(int DeviceAddress, byte mode, byte sec_num, ref byte key, int value, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_InitVal(m_hComm, DeviceAddress, mode, sec_num, ref key, value, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Dec")]
        static extern int API_MF_Dec(IntPtr commHandle, int DeviceAddress, byte mode, byte sec_num, ref byte key, int value, ref int result, ref byte pbuffer);
        public int MF_Dec(int DeviceAddress, byte mode, byte sec_num, ref byte key, int value, ref int result, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Dec(m_hComm, DeviceAddress, mode, sec_num, ref key, value, ref result, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_Inc")]
        static extern int API_MF_Inc(IntPtr commHandle, int DeviceAddress, byte mode, byte sec_num, ref byte key, int value, ref int result, ref byte pbuffer);
        public int MF_Inc(int DeviceAddress, byte mode, byte sec_num, ref byte key, int value, ref int result, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_Inc(m_hComm, DeviceAddress, mode, sec_num, ref key, value,ref result, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_MF_TransferCMD")]
        static extern int API_MF_TransferCMD(IntPtr commHandle, int DeviceAddress, byte mode, byte cmdlength, ref byte cmd,ref byte returnlen, ref byte pbuffer);
        public int MF_TransferCMD(int DeviceAddress, byte mode, byte cmdlength, ref byte cmd, ref byte returnlen, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_MF_TransferCMD(m_hComm, DeviceAddress, mode, cmdlength, ref cmd,ref returnlen, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_Request_B")]
        static extern int API_Request_B(IntPtr commHandle, int DeviceAddress,ref byte returnlen, ref byte pbuffer);
        public int Request_B(int DeviceAddress,ref byte returnlen, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_Request_B(m_hComm, DeviceAddress, ref returnlen, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_RESET_B")]
        static extern int API_RESET_B(IntPtr commHandle, int DeviceAddress, ref byte pbuffer);
        public int RESET_B(int DeviceAddress, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_RESET_B(m_hComm, DeviceAddress, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_Anticoll_B")]
        static extern int API_Anticoll_B(IntPtr commHandle, int DeviceAddress,ref byte returnlen, ref byte pbuffer);
        public int Anticoll_B(int DeviceAddress,ref byte returnlen, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_Anticoll_B(m_hComm, DeviceAddress, ref returnlen, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_Attrib_B")]
        static extern int API_Attrib_B(IntPtr commHandle, int DeviceAddress, ref byte SerialNum, ref byte pbuffer);
        public int Attrib_B(int DeviceAddress, ref byte SerialNum, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_Attrib_B(m_hComm, DeviceAddress, ref SerialNum, ref pbuffer);
        }

        [DllImport(dllpath, EntryPoint = "API_TransferCMD_B")]
        static extern int API_TransferCMD_B(IntPtr commHandle, int DeviceAddress, byte cmdSize, ref byte cmd, ref byte returnlen, ref byte pbuffer);
        public int TransferCMD_B(int DeviceAddress, byte cmdSize, ref byte cmd, ref byte returnlen, ref byte pbuffer)
        {
            if (IntPtr.Zero == m_hComm)
                return 1;
            return API_TransferCMD_B(m_hComm, DeviceAddress, cmdSize, ref cmd, ref returnlen, ref pbuffer);
        }
    }
}
