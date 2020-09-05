using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using MySql.Data.MySqlClient;

namespace FormSchool.Libraries
{

    class FileIO
    {
        public void msg(string param)
        {
            MessageBox.Show(param);
        }
        public string[] aCurrentDir()
        {
            int AsciCode = 92;
            char separator = (char)AsciCode;
            string[] returnValue = Directory.GetCurrentDirectory().Split(separator);
            return Directory.GetCurrentDirectory().Split(separator);
        }

        /*
        public string solutionName()
        {
            String solutionName = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
            msg(solutionName); 
            return solutionName.Substring(0, solutionName.IndexOf("."));
        } 
        */

        public string solutionDir()
        {
            string returnValue = "";
            string comma = "";
            string[] aDir = aCurrentDir();
            foreach (string dir in aDir)
            {
                returnValue += comma + dir;
                if (Directory.Exists(returnValue + @"\Data") &&
                    Directory.Exists(returnValue + @"\Photos") &&
                    Directory.Exists(returnValue + @"\Photos") &&
                    comma.Length > 0)
                {
                    //MessageBox.Show(returnValue);
                    break;
                }
                //MessageBox.Show(returnValue + " :: " + Directory.Exists(returnValue + @"\Data").ToString());
                comma = @"\";
            }
            return returnValue;
        }

        public ArrayList aFilesIn(string targetDirectory)
        {
            ArrayList returnValue = new ArrayList();
            string[] filesIn = Directory.GetFiles(targetDirectory);
            foreach (string fileName in filesIn)
            {
                returnValue.Add(fileName);
            } 
            return returnValue;
        }

        public string getOnlyFileName(string fullNameFile) 
        {
            int index = fullNameFile.LastIndexOf(@"\");
            int length = fullNameFile.Length;
            if (index==(-1)) { return fullNameFile; }
            ++index;
            string returnValue = fullNameFile.Substring(index, (length - index));
            return returnValue;    
        }

        public string fileWithouthExt(string fileName)
        {
            int index = fileName.LastIndexOf(".");
            if (index == (-1)) return fileName;
            return fileName.Substring(0, index);
        }

        public string getFilename(string cmbFileName)
        {
            string fileName = "";
            int comma = cmbFileName.IndexOf(",");
            int dots = cmbFileName.IndexOf(":");
            fileName = cmbFileName.Substring(0, comma);
            fileName += cmbFileName.Substring(dots + 1, (cmbFileName.Length - dots) - 1);
            return fileName;
        }

        public ArrayList readDataFromFile(   string dataDirFrag,
                                        string cmbFileName)
        {
            string EOL = Environment.NewLine;
            ArrayList returnValue = new ArrayList();

            string dataDirWithPath = solutionDir() + dataDirFrag;
            Directory.SetCurrentDirectory(solutionDir());
            if (!Directory.Exists(dataDirFrag))
            {
                Directory.CreateDirectory(dataDirFrag);
            }
            Directory.SetCurrentDirectory(dataDirWithPath);

            string fileName = getFilename(cmbFileName);
            string[] aFileName = fileName.Split(' ');
            fileName = aFileName[0] + "~" + aFileName[1] + "~" + aFileName[2] + ".data";
            if (File.Exists(fileName)) {
                using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null && line != "")
                    {
                        returnValue.Add(line);
                    }
                }
            }
            return returnValue;
        }

        public void saveDataInFile( string dataDirFrag,
                                    string fileName,
                                    ArrayList eData)
        {
            string EOL = Environment.NewLine;

            Directory.SetCurrentDirectory(solutionDir());
            if (!Directory.Exists(dataDirFrag))
            {
                Directory.CreateDirectory(dataDirFrag);
            }

            string dataDirWithPath = solutionDir() + dataDirFrag;
            Directory.SetCurrentDirectory(dataDirWithPath);

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            string content = "";
            foreach(string line in eData)
            {
                content += line + EOL;
            }

            using (var sw = new StreamWriter(File.Open(fileName, FileMode.CreateNew), Encoding.UTF8))
            {
                sw.WriteLine(content);
                sw.Close();
            }
        }

    }
}
