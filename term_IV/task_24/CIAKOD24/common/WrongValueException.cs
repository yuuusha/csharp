using System;

namespace CIAKOD24_exception
{
    class WrongValueException : Exception
    {
        internal WrongValueException(string message)
        : base(message) { }
    }
}