using System;

namespace Projet_bloc4.Exceptions
{
    class AddExistingEmployeeException : Exception
    {
        public AddExistingEmployeeException(string message) : base(message)
        {
        }
    }
}
