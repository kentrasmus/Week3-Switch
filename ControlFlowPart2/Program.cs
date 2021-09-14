using System;

namespace ControlFlowPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-Koodi
            //programm võrdleb sisestatud PIN-Koodi arvuga 1234
            //Kui sisestatud PIN-Kood on 1234
            //programm kuvas konsoolis "Tere tulemast!
            //kui sisestatud pin on vale, programm kuvab konsoolis
            //"vale pin. Proovi uuesti"



            Console.WriteLine("Sisesta PIN-Kood pls");

            int PIN = Convert.ToInt32(Console.ReadLine());

            if (PIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            
            }
            else
            {
                Console.WriteLine("PIN on vale.Proovi uuesti");
            }

           }   
    }
}
