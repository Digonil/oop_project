using OrientacaoObjetos.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.SubscriptionContext;

public class User : Base
{
    public string UserName  { get; set; }
    public string Password { get; set; }    
}
