using System;

namespace Projet_bloc4.Exceptions
{
    class UpdateInexistingSite : Exception
    {
        public UpdateInexistingSite(string message) : base(message)
        {
        }
    }
}
