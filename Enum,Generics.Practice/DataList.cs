using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Enum_Generics.Practice
{
    internal class DataList<T> where T : class
    {
        private T[] _datas;
        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
                _datas[_datas.Length-1] = item;
        }

        //public void GetAll()
        //{
        //    foreach (T item in _datas)
        //    {
        //        Console.WriteLine(item);
        //    }

        public T[] GetAll()
        {
            return _datas;
        }
    }
}

