using System;

namespace Projet_bloc4.Exceptions
{
    class UpdateInexistingEmployee : Exception
    {
        public UpdateInexistingEmployee(string message) : base(message)
        {
        }
    }
}
