using Compartilhamento.Entidade;
using System;

namespace Dominio.Entidades
{
    public class CronogramaMissaSemanal : Entidade
    {
        public CronogramaMissaSemanal()
        {

        }
        public CronogramaMissaSemanal(Guid id_Igreja, string materialApoio, DateTime data, TimeSpan horario_Inicio, TimeSpan horario_Termino)
        {
            Id_Igreja = id_Igreja;
            MaterialApoio = materialApoio;
            Data = data;
            Horario_Inicio = horario_Inicio;
            Horario_Termino = horario_Termino;
        }

        public void Atualizar(string materialApoio, DateTime data, TimeSpan horario_Inicio, TimeSpan horario_Termino)
        {
            MaterialApoio = materialApoio;
            Data = data;
            Horario_Inicio = horario_Inicio;
            Horario_Termino = horario_Termino;
        }

        public Guid Id_Igreja { get; private set; }
        public string MaterialApoio { get; private set; }
        public DateTime Data { get; private set; }
        public TimeSpan Horario_Inicio { get; private set; }
        public TimeSpan Horario_Termino { get; private set; }
    }
}
