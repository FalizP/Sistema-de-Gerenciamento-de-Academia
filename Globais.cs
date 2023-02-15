using System;

namespace Academia
{
    class Globais
    {
        public static string vesao = "1.0";

        public static bool isLogado = false;
        public static int nivel = 0;   //  0 = Não Logado  ||  1 = Básico  |  2 =  Gerente  |  3 = Master

        public static string nomeBancoDeDados = "db_academia.db";
        public static string nomeTabelaUsuarios = "tb_usuarios";
        public static string caminhoBancoDeDados = $@"{Environment.CurrentDirectory}\sql\{nomeBancoDeDados}";

        #region Campos Banco de Dados
        private static string db_nome = "T_NOME";
        public static string Db_Nome { get => db_nome; set => db_nome = value; }

        private static string db_username = "T_USERNAME";
        public static string Db_Username { get => db_username; set => db_username = value; }

        private static string db_senha = "T_SENHA";
        public static string Db_Senha { get => db_senha; set => db_senha = value; }

        private static string db_status = "T_STATUS";
        public static string Db_status { get => db_status; set => db_status = value; }

        private static string db_nivel = "N_NIVEL";
        public static string Db_nivel { get => db_nivel; set => db_nivel = value; }
        #endregion Campos Banco de Dados
    }
}
