using FormSchool.Libraries;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormSchool
{
    public partial class formTest : Form
    {
        public formTest()
        {
            InitializeComponent();
        }
        readonly int elementCount = 15;
        public int okForm = 1;
        public Boolean tester = false;

        private formLibrary fl = new formLibrary();
        private Clibrary cl = new Clibrary();
        private FileIO fio = new FileIO();

        public string photoDirFrag = @"\Photos";
        public string dataDirFrag = @"\Data";
        private void Form1_Load(object sender, EventArgs e)
        {
            comboPictureLoad();
            btnSave.Enabled = true; ///to do 
            btnDeleteFile.Visible = false;
            dataInFiles();
        }

        private void dataInFiles()
        {
            cmbFromDir.Items.Clear();
            ArrayList aFilesIn = fio.aFilesIn(fio.solutionDir() + dataDirFrag);
            string[] aComboItem;
            string comboItem;
            foreach (string file in aFilesIn)
            {
                aComboItem = fio.fileWithouthExt(fio.getOnlyFileName(file)).Split('~');
                comboItem = aComboItem[0] + " " + aComboItem[1] + ", dát.narodenia: " + aComboItem[2];
                cmbFromDir.Items.Add(comboItem);
            }
        }

        private void comboPictureLoad()
        {
            string solutionDir = fio.solutionDir();
            string photoDir = solutionDir + this.photoDirFrag;
            ArrayList aPhotoFiles = fio.aFilesIn(photoDir);
            foreach (string file in aPhotoFiles)
            {
                cmbPhotos.Items.Add(fio.getOnlyFileName(fio.fileWithouthExt(file)));
            }
        }


        private ArrayList inpName_ePar()
        {
            TextBox element = inpName;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("MVm");
            ePar.Add(2);
            ePar.Add("Meno musí obsahovať malé písmená s prvým veľkým písmenom (Jozef)");
            ePar.Add(inpMessage);
            ePar.Add(labName);
            ePar.Add("" + element.Text);
            return ePar;
        }
        private void inpName_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpName_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpLastName_ePar()
        {
            TextBox element = inpLastName;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("MVm");
            ePar.Add(2);
            ePar.Add("Priezvisko musí obsahovať malé písmená s prvý veľkým písmenom (Novák)");
            ePar.Add(inpMessage);
            ePar.Add(labLastname);
            ePar.Add(element.Text);
            return ePar;
        }
        private void inpLastName_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpLastName_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpStreet_ePar()
        {
            TextBox element = inpStreet;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("Mz");
            ePar.Add(3);
            ePar.Add("Ulica obsahuje malé a veľké znaky bez čísiel prípadne medzeru (Jakubovo nám.)");
            ePar.Add(inpMessage);
            ePar.Add(labStreet);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpStreet_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpStreet_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpRegNumber_ePar()
        {
            TextBox element = inpRegNumber;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("C");
            ePar.Add(0);
            ePar.Add("Súpisné číslo môže obsahovať len čísla");
            ePar.Add(inpMessage);
            ePar.Add(labNumber);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpRegNumber_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpRegNumber_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpNumber_ePar()
        {
            TextBox element = inpNumber;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("Cd");
            ePar.Add(1);
            ePar.Add("Čislo domu obsahuje vždy čísla a na konci môže obsahovať písmeno (12, 13a)");
            ePar.Add(inpMessage);
            ePar.Add(labNumber);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpNumber_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpNumber_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpPSC_ePar()
        {
            TextBox element = inpPSC;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("PSC");
            ePar.Add(1);
            ePar.Add("Poštove esmerové číslo má formát  (999 99)");
            ePar.Add(inpMessage);
            ePar.Add(labPSC);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpPSC_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpPSC_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpCity_ePar()
        {
            TextBox element = inpCity;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("Mz");
            ePar.Add(3);
            ePar.Add("Názov mesta obsahuje malé a veľké znaky bez čísiel prípadne medzeru (Jakubovo nám.)");
            ePar.Add(inpMessage);
            ePar.Add(labCity);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpCity_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpCity_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpBirthDay_ePar()
        {
            TextBox element = inpBirthDay;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("D");
            ePar.Add(1);
            ePar.Add("Dátum má predpísaný formát (99-99-9999)");
            ePar.Add(inpMessage);
            ePar.Add(labBirth);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpBirthDay_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpBirthDay_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpEMail_ePar()
        {
            TextBox element = inpEMail;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("E");
            ePar.Add(1);
            ePar.Add("Nesprávny formát e-mailu (meno@domena.sk)");
            ePar.Add(inpMessage);
            ePar.Add(labEMail);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpEMail_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpEMail_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList inpMobil_ePar()
        {
            TextBox element = inpMobil;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("T");
            ePar.Add(1);
            ePar.Add("Telefónne číslo (mobil) má predpísaný formát (+421 904 999999)");
            ePar.Add(inpMessage);
            ePar.Add(labMobil);
            ePar.Add(element.Text);
            return ePar;
        }

        private void inpMobil_TextChanged(object sender, EventArgs e)
        {
            ArrayList ePar = inpMobil_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList lstRegion_ePar()
        {
            ListBox element = lstRegion;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("LST");
            ePar.Add(1);
            ePar.Add("Lokalita musí byť jednoznačne definovaná !");
            ePar.Add(inpMessage);
            ePar.Add(labRegion);
            ePar.Add(element.Text);
            return ePar;
        }

        private void lstRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList ePar = lstRegion_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private void radioMan_CheckedChanged(object sender, EventArgs e)
        {
            radioCheckedMan();
        }
        private void radioWoman_CheckedChanged(object sender, EventArgs e)
        {
            radioCheckedMan();
        }

        private ArrayList radioCheckedMan_eChecks()
        {
            RadioButton element = radioMan;
            ArrayList eChecks = new ArrayList();
            eChecks.Add(radioMan);
            eChecks.Add(radioWoman);
            return eChecks;
        }

        private ArrayList radioCheckedMan_ePar()
        {
            RadioButton element = radioMan;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("Pohlavie musí byť jednoznačne definované !");
            ePar.Add(inpMessage);
            return ePar;
        }

        private void radioCheckedMan()
        {
            ArrayList eChecks = radioCheckedMan_eChecks();
            ArrayList ePar = radioCheckedMan_ePar();
            fl.checkedImpact(eChecks, ePar, okForm = fl.control(eChecks, ePar));
            progressImpact(true);
        }

        private void checkCSharp_CheckedChanged(object sender, EventArgs e)
        {
            checkedCoders();
        }

        private void checkJS_CheckedChanged(object sender, EventArgs e)
        {
            checkedCoders();
        }

        private void checkPHP_CheckedChanged(object sender, EventArgs e)
        {
            checkedCoders();
        }

        private void checkJAVA_CheckedChanged(object sender, EventArgs e)
        {
            checkedCoders();
        }

        private void checkOther_CheckedChanged(object sender, EventArgs e)
        {
            checkedCoders();
        }

        private ArrayList checkedCoders_eChecks()
        {
            CheckBox element = checkCSharp;
            ArrayList eChecks = new ArrayList();
            eChecks.Add(checkCSharp);
            eChecks.Add(checkPHP);
            eChecks.Add(checkJS);
            eChecks.Add(checkJAVA);
            eChecks.Add(checkOther);
            return eChecks;
        }

        private ArrayList checkedCoders_ePar()
        {
            CheckBox element = checkCSharp;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("Programátorská zručnosť musí byť definovaná !");
            ePar.Add(inpMessage);
            return ePar;
        }

        private void checkedCoders()
        {
            ArrayList eChecks = checkedCoders_eChecks();
            ArrayList ePar = checkedCoders_ePar();
            fl.checkedImpact(eChecks, ePar, okForm = fl.control(eChecks, ePar));
            progressImpact(true);
        }

        private ArrayList cmbSchool_ePar()
        {
            ComboBox element = cmbSchool;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("");
            ePar.Add(1);
            ePar.Add("Dosiahnuté vzdelanie musí byť jednoznačne definované !");
            ePar.Add(inpMessage);
            ePar.Add(labSchool);
            ePar.Add(element.Text);
            return ePar;
        }

        private void cmbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList ePar = cmbSchool_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private ArrayList cmbPhotos_ePar()
        {
            ComboBox element = cmbPhotos;
            ArrayList ePar = new ArrayList();
            ePar.Add(element);
            ePar.Add("");
            ePar.Add(1);
            ePar.Add("Ku údajom vo formulári nie je vybratá fotografia !");
            ePar.Add(inpMessage);
            ePar.Add(labPhotos);
            ePar.Add(element.Text);
            return ePar;
        }

        private void controlComboPhoto()
        {
            ArrayList ePar = cmbPhotos_ePar();
            fl.editImpact(ePar, okForm = fl.control(ePar));
            progressImpact(true);
        }

        private void cmbPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList aPhotoFiles = fio.aFilesIn(fio.solutionDir() + this.photoDirFrag);
            string currentPhoto = (string)aPhotoFiles[cmbPhotos.SelectedIndex];
            pictPhotos.Image = Image.FromFile(currentPhoto);
            string sessionInfo = currentPhoto.Substring(currentPhoto.LastIndexOf(@"\") + 1, (currentPhoto.Length - currentPhoto.LastIndexOf(@"\")) - 1);
            sessionPhoto.Text = sessionInfo;
            controlComboPhoto();
        }

        private int progressImpact(Boolean notEmptyForm)
        {

            int okProgress = 0;
            if (notEmptyForm)
            {
                if (fl.simpleControl(inpName_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpLastName_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpStreet_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpRegNumber_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpNumber_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpPSC_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpCity_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpBirthDay_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpEMail_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(inpMobil_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(lstRegion_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(cmbSchool_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(cmbPhotos_ePar()) == 1) ++okProgress;
                if (fl.simpleControl(checkedCoders_eChecks(), checkedCoders_ePar())) ++okProgress;
                if (fl.simpleControl(radioCheckedMan_eChecks(), radioCheckedMan_ePar())) ++okProgress;

            }
            

            progressForm.Minimum = 0;
            progressForm.Maximum = 15;
            progressForm.Value = okProgress;

            if (okProgress > 1)
            {
                labFromDir.Visible = false;
                cmbFromDir.Visible = false;
            }
            else
            {
                labFromDir.Visible = true;
                cmbFromDir.Visible = true;
            }
            if (okProgress == this.elementCount)
            {
                btnSave.Enabled = true;
                btnDeleteFile.Visible = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnDeleteFile.Visible = false;
            }
            return okProgress;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = inpLastName.Text + "~" + inpName.Text + "~" + inpBirthDay.Text + ".data";
            ArrayList eData = fl.formSaveInFile(getControls(), fileName);
            eData.Add(pictPhotos.Name + "~" + sessionPhoto.Text);

            fio.saveDataInFile(this.dataDirFrag,
                                fileName,
                                eData);
            inpMessage.ForeColor = cl.hex("#006208");
            inpMessage.Text = "Obsah formulára bol úspešne zapísaný do súboru, formulár je možné vymazať.";
            dataInFiles();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Naozaj chcete vymazať formulár ?", "Otázka", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                fl.resetContent(getControls());
                labFromDir.Visible = true;
                cmbFromDir.Visible = true;
                btnDeleteFile.Visible = false;
                progressImpact(false);
                inpMessage.Text = "";
                inpMessage.BackColor = cl.hex("#f0f0f0");
            }
        }

        private void cmbFromDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Načítať dáta do formulára zo súboru ?", "Otázka", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Directory.SetCurrentDirectory(fio.solutionDir() + dataDirFrag);
                ArrayList aContent = fio.readDataFromFile(this.dataDirFrag, cmbFromDir.Text);
                pictPhotos.Image = null;
                Color okC = cl.hex("#c4face");

                string except = fl.contentInForm(getControls(),
                                    aContent,
                                    "pictPhotos");
                if (except.Length > 0)
                {
                    pictPhotos.ImageLocation = fio.solutionDir() + photoDirFrag + @"\" + except;
                    sessionPhoto.Text = except;
                }
                progressImpact(true);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Naozaj vymazať súbor s aktuálnymi dátami vo formulári ?", "Otázka", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                confirmResult = MessageBox.Show("Dáta môžete definitívne stratiť, pokračovať ?", "Otázka", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Directory.SetCurrentDirectory(fio.solutionDir() + dataDirFrag);
                    string fileName = inpLastName.Text + "~" + inpName.Text + "~" + inpBirthDay.Text + ".data";
                    if (File.Exists(fileName)) { File.Delete(fileName); }
                    dataInFiles();
                }
            }
        }

        private void msg(string msg)
        {
            Label debugMsg = new Label();
            debugMsg.Location = new Point(100, 0);
            debugMsg.Size = new Size(500, 12);
            debugMsg.ForeColor = cl.hex("#cc0000");
            debugMsg.BackColor = cl.hex("#fff");
            debugMsg.TextAlign = ContentAlignment.MiddleCenter;
            debugMsg.Text = msg;
            this.Controls.Add(debugMsg);
        }

        private void show(string msg)
        {
            MessageBox.Show(msg);
        }

        private ArrayList getControls()
        {
            ArrayList returnValue = new ArrayList();
            foreach (Control element in this.Controls)
            {
                returnValue.Add(element);
            }
            return returnValue;
        }
    }
}
