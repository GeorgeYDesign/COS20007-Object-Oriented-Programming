using System;
namespace HelloWorld
{
    class Message
    {
        private string _text;

        public Message(String txt)
        {
            _text = txt;
        }

        public void print()
        {
            Console.WriteLine(_text);
        }
    }
}