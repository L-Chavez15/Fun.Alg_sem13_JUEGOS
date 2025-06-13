﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

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

            //SoundPlayer sonido = new SoundPlayer("song1.wav");
            //sonido.Play();
            //Thread.Sleep(5000);
            //sonido.Stop();
            int inicio;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║************************************************************************║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                             > 1)INICIAR                              *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                             > 2)SALIR                                *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║*                                                                      *║");
                Console.WriteLine("║************************************************************************║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("");
                inicio = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (inicio)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║******************************* JUEGOS *********************************║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("║                        SELECCIONE UN JUEGO                             ║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("║                      > 1)ADIVINA LA PALABRA                            ║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("║                      > 2)ADIVINA EL NÚMERO                             ║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("║                      > 3)PIEDRA, PAPE O TIJERA                         ║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("║                      > 4)PAR O IMPAR                                   ║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("║                      > 5)SALIR DEL JUEGO                               ║");
                        Console.WriteLine("║                                                                        ║");
                        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝\n");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        int juego = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (juego)
                        {

                            case 1:
                                AdivinaLaPalabra();
                                break;
                            case 2:
                                AdivinaElNumero();
                                break;
                            case 3:
                                PiedraPaperlTijera();
                                break;
                            case 4:
                                Par_o_Impar();
                                break;
                            case 5:
                                Console.Write("SALIENDO.....");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Class1 P = new Class1();
                        P.salida();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t\t******** ERROR, FALLA EN EL SISTEMA :C ******** ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ReadKey();
                        break;
                }
            }
            while (inicio != 2);

        }
        static void AdivinaLaPalabra()
        {
            APalabra PalabraSecreta = new APalabra();
            int intentosMaximos = 6;
            int intentos = 0;
            bool adivinado = false;
            Console.WriteLine("Adivina la palabra de 5 letras");
            Console.WriteLine("Tienes 6 intentos\n");
            Console.WriteLine("Pistas:");
            Console.WriteLine("✓ = Letra correcta en posición correcta");
            Console.WriteLine("~ = Letra correcta en posición incorrecta");
            Console.WriteLine("× = Letra no existe en la palabra\n");
            PalabraSecreta.Intentos();
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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t\t*****ADIVINA EL NÚMERO*****\n");
                Console.ResetColor();
                Console.WriteLine("* Ingrese un número del 1 al 20: \n");
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
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
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
            Console.Clear();
        }
        static void PiedraPaperlTijera()
        {
            int opcion;
            do
            {
                Console.Clear();
                string[] opciones = new string[3];
                opciones[0] = "piedra";
                opciones[1] = "papel";
                opciones[2] = "tijera";
                Random random = new Random();
                string computadora = opciones[random.Next(0, 3)];
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t\t\t*****PIEDRA, PAPEL O TIJERA :D *****\n");
                Console.ResetColor();
                Console.WriteLine("*) PIEDRA\n");
                Console.WriteLine("*) PAPEL\n");
                Console.WriteLine("*) TIJERA\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Escribe una opción: \n");
                Console.ResetColor();
                string jugador = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLa computadora eligió: ");
                Console.ResetColor();
                Console.WriteLine(computadora+"\n");

                Class1 class1 = new Class1();
                class1.piedraPapelTijera(computadora, jugador);


                Console.WriteLine("Desea seguir jugando?");
                Console.WriteLine("1. Si");
                Console.WriteLine("0. No\n");
                opcion = int.Parse(Console.ReadLine());
                Console.ReadKey();
                switch (opcion)
                {
                    case 1:
                        break;
                    case 0:
                        Class1 n2 = new Class1();
                        n2.salida();
                        break;
                    default:
                        Console.WriteLine("INGRESA UN VALOR VALIDO\n");
                        break;
                }
                Console.ReadKey();

            }
            while (opcion!=0);
        }
        static void Par_o_Impar()
        {
            string seguir = "s";

            while (seguir == "s")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t\t*****PAR O IMPAR*****\n");
                Console.ResetColor();
                Console.WriteLine("Escribe par o impar:");
                string eleccion;
                eleccion = Console.ReadLine();

                Console.WriteLine("Elige un número del 1 al 100");
                int numeroUsuario;
                numeroUsuario = Convert.ToInt32(Console.ReadLine());
                if (numeroUsuario < 100)
                {

                Random r = new Random();
                int numeroMaquina;
                numeroMaquina = r.Next(1, 10);
                int suma = numeroUsuario + numeroMaquina;

                Console.WriteLine("Tu numero: " + numeroUsuario);
                Console.WriteLine("Número de la maquina: " + numeroMaquina);
                Console.WriteLine("Suma total: " + suma);

                if (suma % 2 == 0)
                {
                    Console.WriteLine("El resultado es PAR.");
                    if (eleccion == "par")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" ¡Ganaste mano!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Perdiste, causa.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("El resultado es IMPAR.");
                    if (eleccion == "impar")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Ganaste mano!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Perdiste causa.");
                        Console.ResetColor();
                    }
                }

                Console.WriteLine("\n¿Quieres jugar otra vez? (S o N)");
                seguir = Console.ReadLine();
                Console.Clear();
                }else
                {
                    Console.WriteLine("NUMERO INCORRECTO");
                }
            }
        }
    }
}
