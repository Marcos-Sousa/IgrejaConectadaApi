using Compartilhamento.Comando;
using System;

namespace Dominio.Comandos.ComandosEntrada.Cidade
{
    public class ComandoManipuladorAtualizarCidade : IComandoDeEntrada
    {
        public Guid Id_Estado { get; set; }
        public string Nome { get; set; }
    }
}
