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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            desabilitarCampos();
        }


        public void desabilitarCampos()
        {
            rdBCodigo.Checked = false;
            rbdNome.Checked = false;
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdBCodigo.Checked == false || rbdNome.Checked == false)
            {
                MessageBox.Show("selecionar pesquisa");
            }
            else
            {
                if (rdBCodigo.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Não posso pesquisar");
                    }
                    else
                    {
                        //busca por codigo

                    }
                }
                else
                {
                    MessageBox.Show("selecionar pesquisa");
                }

                if (rbdNome.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Não posso pesquisar");
                    }
                    else
                    {
                        //busca por codigo

                    }
                }
                else
                {

                }
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //lstPesquisar.Items.Clear();
            lstPesquisar.Items.Add(txtDescricao.Text);           
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // lstPesquisar.Items.Clear();
            txtDescricao.Text = "";
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = lstPesquisar.SelectedIndex;
             string nome = lstPesquisar.SelectedItem.ToString();
             //MessageBox.Show("o numero da linha é " + i + "-" + nome);
            

            frmFuncionarios abrir = new frmFuncionarios(nome);
            abrir.Show();
            this.Hide();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstPesquisar.Items.Add(txtDescricao.Text);
                txtDescricao.Clear();
                txtDescricao.Focus();
            }            
            
        }
    }
}
