using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--Sequência de números pares--\n");
            Console.ResetColor();
            int x;

            Console.Write("Insira um número inteiro...: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            x = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine();

            int i = 0;
            while (i <= x)
            {
               if (i % 2 == 0)
               {
                   Console.ForegroundColor = ConsoleColor.DarkGreen;
                   Console.WriteLine(i);
                   Console.ResetColor();
               } 
               i++;
            }
                Console.WriteLine("\nObrigado por usar o nosso programa.\n");

            
                
        }
    }
}
