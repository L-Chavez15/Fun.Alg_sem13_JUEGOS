using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Sem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine("|************************************************************************|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                             > 1)INICIAR                              *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                             > 2)SALIR                                *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|*                                                                      *|");
            Console.WriteLine("|************************************************************************|");
            Console.WriteLine(" ------------------------------------------------------------------------\n");
            Console.Write("");
            int inicio = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (inicio)
            {
                case 1:

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine("|******************************* JUEGOS *********************************|");
                    Console.WriteLine("|                                                                        |");
                    Console.WriteLine("|                        SELECCIONE UN JUEGO                             |");
                    Console.WriteLine("|                                                                        |");
                    Console.WriteLine("|                      > 1)ADIVINA LA PALABRA                            |");
                    Console.WriteLine("|                                                                        |");
                    Console.WriteLine("|                      > 2)ADIVINA EL NÚMERO                             |");
                    Console.WriteLine("|                                                                        |");
                    Console.WriteLine("|                      > 3)TRES EN RAYA                                  |");
                    Console.WriteLine("|                                                                        |");
                    Console.WriteLine("|                      > 0)SALIR                                         |");
                    Console.WriteLine("|                                                                        |");
                    Console.WriteLine(" ------------------------------------------------------------------------\n");
                    Console.WriteLine("");
                    int juego = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (juego)
                    {
                        case 1:
                            JuegoAdivinalaPalabra();
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            
                            break;
                        default:
                            
                            break;
                    }
                    break;
                case 2:
                    
                    break;
                default:
                    
                    break;
            }
        }
        static void JuegoAdivinalaPalabra()
        {
            Console.WriteLine("Adivina la palabra de 5 letras");
            Console.WriteLine("Tienes 6 intentos\n");
            Console.WriteLine("Pistas:");
            Console.WriteLine("✓ = Letra correcta en posición correcta");
            Console.WriteLine("~ = Letra correcta en posición incorrecta");
            Console.WriteLine("× = Letra no existe en la palabra\n");
            Console.ReadKey();

        }
    }
}
