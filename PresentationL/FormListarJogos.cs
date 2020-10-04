using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationL
{
    public partial class FormListarJogos : Form
    {
        public FormListarJogos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Quando essa tela abrir, ela carregará a lista de jogos do banco de dados.
        /// </summary>
        
        private void FormListarJogos_Load(object sender, EventArgs e)
        {
            ListarJogos();
        }
        /// <summary>
        /// Quando o usuário clicar no botão, essa tela fechará
        /// </summary>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Quando o usuário clicar no botão, atualizará as informações da lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarJogos();
            lbltexatualiza.Text = "Atualizado com Sucesso!";
        }
        /// <summary>
        /// Lista e coloca na tela as informações dos jogos do banco de dados.
        /// </summary>
        private void ListarJogos()
        {
            lblJogos.Text = "";
            lblPlacar.Text = "";
            lblMaxTemporada.Text = "";
            lblMinTemporada.Text = "";
            lblQuebRecordeMax.Text = "";
            lblQuebRecordeMin.Text = "";
            List<Jogos> jl = Validacoes.ListarJogos();
            for (int i = 0; i < jl.Count; i++)
            {
                lblJogos.Text += jl[i].Jogo.ToString() + "\r\n";
                lblPlacar.Text += jl[i].Placar.ToString() + "\r\n";
                lblMaxTemporada.Text += jl[i].MaximoTemporada.ToString() + "\r\n";
                lblMinTemporada.Text += jl[i].MinimoTemporada.ToString() + "\r\n";
                lblQuebRecordeMax.Text += jl[i].QuebraRecordeMaximo.ToString() + "\r\n";
                lblQuebRecordeMin.Text += jl[i].QuebraRecordeMinimo.ToString() + "\r\n";
            }
        }
    }
}
