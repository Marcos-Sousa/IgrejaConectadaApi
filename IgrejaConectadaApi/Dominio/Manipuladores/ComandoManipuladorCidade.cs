using Compartilhamento.Comando;
using Dominio.Comandos.ComandosEntrada.Cidade;
using Dominio.Comandos.ComandosSaida;
using Dominio.Entidades;
using Dominio.Repositorios;
using Flunt.Notifications;
using System.Threading.Tasks;

namespace Dominio.Manipuladores
{
    public class ComandoManipuladorCidade : Notifiable, IComandoManipulador<ComandoManipuladorAdicionarCidade>,
        IComandoManipulador<ComandoManipuladorAtualizarCidade>
    {
        private readonly ICidadeRepositorio _cidadeRepositorio;

        public ComandoManipuladorCidade(ICidadeRepositorio cidadeRepositorio)
        {
            _cidadeRepositorio = cidadeRepositorio;
        }

        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAdicionarCidade Comando)
        {
            Cidade cidade = new Cidade(Comando.Id_Estado, Comando.Nome);

            if (cidade.Invalid)
            {
                return new Saida(cidade, false, "Erro ao realizar cadastro");
            }

            await Task.Factory.StartNew(() =>
            {
                _cidadeRepositorio.Cadastrar(cidade);
            });
            return new Saida(cidade, true, "Cadastro realizado com sucesso");
        }

        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAtualizarCidade Comando)
        {
            Cidade cidade = await _cidadeRepositorio.BuscarPorId(Comando.Id);

            if (cidade.Invalid)
            {
                return new Saida(cidade, false, "Erro ao atualizar cadastro");
            }

            await Task.Factory.StartNew(() =>
            {
                _cidadeRepositorio.Atualizar(cidade);
            });
            return new Saida(cidade, true, "Atualização realizado com sucesso");
        }
    }
}
