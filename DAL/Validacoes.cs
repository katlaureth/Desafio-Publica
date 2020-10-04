using DTO;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Classe que acessa as informações do banco de dados e preenche propriedades.
    /// </summary>
    public static class Validacoes
    {
        /// <summary>
        /// Insere o jogo no banco de dados
        /// </summary>
        /// <param name="jogos">Jogo a ser inserido</param>
        /// <returns>Retorna o resultado da operação</returns>
        public static string Inserir(Jogos jogos)
        {
            JogosDAL jdal = new JogosDAL();
            string messagem = jdal.Inserir(jogos);
            return messagem;
        }
        /// <summary>
        /// Busca e lista todos os jogos do banco de dados
        /// </summary>
        /// <returns>Retorna uma lista de jogos</returns>
        public static List<Jogos> ListarJogos()
        {
            JogosDAL jdal = new JogosDAL();
            return jdal.LerTodos();
        }
        /// <summary>
        /// Calcula o placar máximo,mínimo da temporada, além de calcular o máximo e o mínimo que o recorde foi quebrado
        /// </summary>
        /// <param name="jogos">Jogo a ser inserido</param>
        /// <returns>Retorna o Jogo com as propriedades preenchidas</returns>
        public static Jogos Calcular(Jogos jogos)
        {
            List<Jogos> jl = ListarJogos();
            jl.Add(jogos);
            int placarmaximo = 0;
            int placarminimo = 1000;
            int recordemaximo = 0;
            int recordeminimo = 1000;

            for (int i = 0; i < jl.Count; i++)
            {

                int placaratual = jl[i].Placar;
                if (placarmaximo < placaratual)
                {
                    placarmaximo = placaratual;
                    recordemaximo += 1;
                }
                if (placarminimo > placaratual)
                {
                    placarminimo = placaratual;
                }
                if (recordeminimo > recordemaximo)
                {
                    recordeminimo = recordemaximo;
                }
            }

            jogos.MinimoTemporada = placarminimo;
            jogos.MinimoTemporada = placarminimo;
            jogos.QuebraRecordeMinimo = recordeminimo;
            jogos.QuebraRecordeMaximo = recordemaximo;
            return jogos;
        }
    }
}
