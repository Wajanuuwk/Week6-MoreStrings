using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lasuet "Hello, World!" Tagurpidi
            string helloWorld = "Hello, world!";


            for (int i = helloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(helloWorld[i]);
            }
        }
    }
}
