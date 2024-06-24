using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Project_Clube_Futebol.DataAccess;

namespace Project_Clube_Futebol.Services
{
    public class AtletaDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<Atleta> GetAtletas()
        {
            List<Atleta> atletas = new List<Atleta>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tb_atletas";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Atleta atleta = new Atleta
                        {
                            Id = (int)reader["id"],
                            Nome = reader["nome"].ToString(),
                            Apelido = reader["apelido"].ToString(),
                            Data_Nascimento = (DateTime)reader["data_nascimento"],
                            Altura = (double)reader["altura"],
                            Peso = (double)reader["peso"],
                            Posicao = reader["posicao"].ToString(),
                            Numero_Camisa = (int)reader["numero_camisa"],
                        };

                        atletas.Add(atleta);
                    }
                }
            }
            return atletas;
        }

        public void AddAtleta(Atleta atleta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tb_atletas (nome, apelido, data_nascimento, altura, peso, posicao, numero_camisa) VALUES (@nome, @apelido, @data_nascimento, @altura, @peso, @posicao, @numero_camisa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", atleta.Nome);
                cmd.Parameters.AddWithValue("@apelido", atleta.Apelido);
                cmd.Parameters.AddWithValue("@data_nascimento", atleta.Data_Nascimento);
                cmd.Parameters.AddWithValue("@altura", atleta.Altura);
                cmd.Parameters.AddWithValue("@peso", atleta.Peso);
                cmd.Parameters.AddWithValue("@posicao", atleta.Posicao);
                cmd.Parameters.AddWithValue("@numero_camisa", atleta.Numero_Camisa);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAtleta(Atleta atleta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tb_atletas SET nome = @nome, apelido = @apelido, data_nascimento = @data_nascimento, altura = @altura, Peso = @peso, posicao = @posicao, numero_camisa = @numero_camisa WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", atleta.Nome);
                cmd.Parameters.AddWithValue("@apelido", atleta.Apelido);
                cmd.Parameters.AddWithValue("@data_nascimento", atleta.Data_Nascimento);
                cmd.Parameters.AddWithValue("@altura", atleta.Altura);
                cmd.Parameters.AddWithValue("@peso", atleta.Peso);
                cmd.Parameters.AddWithValue("@posicao", atleta.Posicao);
                cmd.Parameters.AddWithValue("@numero_camisa", atleta.Numero_Camisa);
                cmd.Parameters.AddWithValue("@id", atleta.Id);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteAtleta(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tb_atletas WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}