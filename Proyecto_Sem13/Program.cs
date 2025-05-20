using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_Sem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interfas();
        }
        static void Interfas()
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    int juego = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (juego)
                    {
                        case 0:
                            
                            Console.Write("SALIENDO.....");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Salida();
                            break;
                        case 1:
                            AdivinaLaPalabra();
                            break;
                        case 2:
                            AdivinaElNumero();
                            break;
                        case 3: 
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Salida();
                break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t******** ERROR, FALLA EN EL SISTEMA :C ******** ");
                    Console.ReadKey();
                    break;
            }
        }
        static void AdivinaLaPalabra()
        {
            Console.WriteLine("Adivina la palabra de 5 letras");
            Console.WriteLine("Tienes 6 intentos\n");
            Console.WriteLine("Pistas:");
            Console.WriteLine("✓ = Letra correcta en posición correcta");
            Console.WriteLine("~ = Letra correcta en posición incorrecta");
            Console.WriteLine("× = Letra no existe en la palabra\n");
            Console.ReadKey();
        }
        static void AdivinaElNumero()
        {
            int numAlt, numIng;
            Random R = new Random();
            numAlt = R.Next(1, 21);
            Console.WriteLine(numAlt);
            do
            {
                Console.WriteLine("Ingrese un número del 1 al 20: ");
                numIng = int.Parse(Console.ReadLine());
                if (numIng == numAlt)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ADIVINASTE!!!! ");
                    Console.Beep(700, 400);
                    Console.Beep(800, 500);
                    Console.Beep(900, 800);
                    Console.Beep(1000, 1000);
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                else
                {
                    if (numIng < numAlt)
                    {
                        Console.WriteLine("INGRESO UN N° MAYOR AL GENERADO");
                    }
                    else
                    {
                        Console.WriteLine("INGRESO UN N° MENOR AL GENERADO");
                    }
                }

            }
            while (numAlt != numIng);
            Console.ReadKey();
        }
        static void Salida()
        {
            Console.WriteLine("\t\t\t\t*********** ESPERAMOS VERTE DE NUEVO ***********\t\t\t\t \n");
            Console.WriteLine("\t\t\t\t\t*********** ADIOS ***********\t\t\t\t\t\t \n");
            Console.ReadKey();
        }
           
    }
}
