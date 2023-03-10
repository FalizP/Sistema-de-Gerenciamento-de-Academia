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
            conexao = new SQLiteConnection($@"Data Source = {Globais.Db_CaminhoBancoDeDados}");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {Globais.Db_NomeTabelaUsuarios}";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable Consulta(string sql)
        {

            DataTable dataTable = new DataTable();
            try
            {
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        #region Form F_NovoUsuario
        public static void NovoUsuario(Usuario usuario)
        {
            if (ExisteUsuario(usuario))
            {
                MessageBox.Show("Username já existe");
                return;
            }

            try
            {
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = $@"
                    INSERT INTO {Globais.Db_NomeTabelaUsuarios} (
                        {Globais.Db_NomeUsuario},
                        {Globais.Db_Username},
                        {Globais.Db_SenhaUsuario},
                        {Globais.Db_StatusUsuario},
                        {Globais.Db_NivelUsuario}
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
                conexao.Close();
            }
        }
        #endregion Form F_NovoUsuario


        #region Form F_GestaoUsuarios
        public static DataTable ObterUsuarioIdNome()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = $"SELECT {Globais.Db_IdUsuario} as 'Id', {Globais.Db_NomeUsuario} as 'Nome' FROM {Globais.Db_NomeTabelaUsuarios}";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {Globais.Db_NomeTabelaUsuarios} WHERE {Globais.Db_IdUsuario} = {id}";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void AtualizarUsuario(Usuario usuario)
        {
            try
            {
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = $@"
                    UPDATE {Globais.Db_NomeTabelaUsuarios}
                    SET {Globais.Db_NomeUsuario} = @nome,
                        {Globais.Db_Username} = @username,
                        {Globais.Db_SenhaUsuario} = @senha,
                        {Globais.Db_StatusUsuario} = @status,
                        {Globais.Db_NivelUsuario} = @nivel
                    WHERE {Globais.Db_IdUsuario} = @id";

                cmd.Parameters.AddWithValue("@id", usuario.id);
                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@status", usuario.status);
                cmd.Parameters.AddWithValue("@nivel", usuario.nivel);

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void DeletarUsuario(string idUsuario)
        {
            try
            {
                string sql = $@"DELETE FROM {Globais.Db_NomeTabelaUsuarios} WHERE {Globais.Db_IdUsuario} = {idUsuario}";

                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = sql;

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }

        }
        #endregion Form F_GestaoUsuarios


        #region Rotinas Gerais
        public static bool ExisteUsuario(Usuario usuario)
        {
            try
            {
                string sql = $"SELECT {Globais.Db_Username} FROM {Globais.Db_NomeTabelaUsuarios} WHERE {Globais.Db_Username} = '{usuario.username}'";

                SQLiteDataAdapter dataAdapter = null;
                SQLiteConnection conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = sql;

                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexao);
                DataTable dataTable = new DataTable();

                Console.WriteLine(dataAdapter);
                dataAdapter.Fill(dataTable);

                return dataTable.Rows.Count > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }

        }
        #endregion Rotinas Gerais

    } // .banco
} // namespace Banco
