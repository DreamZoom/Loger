using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hetao.Framework.Loger
{
    public class FileLoger : ILoger
    {
        public void Info(string info)
        {
            WriteLog(string.Format("info\t{0}",info));
        }

        public void Error(string err)
        {
            WriteLog(string.Format("error\t{0}", err));
        }

        public void Debug(params object[] objects)
        {
            WriteLog(string.Format("debug\t{0}", string.Join("\t\t", objects)));
        }

        public void Warning(string warning)
        {
            WriteLog(string.Format("warning\t{0}", warning));
        }

        private string getLogFile()
        {
            string path = string.Format("{0}/log",System.Environment.CurrentDirectory) ;

            //如果文件夹不存在，则创建
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filename = string.Format("{0}/{1}.txt",path, DateTime.Now.ToString("yyyy-MM-dd"));
            return filename;
        }

        private void WriteLog(object obj)
        {
            string filename = getLogFile();

            List<string> contents = new List<string>();
            contents.Add(string.Format("{0}\t{1}",DateTime.Now,obj));
            try
            {
                //写入文件
                File.AppendAllLines(filename, contents);
            }
            catch{}
            
        }
    }
}
