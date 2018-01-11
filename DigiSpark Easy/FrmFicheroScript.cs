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
    public partial class FrmFicheroScript : Form
    {
        public String url = "";
        public FrmFicheroScript()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txturl.Text=="")
            {
                MessageBox.Show("El campo no puede estar vacio","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                url = txturl.Text;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
