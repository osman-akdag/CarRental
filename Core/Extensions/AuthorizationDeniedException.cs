using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public class AuthorizationDeniedException:Exception
    {    
        public AuthorizationDeniedException(string message) 
            : base(message) { }
    }
}
