using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoamSodoku.CustomExceptions
{
    /// <summary>
    /// Exception thrown when the user provides invalid board length.
    /// </summary>
    internal class InvalidBoardLengthException : Exception
    {
        public InvalidBoardLengthException()
        { }
        public InvalidBoardLengthException(string message)
        : base(message)
        { }

        public InvalidBoardLengthException(string message, Exception innerException)
            : base(message, innerException)
        { }

    }
}
