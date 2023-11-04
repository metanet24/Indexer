using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExceptionHomeWork.Model
{
    public class User:BaseEntitiy
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public string Mail { get; set;}
    }
}
