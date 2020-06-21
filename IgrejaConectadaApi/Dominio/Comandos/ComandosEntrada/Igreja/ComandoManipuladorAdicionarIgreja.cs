using Compartilhamento.Comando;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Comandos.ComandosEntrada.Igreja
{
    public class ComandoManipuladorAdicionarIgreja: IComandoDeEntrada
    {
        public Guid Id_Cidade { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
