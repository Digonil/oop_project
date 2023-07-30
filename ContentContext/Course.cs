using OrientacaoObjetos.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContentContext;

public class Course : Content
{
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }


    public Course(string title, string url)
        : base(title, url)
    {
        //Sempre fazer a inicialização da lista (composição de classes) no construtor.
        Modules= new List<Module>();
    }
}


