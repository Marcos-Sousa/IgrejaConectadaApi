using Compartilhamento.Comando;
using System;

namespace Dominio.Comandos.ComandosEntrada.Igreja
{
    public class ComandoManipuladorAtualizarIgreja: IComandoDeEntrada
    {
        public Guid Id { get; set; }
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
