using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;

namespace DemoUSBASP
{
    public partial class Form1 : Form
    {
        private Avrdude avrdude;

        private String[] tool_name = { "USB-ASP","STK500" };
        private String[] device_name = {"Atmega644","Atmega16", "Atmega32", "Atmega328", "Atmega8", "Atmega128"};
        private String[] interface_programing = { "ISP","HVPP"};

        //HIGH FUSE
        private byte OCDEN_VAL = 0x80;
        private byte JTAG_VAL = 0x40;
        private byte SPI_VAL = 0x20;
        private byte CKOPT_VAL = 0x10;
        private byte EESAVE_VAL = 0x08;
        private byte BODRST_VAL = 0x01;
        private byte[] BOOTSZ_VAL = { 0x06, 0x04, 0x02, 0x00 };
        private String[] BOOTSZ = { "128W", "256W", "512W", "1024W" };
        
        //LOW FUSE
        private byte BODEN_VAL = 0x40;
        private byte[] BODLEVEL_VAL = { 0x00, 0x80 };
        private string[] BODLEVEL = { "4V0", "2V7" };
        private byte[] SUT_CKSEL_VAL = {0x24, 0x3f };
        private string[] SUT_CKSEL = { "INTRCOSC_8MHZ_6CK_64MS", "EXT_HIGHFRQ_16KCK_64MS"};

        //ISP CLOCK
        private double default_clock;
        private double[] speed_arr = { 1, 2, 4, 8, 16, 32, 93.75, 187.5, 375, 750, 1500 };

        //initial
        private string avrdude_dir = @"C:\Program Files\USBASP\bin\avrdude.exe";
      //  private string configfile  = @"C:\ProgramData\USBASP\data.ini";
      //  private string default_dir = "";

        public Form1()
        {
            InitializeComponent();
            this.Icon = DemoUSBASP.Properties.Resources.Icon;
           
            default_clock = 750;

            initial_component();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            avrdude = new Avrdude(avrdude_dir);
            Util.UI = this;
            Util.consoleSet(txtConsole);

        }

        #region INITIAL
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Far;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        public void initial_component()
        {
            //Tool name
            foreach (String s in tool_name)
            {
                cboxTool.Items.Add(s);
            }
            cboxTool.SelectedIndex = 0;

            //Device Name
            foreach(String s in device_name)
            {
                cboxDevice.Items.Add(s);
            }
            cboxDevice.SelectedIndex = 0;

            //Interface programing
            foreach (String s in interface_programing)
            {
                cboxInterface.Items.Add(s);
            }
            cboxInterface.SelectedIndex = 0;

            //ISP clock
            int i=0;
            foreach(double d in speed_arr ) 
            {
                if (d == default_clock) trackBarSpeed.Value = i;
                i++;
            }
            lblSpeed.Text = default_clock.ToString() + "KHz";


            //COM PORT
            find_COM_port();

            initial_fuse_tab();
        }

        public void find_COM_port()
        {
            string[] ports = SerialPort.GetPortNames();
            cboxCOM.Items.Clear();
            foreach (string port in ports)
            {
                cboxCOM.Items.Add(port);
            }
            cboxCOM.SelectedIndex = (cboxCOM.Items.Count - 1);
        }

        public void initial_fuse_tab()
        {
            //BOOTSZ
            foreach (String s in BOOTSZ)
            {
                cboxFuseBOOTZ.Items.Add(s);
            }
            cboxFuseBOOTZ.SelectedIndex = 3;

            //BODLEVEL
            foreach(String s in BODLEVEL)
            {
                cboxFuseBODLVL.Items.Add(s);
            }
            cboxFuseBODLVL.SelectedIndex = 1;

            //SU_CKSEL
            foreach (String s in SUT_CKSEL)
            {
                cboxFuseCLK.Items.Add(s);
            }
            cboxFuseCLK.SelectedIndex = 1;
        }

        #endregion

        #region FUSE
        public byte read_low_fuse()
        {
            byte val = 0;
            if (chboxFuse7.Checked==false) val += BODEN_VAL;
            try
            {
                val += BODLEVEL_VAL[cboxFuseBODLVL.SelectedIndex];
                val += SUT_CKSEL_VAL[cboxFuseCLK.SelectedIndex];
            }
            catch (Exception) { }
            return val;
        }

