using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja
            //perekonnanimes kokku on

            int counter = 0;
            // 'a'

            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();
            string fullname = firstName + lastName.ToLower();

            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {
                    counter++;
                }
                else if(fullname[i] == 'A')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");


        }
    }
}
