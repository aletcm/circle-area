using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj0000 {
   internal class Program {
      static void Main() {
         Console.ForegroundColor = ConsoleColor.DarkCyan;
         Console.WriteLine("**************************************************************************");
         Console.WriteLine("           Calcular a área de círculos em metros quadrados (m²)           ");
         Console.WriteLine("**************************************************************************\n");
         Console.ResetColor();

      start:
         Console.Write("Digite o raio do círculo em metros ou \"sair\" para interromper: ");
         string input = Console.ReadLine();
         bool proceed = double.TryParse(input, out double radius);

         if (input.ToLower() == "sair") {
            Console.WriteLine();
            return;
         } else {
            if (!proceed || radius < 0) {
               IsInvalid();
               goto start;
            } else {
               double area = Math.PI * Math.Pow(radius, 2);
               Result(area, radius);
               goto start;
            }
         }
      }
      static void IsInvalid() {
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         Console.WriteLine("\nENTRADA INVÁLIDA! Tente novamente.");
         Console.ResetColor();
      }
      static void Result(double a, double r) {
         Console.Write($"\nA área do círculo de raio ");
         Console.ForegroundColor = ConsoleColor.Red;
         Console.Write($"{r}m");
         Console.ResetColor();
         Console.Write($" é igual a ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.Write($"{a}m²\n");
         Console.ResetColor();
      }

   }
}
