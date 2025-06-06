using System;
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

            SoundPlayer sonido = new SoundPlayer("song1.wav");
            sonido.Play();
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
                        Console.WriteLine("║                      > 4)SALIR DEL JUEGO                               ║");
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
            /*while (intentos < intentosMaximos && !adivinado)
            {
                intentos++;

                string intento;
                do
                {
                    Console.Write("Intento {intentos}: ");
                    intento = Console.ReadLine();

                    if (string.IsNullOrEmpty(intento))
                    {
                        Console.WriteLine("No puedes dejar el espacio vacío");
                    }
                    else if (intento.Length != 5)
                    {
                        Console.WriteLine("La palabra debe tener exactamente 5 letras");
                    }

                } while (string.IsNullOrEmpty(intento) || intento.Length != 5);

                intento = intento.ToUpper();
                Console.WriteLine("Pistas:");
                for (int i = 0; i < 5; i++)
                {
                    if (intento[i] == PalabraSecreta)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("✓ ");
                    }
                    else if (palabraSecreta.Contains(intento[i].ToString()))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("~ ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("× ");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine("\n");

                if (intento == palabraSecreta)
                {
                    adivinado = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Felicidades! ¡Adivinaste la palabra!");
                    Console.Beep(700, 400);
                    Console.Beep(800, 500);
                    Console.Beep(900, 800);
                    Console.Beep(1000, 1000);
                    Console.ResetColor();
                }
            }

            if (!adivinado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"¡Oh no! La palabra era: {palabraSecreta}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.Clear();
            Console.ReadKey();*/

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
                        Console.WriteLine("INGRESO UN N° MAYOR AL INGRESADO");
                    }
                    else
                    {
                        Console.WriteLine("INGRESO UN N° MENOR AL IGRESADO");
                    }
                }

            }
            while (numAlt != numIng);
            Thread.Sleep(3000);
            Console.Clear();
            Console.ReadKey();
        }
        static void PiedraPaperlTijera()
        {
            int opcion;
            do
            {
                int intentosMaximos = 3;
                int intentos = 0;
                string[] opciones = new string[3];
                opciones[0] = "piedra";
                opciones[1] = "papel";
                opciones[2] = "tijera";
                Random random = new Random();
                string computadora = opciones[random.Next(0, 3)];

                Console.WriteLine("Elige una opción: Piedra, Papel o Tijera\n");
                string jugador = Console.ReadLine();

                Console.WriteLine("La computadora eligió: " + computadora+"\n");

                Class1 class1 = new Class1();
                class1.piedraPapelTijera(computadora, jugador);


                Console.WriteLine("Desea seguir jugando?");
                Console.WriteLine("1. Si");
                Console.WriteLine("0. No\n");
                opcion = int.Parse(Console.ReadLine());
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
            }
            while (opcion!=0);
            Console.Clear();
        }
    }
}
