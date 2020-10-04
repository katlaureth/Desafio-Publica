using System;
using System.Windows.Forms;

namespace PresentationL
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Quando o usuário clicar nesse botão a tela Lista de jogos abrirá.
        /// </summary>
   
        private void BtnListarJogos_Click(object sender, EventArgs e)
        {
            FormListarJogos fmListarJogos = new FormListarJogos();
            Hide();
            fmListarJogos.ShowDialog();
            Show();
        }
        /// <summary>
        /// Quando o usuário clicar nesse botão a tela de cadastrar jogos abrirá.
        /// </summary>
        private void BtnCadastrarJogos_Click(object sender, EventArgs e)
        {
            FormCadastrar fmcadastrar = new FormCadastrar();
            Hide();
            fmcadastrar.ShowDialog();
            Show();
        }

        
    }
}
