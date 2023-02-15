using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection($@"Data Source = {Globais.caminhoBancoDeDados}");
            conexao.Open();

            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM {Globais.nomeTabelaUsuarios}";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }

        public static DataTable Consulta(string sql)
        {

            DataTable dataTable = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }

        #region Form F_NovoUsuario
        public static void NovoUsuario(Usuario usuario)
        {
            if (IsExisteUsuario(usuario))
            {
                MessageBox.Show("Username já existe");
                return;
            }

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = $@"
                    INSERT INTO {Globais.nomeTabelaUsuarios} (
                        {Globais.Db_Nome}, {Globais.Db_Username}, {Globais.Db_Senha}, {Globais.Db_status},{Globais.Db_nivel}
                    )
                    VALUES (
                        @nome, @username, @senha, @status, @nivel
                    )";
                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@status", usuario.status);
                cmd.Parameters.AddWithValue("@nivel", usuario.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário Cadastrado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }
        #endregion Form F_NovoUsuario


        #region Rotinas Gerais
        public static bool IsExisteUsuario(Usuario usuario)
        {
            string sql = $"SELECT {Globais.Db_Username} FROM {Globais.nomeTabelaUsuarios} WHERE {Globais.Db_Username} = '{usuario.username}'";

            SQLiteDataAdapter dataAdapter = null;

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = sql;

            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            DataTable dataTable = new DataTable();

            Console.WriteLine(dataAdapter);
            dataAdapter.Fill(dataTable);

            return dataTable.Rows.Count > 0;
        }
        #endregion Rotinas Gerais

    } // .banco
} // namespace Banco
