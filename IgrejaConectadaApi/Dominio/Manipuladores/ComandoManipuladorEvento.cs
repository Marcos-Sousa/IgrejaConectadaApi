using Compartilhamento.Comando;
using Dominio.Comandos.ComandosEntrada.Evento;
using Dominio.Comandos.ComandosSaida;
using Dominio.Entidades;
using Dominio.Repositorios;
using Flunt.Notifications;
using System;
using System.Threading.Tasks;

namespace Dominio.Manipuladores
{
    public class ComandoManipuladorEvento : Notifiable, IComandoManipulador<ComandoManipuladorAdicionarEvento>
    {
        private readonly IEventoRepositorio _eventoRepositorio;

        public ComandoManipuladorEvento(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }
        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAdicionarEvento Comando)
        {
            Evento evento = new Evento(Comando.Id_igreja, Comando.Imagem, Comando.Horario_Inicio, Comando.Horario_Termino, Comando.Data_Inicio, Comando.Data_Termino, Comando.Descricao);
            if (evento.Invalid)
            {
                return new Saida(evento, false, "Erro ao realizar cadastro");
            }

            await Task.Factory.StartNew(() =>
            {
                _eventoRepositorio.Cadastrar(evento);
            });
            return new Saida(evento, true, "Cadastro realizado com sucesso");
        }
    }
}