        public byte read_high_fuse()
        {
            byte val = 0;
            if (chboxFuse1.Checked == false) val += OCDEN_VAL;
            if (chboxFuse2.Checked == false) val += JTAG_VAL;
            if (chboxFuse3.Checked == false) val += SPI_VAL;
            if (chboxFuse4.Checked == false) val += CKOPT_VAL;
            if (chboxFuse5.Checked == false) val += EESAVE_VAL;
            if (chboxFuse6.Checked == false) val += BODRST_VAL;
            try
            {
                val += BOOTSZ_VAL[cboxFuseBOOTZ.SelectedIndex];
            }
            catch (Exception) { }
            return val;
        }

        public string update_fuse_output()
        {
            string high=read_high_fuse().ToString("x2");
            string low= read_low_fuse().ToString("x2");
            txtbxOutHigh.Text = high.ToUpper();
            txtbxOutLow.Text = low.ToUpper();
            string s = generate_command("-U") + "lfuse:w:0x"+low+":m -U hfuse:w:0x"+high+":m ";
            return s;
        }
         
        #endregion

        #region EVENT
        private void chboxFuses_ItemChanged(object sender, EventArgs e)//use for all Fuse check box
        {
            update_fuse_output();
        }

        private void cboxTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_fuse_output();
            if (cboxTool.Text == "STK500")
            {
                cboxCOM.Enabled = true;
                cboxInterface.Enabled = true;
                find_COM_port();
            }
            else
            {
                cboxCOM.Enabled = false;
                cboxInterface.Enabled = false;
            }
        }

