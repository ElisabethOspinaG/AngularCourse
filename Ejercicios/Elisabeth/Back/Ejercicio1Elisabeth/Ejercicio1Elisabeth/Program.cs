// See https://aka.ms/new-console-template for more information
using Ejercicio1Elisabeth;

Console.WriteLine(" BIENVENIDO A LA CONSOLA DE JUEGOS ELISABETH");
Console.WriteLine("........................................");


var consolaJuego = new ConsolaDeJuegos();

var opcionJuego = consolaJuego.PedirJuego();

consolaJuego.Jugar(opcionJuego);
//var ReglasJuegoTriqui = new ReglasBasicas();
//var reglasTriqui = ReglasJuegoTriqui.ReglasJuego(opcGame);



