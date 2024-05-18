using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrsplash_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {
                //lblPorcentagem.Text = pgbSplash.Value.ToString();
                pgbSplash.Value = +10;
                lblPorcentagem.Text = pgbSplash.Value.ToString() + "%";

            }
            else
            {
                tmrsplash.Enabled = false;
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
            }
        }

        
        /*
        private void btnEntrar_Click(object sender, EventArgs e)
        {
        frmLogin abrir = new frmLogin();
        abrir.Show();
        this.Hide();
        }
        */
    }
}
