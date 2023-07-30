using OrientacaoObjetos.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.SharedContext;

public abstract class Base : Notifiable
{
    public Guid Id { get; set; }

    public Base()
    {
        //Concentrado a geração de ID no construtor (Gerado um hashcode)
        Id = Guid.NewGuid();//Single point of failure - SPOT

    }
}
