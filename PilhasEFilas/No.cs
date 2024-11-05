using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhasEFilas
{
  public class No<T>
  {
    public T? Valor { get; set; }
    public No<T>? Proximo { get; set; }
  }
}
