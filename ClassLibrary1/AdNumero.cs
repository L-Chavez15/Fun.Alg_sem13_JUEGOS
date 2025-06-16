using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AdNumero
    {
        int eleccion;
        public void Elección(int op)
        {
            switch (op)
            {
                case 0:
                    salida();
                    break;
                case 1:
                    int numAlt, numIng;
                    Random R = new Random();
                    numAlt = R.Next(1, 11);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 10*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 20: \n");
                        numIng = int.Parse(Console.ReadLine());
                        if (numIng == numAlt)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("ADIVINASTE!!!! ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            if (numIng < numAlt)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MAYOR AL INGRESADO\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MENOR AL IGRESADO\n");
                                Console.ResetColor();
                            }
                        }
                        Console.ReadKey();
                    }
                    while (numAlt != numIng);
                    break;
                case 2:
                    int nuAlt, nuIng;
                    Random random = new Random();
                    nuAlt = random.Next(1, 31);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 30*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 20: \n");
                        nuIng = int.Parse(Console.ReadLine());
                        if (nuIng == nuAlt)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("ADIVINASTE!!!! ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            if (nuIng < nuAlt)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MAYOR AL INGRESADO\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MENOR AL IGRESADO\n");
                                Console.ResetColor();
                            }
                        }
                        Console.ReadKey();
                    }
                    while (nuAlt != nuIng);
                    break;
                case 3:
                    int nAlt, nIng;
                    Random N1 = new Random();
                    nAlt = N1.Next(1, 51);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 50*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 50: \n");
                        nIng = int.Parse(Console.ReadLine());
                        if (nIng == nAlt)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("ADIVINASTE!!!! ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            if (nIng < nAlt)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MAYOR AL INGRESADO\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MENOR AL IGRESADO\n");
                                Console.ResetColor();
                            }
                        }
                        Console.ReadKey();
                    }
                    while (nAlt != nIng);
                    break;
                case 4:
                    int Alt, Ing;
                    Random N2 = new Random();
                    Alt = N2.Next(1, 101);
                    Console.WriteLine(Alt);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 100*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 20: \n");
                        Ing = int.Parse(Console.ReadLine());
                        if (Ing == Alt)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("ADIVINASTE!!!! ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            if (Ing < Alt)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MAYOR AL INGRESADO\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nINGRESO UN N° MENOR AL IGRESADO\n");
                                Console.ResetColor();
                            }
                        }
                        Console.ReadKey();
                    }
                    while (Alt != Ing);
                    break;
                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("INGRESE UN VALOR VÁLIDO");
                    Console.ResetColor();
                    break;
            }
        }

        public void salida()
        {
            Console.WriteLine("\t\t\t\t*********** ESPERAMOS VERTE DE NUEVO ***********\t\t\t\t \n");
        }
    }
}
