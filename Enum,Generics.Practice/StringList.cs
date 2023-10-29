using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Generics.Practice
{
    internal class StringList
    {
        private string[] _stringlist;
        public StringList()
        {
            _stringlist = new string[0];
        }

        public void Add(string item)
        {
            Array.Resize(ref _stringlist, _stringlist.Length+1);
            _stringlist[_stringlist.Length - 1] = item;
        }

        public void GettAll()
        {
            foreach(string item in _stringlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
