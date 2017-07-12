﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException()
        {
        }

        public InvalidArtistNameException(string message)
            : base(message)
        {
        }

        public InvalidArtistNameException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
