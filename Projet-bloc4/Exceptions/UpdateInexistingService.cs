using System;

namespace Projet_bloc4.Exceptions
{
    class UpdateInexistingService : Exception
    {
        public UpdateInexistingService(string message) : base(message)
        {
        }
    }
}
