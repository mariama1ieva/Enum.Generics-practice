using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Generics.Practice
{
    internal class IntList
    {
        private int[] _ints;
        public IntList()
        {
            _ints = new int[0];
        }

        public void Add(int item)
        {
            Array.Resize(ref _ints, _ints.Length+1);
            _ints[_ints.Length-1] = item;
        }

        public void GetAll()
        {
            foreach (int item in _ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
