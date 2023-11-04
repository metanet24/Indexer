using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndexerHomeWork
{
    internal class DataList <T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }


        public void Add(T value)
        {
            Array.Resize(ref _datas, _datas.Length+1);
            _datas[_datas.Length-1] = value;
        }

        public T[] GetAll()
        {
            return _datas;
        }

        public T Show(T value)
        {
            return value;
        }
        
    }
}
