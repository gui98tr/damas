using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class UsuarioRepositorio
    {
        private readonly string _connectionString;

        public UsuarioRepositorio(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int InserirUsuario(Usuario usuario)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO usuario (nome, email, senha) VALUES (@Nome, @Email, @Senha)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", usuario.nome);
                    command.Parameters.AddWithValue("@Email", usuario.email);
                    command.Parameters.AddWithValue("@Senha", usuario.senha);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }

        public Usuario ObterUsuario(string nome, string email, string senha)
        {
            Usuario usuario = null;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT nome, email, senha FROM usuario WHERE nome = @Nome AND email = @Email AND senha = @Senha";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            usuario = new Usuario
                            {
                                nome = reader.GetString("nome"),
                                email = reader.GetString("email"),
                                senha = reader.GetString("senha")
                            };
                        }
                    }
                }
            }
            return usuario;
        }
    }
}
