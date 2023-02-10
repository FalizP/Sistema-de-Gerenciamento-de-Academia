using System;
using System.Data;
using System.Data.SQLite;

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
                    string nomeTabela = "tb_usuarios";
                    cmd.CommandText = $"SELECT * FROM {nomeTabela}";
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

        }
        #endregion Form F_NovoUsuario




        #region Rotinas Gerais
        public static bool existeUsuario(Usuario usuario)
        {
            bool isUsuarioExistente;
            string sql = $"SELECT {Globais.Db_Username} FROM {Globais.caminhoBancoDeDados} ";


            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
            DataTable dataTable = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = sql;

            return isUsuarioExistente;
        }
        #endregion Rotinas Gerais





    } // .banco
} // namespace Banco
