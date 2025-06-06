using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class APalabra
    {
        string[] AP = { "perro", "flora", "campo", "arbol", "libro", "carro", "china", "japon", "mouse", "reloj" };

        public void Intentos()
        {
            Random n1 = new Random();
            int SP = n1.Next(AP.Length);
            string palabraSeleccionada = AP[SP];
            int intentos = 0;
            bool adivinado = false;
            Console.WriteLine(palabraSeleccionada);

            for (intentos = 0; intentos < 6; intentos++)
            {
                string op;
                Console.WriteLine("Intento" + (intentos + 1) + ": ");
                op = Console.ReadLine();
                if (op == "")
                {
                    Console.WriteLine("NO PUEDES DEJAR UN ESPACIO EN BLANCO");
                    intentos--;
                }
                else if (op.Length != 5)
                {
                    Console.WriteLine("INGRESE UNA PALABRA DE 5 LETRAS ");
                    intentos--;
                } else
                {
                    if (palabraSeleccionada==op)
                    {
                        Console.WriteLine("FELICIDADES, HAS GANADO");
                        Console.ReadKey();
                        break;
                    } else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            char lps = op[i];
                            bool e = false;
                            for (int j = 0; j < 5; j++)
                            {
                                char lpi=palabraSeleccionada[j];
                                if (lpi==lps)
                                {
                                    e = true;
                                } 
                            }
                            if (e)
                            {
                                Console.Write("v");
                            } else
                            {
                                Console.Write("x");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }



            //Console.WriteLine("pistas: ");
            //for (int i = 0; i < 6; i++)
            //{
            //    if (op[i] == palabraSeleccionada[i])
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write(op[i]);
            //        Console.ResetColor();
            //    }
            //    else if (palabraSeleccionada.Contains(op[i]))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.Write(op[i]);
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write(op[i]);
            //        Console.ResetColor();
            //    }
            //}
            //Console.WriteLine("\n");
            //if (op == palabraSeleccionada)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("FELICIDADES, HAS GANADO");
            //    Console.ResetColor();
            //    break;
            //}
            //else if (intentos == 6)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("HAS PERDIDO, LA PALABRA ERA: " + palabraSeleccionada);
            //    Console.ResetColor();
            //}
            //if (!adivinado)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"¡Oh no! La palabra era:" + palabraSeleccionada);
            //    Console.ResetColor();
            //}

            //Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.Clear();
            Console.ReadKey();

        }
    }
}

