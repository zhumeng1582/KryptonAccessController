using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KryptonAccessController.OperationFile
{
    class Win32
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展
        const int AW_CENTER = 0x0010;
        //激活窗口,在使用了AW_HIDE标志后不要使用这个标志。
        const int AW_ACTIVATE = 0x20000;
        //隐藏窗口，缺省则显示窗口
        const int AW_HIDE = 0x00010000;
        //使用滑动类型,缺省则为滚动动画类型,当使用AW_CENTER标志时，这个标志就被忽略
        const int AW_SLIDE = 0x00040000;
        //自下向上显示窗口,该标志可以在滚动动画和滑动动画中使用,当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_NEGATIVE = 0x00000008;
        //使用淡出效果,只有当hWnd为顶层窗口的时候才可以使用此标志
        const int AW_BLEND = 0x00080000;

        public static bool animateWindowCenter(IntPtr Handle, int time)
        {
            return AnimateWindow(Handle, time, AW_CENTER | AW_ACTIVATE);
        }
        public static bool animateWindowHide(IntPtr Handle, int time)
        {
            return AnimateWindow(Handle, time, AW_SLIDE + AW_VER_NEGATIVE + AW_HIDE);
        }

        public static bool animateWindowNegative(IntPtr Handle, int time)
        {
            return AnimateWindow(Handle, time, AW_SLIDE + AW_VER_NEGATIVE);
        }


        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        public static bool WriteValue(string sPath,string section, string key, string value)
        {
            return WritePrivateProfileString(section, key, value, sPath);

        }

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);
        public static string ReadValue(string sPath,string section, string key)
        {
            
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, sPath);
            if (i == 0)
                return null;
            else
                return temp.ToString();
        }


        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool SetCursorPos(int X, int Y);
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool GetCursorPos(out Point lpPoint);

        public enum MouseEventFlags
        {
            LEFTDOWNE = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        /// <summary>
        /// 模拟鼠标按下
        /// </summary>
        /// <param name="lpPoint">鼠标按下的位置</param>
        public static void simulateDeviceMouseDown(Point lpPoint)
        {
            //先释放鼠标
            mouse_event((int)(MouseEventFlags.LEFTUP | MouseEventFlags.ABSOLUTE), 0, 0, 0, 0);
            //将鼠标移动到指定位置
            SetCursorPos(lpPoint.X + 5, lpPoint.Y + 5);
            //在模拟鼠标按下
            mouse_event((int)(MouseEventFlags.LEFTDOWNE | MouseEventFlags.ABSOLUTE), lpPoint.X, lpPoint.Y, 0, 0);
        }
    }
}
