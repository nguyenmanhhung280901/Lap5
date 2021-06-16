using System;

namespace Lap5
{
    public class AmountException : Exception
    {
        private string _personName;
        private string _message;

        public AmountException(string message, string personName) : base(message)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
        }

        public void PrintError()
        {
            Console.Error.WriteLine($"Error: {_message}, Name {_personName}");
        }
    }
}