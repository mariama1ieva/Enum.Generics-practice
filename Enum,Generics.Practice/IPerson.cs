using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Generics.Practice
{
    internal interface IPerson<T> where T : class
    {
    }
}
