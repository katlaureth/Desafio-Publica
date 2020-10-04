namespace PresentationL
{
    partial class FormCadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPlacar = new System.Windows.Forms.TextBox();
            this.btnListartodosJogos = new System.Windows.Forms.Button();
            this.txtjogo = new System.Windows.Forms.TextBox();
            this.lblMenssagemPlacar = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(23, 208);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtPlacar
            // 
            this.txtPlacar.Location = new System.Drawing.Point(179, 82);
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(100, 20);
            this.txtPlacar.TabIndex = 2;
            // 
            // btnListartodosJogos
            // 
            this.btnListartodosJogos.Location = new System.Drawing.Point(204, 200);
            this.btnListartodosJogos.Name = "btnListartodosJogos";
            this.btnListartodosJogos.Size = new System.Drawing.Size(75, 39);
            this.btnListartodosJogos.TabIndex = 5;
            this.btnListartodosJogos.Text = "Listar todos os jogos";
            this.btnListartodosJogos.UseVisualStyleBackColor = true;
            this.btnListartodosJogos.Click += new System.EventHandler(this.btnListartodosJogos_Click);
            // 
            // txtjogo
            // 
            this.txtjogo.Location = new System.Drawing.Point(30, 82);
            this.txtjogo.Name = "txtjogo";
            this.txtjogo.Size = new System.Drawing.Size(100, 20);
            this.txtjogo.TabIndex = 1;
            // 
            // lblMenssagemPlacar
            // 
            this.lblMenssagemPlacar.AutoSize = true;
            this.lblMenssagemPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMenssagemPlacar.ForeColor = System.Drawing.Color.Red;
            this.lblMenssagemPlacar.Location = new System.Drawing.Point(51, 120);
            this.lblMenssagemPlacar.Name = "lblMenssagemPlacar";
            this.lblMenssagemPlacar.Size = new System.Drawing.Size(0, 20);
            this.lblMenssagemPlacar.TabIndex = 12;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(114, 208);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 285);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMenssagemPlacar);
            this.Controls.Add(this.txtjogo);
            this.Controls.Add(this.btnListartodosJogos);
            this.Controls.Add(this.txtPlacar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastrar";
            this.Text = "Cadastrar jogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtPlacar;
        private System.Windows.Forms.Button btnListartodosJogos;
        private System.Windows.Forms.TextBox txtjogo;
        private System.Windows.Forms.Label lblMenssagemPlacar;
        private System.Windows.Forms.Button btnVoltar;
    }
}