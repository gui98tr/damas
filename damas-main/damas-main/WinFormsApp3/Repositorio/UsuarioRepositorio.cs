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
                string query = "INSERT INTO usuario (username, senha) VALUES (@Username, @Senha)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", usuario.nome);
                    command.Parameters.AddWithValue("@Senha", usuario.senha);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }

        public Usuario ObterUsuario(string nome, string senha)
        {
            Usuario usuario = null;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT username, senha FROM usuario WHERE username = @Nome AND senha = @Senha";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                nome = reader.GetString("username"),
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
