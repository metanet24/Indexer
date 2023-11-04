using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndexerHomeWork
{
    public class PersonList
    {

        public Person  GetById(int id)
        {
            DataList<Person> person = new();

            Person[] res =person.GetAll();

            Person result=res.FirstOrDefault(x=>x.Id==id);

            return result;
        }

        public Person Delete(int id)
        {
            DataList<Person> person = new();

            
            Person[] res=person.GetAll();

            Person[] per = new Person[5];

            foreach(Person p in res)
            {
                if (p.Id == id)
                {
                    continue;
                }
                
                  
               
            }
        }
   

    }
}
