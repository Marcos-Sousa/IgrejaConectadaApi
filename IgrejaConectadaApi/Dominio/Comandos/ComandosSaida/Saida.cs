using Compartilhamento.Comando;

namespace Dominio.Comandos.ComandosSaida
{
    public class Saida : IComandoDeSaida
    {
        public object Data { get; set; }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
