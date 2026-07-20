
using System;
using System.Threading.Tasks;

namespace Async.Practica.Async
{
    public static class AsyncDemo
    {
        public static async Task Ejecutar()
        {


            Console.WriteLine("=== Prueba SINCRONA (Mala Practica) ===");
            var inicio = DateTime.Now;
            var resultado1 = ObtenerDatosSinAsync(1);
            var resultado2 = ObtenerDatosSinAsync(2);
            var resultado3 = ObtenerDatosSinAsync(3);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine($" Tiempo total: {(DateTime.Now - inicio).Seconds} segundos\n");

            Console.WriteLine("=== Pueba ASINCRONA (buena practica) ===");
            inicio = DateTime.Now;

            var tarea1 = ObtenerDatosDeBDAsync(1);
            var tarea2 = ObtenerDatosDeBDAsync(2);
            var tarea3 = ObtenerDatosDeBDAsync(3);


            var resultado = await Task.WhenAll(tarea1, tarea2, tarea3);

            Console.WriteLine(resultado[0]);
            Console.WriteLine(resultado[1]);
            Console.WriteLine(resultado[2]);
            Console.WriteLine($" Tiempo total: {(DateTime.Now - inicio).Seconds} segundos");
        }



        static async Task<String> ObtenerDatosDeBDAsync(int usuarioId)
        {
            Console.WriteLine($" → Consultando usuario {usuarioId}... ");
            await Task.Delay(2000);
            return $"Nombre: Usuario{usuarioId}, Email: user{usuarioId}@empresa.com";


        }

        static string ObtenerDatosSinAsync(int usuarioId)
        {
            Console.WriteLine($" → Consultando usuario {usuarioId} (bloquendo)...");
            Task.Delay(2000).Wait();
            return $"Nombre: Usuario{usuarioId}, Email: user{usuarioId}@empresa.com";

        }
    }
}
