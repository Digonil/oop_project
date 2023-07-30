using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.ContentContext;

public abstract class Content : Base
{
    //Classe abstrata, pois não faz sentido para o modelo de negócio a sua instanciação.

    public string Title { get; set; }
    public string Url { get; set; }

    public Content(string title, string url)
    {
       
        Title= title;
        Url= url;
    }
}
