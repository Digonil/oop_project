using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContentContext;

public class Career : Content
{
    public int Courses { get; set; }

    public IList<CareerItem> Items { get; set; }
    
    //Parametro comum mas com regra de negócio aplicada no get
    //Aplicado Expression Body
    public int TotalCourses => Items.Count;
    /*
     * O mesmo que a expressão acima
    {
        get { return Items.Count; }
    }
    */

    public Career(string title, string url)
        : base(title, url)
    {
        Items= new List<CareerItem>();
    }

}
