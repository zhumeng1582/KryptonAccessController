using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;
using KryptonAccessController.OperationFile;

namespace KryptonAccessController.International
{
    class Internation
    {
        static ResourceManager rm = null;
        Language languageType;
        private static Internation instance = null;
        public static Internation getInstance()
        {
            if (instance == null)
            {
                instance = new Internation();
            }
            return instance;
        }

        private Internation()
        {
            languageType = getLanguageTypeFromIniFile();
            if (languageType == Language.English)
            {
                rm = new ResourceManager("AccessController.Stringsen-us", Assembly.GetExecutingAssembly());
            }
            else if (languageType == Language.Chinese)
            {
                rm = new ResourceManager("AccessController.Stringszh-cn", Assembly.GetExecutingAssembly());
            }
        }

        public Language getLanguageTypeFromIniFile()
        {
            string type = IniFile.getStartUpLanguage();
            Language ret;
            switch (type)
            {
                case "Chinese": ret = Language.Chinese; break;
                case "English": ret = Language.English; break;
                default: ret = Language.Error; break;
            }
            return ret;
        }
        public Language getCurrentLanguageType()
        {
            return languageType;
        }

        public void setLanguageType(Language languageType)
        {
            switch (languageType)
            {
                case Language.Chinese: IniFile.setStartUpLanguage("Chinese"); break;
                case Language.English: IniFile.setStartUpLanguage("English"); break;
                default: IniFile.setStartUpLanguage("Error"); break;
            }
        }

        public string GetString(string name)
        {
            return rm.GetString(name);
        }
    }
}
