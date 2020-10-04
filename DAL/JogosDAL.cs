using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Classe que acessa o banco de dados
    /// </summary>
    class JogosDAL
    {
        /// <summary>
        /// Insere o jogo no banco de dados
        /// </summary>
        /// <param name="jogos">Jogo a ser inserido</param>
        /// <returns>Retorna o resultado da operação</returns>
        public string Inserir(Jogos jogos)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                CommandText =
                "INSERT INTO Jogos (Jogo,Placar,Recorde,MaximoTemporada,MinimoTemporada,QuebraRecordeMaximo,QuebraRecordeMinimo)  VALUES (@Jogo,@Placar,@Recorde,@MaximoTemporada,@MinimoTemporada,@QuebraRecordeMaximo,@QuebraRecordeMinimo)"
            };
            command.Parameters.AddWithValue("@Jogo", jogos.Jogo);
            command.Parameters.AddWithValue("@Placar", jogos.Placar);
            command.Parameters.AddWithValue("@Recorde", jogos.Recorde);
            command.Parameters.AddWithValue("@MaximoTemporada", jogos.MaximoTemporada);
            command.Parameters.AddWithValue("@MinimoTemporada", jogos.MinimoTemporada);
            command.Parameters.AddWithValue("@QuebraRecordeMaximo", jogos.QuebraRecordeMaximo);
            command.Parameters.AddWithValue("@QuebraRecordeMinimo", jogos.QuebraRecordeMinimo);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Busca e lista todos os jogos do banco de dados
        /// </summary>
        /// <returns>Retorna uma lista de jogos</returns>
        public List<Jogos> LerTodos()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                CommandText = "SELECT * FROM Jogos"
            };
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Jogos> jogos = new List<Jogos>();
                while (reader.Read())
                {
                    jogos.Add(new Jogos
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Placar = Convert.ToInt32(reader["Placar"]),
                        Jogo = Convert.ToInt32(reader["Jogo"]),
                        Recorde = Convert.ToInt32(reader["Recorde"]),
                        MaximoTemporada = Convert.ToInt32(reader["MaximoTemporada"]),
                        MinimoTemporada = Convert.ToInt32(reader["MinimoTemporada"]),
                        QuebraRecordeMaximo = Convert.ToInt32(reader["QuebraRecordeMaximo"]),
                        QuebraRecordeMinimo = Convert.ToInt32(reader["QuebraRecordeMinimo"])
                    });
                }
                return jogos;
            }
            catch (Exception)
            {
                throw new Exception("Erro no Banco de Dados, contate o administrador.");
            }
            finally
            {

                conn.Dispose();
            }
        }
    }
}