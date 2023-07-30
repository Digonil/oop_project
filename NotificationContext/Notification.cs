using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.NotificationContext;

public sealed class Notification

    //sealed não permite extensão da classe

{
    public string Property { get; set; }
    public string Message { get; set; }

    public Notification()
    {

    }

    public Notification(string property, string message)
    {
        Property = property;
        Message = message;
    }
}
