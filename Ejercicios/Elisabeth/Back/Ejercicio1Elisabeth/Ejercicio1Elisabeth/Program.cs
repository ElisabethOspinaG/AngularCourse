// See https://aka.ms/new-console-template for more information
using Ejercicio1Elisabeth;

Console.WriteLine("Hello, World!");

var consolaJuego = new ConsolaDeJuegos();

var opcionJuego = consolaJuego.pedirJuego();


consolaJuego.jugar(opcionJuego);


