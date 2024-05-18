
namespace ProjetoLojaABC
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.grbPequisar = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rbdNome = new System.Windows.Forms.RadioButton();
            this.rdBCodigo = new System.Windows.Forms.RadioButton();
            this.lstPesquisar = new System.Windows.Forms.ListBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grbPequisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPequisar
            // 
            this.grbPequisar.Controls.Add(this.btnLimpar);
            this.grbPequisar.Controls.Add(this.btnTeste);
            this.grbPequisar.Controls.Add(this.txtDescricao);
            this.grbPequisar.Controls.Add(this.btnPesquisar);
            this.grbPequisar.Controls.Add(this.lblDescricao);
            this.grbPequisar.Controls.Add(this.rbdNome);
            this.grbPequisar.Controls.Add(this.rdBCodigo);
            this.grbPequisar.Location = new System.Drawing.Point(12, 12);
            this.grbPequisar.Name = "grbPequisar";
            this.grbPequisar.Size = new System.Drawing.Size(776, 194);
            this.grbPequisar.TabIndex = 0;
            this.grbPequisar.TabStop = false;
            this.grbPequisar.Text = "Pesquiasr por:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(79, 92);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(365, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(644, 42);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 109);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(17, 92);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // rbdNome
            // 
            this.rbdNome.AutoSize = true;
            this.rbdNome.Location = new System.Drawing.Point(214, 42);
            this.rbdNome.Name = "rbdNome";
            this.rbdNome.Size = new System.Drawing.Size(53, 17);
            this.rbdNome.TabIndex = 2;
            this.rbdNome.Text = "Nome";
            this.rbdNome.UseVisualStyleBackColor = true;
            // 
            // rdBCodigo
            // 
            this.rdBCodigo.AutoSize = true;
            this.rdBCodigo.Location = new System.Drawing.Point(57, 42);
            this.rdBCodigo.Name = "rdBCodigo";
            this.rdBCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdBCodigo.TabIndex = 1;
            this.rdBCodigo.Text = "Código";
            this.rdBCodigo.UseVisualStyleBackColor = true;
            // 
            // lstPesquisar
            // 
            this.lstPesquisar.FormattingEnabled = true;
            this.lstPesquisar.Location = new System.Drawing.Point(12, 233);
            this.lstPesquisar.Name = "lstPesquisar";
            this.lstPesquisar.Size = new System.Drawing.Size(776, 186);
            this.lstPesquisar.TabIndex = 5;
            this.lstPesquisar.SelectedIndexChanged += new System.EventHandler(this.lstPesquisar_SelectedIndexChanged);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(513, 42);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 5;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(513, 92);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPesquisar);
            this.Controls.Add(this.grbPequisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPesquisar";
            this.Text = "Pesquisar";
            this.grbPequisar.ResumeLayout(false);
            this.grbPequisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPequisar;
        private System.Windows.Forms.RadioButton rbdNome;
        private System.Windows.Forms.RadioButton rdBCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListBox lstPesquisar;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnLimpar;
    }
}