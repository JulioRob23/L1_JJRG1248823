internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1.Hola Mundo soy JULIO");
        Console.WriteLine("");
        Console.ReadKey();

        /* COMENTARIOS */

        Console.Write("2.Hola Mundo");
        Console.Write(" soy JULIO");
        Console.WriteLine("");
        Console.ReadLine();

        /* COMENTARIOS */

        Console.WriteLine("3.Ingrese su nombre:");
        string Nombre = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("4.Hola Mundo");
        Console.WriteLine("soy " + Nombre);
        Console.WriteLine("");

        /* COMENTARIOS */

        Console.Write("5.Hola Mundo");
        Console.Write(" soy " + Nombre);
        Console.ReadKey();

    }
}