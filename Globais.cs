using System;

namespace Academia
{
    class Globais
    {
        public static string vesao = "1.0";

        public static bool isLogado = false;
        public static int nivel = 0;   //  0 = Não Logado  ||  1 = Básico  |  2 =  Gerente  |  3 = Master

        public static string nomeBancoDeDados = "bd_academia.db";
        public static string caminhoBancoDeDados = $@"{Environment.CurrentDirectory}\sql\{nomeBancoDeDados}";

        private static string db_Username = "T_USERNAME";
        public static string Db_Username { get => db_Username; set => db_Username = value; }
    }
}
