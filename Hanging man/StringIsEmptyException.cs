using System;
using System.Runtime.Serialization;

namespace Hanging_man
{
    [Serializable]
    internal class StringIsEmptyException : Exception
    {
        //public StringIsEmptyException()
        //{
        //    throw new StringIsEmptyException("You didnt choose a letter");
        //}

        public StringIsEmptyException(string message) : base(message)
        {
            throw new StringIsEmptyException("You didnt choose a letter");
        }

    }
}