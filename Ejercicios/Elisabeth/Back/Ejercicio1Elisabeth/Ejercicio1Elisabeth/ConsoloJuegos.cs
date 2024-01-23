using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Elisabeth
{
    internal class ConsolaDeJuegos
    {
        public int pedirJuego ()
        {
            Console.WriteLine(" BIENVENIDO A LA CONSOLO DE JUEGOS ELISABETH");
            Console.WriteLine("........................................");
            Console.WriteLine(" QUE JUEGO DESEA JUGAR: ................");
            Console.WriteLine("1. FRIO - TIBIO - CALIENTE");
            Console.WriteLine("2. PIEDRA - PAPEL - TIJERA");
            Console.WriteLine("3. TRIQUI");
            Console.WriteLine("INGRESE LA OPCION DESEADA: ");
            var opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }

        public int pedirNumeroUnoAlNueve()
        {
            Console.WriteLine("Ingrese un numero del 1 al 10: ");
            var numElegido = Convert.ToInt32(Console.ReadLine());
            return numElegido;
        }

        public void jugar (int opc)
        {
            if (opc == 1)

            {
              
                var numRandom = 9;
                Console.WriteLine("BIENVENIDO AL JUEGO FRIO - TIBIO - CALIENTE");
                Console.WriteLine("____________________________________");
                var numElegido = pedirNumeroUnoAlNueve();

                if (numElegido != 9)
                {
                    while (numElegido != 9)
                    {
                        if (numElegido == 1 || numElegido == 2 || numElegido == 3)
                        {
                            Console.WriteLine(" usted esta frio");
                            Console.WriteLine("Ingrese nuevamnte un numero del 1 al 10: ");
                            numElegido = Convert.ToInt32(Console.ReadLine());

                        };
                        if (numElegido == 4 || numElegido == 5 || numElegido == 6)
                        {
                            Console.WriteLine(" usted esta tibio");
                            Console.WriteLine("Ingrese nuevamnte un numero del 1 al 10: ");
                            numElegido = Convert.ToInt32(Console.ReadLine());
                        }
                        if (numElegido == 7 || numElegido == 8 || numElegido == 10)
                        {
                            Console.WriteLine(" usted esta caliente");
                            Console.WriteLine("Ingrese nuevamnte un numero del 1 al 10: ");
                            numElegido = Convert.ToInt32(Console.ReadLine());
                        }
                        if (numElegido == 0)
                        {
                            Console.WriteLine(" opcion invalida, ingrese un numero del 1 al 10");
                            Console.WriteLine("Ingrese nuevamnte un numero del 1 al 10: ");
                            numElegido = Convert.ToInt32(Console.ReadLine());
                        }

                    }
                    
                }
                else
                {
                    Console.Write("Correcto, usted ha ganado. El numero era: " + numRandom);
                }
               

            }
            if (opc == 2)
            {
                Console.WriteLine("BIENVENIDO AL JUEGO PIEDRA - PAPEL - TIJERA");
                Console.WriteLine("____________________________________");
                
            }
            if (opc == 3)
            {
                var numRandom = 9;
                Console.WriteLine("BIENVENIDO AL JUEGO OTRO");
                Console.WriteLine("____________________________________");
                Console.WriteLine("Ingrese un numero del 1 al 10: ");
                var numElegido = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
