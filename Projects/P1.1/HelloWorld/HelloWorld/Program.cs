using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message[] message = new Message[5];
            message[0] = new Message("Welcome back oh great educator!");
            message[1] = new Message("What a lovely name");
            message[2] = new Message("Great name");
            message[3] = new Message("This name is God!");
            message[4] = new Message("That is a silly name");

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            if (name.ToLower() == "george")
            {
                message[0].print();
            }
            else if (name.ToLower() == "salim")
            {
                message[1].print();
            }
            else if (name.ToLower() == "juliana")
            {
                message[2].print();
            }
            else if (name.ToLower() == "fred")
            {
                message[3].print();
            }
            else
            {
                message[4].print();
            }
        }
    }
}