using FormSchool.Libraries;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSchool
{
    class controlsForm
    {
        public void resetColor( Control element )
        {
            Clibrary cl = new Clibrary();
            if( element is TextBox || 
                element is ComboBox ||
                element is ListBox)
            {
                element.BackColor = cl.hex("#fff");
            }

            if (element is RadioButton ||
                element is CheckBox ||
                element.Name.IndexOf("session") == 0
                )
            {
                element.BackColor = cl.hex("#f0f0f0");
            }
        }
        private string checkValue(Boolean get, Control element, Boolean value)
        {
            string returnValue = "";
            if(get)
            {
                if(element is RadioButton)
                {
                    RadioButton tempo = element as RadioButton;
                    returnValue = tempo.Checked.ToString();
                }
                if (element is CheckBox)
                {
                    CheckBox tempo = element as CheckBox;
                    returnValue = tempo.Checked.ToString();
                }
            } else {

                if (element is RadioButton)
                {
                    RadioButton tempo = element as RadioButton;
                    tempo.Checked = value;
                }
                if (element is CheckBox)
                {
                    CheckBox tempo = element as CheckBox;
                    tempo.Checked = value;
                }

            }
            return returnValue;
        }
    
        private string textValue(Boolean get, Control element, string value)
        {
            string returnValue = "";
            if (value.Trim().IndexOf("~") == 0)
            {
                returnValue = element.Text;
            }
            else
            {
                element.Text = value;
            }
            return returnValue;
        }

        public string element(Boolean get, Control element, string value, Boolean bgColor)
        {
            Clibrary cl = new Clibrary();    
            string returnValue = "";
            Color newBgColor;

            if (element is TextBox ||
                element is ComboBox ||
                element is ListBox )
            {
                if(get)
                {
                    newBgColor = cl.hex("#fff");
                } else
                {
                    newBgColor = cl.hex("#c4face");
                }

                returnValue = textValue(get, element, value);
                if(bgColor)
                {
                    element.BackColor = newBgColor;
                }
            }
            
            if (element is CheckBox ||
                element is RadioButton)
            {
                newBgColor = cl.hex("#f0f0f0");
                if(value.ToLower().Trim().IndexOf("true")!=0 && value.ToLower().Trim().IndexOf("false") != 0)
                {
                    value = "false";
                }
                returnValue = checkValue(get, element, bool.Parse(value));
                if (bgColor)
                {
                    element.BackColor = newBgColor;
                }
            }
            return returnValue;
        }

    }

    class formLibrary
    {
        public ArrayList formSaveInFile(    ArrayList aControls, 
                                            string fileName)
        {
            controlsForm cnt = new controlsForm();
            ArrayList eData = new ArrayList();
            foreach (Control element in aControls)
            {
                eData.Add(element.Name + "~" + cnt.element(true, element, "~", false));
            }
            return eData;
        } 
        public void resetContent(ArrayList aControls)
        {
            controlsForm cnt = new controlsForm();
            foreach (Control element in aControls)
            {
                cnt.element(false, element, "", false);
                if (element.Name.IndexOf("pict") == 0)
                {
                    PictureBox oImage = element as PictureBox;
                    oImage.Image = null;
                }
            }

            foreach (Control element in aControls)
            {
                cnt.resetColor(element);
            }
        }

        public string contentInForm(    ArrayList aControls,
                                        ArrayList aContent,
                                        string except) 
        {
            controlsForm cnt = new controlsForm();
            Clibrary cl = new Clibrary();
            string[] aLine;
            string returnValue = "";
            Color okC = cl.hex("#c4face");
            foreach (string line in aContent)
            {
                aLine = line.Split('~');
                if (aLine[0].IndexOf(except) > (-1)) { returnValue = aLine[1]; } 
                foreach (Control element in aControls)
                {
                    if (aLine[0].IndexOf(element.Name) > (-1))
                    {
                        cnt.element(false, element, aLine[1], true);
                    }
                }
            }
            return returnValue;
        } 
        public void msg(string param)
        {
            MessageBox.Show(param);
        }

        public void setMsgPlace( TextBox place, int correct)
        {
            if(correct > 0 ) place.ForeColor = Color.Red;
        }

        public Boolean simpleControl(ArrayList eChecks,
                            ArrayList ePar)
        {

            Boolean isChecked = false;
            if (ePar[0].GetType().ToString().IndexOf(".RadioButton") > (-1))
            {
                foreach (RadioButton element in eChecks)
                {
                    if (!isChecked) { isChecked = element.Checked; }
                }
            }

            if (ePar[0].GetType().ToString().IndexOf(".CheckBox") > (-1))
            {
                foreach (CheckBox element in eChecks)
                {
                    if (!isChecked) { isChecked = element.Checked; }
                }
            }
            return isChecked;
        }


        public int control( ArrayList eChecks, 
                            ArrayList ePar)
        {
            string errMsg = (string)ePar[1];
            TextBox msgPlace = (TextBox)ePar[2];

            int correct = 0;
            if (simpleControl(eChecks, ePar)) { 
                correct = 1; 
            } 

            setMsgPlace(msgPlace, correct);
            
            if(correct == 0)
            {
                msgPlace.Text = errMsg;
            }

            return correct;
        }
        
        public int simpleControl(ArrayList ePars)
        {
            string matchType = (string)ePars[1];
            int minSize = (int)ePars[2];
            string elementText = (string)ePars[ePars.Count - 1];


            Clibrary cl = new Clibrary();

            int correct = 0;
            correct = cl.regMatch(matchType, elementText, minSize);

            if (minSize == 0) { correct = 1; }
            return correct;
        }

        public int  control(ArrayList ePars)
        {
            int minSize = (int)ePars[2]; 
            string errMsg = (string)ePars[3];
            
            TextBox msgPlace = (TextBox)ePars[4];
            int correct = simpleControl(ePars);

            if (correct == 2)
            {
                setMsgPlace(msgPlace, correct);
                Label labelName = (Label)ePars[5];
                string labelNameText = (string)labelName.Text;
                msgPlace.Text = "Položka ("+ labelNameText + ") musí obsahovať počet znakov aspoň " + minSize + " !";

            }
            else if (correct == 0)
            {
                setMsgPlace(msgPlace, correct);
                msgPlace.Text = errMsg;
            }
            return correct;
        }

        public void checkedImpact(ArrayList eChecks, ArrayList ePar, int okForm)
        {
            
            Clibrary cl = new Clibrary();
            Color c;
            if (okForm == 1)
            {
                c = cl.hex("#c4face");
            }
            else
            {
                c = cl.hex("#fcdade");
            }

            if(ePar[0].GetType().ToString().IndexOf(".RadioButton")>(-1))
            {
                foreach(RadioButton element in eChecks)
                {
                    element.BackColor = c;
                }
            }

            if (ePar[0].GetType().ToString().IndexOf(".CheckBox") > (-1))
            {
                foreach (CheckBox element in eChecks)
                {
                    element.BackColor = c;
                }
            }

            TextBox inpMessage = (TextBox)ePar[2];
            if (okForm == 1)
            {
                inpMessage.Text = "";
            }

        }


        public void editImpact(ArrayList ePar, int okForm)
        {

            Clibrary cl = new Clibrary();
            Color c;
            if (okForm == 1) {
                c = cl.hex("#c4face");
            } else
            {
                c = cl.hex("#fcdade");
            }

            
            if (ePar[0].GetType().ToString().IndexOf(".ListBox") > (-1))
            {
                ListBox element = (ListBox)ePar[0];
                element.BackColor = c;
            }

            if (ePar[0].GetType().ToString().IndexOf(".TextBox") > (-1))
            {
                TextBox element = (TextBox)ePar[0];
                element.BackColor = c;
            }

            if (ePar[0].GetType().ToString().IndexOf(".ComboBox") > (-1))
            {
                ComboBox element = (ComboBox)ePar[0];
                element.BackColor = c;
            }

            TextBox inpMessage = (TextBox)ePar[4];

            if (okForm == 1)
            {
                inpMessage.Text = "";
            }
        }
    }
}
