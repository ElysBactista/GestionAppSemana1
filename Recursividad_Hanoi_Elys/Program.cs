using System;

class Program
{
    // Esto es lo primero de la imagen 1
    static int contador = 0;

    static void Main(string[] args)
    {
        // Esto es lo de la imagen 2 (Programa Principal)
        Console.WriteLine("=== TORRE DE HANOI ===");
        Console.Write("Ingrese número de discos: ");
        int discos = Convert.ToInt32(Console.ReadLine());

        contador = 0;
        Console.WriteLine("\nResolviendo para {0} discos:\n", discos);
        Hanoi(discos, "A", "C", "B");

        Console.WriteLine("\nTotal de movimientos: {0}", contador);
        Console.WriteLine("Fórmula: 2^{0} - 1 = {1}", discos, (int)Math.Pow(2, discos) - 1);

        // Esta es la parte de la tabla automática
        Console.WriteLine("\n--- Tabla de Movimientos ---");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} discos = {1} movimientos", i, (int)Math.Pow(2, i) - 1);
        }
        Console.ReadLine();
    }

    // Este es el método de la imagen 1
    static void Hanoi(int n, string origen, string destino, string auxiliar)
    {
        if (n == 1)
        {
            contador++;
            Console.WriteLine("Mov {0}: Disco {1} de {2} -> {3}", contador, n, origen, destino);
            return;
        }

        Hanoi(n - 1, origen, auxiliar, destino);

        contador++;
        Console.WriteLine("Mov {0}: Disco {1} de {2} -> {3}", contador, n, origen, destino);

        Hanoi(n - 1, auxiliar, destino, origen);
    }
}