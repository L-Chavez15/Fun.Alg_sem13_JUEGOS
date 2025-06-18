using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string piedraPapelTijera(string op1, string op2)
        {
            
            if (op1.ToLower() == "piedra" && op2.ToLower() == "tijera")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PERDISTE\n");
                Console.ResetColor();
                return op1;
            }
            else if (op1.ToLower() == "tijera" && op2.ToLower() == "papel")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PERDISTE\n");
                Console.ResetColor();
                return op1;
            }
            else if (op1.ToLower() == "papel" && op2.ToLower() == "piedra")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("******PERDISTE******\n");
                Console.ResetColor();
                return op1;
            }
            else if (op1.ToLower() == op2.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("******EMPATE******\n");
                Console.ResetColor();
                return "Empate";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("******GANASTE******\n");
                Console.ResetColor();
                return "Jugador 2 gana";
            }
        }
        public void salida()
        {
            Console.WriteLine("\t\t\t\t*********** ESPERAMOS VERTE DE NUEVO ***********\t\t\t\t \n");
            Console.WriteLine("\t\t\t\t\t*********** ADIOS ***********\t\t\t\t\t\t \n");
            Console.ReadKey();
        }
    }
}
