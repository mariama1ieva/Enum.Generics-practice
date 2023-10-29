using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Generics.Practice
{
    internal class Person:BaseEntity
    {
       
        public string Name { get; set; }
        public string SurName { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name},{SurName}";
        //}
    }
}
