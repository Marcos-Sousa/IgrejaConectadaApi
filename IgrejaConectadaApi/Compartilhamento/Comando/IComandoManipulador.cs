using System.Threading.Tasks;

namespace Compartilhamento.Comando
{
    public interface IComandoManipulador<T> where T: IComandoDeEntrada
    {
        Task<IComandoDeSaida> Manipulador(T Comando);
    }
}
