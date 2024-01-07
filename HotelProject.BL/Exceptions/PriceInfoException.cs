﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Exceptions
{
    public class PriceInfoException : Exception
    {
        public PriceInfoException(string? message) : base(message)
        {
        }

        public PriceInfoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}