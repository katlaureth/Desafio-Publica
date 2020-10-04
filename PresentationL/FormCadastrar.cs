using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace PresentationL
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }
        Jogos j = new Jogos();
        /// <summary>
        /// Quando o usuário clicar no botão, a tela de listar os jogos abrirá.
        /// </summary>

        private void btnListartodosJogos_Click(object sender, EventArgs e)
        {
            FormListarJogos fmListarJogos = new FormListarJogos();
            Hide();
            fmListarJogos.ShowDialog();
            Show();
        }
        /// <summary>
        /// Quando o usuário clicar no botão, verificará se as informações estão correstas e insere no banco de dados.
        /// </summary>
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblMenssagemPlacar.Text = "";
            ValidarInformacoesTela();
            j = Validacoes.Calcular(j);
            string menssagem = Validacoes.Inserir(j);
            if (menssagem.Contains("sucesso"))
            {
                lblMenssagemPlacar.Text = menssagem;
                lblMenssagemPlacar.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMenssagemPlacar.Text = "Houve um problema ao cadastrar, tente novamente ou contate o administração do banco de dados";
            }
        }
        /// <summary>
        /// Verifica se as informações colocadas pelo usuário estão corretas.
        /// </summary>
        private void ValidarInformacoesTela()
        {
            int jogo = 0;
            int placar = 0;
            int quebrarecorde = -1;
            string erro = "";
            try
            {
                jogo = Convert.ToInt32(txtjogo.Text);
                placar = Convert.ToInt32(txtPlacar.Text);
                if (placar > 1000 || placar <= 0)
                {
                    erro = "Insira placar valido \r\n";
                }
                if (jogo <= 0)
                {
                    erro += "Insira o valor de jogo valido \r\n";
                }

                if (erro.Length > 0)
                {
                    lblMenssagemPlacar.Text = erro;
                    return;
                }

            }
            catch (Exception)
            {
                lblMenssagemPlacar.Text = "Insira valores validos";
            }

            j.Placar = placar;
            j.Jogo = jogo;
            j.Recorde = quebrarecorde;
        }
        /// <summary>
        /// Quando o usuário clicar no botão, essa tela irá fechar.
        /// </summary>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
