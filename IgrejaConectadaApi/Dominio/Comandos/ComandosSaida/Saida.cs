using Compartilhamento.Comando;

namespace Dominio.Comandos.ComandosSaida
{
    public class Saida : IComandoDeSaida
    {
        public Saida()
        {

        }
        public Saida(object data, bool sucesso, string mensagem)
        {
            Data = data;
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public object Data { get; set; }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
