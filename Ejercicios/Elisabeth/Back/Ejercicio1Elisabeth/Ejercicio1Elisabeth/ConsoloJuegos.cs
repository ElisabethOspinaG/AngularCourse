using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio1Elisabeth
{
    internal class ConsolaDeJuegos
    {
        public int PedirJuego ()
        {

            Console.WriteLine(" BIENVENIDO A LA CONSOLA DE JUEGOS ELISABETH");
            Console.WriteLine("........................................");
            Console.WriteLine(" QUE JUEGO DESEA JUGAR: ................");
            Console.WriteLine("1. FRIO - TIBIO - CALIENTE");
            Console.WriteLine("2. PIEDRA - PAPEL - TIJERA");
            Console.WriteLine("3. TRIQUI");
            Console.WriteLine("/n");
            Console.WriteLine("INGRESE LA OPCION DESEADA: ");
            var opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
        public void Jugar (int opc)
        {
            var ReglasJuegoTriqui = new ReglasBasicas();
            var jugarTriqui = new JuegoTriqui();
            
            if (opc == 1)
            {
                Console.WriteLine("BIENVENIDO AL JUEGO FRIO - CALIENTE");
                Console.WriteLine("____________________________________");
                Console.WriteLine("\n");
            }
            if (opc == 2)
            {
                Console.WriteLine("BIENVENIDO AL JUEGO PIEDRA - PAPEL - TIJERA");
                Console.WriteLine("____________________________________");
                Console.WriteLine("\n");
            }
            if (opc == 3)
            {
                Console.WriteLine("BIENVENIDO AL JUEGO TRIQUI");
                Console.WriteLine("____________________________________");
                Console.WriteLine("\n");

                jugarTriqui.IniciarJugoTriqui(opc);
            }
                if (opc == 4)
            {
                string[,] Matrix3x3Triqui = new string[3, 3];
                string[] ArrayOpcTableroTriqui = ["1", "2", "3","4", "5", "6", "7", "8", "9"];
                //bool stringValido = false;
                //string opcion = "";
                Console.WriteLine("BIENVENIDO AL JUEGO TRIQUI");
                Console.WriteLine("____________________________________");
                Console.WriteLine("\n");
                Console.WriteLine(" las reglas del juego son: ........");
                //ReglasJuegoTriqui.ReglasJuego(opc);
                Console.WriteLine("\n");

                for (int i = 0; i < 4; i++)
                    {
                     if (i == 0)
                        {
                            Console.WriteLine("estoy en la iteracion: " + 0);
                            Console.WriteLine("Jugador 1: ingrese una opcion del 1 al 9 segun la posición elegida, si desea salir digite en numero 0");
                            var datoJugador1 = Console.ReadLine();
                            var validarDato1 = !string.IsNullOrEmpty(datoJugador1);
                            if (true)
                            {
                                switch (datoJugador1)
                                {
                                    case "1":
                                        Matrix3x3Triqui[0, 0] = "X";
                                        Console.WriteLine("|  " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |" );
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                    break;

                                    case "2":
                                        Matrix3x3Triqui[0, 1] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |  " + Matrix3x3Triqui[0, 1] + "   |   " + Matrix3x3Triqui[0, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                        break;
                                    case "3":
                                        Matrix3x3Triqui[0, 2] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                    break;
                                    case "4":
                                        Matrix3x3Triqui[1, 0] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "    |");
                                        Console.WriteLine("|  " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                        break;
                                    case "5":
                                        Matrix3x3Triqui[1, 1] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "    |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |  " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                        break;
                                    case "6":
                                        Matrix3x3Triqui[1, 2] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "    |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "  |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                    break;
                                    case "7":
                                        Matrix3x3Triqui[2, 0] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "    |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|  " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                    break;
                                    case "8":
                                        Matrix3x3Triqui[2, 1] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "    |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |  " + Matrix3x3Triqui[2, 1] + "   |   " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                    break;
                                    case "9":
                                        Matrix3x3Triqui[2, 2] = "X";
                                        Console.WriteLine("|   " + Matrix3x3Triqui[0, 0] + "   |   " + Matrix3x3Triqui[0, 1] + "   |  " + Matrix3x3Triqui[0, 2] + "    |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[1, 0] + "   |   " + Matrix3x3Triqui[1, 1] + "   |   " + Matrix3x3Triqui[1, 2] + "   |");
                                        Console.WriteLine("|   " + Matrix3x3Triqui[2, 0] + "   |   " + Matrix3x3Triqui[2, 1] + "   |  " + Matrix3x3Triqui[2, 2] + "   |");
                                        Console.WriteLine("................................");
                                    break;
                                    case "0":
                                        Console.WriteLine(" gracias por Jugar con nosotros hasta la próxima. ");
                                        break;
                                    default:
                                        Console.WriteLine("Opcion incorrecta. Digite un numero del 1 al 9 segun la posición elegida, si desea sair digite en numero 0 ");
                                        break;
                                }
                            }

                        }
                     else if (i == 1)
                        {
                            Console.WriteLine("iteracion " + i);
                            Console.WriteLine("Jugador 2: ingrese una opcion del 1 al 9 segun la posición elegida, si desea sair digite en numero 0");
                            var datoJugador2 = Console.ReadLine();
                            var validarDato2 = !string.IsNullOrEmpty(datoJugador2);
                            if (validarDato2)
                            {
                            switch (datoJugador2)
                            {
                                case "0":
                                    Console.WriteLine(" gracias por utilizar la consola elisabeth hasta pronto !!");
                                    Console.WriteLine("esto es lo que hay en i: " + i);
                                    i = 9;
                                    Console.WriteLine("esto es el nuevo valor en i: " + i);
                                    break;
                                 case "1":
                                   
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
                                        Console.WriteLine("esa posicion ya esta siendo ocupada. " );
                                        Console.WriteLine("Ingrese otra opcion diferente del 2 al 9 o el numero cero para salir del juego " + Matrix3x3Triqui[0, 0]);
                                        i--;
                                        break;
                                        }
                                    break;
                                 case "2":
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
                                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                                        Console.WriteLine("Ingrese una posicion diferente.  puede ser 1 o del 3 al 9. Si no desea jugar mas  ingrese el numero 0 ");
                                        i--;
                                        break;
                                    }

                                  break;
                                 case "3":
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
                                case "4":
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
                                case "5":
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
                                case "6":
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
                                case "7":
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
                                case "8":
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
                                case "9":
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
                                        Console.WriteLine("esa posicion ya esta siendo ocupada. ");
                                        Console.WriteLine("Ingrese una posicion diferente.  puede ser del 1 al 7 o el 9. Si no desea jugar mas  ingrese el numero 0 ");
                                        i--;
                                        break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opcion incorrecta. Digite un numero del 1 al 9 segun la posición elegida, si desea sair digite en numero 0 ");
                                    i--;
                                    break;
                                    
                            }

                        }
                     }
                     else if (i == 2)
                        {
                        Console.WriteLine("iteracion " + i);
                        Console.WriteLine("Jugador 2: ingrese una opcion del 1 al 9 segun la posición elegida, si desea sair digite en numero 0");
                        var datoJugador1 = Console.ReadLine();
                        var validarDato1 = !string.IsNullOrEmpty(datoJugador1);
                        if (validarDato1)
                        {

                        }
                        }
                                     
                } 
            }

        }
    }
}
