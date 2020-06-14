using Flunt.Notifications;
using System;

namespace Compartilhamento.Entidade
{
    public abstract class Entidade : Notifiable
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
