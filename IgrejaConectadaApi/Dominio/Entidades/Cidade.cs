using Compartilhamento.Entidade;
using System;

namespace Dominio.Entidades
{
    public  class Cidade : Entidade
    {
        public Cidade()
        {
                
        }
        public Cidade(Guid id_Estado, string nome)
        {
            Id_Estado = id_Estado;
            Nome = nome;
        }

        public void Atualizar(Guid id_Estado)
        {
            Id_Estado = id_Estado;
        }

        public Guid Id_Estado { get; private set; }
        public string Nome { get;private set; }
    }
}
