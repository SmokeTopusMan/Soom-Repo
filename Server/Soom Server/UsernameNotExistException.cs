﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soom_server
{
    public class UsernameNotExistException : Exception
    {
        public UsernameNotExistException() : base() { }
    }
}
