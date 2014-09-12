using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

using KryptonAccessController.OperationFile;
using KryptonAccessController.RelationManage;
namespace KryptonAccessController
{
    public enum ReturnValue {Fail = -5,NotAvailable = -4,Exist = -3,Unkonwn=-2,NotExist = -1,Success = 0 };
    public enum Language { Error = 0, Chinese = 1, English = 2 };
    public enum OpenMode { Add, Update, View,ChangeCard,Login,Unclock };
    public enum ModeValue { edit = 0, save = 1 };
    public enum DoorUnitState { Close = 1, Open };
    public enum RealWatchState { Close =1,Open };
    public struct Time1
    {
        public int hour;
        public int minute;
        public int second;
        public Time1(int hour,int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
    public class Admin
    {
        public static string name;
        public static string password;
    }

    static class Program
    {
        //IniFile iniFile = new IniFile();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //.InstalledUICulture.Name
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDataBase());
            //Application.Run(new Tool.KryptonFormDeviceManage());
        }
    }
}