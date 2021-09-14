using System;

namespace InstagramAgeProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on sinu sünniaasta?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int age = 2021 - YearOfBirth;

            if (age > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et luua insta konto!");
            }
            else if (age < 13)
            {
                Console.WriteLine("Oled liiga noor, et luua insta konto!");
            }
            else
            {
                Console.WriteLine("Oled täpselt 13!");
            }
        }
        
         
        
        
    }
}