        private void cboxInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_fuse_output();
        }

        private void btnWriteFuse_Click(object sender, EventArgs e)
        {
            avrdude.runCommand(update_fuse_output());
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            string s = generate_command("-n");
            avrdude.runCommand(s);
        }

        private void btnDirMemory_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenHexFile = new OpenFileDialog();
            OpenHexFile.Filter = "All files (*.*)|*.*|Hex files (*.hex)|*.hex";
            OpenHexFile.FilterIndex = 2;
            OpenHexFile.RestoreDirectory = true;

            if (OpenHexFile.ShowDialog() == DialogResult.OK)
            {
                cmbDirMemory.Items.Add(OpenHexFile.FileName);
                cmbDirMemory.SelectedIndex = cmbDirMemory.Items.Count-1;
            }
        }
        private void btnDirEeprom_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenEepromFile = new OpenFileDialog();
            OpenEepromFile.Filter = "All files (*.*)|*.*|Hex files (*.eep)|*.eep";
            OpenEepromFile.FilterIndex = 2;
            OpenEepromFile.RestoreDirectory = true;

            if (OpenEepromFile.ShowDialog() == DialogResult.OK)
            {
                cmbDirEeprom.Items.Add(OpenEepromFile.FileName);
                cmbDirEeprom.SelectedIndex = cmbDirEeprom.Items.Count-1;
            }
        }

        private void btnWriteMemory_Click(object sender, EventArgs e)
        {
            if (cmbDirMemory.Items.Count == 0 || cmbDirMemory.Text.Trim()=="")
            {
                OpenFileDialog OpenHexFile = new OpenFileDialog();
                OpenHexFile.Filter = "All files (*.*)|*.*|Hex files (*.hex)|*.hex";
                OpenHexFile.FilterIndex = 2;
                OpenHexFile.Title = "Open hex to write";
                OpenHexFile.RestoreDirectory = true;

                if (OpenHexFile.ShowDialog() == DialogResult.OK)
                {
                    cmbDirMemory.Items.Add(OpenHexFile.FileName);
                    cmbDirMemory.SelectedIndex = cmbDirMemory.Items.Count - 1;

                }
                else return;
            }
            string verify = chboxVerifyFlash.Checked ? "" : "-V ";
            string erase = chboxEraseDvc.Checked ? "" : "-D ";
            avrdude.runCommand(generate_command(verify + erase + "-U") + "flash:w:\"" + cmbDirMemory.Text + "\":i");
        }
        private void btnWriteEeprom_Click(object sender, EventArgs e)
        {
            if (cmbDirEeprom.Items.Count == 0 || cmbDirEeprom.Text.Trim()=="")
            {
                OpenFileDialog OpenEepromFile = new OpenFileDialog();
                OpenEepromFile.Filter = "All files (*.*)|*.*|Hex files (*.eep)|*.eep";
                OpenEepromFile.FilterIndex = 2;
                OpenEepromFile.Title = "Open eeprom to write";
                OpenEepromFile.RestoreDirectory = true;

                if (OpenEepromFile.ShowDialog() == DialogResult.OK)
                {
                    cmbDirEeprom.Items.Add(OpenEepromFile.FileName);
                    cmbDirEeprom.SelectedIndex = cmbDirEeprom.Items.Count - 1;
                }
                else return;
            }
            string verify = chboxVerifyEeprom.Checked ? "" : "-V ";
            avrdude.runCommand(generate_command(verify + "-U") + "eeprom:w:\"" + cmbDirEeprom.Text + "\":i");
        }
        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveMemDialog = new SaveFileDialog();
            saveMemDialog.Title = "Save Hex Files";
            saveMemDialog.CheckPathExists = true;
            saveMemDialog.DefaultExt = "hex";
            saveMemDialog.Filter = "All files (*.*)|*.*|Hex files (*.hex)|*.hex";
            saveMemDialog.FilterIndex = 2;
            saveMemDialog.RestoreDirectory = true;
            saveMemDialog.FileName = System.DateTime.Now.ToString("dd-MM_hh-mm tt");
            if (saveMemDialog.ShowDialog() == DialogResult.OK)
            {
                avrdude.runCommand(generate_command("-U") + "flash:r:\"" + saveMemDialog.FileName + "\":i");
            }
          
        }

        private void btnReadEeprom_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEepDialog = new SaveFileDialog();
            saveEepDialog.Title = "Save Eeprom Files";
            saveEepDialog.CheckPathExists = true;
            saveEepDialog.DefaultExt = "eep";
            saveEepDialog.Filter = "All files (*.*)|*.*|Hex files (*.eep)|*.eep";
            saveEepDialog.FilterIndex = 2;
            saveEepDialog.RestoreDirectory = true;
            saveEepDialog.FileName = System.DateTime.Now.ToString("dd-MM_hh-mm tt");
            if (saveEepDialog.ShowDialog() == DialogResult.OK)
            {
                avrdude.runCommand(generate_command("-U") + "eeprom:r:\"" + saveEepDialog.FileName + "\":i");
            }
        }
        private void btnVerifyMemory_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMemDialog = new OpenFileDialog();
            openMemDialog.Title = "Open hex to verify";
            openMemDialog.CheckPathExists = true;
            openMemDialog.DefaultExt = "hex";
            openMemDialog.Filter = "All files (*.*)|*.*|Hex files (*.hex)|*.hex";
            openMemDialog.FilterIndex = 2;
            openMemDialog.RestoreDirectory = true;
            if (openMemDialog.ShowDialog() == DialogResult.OK)
            {
                avrdude.runCommand(generate_command("-U") + "flash:v:\"" + openMemDialog.FileName + "\":i");
            }
        }

        private void btnVerifyEeprom_Click(object sender, EventArgs e)
        {
            OpenFileDialog openEepDialog = new OpenFileDialog();
            openEepDialog.Title = "Open eeprom to ferify";
            openEepDialog.CheckPathExists = true;
            openEepDialog.DefaultExt = "eep";
            openEepDialog.Filter = "All files (*.*)|*.*|Eeprom files (*.eep)|*.eep";
            openEepDialog.FilterIndex = 2;
            openEepDialog.RestoreDirectory = true;
            if (openEepDialog.ShowDialog() == DialogResult.OK)
            {
                avrdude.runCommand(generate_command("-U") + "eeprom:v:\"" + openEepDialog.FileName + "\":i");
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            default_clock = speed_arr[trackBarSpeed.Value];
            lblSpeed.Text = default_clock.ToString() + "KHz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        #endregion

 
        private string generate_command(string type) //type is -n, -U
        {
            string tool = "";
            switch (cboxTool.Text)
            {
                case "USB-ASP": tool = "usbasp"; break;
                case "STK500":
                    switch (cboxInterface.Text)
                    {
                        case "ISP": tool = "stk500v2 -P "; break;
                        case "HVPP": tool = "stk500pp -P "; break;
                    }
                    tool += cboxCOM.Text;
                    break;
            }

            string device = "";
            switch (cboxDevice.Text)
            {
                case "Atmega16": device = "m16"; break;
                case "Atmega32": device = "m32"; break;
                case "Atmega8":  device = "m8"; break;
                case "Atmega128": device = "m128"; break;
                case "Atmega328": device = "m328p"; break;
                case "Atmega644": device = "m644p"; break;
            }

            string speed = (750 / default_clock).ToString();
            speed = speed.Replace(',', '.');
            string s = "-c " + tool + " -p " + device + " -B " + speed + " " + type + " ";
            return s;
        }

        private void read_config_file()
        {

        }
        private void write_config_file()
        {
    //        if (cmbDirMemory.Text.Trim() !="") INI.WRITE(configfile, "USB-ASP-CONFIG", "default_dir", cmbDirMemory.Text);
        }

    }
}
