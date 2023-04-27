using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBreakfastLibrary.Services.Exceptions
{
    public class IntegrityExceptions : ApplicationException
    {
        public IntegrityExceptions(string message) : base(message)
        {
        }
    }
}
