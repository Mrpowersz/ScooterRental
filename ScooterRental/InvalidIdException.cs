using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException() : base("provided id is not valid")
        {
            
        }
    }
}
