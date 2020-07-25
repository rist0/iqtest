﻿using System;

namespace IQTest.Api.Helpers
{
    public class AppException : Exception
    {
        public AppException() : base()
        {

        }

        public AppException(string message) : base(message)
        {

        }
    }
}
