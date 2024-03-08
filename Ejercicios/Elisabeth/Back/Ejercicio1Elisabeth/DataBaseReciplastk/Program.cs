// See https://aka.ms/new-console-template for more information
using DataBaseReciplastk.Services;

Console.WriteLine("Bienvenidos!");

ProductsServices productsServices = new ProductsServices();

var exit = 0;
do
{
    Console.WriteLine();
    Console.WriteLine(" Digite la opcion deseada: 1, 2, 3, 4, 5, 6, 7 o 0 para salir: ");
    Console.WriteLine();
    Console.WriteLine(" 1. Mostrar todos los productos.");
    Console.WriteLine(" 2. Buscar por todos los nombres coincidentes.");
    Console.WriteLine(" 3. Filtrar por el primer nombre encontrado.");
    Console.WriteLine(" 4. Modificar Producto.");
    Console.WriteLine(" 5. Eliminar Producto.");
    Console.WriteLine(" 6. Crear Producto. ");
    Console.WriteLine(" 0. Salir.");
    Console.WriteLine();
    var opc = Console.ReadLine();
    var name = "";
    switch (opc)
    {
        case "1":
            productsServices.ShowAllProductsReciPlastk();
            break;
        case "2":
            Console.WriteLine("Digite el nombre del producto que sea buscar");
            name = Console.ReadLine();
            productsServices.FilterAllProductsForName(name);
            break;
        case "3":
            Console.WriteLine("Digite el nombre del producto que desea buscar");
            name = Console.ReadLine();
            productsServices.FilterFirstProductsforName(name);
            break;
        case "4":
            Console.WriteLine("Digite el nombre del producto que sea modificar: ");
            name = Console.ReadLine();
            productsServices.ModifyProduct(name);
            break;
            
        case "5":
            Console.WriteLine("Digite el nombre del producto que desea ELIMINAR: ");
            name = Console.ReadLine();
            productsServices.DeleteProduct(name);
            break;
        case "6":
            productsServices.CreateNewProduct();
            break;

        case "0":
            Console.WriteLine("Hasta pronto.");
            break;

        default: ;
            Console.WriteLine("Digite una opcion  Correcta o Cero para salir: ");
            break;
    }
} while (exit != 0);



