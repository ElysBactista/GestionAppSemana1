using System;
using System.Threading.Tasks;

namespace GestionApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ISolicitudService servicio = new SolicitudService();

            Usuario usuarioPrueba = new Usuario(1, "Tu Nombre", "correo@pasantia.com", "Pasante");

            bool continuar = true;
            int contadorId = 1;

            Console.WriteLine("=== SISTEMA DE GESTIÓN DE SOLICITUDES ===");

            while (continuar)
            {
                try
                {
                    Console.WriteLine("\nSeleccione una opción:");
                    Console.WriteLine("1. Crear una nueva solicitud");
                    Console.WriteLine("2. Ver todas las solicitudes");
                    Console.WriteLine("3. Buscar solicitud por ID");
                    Console.WriteLine("4. Salir");
                    Console.Write("Opción: ");

                    string opcion = Console.ReadLine();
                    Console.Clear();
                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese el título de la solicitud: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Ingrese la descripción: ");
                            string descripcion = Console.ReadLine();

                            Solicitud nueva = new Solicitud(contadorId++, titulo, descripcion, usuarioPrueba.id);
                            await servicio.CrearSolicitudAsync(nueva);
                            break;

                        case "2":
                            var todas = await servicio.ObtenerTodasAsync();
                            Console.WriteLine("\n--- LISTA DE SOLICITUDES ---");
                            foreach (var sol in todas)
                            {
                                Console.WriteLine($"[ID: {sol.Id}] {sol.Titulo} - Estado: {sol.Estado} (Creada: {sol.FechaCreacion})");
                            }
                            break;

                        case "3":
                            Console.Write("Ingrese el ID a buscar: ");
                            int idBuscar = int.Parse(Console.ReadLine());

                            var encontrada = await servicio.ObtenerPorIdAsync(idBuscar);

                            if (encontrada != null)
                            {
                                Console.WriteLine($"\nEncontrada: {encontrada.Titulo} | Descripción: {encontrada.Descripcion} | Estado: {encontrada.Estado}");
                            }
                            else
                            {
                                Console.WriteLine("[Sistema]: No se encontró ninguna solicitud con ese ID.");
                            }
                            break;

                        case "4":
                            continuar = false;
                            Console.WriteLine("Saliendo del sistema...");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("[ERROR COMPROBADO]: Por favor, ingrese un número válido. No se permiten letras en este campo.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR INESPERADO]: Ocurrió un problema: {ex.Message}");
                }
            }
        }
    }
}