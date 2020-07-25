using Compartilhamento.Comando;
using Dominio.Comandos.ComandosEntrada.Igreja;
using Dominio.Comandos.ComandosSaida;
using Dominio.Entidades;
using Dominio.Repositorios;
using Flunt.Notifications;
using System.Threading.Tasks;

namespace Dominio.Manipuladores
{
    public class ComandoManipuladorIgreja : Notifiable, IComandoManipulador<ComandoManipuladorAdicionarIgreja>, IComandoManipulador<ComandoManipuladorAtualizarIgreja>
    {
        private readonly IIgrejaRepositorio _igrejaRepositorio;

        public ComandoManipuladorIgreja(IIgrejaRepositorio igrejaRepositorio)
        {
            _igrejaRepositorio = igrejaRepositorio;
        }

        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAdicionarIgreja Comando)
        {
            Igreja igreja = new Igreja(Comando.Id_Cidade, Comando.Nome, Comando.Imagem, Comando.Rua, Comando.CEP, Comando.Bairro, Comando.Numero, Comando.Complemento);
            if (igreja.Invalid)
            {
                return new Saida(igreja, false, "Erro ao realizar cadastro");
            }

            await Task.Factory.StartNew(() =>
            {
                _igrejaRepositorio.Cadastrar(igreja);
            });
            return new Saida(igreja, true, "Cadastro realizado com sucesso");
        }

        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAtualizarIgreja Comando)
        {
            Igreja igreja = await _igrejaRepositorio.BuscarPorId(Comando.Id);

            igreja.Atualizar(Comando.Nome, Comando.Imagem, Comando.Rua, Comando.CEP, Comando.Bairro, Comando.Numero, Comando.Complemento);

            if (igreja.Invalid)
            {
                return new Saida(igreja, false, "Erro ao realizar atualização");
            }

            await Task.Factory.StartNew(() =>
            {
                _igrejaRepositorio.Atualizar(igreja);
            });
            return new Saida(igreja, true, "Atualização realizado com sucesso");
        }
    }
}
