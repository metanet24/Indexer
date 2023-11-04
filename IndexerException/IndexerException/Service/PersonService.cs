using IndexerException.Data;
using IndexerException.Models;
using IndexerException.Service.Interrface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Service
{
    public class PersonService : IPersonService
    {

        private AppDbContext _context;
        public PersonService()
        {
            _context = new AppDbContext();
        }
        public Person GetById(int? id)
        {
            if (id == null) {  throw new ArgumentNullException(); }

         var existData= _context.People().FirstOrDefault(m => m.Id == id);

            if (existData == null)
            {
                throw new NullReferenceException("Data not found");
            }
            else
            {
                return existData;
            }
        }
    }
}
    


