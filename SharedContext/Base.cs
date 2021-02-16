using System;
using ProjBalta.NotificationContext;

namespace ProjBalta.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }
    }    
}