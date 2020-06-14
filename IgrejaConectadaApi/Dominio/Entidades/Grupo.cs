using Compartilhamento.Entidade;
using System;

namespace Dominio.Entidades
{
    public class Grupo: Entidade
    {
        public Grupo()
        {

        }
        public Grupo(Guid id_Igreja, string imagem, TimeSpan horario_Inicio, TimeSpan horario_Termino, string coordenador, string descricao)
        {
            Id_Igreja = id_Igreja;
            Imagem = imagem;
            Horario_Inicio = horario_Inicio;
            Horario_Termino = horario_Termino;
            Coordenador = coordenador;
            Descricao = descricao;
        }

        public Guid Id_Igreja { get; private set; }
        public string Imagem { get; private set; }
        public TimeSpan Horario_Inicio { get; private set; }
        public TimeSpan Horario_Termino { get; private set; }
        public string Coordenador { get; private set; }
        public string Descricao { get; private set; }

    }
}
