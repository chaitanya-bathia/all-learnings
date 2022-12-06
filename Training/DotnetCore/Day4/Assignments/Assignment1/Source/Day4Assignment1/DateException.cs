using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Day4Assignment1
{
    class DateException : ApplicationException
    {
        public DateException()
        {
        }

        public DateException(string message) : base(message)
        {
        }

        public DateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
