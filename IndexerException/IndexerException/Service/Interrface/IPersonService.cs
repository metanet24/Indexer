using IndexerException.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Service.Interrface
{
    public interface IPersonService
    {
        Person GetById(int? id);
    }
}
