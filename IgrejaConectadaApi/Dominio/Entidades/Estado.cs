using Compartilhamento.Entidade;

namespace Dominio.Entidades
{
    public class Estado : Entidade
    {
        public Estado()
        {

        }
        public Estado(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
