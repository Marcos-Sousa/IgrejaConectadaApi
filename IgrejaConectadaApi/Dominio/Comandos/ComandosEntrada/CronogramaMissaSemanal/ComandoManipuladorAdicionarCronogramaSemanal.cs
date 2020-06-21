using Compartilhamento.Comando;
using System;

namespace Dominio.Comandos.ComandosEntrada
{
    public class ComandoManipuladorAdicionarCronogramaSemanal : IComandoDeEntrada
    {
        public Guid Id_Igreja { get; set; }
        public string MaterialApoio { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horario_Inicio { get; set; }
        public TimeSpan Horario_Termino { get; set; }
    }
}
