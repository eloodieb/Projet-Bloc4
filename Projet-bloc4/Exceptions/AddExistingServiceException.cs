using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.Exceptions
{
    class AddExistingServiceException : Exception
    {
        public AddExistingServiceException(string message) : base(message)
        {
        }
    }
}
