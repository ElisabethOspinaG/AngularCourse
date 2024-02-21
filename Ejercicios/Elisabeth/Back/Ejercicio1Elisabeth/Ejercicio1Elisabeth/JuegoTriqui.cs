using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1Elisabeth
{
    internal class JuegoTriqui
    {
        private const int NUM_INTENTOS = 9;
        //private int[] ArrayOpcTableroTriqui = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        private string[] ArrayOpcTableroTriqui = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
        private string[,] Matrix3x3Triqui = new string[3, 3];


        public void IniciarJugoTriqui(int opc)
        {
            var seguirJugando = "N";

            do
            {
                var ReglasJuegoTriqui = new ReglasBasicas();
                ReglasJuegoTriqui.ReglasJuego(opc);
                Console.WriteLine();
                JugarTrqi();

                Console.WriteLine("¿Desea seguir Jugando?. Escriba la Y para si y la N para no. Y/N");
                seguirJugando = SolicitarDato();

            } while (seguirJugando.ToUpper() == "Y");
           
        }

        private void JugarTrqi( )
        {
            //Console.WriteLine("Entro en el metodo jugartriqui; ");

            for (int i = 0; i < 4; i++)
            {
               
                if (i == 0)
                {
                    Console.WriteLine("Jugador Uno: Ronda 1");
                    Console.WriteLine();
                    var datoString = SolicitarDato();
                    var datoValidado = ValidarStringEnMatrix(datoString);
                    Console.WriteLine();
                    ImprimirArregloJugador1(i, datoValidado);
                    Console.WriteLine();

                    Console.WriteLine("Jugador Dos: Ronda 1");
                    Console.WriteLine();
                    var datoString2 = SolicitarDato();
                    var datoValidado2 = ValidarStringEnMatrix(datoString2);
                    Console.WriteLine();
                    ImprimirArregloJugador2(i, datoValidado2);
                    Console.WriteLine();
                }
                else if (i == 1)
                {
                    Console.WriteLine("Jugador Uno: Ronda 2");
                    var datoString = SolicitarDato();
                    var datoValidado = ValidarStringEnMatrix(datoString);
                    Console.WriteLine();
                    ImprimirArregloJugador1(i, datoValidado);

                    Console.WriteLine("Jugador Dos: Ronda 2");
                    Console.WriteLine();
                    var datoString2 = SolicitarDato();
                    var datoValidado2 = ValidarStringEnMatrix(datoString2);
                    Console.WriteLine();
                    ImprimirArregloJugador2(i, datoValidado2);
                    Console.WriteLine();


                }
                else if (i == 2)
                {
                    Console.WriteLine("Jugador Uno: Ronda 3");
                    var datoString = SolicitarDato();
                    var datoValidado = ValidarStringEnMatrix(datoString);
                    Console.WriteLine();
                    ImprimirArregloJugador1(i, datoValidado);

                    Console.WriteLine("Jugador Dos: Ronda 3");
                    Console.WriteLine();
                    var datoString2 = SolicitarDato();
                    var datoValidado2 = ValidarStringEnMatrix(datoString2);
                    Console.WriteLine();
                    ImprimirArregloJugador2(i, datoValidado2);
                    Console.WriteLine();
                }
                else if (i == 3)
                {
                    Console.WriteLine("Jugador Uno: Ronda 4");
                    var datoString = SolicitarDato();
                    var datoValidado = ValidarStringEnMatrix(datoString);
                    Console.WriteLine();
                    ImprimirArregloJugador1(i, datoValidado);
                   

                    Console.WriteLine("Jugador Dos: Ronda 4");
                    Console.WriteLine();
                    var datoString2 = SolicitarDato();
                    var datoValidado2 = ValidarStringEnMatrix(datoString2);
                    Console.WriteLine();
                    ImprimirArregloJugador2(i, datoValidado2);
                    Console.WriteLine();
                }
               
                
            }
        }
        private string SolicitarDato()
        {
            var datoValido = "";
            var datoString = "";
            //Console.WriteLine("entre al metodo Solicitar Datos");
            Console.WriteLine("Escriba la opcion deseada.");
            datoString = Console.ReadLine();
            //Console.WriteLine($"dataString: {datoString}");
            
            if (!string.IsNullOrWhiteSpace(datoString))
            {
                //Console.WriteLine("Ingrese al if valido, datoString: " + datoString);
                datoValido = datoString.Trim();
            }
            else if (string.IsNullOrWhiteSpace(datoString))
            {
                do
                {
                    Console.WriteLine("Error. Escriba la opcion deseada.");
                    datoString = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(datoString))
                    {
                        //Console.WriteLine($"Ingrese al if valido, datoString: {datoString}");
                        if (datoString == "0")
                        {
                            Console.WriteLine("Gracias por preferirnos. Consola de Juegos Elisabeth lo espera pronto");
                            datoString = "0";
                        }
                        else
                        {
                            Console.WriteLine($"Ingreso opcion valida, datoString: {datoString}");
                            datoValido = datoString.Trim();
                            //datoString = "0";
                        } 
                    }
                    else if (string.IsNullOrWhiteSpace(datoString))
                    {
                        Console.WriteLine(" Error: no ha ingresado algun valor, digite la opcion deseada.");
                    }
                    
                } while (datoString != "0");

            }

            return datoValido;
        }
        private int ValidarStringEnMatrix(string datoString)
        {
            //Console.WriteLine("entre al metodo validarStringEnMatrix");
            //Console.WriteLine("................");
            var datoExistenteEnArreglo = 0;
            var validarDato = ArrayOpcTableroTriqui.Contains(datoString);
            //Console.Write($"datoString: {datoString}");
            //Console.WriteLine("\n");
            //Console.Write($"validarDato: {validarDato}");
            //Console.WriteLine("\n");

            if (validarDato == true)
            {
                validarDato = int.TryParse(datoString, out var number);
                datoExistenteEnArreglo = number;
                Console.WriteLine("dato en Matrix: " + datoExistenteEnArreglo);

            }
            else if (validarDato == false)
            {
                Console.WriteLine("no esta en el arreglo: " + datoExistenteEnArreglo);
                SolicitarDato();
            }

            return datoExistenteEnArreglo;


        }
        private void ImprimirArregloJugador1(int i, int datoNumerico)
        {
            //var historicoJugador1 = 0;
           
            //var historicoJugador2 = 0;
            switch (datoNumerico)
            {
                case 1:

                    if (string.IsNullOrEmpty(Matrix3x3Triqui[0, 0]))
                    {
                        Matrix3x3Triqui[0, 0] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        

                    }
                    else
                    {
                        Console.WriteLine("esa posición está ocupada. ");
                        Console.WriteLine("Ingrese otra opción diferente del 2 al 9 o el numero cero para salir del juego " + Matrix3x3Triqui[0, 0]);
                        i--;
                        break;
                    }
                    break;
                case 2:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[0, 1]))
                    {
                        Matrix3x3Triqui[0, 1] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |  " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                       
                    }
                    else
                    {
                        Console.WriteLine("esa posición ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posición diferente.  puede ser 1 o del 3 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }

                    break;
                case 3:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[0, 2]))
                    {
                        Matrix3x3Triqui[0, 2] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                        // Comprobar filas
                       

                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser 1, 2 o del 4 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }

                    break;
                case 4:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[1, 0]))
                    {
                        Matrix3x3Triqui[1, 0] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|  " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                        
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser 1, 2 o 3 0 del 5 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 5:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[1, 1]))
                    {
                        Matrix3x3Triqui[1, 1] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "  |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                        // Comprobar filas
                       
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 4 0 del 6 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 6:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[1, 2]))
                    {
                        Matrix3x3Triqui[1, 2] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "  |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                        // Comprobar filas
                        
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 5 0 del 7 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 7:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[2, 0]))
                    {
                        Matrix3x3Triqui[2, 0] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|  " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                       
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 6 0 el 8 y el 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }

                    break;
                case 8:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[2, 1]))
                    {
                        Matrix3x3Triqui[2, 1] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |  " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                       
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 7 o el 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 9:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[2, 2]))
                    {
                        Matrix3x3Triqui[2, 2] = "X";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "    |  " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                        //var partidasGanadasJugador1 = EncontrarGanador(Matrix3x3Triqui, historicoJugador1);
                       
                    }
                    else
                    {
                        Console.WriteLine("esa posición esta ocupada. ");
                        Console.WriteLine("Ingrese una posición diferente.  puede ser del 1 al 7 o el 9. Si desea SALIR  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                break;
                case 0:
                    Console.WriteLine("gracias por utilizar la consola de Juegos Elisabeth");
                    break;


            }
           

        }

        private void ImprimirArregloJugador2(int i , int datoNumerico)
        {
            switch (datoNumerico)
            {
                case 1:

                    if (string.IsNullOrEmpty(Matrix3x3Triqui[0, 0]))
                    {
                        Matrix3x3Triqui[0, 0] = "O";
                        Console.WriteLine("|  " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posición está ocupada. ");
                        Console.WriteLine("Ingrese otra opción diferente del 2 al 9 o el numero cero para salir del juego " + Matrix3x3Triqui[0, 0]);
                        i--;
                        break;
                    }
                    break;
                case 2:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[0, 1]))
                    {
                        Matrix3x3Triqui[0, 1] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |  " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posición ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posición diferente.  puede ser 1 o del 3 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }

                    break;
                case 3:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[0, 2]))
                    {
                        Matrix3x3Triqui[0, 2] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser 1, 2 o del 4 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }

                    break;
                case 4:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[1, 0]))
                    {
                        Matrix3x3Triqui[1, 0] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|  " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser 1, 2 o 3 0 del 5 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 5:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[1, 1]))
                    {
                        Matrix3x3Triqui[1, 1] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "  |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 4 0 del 6 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 6:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[1, 2]))
                    {
                        Matrix3x3Triqui[1, 2] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "  |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 5 0 del 7 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 7:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[2, 0]))
                    {
                        Matrix3x3Triqui[2, 0] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|  " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 6 0 el 8 y el 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }

                    break;
                case 8:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[2, 1]))
                    {
                        Matrix3x3Triqui[2, 1] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |  " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 7 o el 9. Si no desea jugar mas  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 9:
                    if (string.IsNullOrEmpty(Matrix3x3Triqui[2, 2]))
                    {
                        Matrix3x3Triqui[2, 2] = "O";
                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |  " + Matrix3x3Triqui[2, 1] + "    |  " + Matrix3x3Triqui[2, 2] + "   |");
                        Console.WriteLine("................................");
                    }
                    else
                    {
                        Console.WriteLine("esa posición esta ocupada. ");
                        Console.WriteLine("Ingrese una posición diferente.  puede ser del 1 al 7 o el 9. Si desea SALIR  ingrese el numero 0 ");
                        i--;
                        break;
                    }
                    break;
                case 0:
                    Console.WriteLine("gracias por utilizar la consola de Juegos Elisabeth");
                    break;
            }
        }

        
    }
        
    
}

