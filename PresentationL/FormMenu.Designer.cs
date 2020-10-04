namespace PresentationL
{
    partial class FormMenu
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
            this.BtnListarJogos = new System.Windows.Forms.Button();
            this.BtnCadastrarJogos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnListarJogos
            // 
            this.BtnListarJogos.Location = new System.Drawing.Point(12, 89);
            this.BtnListarJogos.Name = "BtnListarJogos";
            this.BtnListarJogos.Size = new System.Drawing.Size(228, 54);
            this.BtnListarJogos.TabIndex = 0;
            this.BtnListarJogos.Text = "Listar Jogos";
            this.BtnListarJogos.UseVisualStyleBackColor = true;
            this.BtnListarJogos.Click += new System.EventHandler(this.BtnListarJogos_Click);
            // 
            // BtnCadastrarJogos
            // 
            this.BtnCadastrarJogos.Location = new System.Drawing.Point(290, 89);
            this.BtnCadastrarJogos.Name = "BtnCadastrarJogos";
            this.BtnCadastrarJogos.Size = new System.Drawing.Size(228, 54);
            this.BtnCadastrarJogos.TabIndex = 1;
            this.BtnCadastrarJogos.Text = "Cadastrar Jogos";
            this.BtnCadastrarJogos.UseVisualStyleBackColor = true;
            this.BtnCadastrarJogos.Click += new System.EventHandler(this.BtnCadastrarJogos_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 210);
            this.Controls.Add(this.BtnCadastrarJogos);
            this.Controls.Add(this.BtnListarJogos);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnListarJogos;
        private System.Windows.Forms.Button BtnCadastrarJogos;
    }
}