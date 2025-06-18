using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AdNumero
    {
        int eleccion, numAlt, numIng;
        public void Elección(int op)
        {
            switch (op)
            {
                case 0:
                    salida();
                    break;
                case 1:
                    Random R = new Random();
                    numAlt = R.Next(1, 11);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 10*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 10: \n");
                        numIng = int.Parse(Console.ReadLine());
                        if (numIng>10)
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("\n INGRESE UN NÚMERO DEL 1 AL 10\n");
                            Console.ResetColor();
                        }
                        else
                        {
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
                        }
                        
                        Console.ReadKey();
                    }
                    while (numAlt != numIng);
                    break;
                case 2:
                    Random random = new Random();
                    numAlt = random.Next(1, 21);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 20*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 20: \n");
                        numIng = int.Parse(Console.ReadLine());
                        if (numIng>20)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n INGRESE UN NÚMERO DEL 1 AL 20\n");
                            Console.ResetColor();
                        }
                        else
                        {
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
                        }
                        
                        Console.ReadKey();
                    }
                    while (numAlt != numIng);
                    break;
                case 3:
                    Random N1 = new Random();
                    numAlt = N1.Next(1, 51);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 50*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 50: \n");
                        numIng = int.Parse(Console.ReadLine());
                        if (numIng>50)
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("\nINGRESE UN NUMERO DEL 1 AL 50\n");
                            Console.ResetColor();
                        }
                        else
                        {
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
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nINGRESO UN N° MENOR AL IGRESADO\n");
                                    Console.ResetColor();
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    while (numAlt != numIng);
                    break;
                case 4:
                    Random N2 = new Random();
                    numAlt = N2.Next(1, 101);
                    Console.WriteLine(numAlt);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t*****ADIVINA EL NÚMERO DEL 1 AL 100*****\n");
                        Console.ResetColor();
                        Console.WriteLine("* Ingrese un número del 1 al 100: \n");
                        numIng = int.Parse(Console.ReadLine());
                        if (numIng>100)
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("\nINGRESE UN NÚMERO DEL 1 AL 100\n");
                            Console.ResetColor();
                        }
                        else
                        {
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
                        }
                        
                        Console.ReadKey();
                    }
                    while (numAlt != numIng);
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
