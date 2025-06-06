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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("FELICIDADES, HAS GANADO");
                        Console.ResetColor();
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
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("v");
                                Console.ResetColor();
                            } else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("x");
                                Console.ResetColor();
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.Clear();
            Console.ReadKey();

        }
    }
}

