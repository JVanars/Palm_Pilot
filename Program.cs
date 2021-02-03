using System;

namespace Palm_Pilot
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Please enter or select 1 program: ");
            response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                return;
            }
            if (response == "1")
            {
                var instance = new Bodymass();
                instance.Bodymassindex();
            }
            else 
            {
                Console.WriteLine("Goodbye!");
            }
            
        }
    }
}
