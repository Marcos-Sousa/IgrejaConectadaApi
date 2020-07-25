using Compartilhamento.Comando;
using Dominio.Comandos.ComandosEntrada;
using Dominio.Comandos.ComandosEntrada.CronogramaMissaSemanal;
using Dominio.Comandos.ComandosSaida;
using Dominio.Entidades;
using Dominio.Repositorios;
using Flunt.Notifications;
using System.Threading.Tasks;

namespace Dominio.Manipuladores
{
    public class ComandoManipuladorCronogramaMissaSemanal : Notifiable, IComandoManipulador<ComandoManipuladorAdicionarCronogramaSemanal>,
        IComandoManipulador<ComandoManipuladorAtualizarCronogramaMissaSemanal>
    {
        private readonly ICronogramaMissaSemanalRepositorio _cronogramaMissaSemanalRepositorio;

        public ComandoManipuladorCronogramaMissaSemanal(ICronogramaMissaSemanalRepositorio cronogramaMissaSemanalRepositorio)
        {
            _cronogramaMissaSemanalRepositorio = cronogramaMissaSemanalRepositorio;
        }

        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAdicionarCronogramaSemanal Comando)
        {
            CronogramaMissaSemanal cronogramaMissaSemanal = new CronogramaMissaSemanal(Comando.Id_Igreja, Comando.MaterialApoio, Comando.Data, Comando.Horario_Inicio, Comando.Horario_Termino);
            if (cronogramaMissaSemanal.Invalid)
            {
                return new Saida(cronogramaMissaSemanal, false, "Erro ao realizar cadastro");
            }
            await Task.Factory.StartNew(() =>
            {
                _cronogramaMissaSemanalRepositorio.Cadastrar(cronogramaMissaSemanal);
            });
            return new Saida(cronogramaMissaSemanal, true, "Cadastro realizado com sucesso");
        }

        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAtualizarCronogramaMissaSemanal Comando)
        {
            CronogramaMissaSemanal cronogramaMissaSemanal = await _cronogramaMissaSemanalRepositorio.BuscarPorId(Comando.Id);

            if (cronogramaMissaSemanal.Invalid)
            {
                return new Saida(cronogramaMissaSemanal, false, "Erro ao realizar atualização");
            }
            await Task.Factory.StartNew(() =>
            {
                _cronogramaMissaSemanalRepositorio.Atualizar(cronogramaMissaSemanal);
            });
            return new Saida(cronogramaMissaSemanal, true, "Atualização realizado com sucesso");
        }
    }
}