//private string EncontrarGanador(char[,] matrizTriqui)
        //{
        //    // Comprobar filas
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (matrizTriqui[i, 0] == matrizTriqui[i, 1] && matrizTriqui[i, 1] == matrizTriqui[i, 2])
        //        {
        //            return matrizTriqui[i, 0];

        //        }
        //    }

        //    // Comprobar columnas
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (matrizTriqui[0, j] == matrizTriqui[1, j] && matrizTriqui[1, j] == matrizTriqui[2, j])
        //        {
        //            return matrizTriqui[0, j];
        //        }
        //    }

        //    // Comprobar diagonales
        //    if (matrizTriqui[0, 0] == matrizTriqui[1, 1] && matrizTriqui[1, 1] == matrizTriqui[2, 2])
        //    {
        //        return matrizTriqui[0, 0];
        //    }

        //    if (matrizTriqui[0, 2] == matrizTriqui[1, ] && matrizTriqui[1, 1] == matrizTriqui[2, 0])
        //    {
        //        return matrizTriqui[0, 2];
        //    }

        //    // No hay ganador
        //    return '\No hay ganador';
        //}

//private int EncontrarGanadorJugadorUno( string[,] matrizTriqui, int historicoJugador1)
        //{
 
        //    if (matrizTriqui[0,0] == "X" & matrizTriqui[0, 1] == "X" & matrizTriqui[0, 2] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[1, 0] == "X" & matrizTriqui[1, 1] == "X" & matrizTriqui[1, 2] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[2, 0] == "X" & matrizTriqui[2, 1] == "X" & matrizTriqui[2, 2] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[0, 0] == "X" & matrizTriqui[1, 0] == "X" & matrizTriqui[2, 0] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[0, 1] == "X" & matrizTriqui[1, 1] == "X" & matrizTriqui[2, 1] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[0, 2] == "X" & matrizTriqui[1, 2] == "X" & matrizTriqui[2, 2] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[0, 0] == "X" & matrizTriqui[1, 1] == "X" & matrizTriqui[2, 2] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }
        //    else if (matrizTriqui[0, 2] == "X" & matrizTriqui[1, 1] == "X" & matrizTriqui[2, 0] == "X")
        //    {
        //        Console.WriteLine("Jugador 1, Usted a ganado la partida");
        //        historicoJugador1 += 1;
        //    }

        //    return historicoJugador1;
        //}