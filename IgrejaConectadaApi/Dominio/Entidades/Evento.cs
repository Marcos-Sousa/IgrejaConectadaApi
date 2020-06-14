using Compartilhamento.Entidade;
using System;

namespace Dominio.Entidades
{
    public class Evento : Entidade
    {
        public Evento()
        {

        }
        public Evento(Guid id_igreja, string imagem, TimeSpan horario_Inicio, TimeSpan horario_Termino, DateTime data_Inicio, DateTime data_Termino, string descricao)
        {
            Id_igreja = id_igreja;
            Imagem = imagem;
            Horario_Inicio = horario_Inicio;
            Horario_Termino = horario_Termino;
            Data_Inicio = data_Inicio;
            Data_Termino = data_Termino;
            Descricao = descricao;
        }
        public void Atualizar(string imagem, TimeSpan horario_Inicio, TimeSpan horario_Termino, DateTime data_Inicio, DateTime data_Termino, string descricao)
        {
            Imagem = imagem;
            Horario_Inicio = horario_Inicio;
            Horario_Termino = horario_Termino;
            Data_Inicio = data_Inicio;
            Data_Termino = data_Termino;
            Descricao = descricao;
        }

        public Guid Id_igreja { get;private set; }
        public string Imagem { get; private set; }
        public TimeSpan Horario_Inicio { get; private set; }
        public TimeSpan Horario_Termino { get; private set; }
        public DateTime Data_Inicio { get; private set; }
        public DateTime Data_Termino { get; private set; }
        public string Descricao { get; private set; }
    }
}
