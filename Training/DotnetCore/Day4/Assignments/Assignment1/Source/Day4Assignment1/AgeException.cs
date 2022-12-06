using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Day4Assignment1
{
    class AgeException : ApplicationException
    {
        public AgeException()
        {
        }

        public AgeException(string message) : base(message)
        {
        }

        public AgeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
