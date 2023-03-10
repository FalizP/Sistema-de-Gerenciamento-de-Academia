using System;

namespace Academia
{ 
    internal class Usuario
    {
        public string id;
        public string nome;
        public string username;
        public string senha;
        public string status;
        public Int32 nivel;

        public Usuario(string id = "", string nome = "", string username = "", string senha = "", string status = "", Int32 nivel = 0)
        {
            this.id = id;
            this.nome = nome;
            this.username = username;
            this.senha = senha;
            this.status = status;
            this.nivel = nivel;
        }
    }
}
