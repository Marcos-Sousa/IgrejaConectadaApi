using Compartilhamento.Comando;
using Dominio.Comandos.ComandosEntrada;
using Dominio.Comandos.ComandosSaida;
using Dominio.Entidades;
using Dominio.Repositorios;
using Flunt.Notifications;
using System;
using System.Threading.Tasks;

namespace Dominio.Manipuladores
{
    public class ComandoManipuladorGrupo : Notifiable, IComandoManipulador<ComandoManipuladorAdicionarGrupo>
    {
        private readonly IGrupoRepositorio _grupoRepositorio;

        public ComandoManipuladorGrupo(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }
        public async Task<IComandoDeSaida> Manipulador(ComandoManipuladorAdicionarGrupo Comando)
        {
            Grupo grupo = new Grupo(Comando.Id_Igreja, Comando.Imagem, Comando.Horario_Inicio, Comando.Horario_Termino, Comando.Coordenador, Comando.Descricao);

            if (grupo.Invalid)
            {
                return new Saida(grupo, false, "Erro ao realizar cadastro");
            }

            await Task.Factory.StartNew(() =>
            {
                _grupoRepositorio.Cadastrar(grupo);
            });
            return new Saida(grupo, true, "Cadastro realizado com sucesso");
        }
    }
}
