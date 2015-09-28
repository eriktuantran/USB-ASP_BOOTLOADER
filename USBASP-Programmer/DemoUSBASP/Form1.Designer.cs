namespace DemoUSBASP
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClock = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVeriEeprom = new System.Windows.Forms.Button();
            this.btnReadEeprom = new System.Windows.Forms.Button();
            this.btnWriteEeprom = new System.Windows.Forms.Button();
            this.btnDirEeprom = new System.Windows.Forms.Button();
            this.cmbDirEeprom = new System.Windows.Forms.ComboBox();
            this.chboxVerifyEeprom = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVeriMemory = new System.Windows.Forms.Button();
            this.btnWriteMemory = new System.Windows.Forms.Button();
            this.btnReadMemory = new System.Windows.Forms.Button();
            this.btnDirMemory = new System.Windows.Forms.Button();
            this.cmbDirMemory = new System.Windows.Forms.ComboBox();
            this.chboxVerifyFlash = new System.Windows.Forms.CheckBox();
            this.chboxEraseDvc = new System.Windows.Forms.CheckBox();
            this.tabFuse = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnReadFuse = new System.Windows.Forms.Button();
            this.btnWriteFuse = new System.Windows.Forms.Button();
            this.txtbxOutHigh = new System.Windows.Forms.TextBox();
            this.txtbxOutLow = new System.Windows.Forms.TextBox();
            this.lblOutLow = new System.Windows.Forms.Label();
            this.lblOutHigh = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFuse1 = new System.Windows.Forms.Label();
            this.chboxFuse1 = new System.Windows.Forms.CheckBox();
            this.chboxFuse2 = new System.Windows.Forms.CheckBox();
            this.chboxFuse3 = new System.Windows.Forms.CheckBox();
            this.chboxFuse5 = new System.Windows.Forms.CheckBox();
            this.lblFuse2 = new System.Windows.Forms.Label();
            this.lblFuse3 = new System.Windows.Forms.Label();
            this.lblFuse5 = new System.Windows.Forms.Label();
            this.lblFuse4 = new System.Windows.Forms.Label();
            this.chboxFuse4 = new System.Windows.Forms.CheckBox();
            this.lblFuse7 = new System.Windows.Forms.Label();
            this.chboxFuse6 = new System.Windows.Forms.CheckBox();
            this.lblFuse8 = new System.Windows.Forms.Label();
            this.cboxFuseBODLVL = new System.Windows.Forms.ComboBox();
            this.lblFuse9 = new System.Windows.Forms.Label();
            this.chboxFuse7 = new System.Windows.Forms.CheckBox();
            this.lblFuse10 = new System.Windows.Forms.Label();
            this.cboxFuseCLK = new System.Windows.Forms.ComboBox();
            this.cboxFuseBOOTZ = new System.Windows.Forms.ComboBox();
            this.lblFuse6 = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cboxInterface = new System.Windows.Forms.ComboBox();
            this.cboxCOM = new System.Windows.Forms.ComboBox();
            this.cboxDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblTool = new System.Windows.Forms.Label();
            this.cboxTool = new System.Windows.Forms.ComboBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabClock.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.tabMemory.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabFuse.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabClock);
            this.tabControl1.Controls.Add(this.tabMemory);
            this.tabControl1.Controls.Add(this.tabFuse);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 75);
            this.tabControl1.Location = new System.Drawing.Point(7, 54);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 197);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabClock
            // 
            this.tabClock.Controls.Add(this.groupBox3);
            this.tabClock.Location = new System.Drawing.Point(79, 4);
            this.tabClock.Name = "tabClock";
            this.tabClock.Padding = new System.Windows.Forms.Padding(3);
            this.tabClock.Size = new System.Drawing.Size(487, 189);
            this.tabClock.TabIndex = 3;
            this.tabClock.Text = "Speed";
            this.tabClock.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBarSpeed);
            this.groupBox3.Controls.Add(this.lblSpeed);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(17, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 78);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ISP Clock";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 19);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(375, 45);
            this.trackBarSpeed.TabIndex = 1;
            this.trackBarSpeed.Value = 9;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSpeed.Location = new System.Drawing.Point(388, 34);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(49, 17);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Speed";
            // 
            // tabMemory
            // 
            this.tabMemory.Controls.Add(this.groupBox4);
            this.tabMemory.Controls.Add(this.groupBox2);
            this.tabMemory.Location = new System.Drawing.Point(79, 4);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemory.Size = new System.Drawing.Size(487, 189);
            this.tabMemory.TabIndex = 0;
            this.tabMemory.Text = "Memory";
            this.tabMemory.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVeriEeprom);
            this.groupBox4.Controls.Add(this.btnReadEeprom);
            this.groupBox4.Controls.Add(this.btnWriteEeprom);
            this.groupBox4.Controls.Add(this.btnDirEeprom);
            this.groupBox4.Controls.Add(this.cmbDirEeprom);
            this.groupBox4.Controls.Add(this.chboxVerifyEeprom);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(6, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 88);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EEPROM";
            // 
            // btnVeriEeprom
            // 
            this.btnVeriEeprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnVeriEeprom.Location = new System.Drawing.Point(404, 47);
            this.btnVeriEeprom.Name = "btnVeriEeprom";
            this.btnVeriEeprom.Size = new System.Drawing.Size(65, 29);
            this.btnVeriEeprom.TabIndex = 3;
            this.btnVeriEeprom.Text = "Verify";
            this.btnVeriEeprom.UseVisualStyleBackColor = true;
            this.btnVeriEeprom.Click += new System.EventHandler(this.btnVerifyEeprom_Click);
            // 
            // btnReadEeprom
            // 
            this.btnReadEeprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReadEeprom.Location = new System.Drawing.Point(333, 47);
            this.btnReadEeprom.Name = "btnReadEeprom";
            this.btnReadEeprom.Size = new System.Drawing.Size(65, 29);
            this.btnReadEeprom.TabIndex = 3;
            this.btnReadEeprom.Text = "Read";
            this.btnReadEeprom.UseVisualStyleBackColor = true;
            this.btnReadEeprom.Click += new System.EventHandler(this.btnReadEeprom_Click);
            // 
            // btnWriteEeprom
            // 
            this.btnWriteEeprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWriteEeprom.Location = new System.Drawing.Point(262, 47);
            this.btnWriteEeprom.Name = "btnWriteEeprom";
            this.btnWriteEeprom.Size = new System.Drawing.Size(65, 29);
            this.btnWriteEeprom.TabIndex = 3;
            this.btnWriteEeprom.Text = "Write";
            this.btnWriteEeprom.UseVisualStyleBackColor = true;
            this.btnWriteEeprom.Click += new System.EventHandler(this.btnWriteEeprom_Click);
            // 
            // btnDirEeprom
            // 
            this.btnDirEeprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDirEeprom.Location = new System.Drawing.Point(446, 19);
            this.btnDirEeprom.Name = "btnDirEeprom";
            this.btnDirEeprom.Size = new System.Drawing.Size(23, 23);
            this.btnDirEeprom.TabIndex = 2;
            this.btnDirEeprom.Text = "...";
            this.btnDirEeprom.UseVisualStyleBackColor = true;
            this.btnDirEeprom.Click += new System.EventHandler(this.btnDirEeprom_Click);
            // 
            // cmbDirEeprom
            // 
            this.cmbDirEeprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDirEeprom.FormattingEnabled = true;
            this.cmbDirEeprom.Location = new System.Drawing.Point(7, 19);
            this.cmbDirEeprom.Name = "cmbDirEeprom";
            this.cmbDirEeprom.Size = new System.Drawing.Size(432, 23);
            this.cmbDirEeprom.TabIndex = 1;
            // 
            // chboxVerifyEeprom
            // 
            this.chboxVerifyEeprom.AutoSize = true;
            this.chboxVerifyEeprom.Checked = true;
            this.chboxVerifyEeprom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxVerifyEeprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxVerifyEeprom.Location = new System.Drawing.Point(7, 54);
            this.chboxVerifyEeprom.Name = "chboxVerifyEeprom";
            this.chboxVerifyEeprom.Size = new System.Drawing.Size(138, 19);
            this.chboxVerifyEeprom.TabIndex = 0;
            this.chboxVerifyEeprom.Text = "Auto Verify EEPROM";
            this.chboxVerifyEeprom.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVeriMemory);
            this.groupBox2.Controls.Add(this.btnWriteMemory);
            this.groupBox2.Controls.Add(this.btnReadMemory);
            this.groupBox2.Controls.Add(this.btnDirMemory);
            this.groupBox2.Controls.Add(this.cmbDirMemory);
            this.groupBox2.Controls.Add(this.chboxVerifyFlash);
            this.groupBox2.Controls.Add(this.chboxEraseDvc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flash";
            // 
            // btnVeriMemory
            // 
            this.btnVeriMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnVeriMemory.Location = new System.Drawing.Point(404, 48);
            this.btnVeriMemory.Name = "btnVeriMemory";
            this.btnVeriMemory.Size = new System.Drawing.Size(65, 29);
            this.btnVeriMemory.TabIndex = 3;
            this.btnVeriMemory.Text = "Verify";
            this.btnVeriMemory.UseVisualStyleBackColor = true;
            this.btnVeriMemory.Click += new System.EventHandler(this.btnVerifyMemory_Click);
            // 
            // btnWriteMemory
            // 
            this.btnWriteMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWriteMemory.Location = new System.Drawing.Point(262, 48);
            this.btnWriteMemory.Name = "btnWriteMemory";
            this.btnWriteMemory.Size = new System.Drawing.Size(65, 29);
            this.btnWriteMemory.TabIndex = 3;
            this.btnWriteMemory.Text = "Write";
            this.btnWriteMemory.UseVisualStyleBackColor = true;
            this.btnWriteMemory.Click += new System.EventHandler(this.btnWriteMemory_Click);
            // 
            // btnReadMemory
            // 
            this.btnReadMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReadMemory.Location = new System.Drawing.Point(333, 48);
            this.btnReadMemory.Name = "btnReadMemory";
            this.btnReadMemory.Size = new System.Drawing.Size(65, 29);
            this.btnReadMemory.TabIndex = 3;
            this.btnReadMemory.Text = "Read";
            this.btnReadMemory.UseVisualStyleBackColor = true;
            this.btnReadMemory.Click += new System.EventHandler(this.btnReadMemory_Click);
            // 
            // btnDirMemory
            // 
            this.btnDirMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDirMemory.Location = new System.Drawing.Point(446, 19);
            this.btnDirMemory.Name = "btnDirMemory";
            this.btnDirMemory.Size = new System.Drawing.Size(23, 23);
            this.btnDirMemory.TabIndex = 2;
            this.btnDirMemory.Text = "...";
            this.btnDirMemory.UseVisualStyleBackColor = true;
            this.btnDirMemory.Click += new System.EventHandler(this.btnDirMemory_Click);
            // 
            // cmbDirMemory
            // 
            this.cmbDirMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDirMemory.FormattingEnabled = true;
            this.cmbDirMemory.Location = new System.Drawing.Point(7, 19);
            this.cmbDirMemory.Name = "cmbDirMemory";
            this.cmbDirMemory.Size = new System.Drawing.Size(432, 23);
            this.cmbDirMemory.TabIndex = 1;
            // 
            // chboxVerifyFlash
            // 
            this.chboxVerifyFlash.AutoSize = true;
            this.chboxVerifyFlash.Checked = true;
            this.chboxVerifyFlash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxVerifyFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxVerifyFlash.Location = new System.Drawing.Point(7, 62);
            this.chboxVerifyFlash.Name = "chboxVerifyFlash";
            this.chboxVerifyFlash.Size = new System.Drawing.Size(109, 19);
            this.chboxVerifyFlash.TabIndex = 0;
            this.chboxVerifyFlash.Text = "Auto verify flash";
            this.chboxVerifyFlash.UseVisualStyleBackColor = true;
            // 
            // chboxEraseDvc
            // 
            this.chboxEraseDvc.AutoSize = true;
            this.chboxEraseDvc.Checked = true;
            this.chboxEraseDvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxEraseDvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxEraseDvc.Location = new System.Drawing.Point(7, 44);
            this.chboxEraseDvc.Name = "chboxEraseDvc";
            this.chboxEraseDvc.Size = new System.Drawing.Size(96, 19);
            this.chboxEraseDvc.TabIndex = 0;
            this.chboxEraseDvc.Text = "Erase device";
            this.chboxEraseDvc.UseVisualStyleBackColor = true;
            // 
            // tabFuse
            // 
            this.tabFuse.Controls.Add(this.groupBox5);
            this.tabFuse.Location = new System.Drawing.Point(79, 4);
            this.tabFuse.Name = "tabFuse";
            this.tabFuse.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuse.Size = new System.Drawing.Size(487, 189);
            this.tabFuse.TabIndex = 1;
            this.tabFuse.Text = "Fuses";
            this.tabFuse.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnReadFuse);
            this.groupBox5.Controls.Add(this.btnWriteFuse);
            this.groupBox5.Controls.Add(this.txtbxOutHigh);
            this.groupBox5.Controls.Add(this.txtbxOutLow);
            this.groupBox5.Controls.Add(this.lblOutLow);
            this.groupBox5.Controls.Add(this.lblOutHigh);
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(5, -2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(478, 189);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fuse";
            // 
            // btnReadFuse
            // 
            this.btnReadFuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReadFuse.Location = new System.Drawing.Point(313, 158);
            this.btnReadFuse.Name = "btnReadFuse";
            this.btnReadFuse.Size = new System.Drawing.Size(66, 26);
            this.btnReadFuse.TabIndex = 9;
            this.btnReadFuse.Text = "Read";
            this.btnReadFuse.UseVisualStyleBackColor = true;
            // 
            // btnWriteFuse
            // 
            this.btnWriteFuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWriteFuse.Location = new System.Drawing.Point(241, 158);
            this.btnWriteFuse.Name = "btnWriteFuse";
            this.btnWriteFuse.Size = new System.Drawing.Size(66, 26);
            this.btnWriteFuse.TabIndex = 10;
            this.btnWriteFuse.Text = "Write";
            this.btnWriteFuse.UseVisualStyleBackColor = true;
            this.btnWriteFuse.Click += new System.EventHandler(this.btnWriteFuse_Click);
            // 
            // txtbxOutHigh
            // 
            this.txtbxOutHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbxOutHigh.Location = new System.Drawing.Point(88, 162);
            this.txtbxOutHigh.Name = "txtbxOutHigh";
            this.txtbxOutHigh.Size = new System.Drawing.Size(32, 20);
            this.txtbxOutHigh.TabIndex = 7;
            // 
            // txtbxOutLow
            // 
            this.txtbxOutLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbxOutLow.Location = new System.Drawing.Point(183, 161);
            this.txtbxOutLow.Name = "txtbxOutLow";
            this.txtbxOutLow.Size = new System.Drawing.Size(32, 20);
            this.txtbxOutLow.TabIndex = 8;
            // 
            // lblOutLow
            // 
            this.lblOutLow.AutoSize = true;
            this.lblOutLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutLow.Location = new System.Drawing.Point(148, 163);
            this.lblOutLow.Name = "lblOutLow";
            this.lblOutLow.Size = new System.Drawing.Size(33, 15);
            this.lblOutLow.TabIndex = 5;
            this.lblOutLow.Text = "Low:";
            // 
            // lblOutHigh
            // 
            this.lblOutHigh.AutoSize = true;
            this.lblOutHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutHigh.Location = new System.Drawing.Point(50, 164);
            this.lblOutHigh.Name = "lblOutHigh";
            this.lblOutHigh.Size = new System.Drawing.Size(36, 15);
            this.lblOutHigh.TabIndex = 6;
            this.lblOutHigh.Text = "High:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblFuse1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboxFuseBODLVL, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse9, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.chboxFuse7, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse10, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboxFuseCLK, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboxFuseBOOTZ, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFuse6, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 139);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblFuse1
            // 
            this.lblFuse1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse1.AutoSize = true;
            this.lblFuse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse1.Location = new System.Drawing.Point(3, 8);
            this.lblFuse1.Name = "lblFuse1";
            this.lblFuse1.Size = new System.Drawing.Size(50, 13);
            this.lblFuse1.TabIndex = 0;
            this.lblFuse1.Text = "OCDEN";
            // 
            // chboxFuse1
            // 
            this.chboxFuse1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse1.AutoSize = true;
            this.chboxFuse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse1.Location = new System.Drawing.Point(64, 5);
            this.chboxFuse1.Name = "chboxFuse1";
            this.chboxFuse1.Size = new System.Drawing.Size(111, 19);
            this.chboxFuse1.TabIndex = 3;
            this.chboxFuse1.Text = "On-Chip Debug";
            this.chboxFuse1.UseVisualStyleBackColor = true;
            this.chboxFuse1.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // chboxFuse2
            // 
            this.chboxFuse2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse2.AutoSize = true;
            this.chboxFuse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse2.Location = new System.Drawing.Point(64, 32);
            this.chboxFuse2.Name = "chboxFuse2";
            this.chboxFuse2.Size = new System.Drawing.Size(105, 19);
            this.chboxFuse2.TabIndex = 4;
            this.chboxFuse2.Text = "JTAG Interface";
            this.chboxFuse2.UseVisualStyleBackColor = true;
            this.chboxFuse2.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // chboxFuse3
            // 
            this.chboxFuse3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse3.AutoSize = true;
            this.chboxFuse3.Checked = true;
            this.chboxFuse3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxFuse3.Enabled = false;
            this.chboxFuse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse3.Location = new System.Drawing.Point(64, 59);
            this.chboxFuse3.Name = "chboxFuse3";
            this.chboxFuse3.Size = new System.Drawing.Size(87, 19);
            this.chboxFuse3.TabIndex = 5;
            this.chboxFuse3.Text = "ISP Enable";
            this.chboxFuse3.UseVisualStyleBackColor = true;
            this.chboxFuse3.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // chboxFuse5
            // 
            this.chboxFuse5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse5.AutoSize = true;
            this.chboxFuse5.Checked = true;
            this.chboxFuse5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxFuse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse5.Location = new System.Drawing.Point(64, 114);
            this.chboxFuse5.Name = "chboxFuse5";
            this.chboxFuse5.Size = new System.Drawing.Size(113, 19);
            this.chboxFuse5.TabIndex = 6;
            this.chboxFuse5.Text = "EEPROM Saver";
            this.chboxFuse5.UseVisualStyleBackColor = true;
            this.chboxFuse5.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblFuse2
            // 
            this.lblFuse2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse2.AutoSize = true;
            this.lblFuse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse2.Location = new System.Drawing.Point(3, 35);
            this.lblFuse2.Name = "lblFuse2";
            this.lblFuse2.Size = new System.Drawing.Size(55, 13);
            this.lblFuse2.TabIndex = 7;
            this.lblFuse2.Text = "JTAGEN";
            // 
            // lblFuse3
            // 
            this.lblFuse3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse3.AutoSize = true;
            this.lblFuse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse3.Location = new System.Drawing.Point(3, 62);
            this.lblFuse3.Name = "lblFuse3";
            this.lblFuse3.Size = new System.Drawing.Size(44, 13);
            this.lblFuse3.TabIndex = 8;
            this.lblFuse3.Text = "SPIEN";
            // 
            // lblFuse5
            // 
            this.lblFuse5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse5.AutoSize = true;
            this.lblFuse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse5.Location = new System.Drawing.Point(3, 117);
            this.lblFuse5.Name = "lblFuse5";
            this.lblFuse5.Size = new System.Drawing.Size(55, 13);
            this.lblFuse5.TabIndex = 9;
            this.lblFuse5.Text = "EESAVE";
            // 
            // lblFuse4
            // 
            this.lblFuse4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse4.AutoSize = true;
            this.lblFuse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse4.Location = new System.Drawing.Point(3, 89);
            this.lblFuse4.Name = "lblFuse4";
            this.lblFuse4.Size = new System.Drawing.Size(48, 13);
            this.lblFuse4.TabIndex = 11;
            this.lblFuse4.Text = "CKOPT";
            // 
            // chboxFuse4
            // 
            this.chboxFuse4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse4.AutoSize = true;
            this.chboxFuse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse4.Location = new System.Drawing.Point(64, 86);
            this.chboxFuse4.Name = "chboxFuse4";
            this.chboxFuse4.Size = new System.Drawing.Size(113, 19);
            this.chboxFuse4.TabIndex = 16;
            this.chboxFuse4.Text = "Clock Operation";
            this.chboxFuse4.UseVisualStyleBackColor = true;
            this.chboxFuse4.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblFuse7
            // 
            this.lblFuse7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse7.AutoSize = true;
            this.lblFuse7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse7.Location = new System.Drawing.Point(193, 35);
            this.lblFuse7.Name = "lblFuse7";
            this.lblFuse7.Size = new System.Drawing.Size(66, 13);
            this.lblFuse7.TabIndex = 10;
            this.lblFuse7.Text = "BOOTRST";
            // 
            // chboxFuse6
            // 
            this.chboxFuse6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse6.AutoSize = true;
            this.chboxFuse6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse6.Location = new System.Drawing.Point(270, 32);
            this.chboxFuse6.Name = "chboxFuse6";
            this.chboxFuse6.Size = new System.Drawing.Size(121, 19);
            this.chboxFuse6.TabIndex = 15;
            this.chboxFuse6.Text = "Boot Reset vector";
            this.chboxFuse6.UseVisualStyleBackColor = true;
            this.chboxFuse6.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblFuse8
            // 
            this.lblFuse8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse8.AutoSize = true;
            this.lblFuse8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse8.Location = new System.Drawing.Point(193, 62);
            this.lblFuse8.Name = "lblFuse8";
            this.lblFuse8.Size = new System.Drawing.Size(71, 13);
            this.lblFuse8.TabIndex = 12;
            this.lblFuse8.Text = "BODLEVEL";
            // 
            // cboxFuseBODLVL
            // 
            this.cboxFuseBODLVL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxFuseBODLVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxFuseBODLVL.FormattingEnabled = true;
            this.cboxFuseBODLVL.Location = new System.Drawing.Point(270, 57);
            this.cboxFuseBODLVL.Name = "cboxFuseBODLVL";
            this.cboxFuseBODLVL.Size = new System.Drawing.Size(80, 23);
            this.cboxFuseBODLVL.TabIndex = 18;
            this.cboxFuseBODLVL.SelectedIndexChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblFuse9
            // 
            this.lblFuse9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse9.AutoSize = true;
            this.lblFuse9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse9.Location = new System.Drawing.Point(193, 89);
            this.lblFuse9.Name = "lblFuse9";
            this.lblFuse9.Size = new System.Drawing.Size(50, 13);
            this.lblFuse9.TabIndex = 13;
            this.lblFuse9.Text = "BODEN";
            // 
            // chboxFuse7
            // 
            this.chboxFuse7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chboxFuse7.AutoSize = true;
            this.chboxFuse7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chboxFuse7.Location = new System.Drawing.Point(270, 86);
            this.chboxFuse7.Name = "chboxFuse7";
            this.chboxFuse7.Size = new System.Drawing.Size(138, 19);
            this.chboxFuse7.TabIndex = 17;
            this.chboxFuse7.Text = " Brown-out detection";
            this.chboxFuse7.UseVisualStyleBackColor = true;
            this.chboxFuse7.CheckedChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblFuse10
            // 
            this.lblFuse10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse10.AutoSize = true;
            this.lblFuse10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse10.Location = new System.Drawing.Point(193, 117);
            this.lblFuse10.Name = "lblFuse10";
            this.lblFuse10.Size = new System.Drawing.Size(46, 13);
            this.lblFuse10.TabIndex = 14;
            this.lblFuse10.Text = "CKSEL";
            // 
            // cboxFuseCLK
            // 
            this.cboxFuseCLK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxFuseCLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxFuseCLK.ForeColor = System.Drawing.Color.Black;
            this.cboxFuseCLK.Location = new System.Drawing.Point(270, 112);
            this.cboxFuseCLK.Name = "cboxFuseCLK";
            this.cboxFuseCLK.Size = new System.Drawing.Size(173, 23);
            this.cboxFuseCLK.TabIndex = 0;
            this.cboxFuseCLK.SelectedIndexChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // cboxFuseBOOTZ
            // 
            this.cboxFuseBOOTZ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxFuseBOOTZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxFuseBOOTZ.FormattingEnabled = true;
            this.cboxFuseBOOTZ.Location = new System.Drawing.Point(270, 3);
            this.cboxFuseBOOTZ.Name = "cboxFuseBOOTZ";
            this.cboxFuseBOOTZ.Size = new System.Drawing.Size(80, 23);
            this.cboxFuseBOOTZ.TabIndex = 2;
            this.cboxFuseBOOTZ.SelectedIndexChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblFuse6
            // 
            this.lblFuse6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuse6.AutoSize = true;
            this.lblFuse6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFuse6.Location = new System.Drawing.Point(193, 8);
            this.lblFuse6.Name = "lblFuse6";
            this.lblFuse6.Size = new System.Drawing.Size(57, 13);
            this.lblFuse6.TabIndex = 1;
            this.lblFuse6.Text = "BOOTSZ";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.label1);
            this.tabHelp.Location = new System.Drawing.Point(79, 4);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(487, 189);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(108, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVR Programming";
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(85, 251);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(491, 162);
            this.txtConsole.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnApply.ForeColor = System.Drawing.Color.Red;
            this.btnApply.Location = new System.Drawing.Point(390, 8);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(58, 40);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cboxInterface
            // 
            this.cboxInterface.FormattingEnabled = true;
            this.cboxInterface.Location = new System.Drawing.Point(186, 24);
            this.cboxInterface.Name = "cboxInterface";
            this.cboxInterface.Size = new System.Drawing.Size(88, 21);
            this.cboxInterface.TabIndex = 7;
            this.cboxInterface.SelectedIndexChanged += new System.EventHandler(this.cboxInterface_SelectedIndexChanged);
            // 
            // cboxCOM
            // 
            this.cboxCOM.Enabled = false;
            this.cboxCOM.FormattingEnabled = true;
            this.cboxCOM.Location = new System.Drawing.Point(99, 24);
            this.cboxCOM.Name = "cboxCOM";
            this.cboxCOM.Size = new System.Drawing.Size(81, 21);
            this.cboxCOM.TabIndex = 7;
            this.cboxCOM.SelectedIndexChanged += new System.EventHandler(this.cboxInterface_SelectedIndexChanged);
            // 
            // cboxDevice
            // 
            this.cboxDevice.FormattingEnabled = true;
            this.cboxDevice.Location = new System.Drawing.Point(280, 24);
            this.cboxDevice.Name = "cboxDevice";
            this.cboxDevice.Size = new System.Drawing.Size(80, 21);
            this.cboxDevice.TabIndex = 6;
            this.cboxDevice.SelectedIndexChanged += new System.EventHandler(this.chboxFuses_ItemChanged);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(277, 9);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(41, 13);
            this.lblDevice.TabIndex = 5;
            this.lblDevice.Text = "Device";
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(183, 9);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(49, 13);
            this.lblInterface.TabIndex = 8;
            this.lblInterface.Text = "Interface";
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(1, 9);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(28, 13);
            this.lblTool.TabIndex = 4;
            this.lblTool.Text = "Tool";
            // 
            // cboxTool
            // 
            this.cboxTool.FormattingEnabled = true;
            this.cboxTool.Location = new System.Drawing.Point(5, 24);
            this.cboxTool.Name = "cboxTool";
            this.cboxTool.Size = new System.Drawing.Size(88, 21);
            this.cboxTool.TabIndex = 3;
            this.cboxTool.SelectedIndexChanged += new System.EventHandler(this.cboxTool_SelectedIndexChanged);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(96, 9);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(31, 13);
            this.lblCom.TabIndex = 8;
            this.lblCom.Text = "COM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxDevice);
            this.groupBox1.Controls.Add(this.cboxTool);
            this.groupBox1.Controls.Add(this.lblCom);
            this.groupBox1.Controls.Add(this.lblTool);
            this.groupBox1.Controls.Add(this.lblDevice);
            this.groupBox1.Controls.Add(this.cboxInterface);
            this.groupBox1.Controls.Add(this.lblInterface);
            this.groupBox1.Controls.Add(this.cboxCOM);
            this.groupBox1.Location = new System.Drawing.Point(7, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClock.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.tabMemory.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabFuse.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMemory;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cboxInterface;
        private System.Windows.Forms.ComboBox cboxCOM;
        private System.Windows.Forms.ComboBox cboxDevice;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.ComboBox cboxTool;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chboxVerifyFlash;
        private System.Windows.Forms.Button btnDirMemory;
        private System.Windows.Forms.ComboBox cmbDirMemory;
        private System.Windows.Forms.CheckBox chboxEraseDvc;
        private System.Windows.Forms.Button btnVeriMemory;
        private System.Windows.Forms.Button btnReadMemory;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabClock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVeriEeprom;
        private System.Windows.Forms.Button btnWriteEeprom;
        private System.Windows.Forms.Button btnDirEeprom;
        private System.Windows.Forms.ComboBox cmbDirEeprom;
        private System.Windows.Forms.CheckBox chboxVerifyEeprom;
        private System.Windows.Forms.TabPage tabFuse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnReadFuse;
        private System.Windows.Forms.Button btnWriteFuse;
        private System.Windows.Forms.TextBox txtbxOutHigh;
        private System.Windows.Forms.TextBox txtbxOutLow;
        private System.Windows.Forms.Label lblOutLow;
        private System.Windows.Forms.Label lblOutHigh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFuse1;
        private System.Windows.Forms.CheckBox chboxFuse1;
        private System.Windows.Forms.CheckBox chboxFuse2;
        private System.Windows.Forms.CheckBox chboxFuse3;
        private System.Windows.Forms.CheckBox chboxFuse5;
        private System.Windows.Forms.Label lblFuse2;
        private System.Windows.Forms.Label lblFuse3;
        private System.Windows.Forms.Label lblFuse5;
        private System.Windows.Forms.Label lblFuse4;
        private System.Windows.Forms.CheckBox chboxFuse4;
        private System.Windows.Forms.Label lblFuse7;
        private System.Windows.Forms.CheckBox chboxFuse6;
        private System.Windows.Forms.Label lblFuse8;
        private System.Windows.Forms.ComboBox cboxFuseBODLVL;
        private System.Windows.Forms.Label lblFuse9;
        private System.Windows.Forms.CheckBox chboxFuse7;
        private System.Windows.Forms.Label lblFuse10;
        private System.Windows.Forms.ComboBox cboxFuseCLK;
        private System.Windows.Forms.ComboBox cboxFuseBOOTZ;
        private System.Windows.Forms.Label lblFuse6;
        private System.Windows.Forms.Button btnReadEeprom;
        private System.Windows.Forms.Button btnWriteMemory;
    }
}