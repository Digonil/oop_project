using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.ContentContext;

public class Lecture : Base
{
    public int Ordem { get; set; }
    public string Title { get; set; }
    
}
