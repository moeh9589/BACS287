using System;

namespace Assignment6_IF_ELSE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to be translated to Spanish:");
            String word = Console.ReadLine();

            if (word.Equals("Beautiful"))
            {
                Console.WriteLine("Beautiful - Bella");
            }
            else if (word.Equals("Country"))
            {
                Console.WriteLine("Country - Pais");
            }
            else if (word.Equals("Dancing"))
            {
                Console.WriteLine("Dancing = Bailando");
            }
            else if (word.Equals("Day"))
            {
                Console.WriteLine("Day = Día");
            }
            else if (word.Equals("Example"))
            {
                Console.WriteLine("Example = Ejemplo");
            }
            else if (word.Equals("Goodbye"))
            {
                Console.WriteLine("Goodbye = Adios");
            }
            else if (word.Equals("Hello"))
            {
                Console.WriteLine("Hello = Hola");
            }
            else if (word.Equals("House"))
            {
                Console.WriteLine("House = Casa");
            }
            else if (word.Equals("Life"))
            {
                Console.WriteLine("Life = Vida");
            }
            else if (word.Equals("Man"))
            {
                Console.WriteLine("Man = Hombre");
            }
            else if (word.Equals("Moment"))
            {
                Console.WriteLine("Moment = Momento");
            }
            else if (word.Equals("No"))
            {
                Console.WriteLine("No = No");
            }
            else if (word.Equals("People"))
            {
                Console.WriteLine("People = Gente");
            }
            else if (word.Equals("People"))
            {
                Console.WriteLine("People = Personas");
            }
            else if (word.Equals("Place"))
            {
                Console.WriteLine("Place = Lugar");
            }
            else if (word.Equals("Please"))
            {
                Console.WriteLine("Please = Por Favor");
            }
            else if (word.Equals("Slowly"))
            {
                Console.WriteLine("Slowly = Despacito");
            }
            else if (word.Equals("Things"))
            {
                Console.WriteLine("Things = Cosas");
            }
            else if (word.Equals("What"))
            {
                Console.WriteLine("What = Que");
            }
            else if (word.Equals("Where"))
            {
                Console.WriteLine("Where = Donde");
            }
            else if (word.Equals("Who"))
            {
                Console.WriteLine("Who = Quien");
            }
            else if (word.Equals("Woman"))
            {
                Console.WriteLine("Woman = Mujer");
            }
            else if (word.Equals("Work"))
            {
                Console.WriteLine("Work = Trabajo");
            }
            else if (word.Equals("World"))
            {
                Console.WriteLine("World = Mundo");
            }
            else if (word.Equals("Years"))
            {
                Console.WriteLine("Years = Anos");
            }
            else if (word.Equals("Yes"))
            {
                Console.WriteLine("Yes = Si");
            }
            else
            {
                Console.WriteLine("This program doesn't know the word you entered. Quitting...");
            }
            Console.ReadKey();
        }
    }
}
