using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Generics.Practice
{
    internal class Repository<T> where T : BaseEntity
    {
        private T[] _datas;
        public Repository()
        {
            _datas = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = item;
        }

        public void GetAll()
        {
            foreach (T item in _datas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
