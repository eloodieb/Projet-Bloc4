using System;

namespace Projet_bloc4.Exceptions
{
    class AddExistingSiteException : Exception
    {
        public AddExistingSiteException(string message) : base(message)
        {
        }
    }
}
