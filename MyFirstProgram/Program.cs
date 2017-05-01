using System;

namespace Task_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            String navn = Console.ReadLine();
            Console.WriteLine("Velkommen "+navn.ToUpper());
            Console.WriteLine("Tryk en tast for at fortsætte");
            Console.Write(Test("yes "));
            Console.ReadKey();
        }

        static string Test(string myText)
        {
            Console.Write(myText);
            return (myText.ToUpper());
        }
    }

}
