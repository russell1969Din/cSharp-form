using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Configuration;
using MySql.Data;

namespace FormSchool.Libraries
{
    class Clibrary
    {
        private void msg(string param)
        {
            MessageBox.Show(param);
        }

        public Color hex(string hexValue)
        {
            Color colour = ColorTranslator.FromHtml(hexValue);
            Color transparent = Color.FromArgb(128, colour);
            return colour;
        }

        public int regMatch(string rg, string param, int minSize)
        {
            string mobilPatern =    @"(\+[0-9]{3}|\+[0-9]{2}\(0\)|\(\+[0-9]{2}\)\(0\)|00[0-9]{2}|0)([0-9]{9}|[0-9\-\s]{9,18})";
            string datePattern = @"(^(((0[1-9]|1[0-9]|2[0-8])[-](0[1-9]|1[012]))|((29|30|31)[-](0[13578]|1[02]))|((29|30)[-](0[4,6,9]|11)))[-](19|[2-9][0-9])\d\d$)|(^29[-]02[-](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)";
            //msg(param.Length.ToString());

            if (param.Length < minSize && minSize > 0)
            {
                return 2;
            }

            param = convertDiaWithout(param);
            string regValue = "";
            switch (rg)
            {
                case "E":   { regValue = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"; break; }
                case "MVm": { regValue = "^[A-Z][a-z]+$"; break; }
                case "Mz":  { regValue = "^[A-Z][a-z. A-Z.]+$"; break; }
                case "C":   { regValue = "^[0-9]+$"; break; }
                case "Cd":  { regValue = "[0-9][a-z]?"; break; }
                case "PSC": { regValue = @"\d{3} \d{2}"; break; }
                case "D":   { regValue = datePattern; break; }
                case "T":   { regValue = mobilPatern; break; }
            }
            //msg(regValue);

            if (regValue.Trim().Length == 0) { return 1; }

            if(Regex.IsMatch(param, regValue))
            {
                return 1;
            } else
            {
                return 0; 
            }
        }

        public string convertDiaWithout(string param)
        {
            string convertText = "";
            //char[] dia =    { 'á', 'ä', 'č', 'ď', 'é', 'í', 'ľ', 'ĺ', 'ň', 'ó', 'ô', 'ŕ', 'š', 'ť', 'ú', 'ý', 'ž', 'Á', 'Č', 'Ď', 'É', 'Í', 'Ľ', 'Ĺ', 'Ň', 'Ó', 'Š', 'Ť', 'Ú', 'Ý', 'Ž' };
            //char[] nodia =  { 'a', 'a', 'c', 'd', 'e', 'i', 'l', 'l', 'n', 'o', 'o', 'r', 's', 't', 'u', 'y', 'z', 'A', 'C', 'D', 'E', 'I', 'L', 'L', 'N', 'O', 'S', 'T', 'U', 'Y', 'Z' };

            string dia      = "áäčďéíľĺňóôŕšťúýžÁČĎÉÍĽĹŇÓŠŤÚÝŽ";
            string nodia    = "aacdeillnoorstuyzACDEILLNOSTUYZ";

            string chr;
            for(int i=0;i<param.Length;++i)
            {
                chr = param.Substring(i, 1);
                if(dia.IndexOf(param[i]) != (-1))
                {
                    convertText += nodia[dia.IndexOf(param[i])];
                } else
                {
                    convertText += param[i];
                }
            }
            return convertText;
        }
    }
}

 
