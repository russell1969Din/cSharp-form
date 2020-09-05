namespace FormSchool
{
    partial class formTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstRegion = new System.Windows.Forms.ListBox();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.checkCSharp = new System.Windows.Forms.CheckBox();
            this.checkJS = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictPhotos = new System.Windows.Forms.PictureBox();
            this.inpMessage = new System.Windows.Forms.TextBox();
            this.labRegion = new System.Windows.Forms.Label();
            this.checkPHP = new System.Windows.Forms.CheckBox();
            this.checkJAVA = new System.Windows.Forms.CheckBox();
            this.cmbSchool = new System.Windows.Forms.ComboBox();
            this.labSchool = new System.Windows.Forms.Label();
            this.progressForm = new System.Windows.Forms.ProgressBar();
            this.cmbPhotos = new System.Windows.Forms.ComboBox();
            this.labPhotos = new System.Windows.Forms.Label();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.sessionPhoto = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbFromDir = new System.Windows.Forms.ComboBox();
            this.labFromDir = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labStreet = new System.Windows.Forms.Label();
            this.inpName = new System.Windows.Forms.TextBox();
            this.inpStreet = new System.Windows.Forms.TextBox();
            this.inpBirthDay = new System.Windows.Forms.TextBox();
            this.labBirth = new System.Windows.Forms.Label();
            this.inpEMail = new System.Windows.Forms.TextBox();
            this.labEMail = new System.Windows.Forms.Label();
            this.labLastname = new System.Windows.Forms.Label();
            this.inpLastName = new System.Windows.Forms.TextBox();
            this.inpMobil = new System.Windows.Forms.TextBox();
            this.labMobil = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.inpRegNumber = new System.Windows.Forms.TextBox();
            this.inpNumber = new System.Windows.Forms.TextBox();
            this.labCity = new System.Windows.Forms.Label();
            this.labPSC = new System.Windows.Forms.Label();
            this.inpPSC = new System.Windows.Forms.TextBox();
            this.inpCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRegion
            // 
            this.lstRegion.FormattingEnabled = true;
            this.lstRegion.Items.AddRange(new object[] {
            "Západné Slovensko",
            "Južné Slovensko",
            "Stredné Slovensko",
            "Východné Slovensko",
            "Zahraničie"});
            this.lstRegion.Location = new System.Drawing.Point(12, 326);
            this.lstRegion.Name = "lstRegion";
            this.lstRegion.Size = new System.Drawing.Size(264, 69);
            this.lstRegion.TabIndex = 11;
            this.lstRegion.SelectedIndexChanged += new System.EventHandler(this.lstRegion_SelectedIndexChanged);
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Location = new System.Drawing.Point(326, 42);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(45, 17);
            this.radioMan.TabIndex = 12;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "Muž";
            this.radioMan.UseVisualStyleBackColor = true;
            this.radioMan.CheckedChanged += new System.EventHandler(this.radioMan_CheckedChanged);
            // 
            // radioWoman
            // 
            this.radioWoman.AutoSize = true;
            this.radioWoman.Location = new System.Drawing.Point(326, 70);
            this.radioWoman.Name = "radioWoman";
            this.radioWoman.Size = new System.Drawing.Size(50, 17);
            this.radioWoman.TabIndex = 13;
            this.radioWoman.TabStop = true;
            this.radioWoman.Text = "Žena";
            this.radioWoman.UseVisualStyleBackColor = true;
            this.radioWoman.CheckedChanged += new System.EventHandler(this.radioWoman_CheckedChanged);
            // 
            // checkCSharp
            // 
            this.checkCSharp.AutoSize = true;
            this.checkCSharp.Location = new System.Drawing.Point(331, 141);
            this.checkCSharp.Name = "checkCSharp";
            this.checkCSharp.Size = new System.Drawing.Size(40, 17);
            this.checkCSharp.TabIndex = 14;
            this.checkCSharp.Text = "C#";
            this.checkCSharp.UseVisualStyleBackColor = true;
            this.checkCSharp.CheckedChanged += new System.EventHandler(this.checkCSharp_CheckedChanged);
            // 
            // checkJS
            // 
            this.checkJS.AutoSize = true;
            this.checkJS.Location = new System.Drawing.Point(331, 164);
            this.checkJS.Name = "checkJS";
            this.checkJS.Size = new System.Drawing.Size(74, 17);
            this.checkJS.TabIndex = 15;
            this.checkJS.Text = "Javascript";
            this.checkJS.UseVisualStyleBackColor = true;
            this.checkJS.CheckedChanged += new System.EventHandler(this.checkJS_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(343, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Zapísať";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictPhotos
            // 
            this.pictPhotos.Location = new System.Drawing.Point(479, 132);
            this.pictPhotos.Name = "pictPhotos";
            this.pictPhotos.Size = new System.Drawing.Size(150, 150);
            this.pictPhotos.TabIndex = 9;
            this.pictPhotos.TabStop = false;
            // 
            // inpMessage
            // 
            this.inpMessage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inpMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inpMessage.ForeColor = System.Drawing.Color.Red;
            this.inpMessage.Location = new System.Drawing.Point(12, 410);
            this.inpMessage.Name = "inpMessage";
            this.inpMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inpMessage.Size = new System.Drawing.Size(661, 15);
            this.inpMessage.TabIndex = 10;
            this.inpMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labRegion
            // 
            this.labRegion.AutoSize = true;
            this.labRegion.Location = new System.Drawing.Point(16, 310);
            this.labRegion.Name = "labRegion";
            this.labRegion.Size = new System.Drawing.Size(112, 13);
            this.labRegion.TabIndex = 11;
            this.labRegion.Text = "Zdržiava sa v regióne:";
            // 
            // checkPHP
            // 
            this.checkPHP.AutoSize = true;
            this.checkPHP.Location = new System.Drawing.Point(331, 190);
            this.checkPHP.Name = "checkPHP";
            this.checkPHP.Size = new System.Drawing.Size(48, 17);
            this.checkPHP.TabIndex = 16;
            this.checkPHP.Text = "PHP";
            this.checkPHP.UseVisualStyleBackColor = true;
            this.checkPHP.CheckedChanged += new System.EventHandler(this.checkPHP_CheckedChanged);
            // 
            // checkJAVA
            // 
            this.checkJAVA.AutoSize = true;
            this.checkJAVA.Location = new System.Drawing.Point(331, 213);
            this.checkJAVA.Name = "checkJAVA";
            this.checkJAVA.Size = new System.Drawing.Size(87, 17);
            this.checkJAVA.TabIndex = 17;
            this.checkJAVA.Text = "JAVA (Kotlin)";
            this.checkJAVA.UseVisualStyleBackColor = true;
            this.checkJAVA.CheckedChanged += new System.EventHandler(this.checkJAVA_CheckedChanged);
            // 
            // cmbSchool
            // 
            this.cmbSchool.FormattingEnabled = true;
            this.cmbSchool.Items.AddRange(new object[] {
            "Základné vzdelanie",
            "Stredné odborné vzdelanie",
            "Úplné stredné vzdelanie",
            "Vysokoškolské vzdelanie"});
            this.cmbSchool.Location = new System.Drawing.Point(435, 54);
            this.cmbSchool.Name = "cmbSchool";
            this.cmbSchool.Size = new System.Drawing.Size(238, 21);
            this.cmbSchool.TabIndex = 18;
            this.cmbSchool.SelectedIndexChanged += new System.EventHandler(this.cmbSchool_SelectedIndexChanged);
            // 
            // labSchool
            // 
            this.labSchool.AutoSize = true;
            this.labSchool.Location = new System.Drawing.Point(432, 35);
            this.labSchool.Name = "labSchool";
            this.labSchool.Size = new System.Drawing.Size(109, 13);
            this.labSchool.TabIndex = 15;
            this.labSchool.Text = "Dosiahnuté vzdelanie";
            // 
            // progressForm
            // 
            this.progressForm.Location = new System.Drawing.Point(12, 431);
            this.progressForm.Name = "progressForm";
            this.progressForm.Size = new System.Drawing.Size(660, 23);
            this.progressForm.TabIndex = 21;
            // 
            // cmbPhotos
            // 
            this.cmbPhotos.FormattingEnabled = true;
            this.cmbPhotos.Location = new System.Drawing.Point(435, 105);
            this.cmbPhotos.Name = "cmbPhotos";
            this.cmbPhotos.Size = new System.Drawing.Size(237, 21);
            this.cmbPhotos.TabIndex = 19;
            this.cmbPhotos.SelectedIndexChanged += new System.EventHandler(this.cmbPhotos_SelectedIndexChanged);
            // 
            // labPhotos
            // 
            this.labPhotos.AutoSize = true;
            this.labPhotos.Location = new System.Drawing.Point(435, 86);
            this.labPhotos.Name = "labPhotos";
            this.labPhotos.Size = new System.Drawing.Size(68, 13);
            this.labPhotos.TabIndex = 23;
            this.labPhotos.Text = "Vybrať fotku:";
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.Location = new System.Drawing.Point(331, 241);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(67, 17);
            this.checkOther.TabIndex = 24;
            this.checkOther.Text = "Iný jazyk";
            this.checkOther.UseVisualStyleBackColor = true;
            this.checkOther.CheckedChanged += new System.EventHandler(this.checkOther_CheckedChanged);
            // 
            // sessionPhoto
            // 
            this.sessionPhoto.AutoSize = true;
            this.sessionPhoto.ForeColor = System.Drawing.SystemColors.Menu;
            this.sessionPhoto.Location = new System.Drawing.Point(479, 289);
            this.sessionPhoto.Name = "sessionPhoto";
            this.sessionPhoto.Size = new System.Drawing.Size(35, 13);
            this.sessionPhoto.TabIndex = 25;
            this.sessionPhoto.Text = "label1";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(424, 343);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Zmazať formulár";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbFromDir
            // 
            this.cmbFromDir.FormattingEnabled = true;
            this.cmbFromDir.Location = new System.Drawing.Point(260, 481);
            this.cmbFromDir.Name = "cmbFromDir";
            this.cmbFromDir.Size = new System.Drawing.Size(291, 21);
            this.cmbFromDir.TabIndex = 27;
            this.cmbFromDir.SelectedIndexChanged += new System.EventHandler(this.cmbFromDir_SelectedIndexChanged);
            // 
            // labFromDir
            // 
            this.labFromDir.AutoSize = true;
            this.labFromDir.Location = new System.Drawing.Point(112, 481);
            this.labFromDir.Name = "labFromDir";
            this.labFromDir.Size = new System.Drawing.Size(120, 13);
            this.labFromDir.TabIndex = 28;
            this.labFromDir.Text = "Načítať dáta zo súboru:";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(343, 372);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(198, 23);
            this.btnDeleteFile.TabIndex = 29;
            this.btnDeleteFile.Text = "Vymazať súbor s aktálnymi  dátami";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(9, 18);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(37, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Meno:";
            // 
            // labStreet
            // 
            this.labStreet.AutoSize = true;
            this.labStreet.Location = new System.Drawing.Point(9, 70);
            this.labStreet.Name = "labStreet";
            this.labStreet.Size = new System.Drawing.Size(37, 13);
            this.labStreet.TabIndex = 1;
            this.labStreet.Text = "Ulica: ";
            // 
            // inpName
            // 
            this.inpName.Location = new System.Drawing.Point(97, 18);
            this.inpName.MaxLength = 25;
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(190, 20);
            this.inpName.TabIndex = 1;
            this.inpName.TextChanged += new System.EventHandler(this.inpName_TextChanged);
            // 
            // inpStreet
            // 
            this.inpStreet.Location = new System.Drawing.Point(97, 70);
            this.inpStreet.MaxLength = 25;
            this.inpStreet.Name = "inpStreet";
            this.inpStreet.Size = new System.Drawing.Size(190, 20);
            this.inpStreet.TabIndex = 3;
            this.inpStreet.TextChanged += new System.EventHandler(this.inpStreet_TextChanged);
            // 
            // inpBirthDay
            // 
            this.inpBirthDay.Location = new System.Drawing.Point(97, 150);
            this.inpBirthDay.MaxLength = 10;
            this.inpBirthDay.Name = "inpBirthDay";
            this.inpBirthDay.Size = new System.Drawing.Size(190, 20);
            this.inpBirthDay.TabIndex = 8;
            this.inpBirthDay.TextChanged += new System.EventHandler(this.inpBirthDay_TextChanged);
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Location = new System.Drawing.Point(8, 153);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(83, 13);
            this.labBirth.TabIndex = 5;
            this.labBirth.Text = "Deň narodenia::";
            // 
            // inpEMail
            // 
            this.inpEMail.Location = new System.Drawing.Point(97, 176);
            this.inpEMail.Name = "inpEMail";
            this.inpEMail.Size = new System.Drawing.Size(190, 20);
            this.inpEMail.TabIndex = 9;
            this.inpEMail.TextChanged += new System.EventHandler(this.inpEMail_TextChanged);
            // 
            // labEMail
            // 
            this.labEMail.AutoSize = true;
            this.labEMail.Location = new System.Drawing.Point(8, 179);
            this.labEMail.Name = "labEMail";
            this.labEMail.Size = new System.Drawing.Size(38, 13);
            this.labEMail.TabIndex = 7;
            this.labEMail.Text = "E-mail:";
            // 
            // labLastname
            // 
            this.labLastname.AutoSize = true;
            this.labLastname.Location = new System.Drawing.Point(9, 42);
            this.labLastname.Name = "labLastname";
            this.labLastname.Size = new System.Drawing.Size(58, 13);
            this.labLastname.TabIndex = 8;
            this.labLastname.Text = "Priezvisko:";
            // 
            // inpLastName
            // 
            this.inpLastName.Location = new System.Drawing.Point(97, 44);
            this.inpLastName.MaxLength = 25;
            this.inpLastName.Name = "inpLastName";
            this.inpLastName.Size = new System.Drawing.Size(190, 20);
            this.inpLastName.TabIndex = 2;
            this.inpLastName.TextChanged += new System.EventHandler(this.inpLastName_TextChanged);
            // 
            // inpMobil
            // 
            this.inpMobil.Location = new System.Drawing.Point(97, 202);
            this.inpMobil.Name = "inpMobil";
            this.inpMobil.Size = new System.Drawing.Size(190, 20);
            this.inpMobil.TabIndex = 10;
            this.inpMobil.TextChanged += new System.EventHandler(this.inpMobil_TextChanged);
            // 
            // labMobil
            // 
            this.labMobil.AutoSize = true;
            this.labMobil.Location = new System.Drawing.Point(8, 205);
            this.labMobil.Name = "labMobil";
            this.labMobil.Size = new System.Drawing.Size(35, 13);
            this.labMobil.TabIndex = 10;
            this.labMobil.Text = "Mobil:";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(9, 98);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(79, 13);
            this.labNumber.TabIndex = 11;
            this.labNumber.Text = "Reg.číslo/čislo";
            // 
            // inpRegNumber
            // 
            this.inpRegNumber.Location = new System.Drawing.Point(97, 96);
            this.inpRegNumber.MaxLength = 6;
            this.inpRegNumber.Name = "inpRegNumber";
            this.inpRegNumber.Size = new System.Drawing.Size(35, 20);
            this.inpRegNumber.TabIndex = 4;
            this.inpRegNumber.TextChanged += new System.EventHandler(this.inpRegNumber_TextChanged);
            // 
            // inpNumber
            // 
            this.inpNumber.Location = new System.Drawing.Point(142, 96);
            this.inpNumber.MaxLength = 6;
            this.inpNumber.Name = "inpNumber";
            this.inpNumber.Size = new System.Drawing.Size(29, 20);
            this.inpNumber.TabIndex = 5;
            this.inpNumber.TextChanged += new System.EventHandler(this.inpNumber_TextChanged);
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(9, 127);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(39, 13);
            this.labCity.TabIndex = 15;
            this.labCity.Text = "Mesto:";
            // 
            // labPSC
            // 
            this.labPSC.AutoSize = true;
            this.labPSC.Location = new System.Drawing.Point(192, 98);
            this.labPSC.Name = "labPSC";
            this.labPSC.Size = new System.Drawing.Size(31, 13);
            this.labPSC.TabIndex = 16;
            this.labPSC.Text = "PSČ:";
            // 
            // inpPSC
            // 
            this.inpPSC.Location = new System.Drawing.Point(229, 95);
            this.inpPSC.MaxLength = 6;
            this.inpPSC.Name = "inpPSC";
            this.inpPSC.Size = new System.Drawing.Size(58, 20);
            this.inpPSC.TabIndex = 6;
            this.inpPSC.TextChanged += new System.EventHandler(this.inpPSC_TextChanged);
            // 
            // inpCity
            // 
            this.inpCity.Location = new System.Drawing.Point(97, 124);
            this.inpCity.MaxLength = 35;
            this.inpCity.Name = "inpCity";
            this.inpCity.Size = new System.Drawing.Size(190, 20);
            this.inpCity.TabIndex = 7;
            this.inpCity.TextChanged += new System.EventHandler(this.inpCity_TextChanged);
            // 
            // formTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 527);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.inpCity);
            this.Controls.Add(this.inpMobil);
            this.Controls.Add(this.labFromDir);
            this.Controls.Add(this.inpEMail);
            this.Controls.Add(this.inpPSC);
            this.Controls.Add(this.inpBirthDay);
            this.Controls.Add(this.cmbFromDir);
            this.Controls.Add(this.labPSC);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.inpNumber);
            this.Controls.Add(this.labCity);
            this.Controls.Add(this.sessionPhoto);
            this.Controls.Add(this.inpRegNumber);
            this.Controls.Add(this.checkOther);
            this.Controls.Add(this.labMobil);
            this.Controls.Add(this.inpLastName);
            this.Controls.Add(this.labPhotos);
            this.Controls.Add(this.inpStreet);
            this.Controls.Add(this.cmbPhotos);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labEMail);
            this.Controls.Add(this.inpName);
            this.Controls.Add(this.progressForm);
            this.Controls.Add(this.labSchool);
            this.Controls.Add(this.labBirth);
            this.Controls.Add(this.cmbSchool);
            this.Controls.Add(this.checkJAVA);
            this.Controls.Add(this.labLastname);
            this.Controls.Add(this.checkPHP);
            this.Controls.Add(this.labRegion);
            this.Controls.Add(this.inpMessage);
            this.Controls.Add(this.pictPhotos);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labStreet);
            this.Controls.Add(this.checkJS);
            this.Controls.Add(this.checkCSharp);
            this.Controls.Add(this.radioWoman);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.radioMan);
            this.Controls.Add(this.lstRegion);
            this.Name = "formTest";
            this.Text = "Ukážka formuláru v C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictPhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstRegion;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.CheckBox checkCSharp;
        private System.Windows.Forms.CheckBox checkJS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictPhotos;
        private System.Windows.Forms.TextBox inpMessage;
        private System.Windows.Forms.Label labRegion;
        private System.Windows.Forms.CheckBox checkPHP;
        private System.Windows.Forms.CheckBox checkJAVA;
        private System.Windows.Forms.ComboBox cmbSchool;
        private System.Windows.Forms.Label labSchool;
        private System.Windows.Forms.ProgressBar progressForm;
        private System.Windows.Forms.ComboBox cmbPhotos;
        private System.Windows.Forms.Label labPhotos;
        private System.Windows.Forms.CheckBox checkOther;
        private System.Windows.Forms.Label sessionPhoto;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbFromDir;
        private System.Windows.Forms.Label labFromDir;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labStreet;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.TextBox inpStreet;
        private System.Windows.Forms.TextBox inpBirthDay;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.TextBox inpEMail;
        private System.Windows.Forms.Label labEMail;
        private System.Windows.Forms.Label labLastname;
        private System.Windows.Forms.TextBox inpLastName;
        private System.Windows.Forms.TextBox inpMobil;
        private System.Windows.Forms.Label labMobil;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox inpRegNumber;
        private System.Windows.Forms.TextBox inpNumber;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labPSC;
        private System.Windows.Forms.TextBox inpPSC;
        private System.Windows.Forms.TextBox inpCity;
    }
}

