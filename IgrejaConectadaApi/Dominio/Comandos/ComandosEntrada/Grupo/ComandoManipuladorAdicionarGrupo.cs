﻿using Compartilhamento.Comando;
using System;

namespace Dominio.Comandos.ComandosEntrada
{
    public class ComandoManipuladorAdicionarGrupo : IComandoDeEntrada
    {
        public Guid Id_Igreja { get; set; }
        public string Imagem { get; set; }
        public TimeSpan Horario_Inicio { get; set; }
        public TimeSpan Horario_Termino { get; set; }
        public string Coordenador { get; set; }
        public string Descricao { get; set; }
    }
}
