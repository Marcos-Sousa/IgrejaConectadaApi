using Compartilhamento.Comando;
using System;

namespace Dominio.Comandos.ComandosEntrada.Evento
{
    public class ComandoManipuladorAtualizarEvento : IComandoDeEntrada
    {
        public Guid Id { get; set; }
        public Guid Id_igreja { get; set; }
        public string Imagem { get; set; }
        public TimeSpan Horario_Inicio { get; set; }
        public TimeSpan Horario_Termino { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Termino { get; set; }
        public string Descricao { get; set; }
    }
}
