using IndexerException.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Data
{
    public class AppDbContext
    {
        public Person[] People()
        {
            return new Person[]
            {
                new Person() {Id=1,FullName="Metanet Abbasova",Age=22},
                new Person() {Id=2,FullName="Cavid Bashirov",Age=30},
                new Person() {Id=3,FullName="Naide Basharatova",Age=41}
            };
        }


    }
}
