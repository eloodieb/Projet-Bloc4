using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.Exceptions
{
    class UpdateInexistingService : Exception
    {
        public UpdateInexistingService(string message) : base(message)
        {
        }
    }
}
