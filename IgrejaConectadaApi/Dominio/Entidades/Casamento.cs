using Compartilhamento.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Casamento : Entidade
    {
        public Guid Id_Igreja { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataNascimentoNoiva { get; set; }
        public DateTime DataNascimentoNoivo { get; set; }
        public string NomeNoiva { get; set; }
        public string NomeNoivo { get; set; }
    }
}
