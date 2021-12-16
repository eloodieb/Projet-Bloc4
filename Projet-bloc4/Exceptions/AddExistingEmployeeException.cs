using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_bloc4.Exceptions
{
    class AddExistingEmployeeException : Exception
    {
        public AddExistingEmployeeException(string message) : base(message)
        {
        }
    }
}
