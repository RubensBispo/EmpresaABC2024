using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using RestSharp;
using RestSharp.Deserializers;

namespace ProjetoLojaABC
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();

            desabilitarCampos();
        }

        public frmFuncionarios( string nome)
        {
            InitializeComponent();

            desabilitarCampos();

            txtNome.Text = nome;
        }

        //desabilitarCampos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtNumero.Enabled = false;
            mskCelular.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtNumero.Enabled = true;
            mskCelular.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public void cadastrarFuncionarios()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tbFuncionarios(nome,email,cpf,telCel,endereco,numero,cep,cidade,bairro,estado)values(@nome,@email,@cpf,@ctps,@telCel,@endereco,@numero,@cep,@cidade,@bairro,@estado);";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar,100).Value = txtNome;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            cmd.Parameters.Add("@telCel", MySqlDbType.VarChar, 10).Value = mskCelular.Text;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 10).Value = txtEndereco.Text;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value =mskCEP.Text;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 10).Value = txtCidade.Text;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 10).Value = txtBairro.Text;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar, 10).Value = cbbEstado.Text;

            cmd.Connection = Conexao.obterConexao();

            int response = cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso");

            Conexao.fecharConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") && txtEndereco.Text.Equals(""))
            {
                if (txtCodigo.Text.Equals("") || txtNome.Text.Equals("") ||
                 txtEndereco.Text.Equals("") || txtCidade.Text.Equals("") ||
                 txtBairro.Text.Equals("") || txtNumero.Text.Equals("") ||
                 txtEmail.Text.Equals("") || mskCelular.Text.Equals("     -")
                 || mskCPF.Text.Equals("   .   .   -") ||
                 mskCEP.Text.Equals("     -") || cbbEstado.Text.Equals(""))
                {
                    MessageBox.Show("Favor inserir valores válidos!!!",
                    "Mensagem do sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                }
                else
                {
                    cadastrarFuncionarios();
                    desabilitarCampos();
                    btnNovo.Enabled = true;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }

        public  void buscaCEP( string cep)
        {
           
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                RestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", mskCEP.Text));
                RestRequest restRequest = new RestRequest(Method.GET);

                IRestResponse restResponse = restClient.Execute(restRequest);

                DadosRetorno dadosRetorno = new JsonDeserializer().Deserialize<DadosRetorno>(restResponse);

                mskCEP.Text = dadosRetorno.cep;
                txtEndereco.Text = dadosRetorno.logradouro;
                txtBairro.Text = dadosRetorno.bairro;
                txtCidade.Text = dadosRetorno.localidade;
                cbbEstado.Text = dadosRetorno.uf;
                txtNumero.Focus();
            }
        }  
    }
}
