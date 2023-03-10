using System;

namespace Academia
{
    class Globais
    {
        public static string vesao = "1.0";

        public static bool isLogado = false;
        public static int nivel = 0;   //  0 = Não Logado  ||  1 = Básico  |  2 =  Gerente  |  3 = Master

        public const string Db_NomeBancoDeDados = "db_academia.db";
        public const string Db_NomeTabelaUsuarios = "tb_usuarios";
        public static string Db_CaminhoBancoDeDados = $@"{Environment.CurrentDirectory}\sql\{Db_NomeBancoDeDados}";

        #region Campos Banco de Dados
        public const string Db_IdUsuario = "N_ID";
        public const string Db_NomeUsuario = "T_NOME";
        public const string Db_Username = "T_USERNAME";
        public const string Db_SenhaUsuario = "T_SENHA";
        public const string Db_StatusUsuario = "T_STATUS";
        public const string Db_NivelUsuario = "N_NIVEL";
        #endregion Campos Banco de Dados

        public static DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}
