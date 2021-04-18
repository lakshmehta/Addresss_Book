﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    
   public class AddressBookException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_EXIST,
        }
        private readonly ExceptionType type;
        public AddressBookException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }

    }
}
