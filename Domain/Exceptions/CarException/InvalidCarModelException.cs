using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.CarException
{
    public class InvalidCarModelException: Exception
    {
        public InvalidCarModelException() { }
        public InvalidCarModelException(string message) : base(message) { }
    }
}
