using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSpark_Easy
{
    public partial class FrmMain : Form
    {
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

    }
}
