using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace KryptonAccessController.OperationFile
{
    class TxtFile
    {
        string path = null;
        public TxtFile(string path)
        {
            this.path = path;
        }
        public void clearFile()
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            //获得字节数组
            byte[] data = new UTF8Encoding().GetBytes("");
            //开始写入
            fs.Write(data, 0, data.Length);

            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        public void writeFile(string txtLine)
        {   
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write); 
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(txtLine);
            sw.Close();
            fs.Close();
            /*
            FileStream fs = new FileStream(path,FileMode.Create);
            //获得字节数组
            byte[] data = new UTF8Encoding().GetBytes(txtLine);
            //开始写入
            fs.Write(data, 0, data.Length);
            
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
             */
        }
        public ArrayList readFile()
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

            StreamReader objReader = new StreamReader(fs,Encoding.Default);
            string sLine = "";
            ArrayList LineList = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null && !sLine.Equals(""))
                    LineList.Add(sLine);
            }
            objReader.Close();
            fs.Close();
            return LineList;
        }
    }
}
