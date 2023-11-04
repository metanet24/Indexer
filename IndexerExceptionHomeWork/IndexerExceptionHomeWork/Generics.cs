using IndexerExceptionHomeWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExceptionHomeWork
{
    public class Generics<T> where T :BaseEntitiy
    {
        private  T[] _list;

        public Generics()
        {
            _list = new T[0];
        }

        public T[] Add(T item) 
        {
            Array.Resize(ref _list, _list.Length+1);

            _list[_list.Length-1] = item;

            return _list;

        }

        public T[] ShowAll()
        {
            return _list;
        }

        public T GetById(int id)=> _list.FirstOrDefault(m => m.Id == id);

       public T[] Delete(int id)
        {
            return _list.Where(m=>m.Id != id).ToArray();
        }

      
        
    }
}
