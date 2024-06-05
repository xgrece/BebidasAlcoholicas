using BebidasAlcoholicas.Models;
using System;


class Program
{
    static void Main(string[] args)
    {
        /*
       int[] numeros = new int[5] { 1, 2, 3, 4, 9 };
        int numero1 = numeros[0];

        Console.WriteLine("Llamando al primer numero de la lista = " + numero1);
        Console.WriteLine("El largo de la lista es de = "+ numeros.Length);

        Console.WriteLine("----------------------------");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Iteracion: " + i + " - " + numeros[i]);
        }

        Console.WriteLine("----------------------------");

        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Bebida bebida = new Bebida();
        Bebida bebida2 = new Bebida("fanta", 500);

        Vino vinoUno = new Vino(50, "tinto");

        bebida.nombre = "Coquita";
        bebida.cantidad = 1000;
        bebida.tomarse(100);
        bebida2.tomarse(100);

        Console.WriteLine("----------------------------");

        Console.WriteLine("Le quedan " + bebida.cantidad + " a la bebida: " + bebida.nombre);
        
        Console.WriteLine("----------------------------");

        Console.WriteLine(bebida2.cantidad);

        Console.WriteLine("----------------------------");

        mostrarRecomendacion(vinoUno);
        Cerveza cerveza = new Cerveza();
        mostrarRecomendacion(cerveza);


        */

        CervezaBD cervezaDB = new CervezaBD();

        var cervezas = cervezaDB.getCervezas();

        // Encabezados de tabla
        Console.WriteLine("+----------------------+---------------+-----------+---------+");
        Console.WriteLine("| Nombre               | Marca         | Cantidad  | Alcohol |");
        Console.WriteLine("+----------------------+---------------+-----------+---------+");

        // Datos de la tabla
        foreach (var c in cervezas)
        {
            Console.WriteLine($"| {c.Nombre,-20} | {c.marca,-13} | {c.Alcohol,-9} | {c.Cantidad,-7} |");
        }

        // Pie de tabla
        Console.WriteLine("+----------------------+---------------+-----------+---------+");

        Console.ReadKey();
        Console.ReadLine();


    }

    static void mostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
    {
        bebidaAlcoholica.MaxRecomendado();
    }
}