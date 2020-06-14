using Compartilhamento.Entidade;
using System;

namespace Dominio.Entidades
{
    public class Igreja: Entidade
    {
        public Igreja()
        {

        }
        public Igreja(Guid id_Cidade, string nome, string imagem, string rua, string cEP, string bairro, int numero, string complemento)
        {
            Id_Cidade = id_Cidade;
            Nome = nome;
            Imagem = imagem;
            Rua = rua;
            CEP = cEP;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
        }

        public void Atualuzar(string nome, string imagem, string rua, string cEP, string bairro, int numero, string complemento)
        {
            Nome = nome;
            Imagem = imagem;
            Rua = rua;
            CEP = cEP;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
        }

        public Guid Id_Cidade { get; private set; }
        public string Nome { get; private set; }
        public string Imagem { get; private set; }
        public string Rua { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
    }
}
