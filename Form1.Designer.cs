namespace Lukas_Huvar
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBA = new System.Windows.Forms.TextBox();
            this.TBB = new System.Windows.Forms.TextBox();
            this.lplus = new System.Windows.Forms.Label();
            this.BtSoucet = new System.Windows.Forms.Button();
            this.LabVys = new System.Windows.Forms.Label();
            this.ButPic = new System.Windows.Forms.Button();
            this.LabTyp = new System.Windows.Forms.Label();
            this.CheckPos = new System.Windows.Forms.CheckBox();
            this.CbDruh = new System.Windows.Forms.ComboBox();
            this.LabDruh = new System.Windows.Forms.Label();
            this.TRBarstat = new System.Windows.Forms.TrackBar();
            this.LaBar = new System.Windows.Forms.Label();
            this.GBPrichut = new System.Windows.Forms.GroupBox();
            this.RBMich = new System.Windows.Forms.RadioButton();
            this.RBCok = new System.Windows.Forms.RadioButton();
            this.RBVal = new System.Windows.Forms.RadioButton();
            this.LabDisk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TextRead = new System.Windows.Forms.RichTextBox();
            this.PrBCas = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtevritSoubor = new System.Windows.Forms.ToolStripMenuItem();
            this.ulozToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Napoveda = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.TipIko = new System.Windows.Forms.ToolTip(this.components);
            this.LabTime = new System.Windows.Forms.Label();
            this.PocetKop = new System.Windows.Forms.NumericUpDown();
            this.LabKop = new System.Windows.Forms.Label();
            this.StatBar = new System.Windows.Forms.Label();
            this.LabOrechy = new System.Windows.Forms.Label();
            this.LabPoKop = new System.Windows.Forms.Label();
            this.Kop = new System.Windows.Forms.Label();
            this.LabDruhk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TRBarstat)).BeginInit();
            this.GBPrichut.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PocetKop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBA
            // 
            this.TBA.Location = new System.Drawing.Point(491, 60);
            this.TBA.Name = "TBA";
            this.TBA.Size = new System.Drawing.Size(80, 20);
            this.TBA.TabIndex = 0;
            // 
            // TBB
            // 
            this.TBB.Location = new System.Drawing.Point(611, 62);
            this.TBB.Name = "TBB";
            this.TBB.Size = new System.Drawing.Size(85, 20);
            this.TBB.TabIndex = 1;
            // 
            // lplus
            // 
            this.lplus.AutoSize = true;
            this.lplus.Location = new System.Drawing.Point(584, 63);
            this.lplus.Name = "lplus";
            this.lplus.Size = new System.Drawing.Size(13, 13);
            this.lplus.TabIndex = 2;
            this.lplus.Text = "+";
            // 
            // BtSoucet
            // 
            this.BtSoucet.Location = new System.Drawing.Point(702, 60);
            this.BtSoucet.Name = "BtSoucet";
            this.BtSoucet.Size = new System.Drawing.Size(41, 25);
            this.BtSoucet.TabIndex = 3;
            this.BtSoucet.Text = "=";
            this.BtSoucet.UseVisualStyleBackColor = true;
            this.BtSoucet.Click += new System.EventHandler(this.BtSoucet_Click);
            // 
            // LabVys
            // 
            this.LabVys.AutoSize = true;
            this.LabVys.Location = new System.Drawing.Point(752, 63);
            this.LabVys.Name = "LabVys";
            this.LabVys.Size = new System.Drawing.Size(49, 13);
            this.LabVys.TabIndex = 4;
            this.LabVys.Text = "vysledek";
            // 
            // ButPic
            // 
            this.ButPic.BackColor = System.Drawing.Color.Yellow;
            this.ButPic.Image = ((System.Drawing.Image)(resources.GetObject("ButPic.Image")));
            this.ButPic.Location = new System.Drawing.Point(687, 133);
            this.ButPic.Name = "ButPic";
            this.ButPic.Size = new System.Drawing.Size(82, 78);
            this.ButPic.TabIndex = 5;
            this.TipIko.SetToolTip(this.ButPic, "Ikonka");
            this.ButPic.UseVisualStyleBackColor = false;
            this.ButPic.UseWaitCursor = true;
            this.ButPic.Click += new System.EventHandler(this.ButPic_Click);
            // 
            // LabTyp
            // 
            this.LabTyp.AutoSize = true;
            this.LabTyp.Location = new System.Drawing.Point(55, 60);
            this.LabTyp.Name = "LabTyp";
            this.LabTyp.Size = new System.Drawing.Size(54, 13);
            this.LabTyp.TabIndex = 6;
            this.LabTyp.Text = "Vanilkova";
            // 
            // CheckPos
            // 
            this.CheckPos.AutoSize = true;
            this.CheckPos.Location = new System.Drawing.Point(46, 209);
            this.CheckPos.Name = "CheckPos";
            this.CheckPos.Size = new System.Drawing.Size(119, 17);
            this.CheckPos.TabIndex = 7;
            this.CheckPos.Text = "Posypany s orisky ?";
            this.CheckPos.UseVisualStyleBackColor = true;
            this.CheckPos.CheckedChanged += new System.EventHandler(this.CheckPos_CheckedChanged);
            // 
            // CbDruh
            // 
            this.CbDruh.FormattingEnabled = true;
            this.CbDruh.Items.AddRange(new object[] {
            "jogurtova",
            "nizkotucna",
            "smetanova"});
            this.CbDruh.Location = new System.Drawing.Point(58, 253);
            this.CbDruh.Name = "CbDruh";
            this.CbDruh.Size = new System.Drawing.Size(176, 21);
            this.CbDruh.TabIndex = 8;
            this.CbDruh.SelectedIndexChanged += new System.EventHandler(this.CbDruh_SelectedIndexChanged);
            this.CbDruh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbDruh_KeyPress);
            // 
            // LabDruh
            // 
            this.LabDruh.AutoSize = true;
            this.LabDruh.Location = new System.Drawing.Point(63, 231);
            this.LabDruh.Name = "LabDruh";
            this.LabDruh.Size = new System.Drawing.Size(69, 13);
            this.LabDruh.TabIndex = 9;
            this.LabDruh.Text = "Druh Zmrliny:";
            // 
            // TRBarstat
            // 
            this.TRBarstat.Location = new System.Drawing.Point(64, 311);
            this.TRBarstat.Name = "TRBarstat";
            this.TRBarstat.Size = new System.Drawing.Size(215, 45);
            this.TRBarstat.TabIndex = 10;
            this.TRBarstat.Scroll += new System.EventHandler(this.TRBarstat_Scroll);
            // 
            // LaBar
            // 
            this.LaBar.AutoSize = true;
            this.LaBar.Location = new System.Drawing.Point(63, 283);
            this.LaBar.Name = "LaBar";
            this.LaBar.Size = new System.Drawing.Size(195, 13);
            this.LaBar.TabIndex = 11;
            this.LaBar.Text = "% disku pro offline slozky (viz status bar)";
            // 
            // GBPrichut
            // 
            this.GBPrichut.Controls.Add(this.RBMich);
            this.GBPrichut.Controls.Add(this.RBCok);
            this.GBPrichut.Controls.Add(this.RBVal);
            this.GBPrichut.Location = new System.Drawing.Point(88, 83);
            this.GBPrichut.Name = "GBPrichut";
            this.GBPrichut.Size = new System.Drawing.Size(169, 106);
            this.GBPrichut.TabIndex = 12;
            this.GBPrichut.TabStop = false;
            this.GBPrichut.Text = "Jakou prichut zmrliny si date?";
            // 
            // RBMich
            // 
            this.RBMich.AutoSize = true;
            this.RBMich.Location = new System.Drawing.Point(19, 78);
            this.RBMich.Name = "RBMich";
            this.RBMich.Size = new System.Drawing.Size(66, 17);
            this.RBMich.TabIndex = 2;
            this.RBMich.Text = "Michana";
            this.RBMich.UseVisualStyleBackColor = true;
            this.RBMich.CheckedChanged += new System.EventHandler(this.RBMich_CheckedChanged);
            // 
            // RBCok
            // 
            this.RBCok.AutoSize = true;
            this.RBCok.Location = new System.Drawing.Point(17, 50);
            this.RBCok.Name = "RBCok";
            this.RBCok.Size = new System.Drawing.Size(82, 17);
            this.RBCok.TabIndex = 1;
            this.RBCok.Text = "Cokoladova";
            this.RBCok.UseVisualStyleBackColor = true;
            this.RBCok.CheckedChanged += new System.EventHandler(this.RBCok_CheckedChanged);
            // 
            // RBVal
            // 
            this.RBVal.AutoSize = true;
            this.RBVal.Checked = true;
            this.RBVal.Location = new System.Drawing.Point(20, 26);
            this.RBVal.Name = "RBVal";
            this.RBVal.Size = new System.Drawing.Size(72, 17);
            this.RBVal.TabIndex = 0;
            this.RBVal.TabStop = true;
            this.RBVal.Text = "Vanilkova";
            this.RBVal.UseVisualStyleBackColor = true;
            this.RBVal.CheckedChanged += new System.EventHandler(this.RBVal_CheckedChanged);
            // 
            // LabDisk
            // 
            this.LabDisk.AutoSize = true;
            this.LabDisk.Location = new System.Drawing.Point(12, 415);
            this.LabDisk.Name = "LabDisk";
            this.LabDisk.Size = new System.Drawing.Size(13, 13);
            this.LabDisk.TabIndex = 13;
            this.LabDisk.Text = "0";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(13, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 20);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(57, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 17);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(107, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 13);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextRead
            // 
            this.TextRead.Location = new System.Drawing.Point(571, 223);
            this.TextRead.Name = "TextRead";
            this.TextRead.Size = new System.Drawing.Size(197, 156);
            this.TextRead.TabIndex = 17;
            this.TextRead.Text = "";
            // 
            // PrBCas
            // 
            this.PrBCas.Location = new System.Drawing.Point(63, 351);
            this.PrBCas.Name = "PrBCas";
            this.PrBCas.Size = new System.Drawing.Size(329, 36);
            this.PrBCas.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.Napoveda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OtevritSoubor,
            this.ulozToToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // OtevritSoubor
            // 
            this.OtevritSoubor.Name = "OtevritSoubor";
            this.OtevritSoubor.Size = new System.Drawing.Size(180, 22);
            this.OtevritSoubor.Text = "Otevrit";
            this.OtevritSoubor.Click += new System.EventHandler(this.otevritToolStripMenuItem_Click);
            // 
            // ulozToToolStripMenuItem
            // 
            this.ulozToToolStripMenuItem.Name = "ulozToToolStripMenuItem";
            this.ulozToToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ulozToToolStripMenuItem.Text = "Uloz to";
            this.ulozToToolStripMenuItem.Click += new System.EventHandler(this.ulozToToolStripMenuItem_Click);
            // 
            // Napoveda
            // 
            this.Napoveda.Name = "Napoveda";
            this.Napoveda.Size = new System.Drawing.Size(73, 20);
            this.Napoveda.Text = "Napoveda";
            this.Napoveda.Click += new System.EventHandler(this.Napoveda_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // TipIko
            // 
            this.TipIko.BackColor = System.Drawing.Color.Yellow;
            this.TipIko.Popup += new System.Windows.Forms.PopupEventHandler(this.TipIko_Popup);
            // 
            // LabTime
            // 
            this.LabTime.AutoSize = true;
            this.LabTime.Location = new System.Drawing.Point(105, 399);
            this.LabTime.Name = "LabTime";
            this.LabTime.Size = new System.Drawing.Size(25, 13);
            this.LabTime.TabIndex = 21;
            this.LabTime.Text = "Cas";
            // 
            // PocetKop
            // 
            this.PocetKop.Location = new System.Drawing.Point(182, 216);
            this.PocetKop.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PocetKop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PocetKop.Name = "PocetKop";
            this.PocetKop.Size = new System.Drawing.Size(51, 20);
            this.PocetKop.TabIndex = 22;
            this.PocetKop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PocetKop.ValueChanged += new System.EventHandler(this.PocetKop_ValueChanged);
            // 
            // LabKop
            // 
            this.LabKop.AutoSize = true;
            this.LabKop.Location = new System.Drawing.Point(247, 220);
            this.LabKop.Name = "LabKop";
            this.LabKop.Size = new System.Drawing.Size(112, 13);
            this.LabKop.TabIndex = 23;
            this.LabKop.Text = "Kolik kopecku? max 4";
            // 
            // StatBar
            // 
            this.StatBar.AutoSize = true;
            this.StatBar.Location = new System.Drawing.Point(117, 428);
            this.StatBar.Name = "StatBar";
            this.StatBar.Size = new System.Drawing.Size(48, 13);
            this.StatBar.TabIndex = 24;
            this.StatBar.Text = "Hodnota";
            this.StatBar.Click += new System.EventHandler(this.StatBar_Click);
            // 
            // LabOrechy
            // 
            this.LabOrechy.AutoSize = true;
            this.LabOrechy.Location = new System.Drawing.Point(115, 60);
            this.LabOrechy.Name = "LabOrechy";
            this.LabOrechy.Size = new System.Drawing.Size(55, 13);
            this.LabOrechy.TabIndex = 25;
            this.LabOrechy.Text = "bez orisku";
            // 
            // LabPoKop
            // 
            this.LabPoKop.AutoSize = true;
            this.LabPoKop.Location = new System.Drawing.Point(176, 60);
            this.LabPoKop.Name = "LabPoKop";
            this.LabPoKop.Size = new System.Drawing.Size(13, 13);
            this.LabPoKop.TabIndex = 26;
            this.LabPoKop.Text = "1";
            // 
            // Kop
            // 
            this.Kop.AutoSize = true;
            this.Kop.Location = new System.Drawing.Point(195, 60);
            this.Kop.Name = "Kop";
            this.Kop.Size = new System.Drawing.Size(48, 13);
            this.Kop.TabIndex = 27;
            this.Kop.Text = "kopecky";
            // 
            // LabDruhk
            // 
            this.LabDruhk.AutoSize = true;
            this.LabDruhk.Location = new System.Drawing.Point(251, 60);
            this.LabDruhk.Name = "LabDruhk";
            this.LabDruhk.Size = new System.Drawing.Size(28, 13);
            this.LabDruhk.TabIndex = 28;
            this.LabDruhk.Text = "druh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(5, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 39);
            this.panel1.TabIndex = 29;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TextFile(*.txt)|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TextFile(*.txt)|*.txt";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabDruhk);
            this.Controls.Add(this.Kop);
            this.Controls.Add(this.LabPoKop);
            this.Controls.Add(this.LabOrechy);
            this.Controls.Add(this.StatBar);
            this.Controls.Add(this.LabKop);
            this.Controls.Add(this.PocetKop);
            this.Controls.Add(this.LabTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PrBCas);
            this.Controls.Add(this.TextRead);
            this.Controls.Add(this.LabDisk);
            this.Controls.Add(this.GBPrichut);
            this.Controls.Add(this.LaBar);
            this.Controls.Add(this.TRBarstat);
            this.Controls.Add(this.LabDruh);
            this.Controls.Add(this.CbDruh);
            this.Controls.Add(this.CheckPos);
            this.Controls.Add(this.LabTyp);
            this.Controls.Add(this.ButPic);
            this.Controls.Add(this.LabVys);
            this.Controls.Add(this.BtSoucet);
            this.Controls.Add(this.lplus);
            this.Controls.Add(this.TBB);
            this.Controls.Add(this.TBA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRBarstat)).EndInit();
            this.GBPrichut.ResumeLayout(false);
            this.GBPrichut.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PocetKop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBA;
        private System.Windows.Forms.TextBox TBB;
        private System.Windows.Forms.Label lplus;
        private System.Windows.Forms.Button BtSoucet;
        private System.Windows.Forms.Label LabVys;
        private System.Windows.Forms.Button ButPic;
        private System.Windows.Forms.Label LabTyp;
        private System.Windows.Forms.CheckBox CheckPos;
        private System.Windows.Forms.ComboBox CbDruh;
        private System.Windows.Forms.Label LabDruh;
        private System.Windows.Forms.TrackBar TRBarstat;
        private System.Windows.Forms.Label LaBar;
        private System.Windows.Forms.GroupBox GBPrichut;
        private System.Windows.Forms.RadioButton RBMich;
        private System.Windows.Forms.RadioButton RBCok;
        private System.Windows.Forms.RadioButton RBVal;
        private System.Windows.Forms.Label LabDisk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox TextRead;
        private System.Windows.Forms.ProgressBar PrBCas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Napoveda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem OtevritSoubor;
        private System.Windows.Forms.ToolTip TipIko;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label LabTime;
        private System.Windows.Forms.NumericUpDown PocetKop;
        private System.Windows.Forms.Label LabKop;
        private System.Windows.Forms.Label StatBar;
        private System.Windows.Forms.Label LabOrechy;
        private System.Windows.Forms.Label LabPoKop;
        private System.Windows.Forms.Label Kop;
        private System.Windows.Forms.Label LabDruhk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem ulozToToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

