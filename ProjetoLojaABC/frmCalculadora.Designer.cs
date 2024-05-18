
namespace ProjetoLojaABC
{
    partial class frmCalculadora
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
            this.lblVar1 = new System.Windows.Forms.Label();
            this.lblVar2 = new System.Windows.Forms.Label();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.gpbOperacao = new System.Windows.Forms.GroupBox();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVar1
            // 
            this.lblVar1.AutoSize = true;
            this.lblVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar1.Location = new System.Drawing.Point(55, 42);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(102, 24);
            this.lblVar1.TabIndex = 0;
            this.lblVar1.Text = "Variável 1";
            // 
            // lblVar2
            // 
            this.lblVar2.AutoSize = true;
            this.lblVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar2.Location = new System.Drawing.Point(55, 122);
            this.lblVar2.Name = "lblVar2";
            this.lblVar2.Size = new System.Drawing.Size(102, 24);
            this.lblVar2.TabIndex = 1;
            this.lblVar2.Text = "Variável 2";
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(174, 46);
            this.txtVar1.Multiline = true;
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(100, 36);
            this.txtVar1.TabIndex = 0;
            this.txtVar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(174, 119);
            this.txtVar2.Multiline = true;
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(100, 36);
            this.txtVar2.TabIndex = 1;
            this.txtVar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbOperacao
            // 
            this.gpbOperacao.Controls.Add(this.rdbDivisao);
            this.gpbOperacao.Controls.Add(this.rdbAdicao);
            this.gpbOperacao.Controls.Add(this.rdbMultiplicao);
            this.gpbOperacao.Controls.Add(this.rdbSubtracao);
            this.gpbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperacao.Location = new System.Drawing.Point(321, 46);
            this.gpbOperacao.Name = "gpbOperacao";
            this.gpbOperacao.Size = new System.Drawing.Size(261, 222);
            this.gpbOperacao.TabIndex = 3;
            this.gpbOperacao.TabStop = false;
            this.gpbOperacao.Text = "Operador";
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdicao.Location = new System.Drawing.Point(22, 42);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(104, 24);
            this.rdbAdicao.TabIndex = 0;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição(+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSubtracao.Location = new System.Drawing.Point(22, 82);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(128, 24);
            this.rdbSubtracao.TabIndex = 5;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração(-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicao
            // 
            this.rdbMultiplicao.AutoSize = true;
            this.rdbMultiplicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMultiplicao.Location = new System.Drawing.Point(22, 132);
            this.rdbMultiplicao.Name = "rdbMultiplicao";
            this.rdbMultiplicao.Size = new System.Drawing.Size(150, 24);
            this.rdbMultiplicao.TabIndex = 6;
            this.rdbMultiplicao.TabStop = true;
            this.rdbMultiplicao.Text = "Multiplicação(*)";
            this.rdbMultiplicao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDivisao.Location = new System.Drawing.Point(22, 173);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(102, 24);
            this.rdbDivisao.TabIndex = 7;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão(/)";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(627, 31);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(631, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 57);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(631, 140);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 58);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(631, 210);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 58);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(631, 281);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(138, 58);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbOperacao);
            this.Controls.Add(this.txtVar2);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.lblVar2);
            this.Controls.Add(this.lblVar1);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.gpbOperacao.ResumeLayout(false);
            this.gpbOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Label lblVar2;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.GroupBox gpbOperacao;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.RadioButton rdbMultiplicao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}