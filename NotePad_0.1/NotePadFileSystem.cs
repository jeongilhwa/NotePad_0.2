using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotePad_0._1
{
    public enum FileSystemMessageBox
    {
        SaveFile,
        UnsaveFile,
        Cancel
    }
    public class NotePadFileSystem
    {
        string saveFileName = string.Empty;
        private StringBuilder OpenFileString = new StringBuilder();


        public string DoOpenFile(string strFilePath)
        {
            StreamReader OpenFilSystem = new StreamReader(strFilePath, Encoding.UTF8, true);
            while (OpenFilSystem.EndOfStream == false)
            {
                OpenFileString.Append(OpenFilSystem.ReadLine());
                OpenFileString.Append("\r\n");
            }
            return OpenFileString.ToString();
        }

    }
}
