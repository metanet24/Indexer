using IndexerException.Service;
using IndexerException.Service.Interrface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _service;

        public PersonController()
        {
            _service = new PersonService();
        }

        public void GetById()
        {
            try
            {
                Console.WriteLine("Add person Id:");
                int id = int.Parse(Console.ReadLine());
                var method = _service.GetById(id);
                Console.WriteLine(method.FullName + " " + method.Age);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
