using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_8_ADVANCES_C__.NET
{
    internal interface IEnqueue<T>
    {
          T Enqueue(T item);
    }
}
