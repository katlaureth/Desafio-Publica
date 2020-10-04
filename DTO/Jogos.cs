namespace DTO
{
    /// <summary>
    /// Representação da entidade Jogos do banco de dados.
    /// </summary>
    public class Jogos
    {
        /// <summary>
        /// Chave de identificação
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Jogo de basquete
        /// </summary>
        public int Jogo { get; set; }
        /// <summary>
        /// Pontos da partida do jogo
        /// </summary>
        public int Placar { get; set; }
        /// <summary>
        /// Recorde atual de pontuação
        /// </summary>
        public int Recorde { get; set; }
        /// <summary>
        ///Valor do placar máximo da temporada
        /// </summary>
        public int MaximoTemporada { get; set; }
        /// <summary>
        /// Valor do plcar minimo da temporada
        /// </summary>
        public int MinimoTemporada { get; set; }
        /// <summary>
        /// Valor do máximo que foi quebrado  na temporada
        /// </summary>
        public int QuebraRecordeMaximo { get; set; }
        /// <summary>
        /// Valor do minimo que foi quebrado na temporada
        /// </summary>
        public int QuebraRecordeMinimo { get; set; }
    }
}
