using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Elisabeth
{
    internal class ReglasBasicas
    {
        public void ReglasJuego(int opcGame)
        {

            if (opcGame == 1)
            {
                Console.WriteLine(" BIENVENIDO AL JUEGO DENOMINADO FRIO CALIENTE");
            }
            if (opcGame == 2)
            {
                Console.WriteLine(" BIENVENIDO AL JUEGO DENOMINADO PIEDRA, PAPEL O TIJERA");
            }
            if (opcGame == 3)
            {
                Console.WriteLine(" BIENVENIDO AL JUEGO DENOMINADO TRIQUI");
                Console.WriteLine("Triqui es un juego de estrategia para dos personas donde solo se necesita un tablero de 3x3 casillas.");
                Console.WriteLine("   1   2   3");
                Console.WriteLine(" |-----------| ");
                Console.WriteLine("1|   |   |   |");
                Console.WriteLine(" |-----------| ");
                Console.WriteLine("2|   |   |   |");
                Console.WriteLine(" |-----------|");
                Console.WriteLine("3|   |   |   |");
                Console.WriteLine(" |-----------|");
                Console.WriteLine("EL jugador 1 tiene asignado el simbolo X y el jugakdor 2 tiene asignado el simbolo O.");
                Console.WriteLine("Se alternan los turnos para colocar su simbolo en una casilla vacia del tablero");
                Console.WriteLine("tanto las filas como las columnas se distinguen con los numeros 1, 2 y 3");
                Console.WriteLine("Si desea realizar su jugada en la primera casilla (fila 1, columna 1) escriba el numero 1");
                Console.WriteLine("|  1 |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la segunda casilla (fila 1, columna 2) escriba el numero 2");
                Console.WriteLine("|    | 2  |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la tercera casilla (fila 1, columna 3) escriba el numero 3");
                Console.WriteLine("|    |    | 3  |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la cuarta casilla (fila 2, columna 3) escriba el numero 4");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("| 4  |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la quinta casilla (fila 2, columna 3) escriba el numero 5");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    | 5  |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la sexta casilla (fila 2, columna 3) escriba el numero 6");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |  6 |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la septima casilla (fila 3, columna 1) escriba el numero 7");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|  7 |    |    |");
                Console.WriteLine("Si desea realizar su jugada en la octava casilla (fila 3, columna 2) escriba el numero 8");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    | 8  |    |");
                Console.WriteLine("Si desea realizar su jugada en la novena casilla (fila 3, columna 3) escriba el numero 9");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |    |");
                Console.WriteLine("|--------------|");
                Console.WriteLine("|    |    |  9 |");
                Console.WriteLine("El objeto del Juego es consiguir alinear tres de sus simbolos en una fila, columna o diagonal antes que el otro jugador lo logre");
                Console.WriteLine("Buena suerte!!!!!");
                Console.WriteLine(" SI DESEA SALIR DEL JUEGO DIGITE EL NUMERO 0.");
            }


            //switch (opcGame)
            //{
            //    case 1 (opcGame == 1):
            //        Console.WriteLine(" BIENVENIDO AL JUEGO DENOMINADO FRIO CALIENTE");
            //        break;
            //    case 2 (opcGame == 2):
            //        Console.WriteLine(" BIENVENIDO AL JUEGO DENOMINADO PIEDRA, PAPEL O TIJERA");
            //        break;

            //    case 3(opcGame == 3): 
                    
            //        Console.WriteLine(" BIENVENIDO AL JUEGO DENOMINADO TRIQUI");
            //        Console.WriteLine("Triqui es un juego de estrategia para dos personas donde solo se necesita un tablero de 3x3 casillas.");
            //        Console.WriteLine("   1   2   3");
            //        Console.WriteLine(" |-----------| ");
            //        Console.WriteLine("1|   |   |   |");
            //        Console.WriteLine(" |-----------| ");
            //        Console.WriteLine("2|   |   |   |");
            //        Console.WriteLine(" |-----------|");
            //        Console.WriteLine("3|   |   |   |");
            //        Console.WriteLine(" |-----------|");
            //        Console.WriteLine("EL jugador 1 tiene asignado el simbolo X y el jugakdor 2 tiene asignado el simbolo O.");
            //        Console.WriteLine("Se alternan los turnos para colocar su simbolo en una casilla vacia del tablero");
            //        Console.WriteLine("tanto las filas como las columnas se distinguen con los numeros 1, 2 y 3");
            //        Console.WriteLine("Si desea realizar su jugada en la primera casilla (fila 1, columna 1) escriba el numero 1");
            //        Console.WriteLine("|  1 |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la segunda casilla (fila 1, columna 2) escriba el numero 2");
            //        Console.WriteLine("|    | 2  |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la tercera casilla (fila 1, columna 3) escriba el numero 3");
            //        Console.WriteLine("|    |    | 3  |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la cuarta casilla (fila 2, columna 3) escriba el numero 4");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("| 4  |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la quinta casilla (fila 2, columna 3) escriba el numero 5");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    | 5  |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la sexta casilla (fila 2, columna 3) escriba el numero 6");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |  6 |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la septima casilla (fila 3, columna 1) escriba el numero 7");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|  7 |    |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la octava casilla (fila 3, columna 2) escriba el numero 8");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    | 8  |    |");
            //        Console.WriteLine("Si desea realizar su jugada en la novena casilla (fila 3, columna 3) escriba el numero 9");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |    |");
            //        Console.WriteLine("|--------------|");
            //        Console.WriteLine("|    |    |  9 |");
            //        Console.WriteLine("El objeto del Juego es consiguir alinear tres de sus simbolos en una fila, columna o diagonal antes que el otro jugador lo logre");
            //        Console.WriteLine("Buena suerte!!!!!");
            //        break;
            //    default:
            //        Console.WriteLine(" OPCION INVALIDA");
            //        Console.WriteLine(" INGRESE EL NUMERO 1 PARA JUGAR FRIO CALIENTE");
            //        Console.WriteLine(" INGRESE EL NUMERO 2 PARA JUGAR PIEDRA PAPEL O TIJERA");
            //        Console.WriteLine(" INGRESE EL NUMERO 3 PARA JUGAR TRIQUI");
            //        Console.WriteLine(" INGRESE EL NUMERO 4 PARA SALIR");

            //}
           
        }
    }
}
