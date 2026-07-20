using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionApp
{
    public class SolicitudService : ISolicitudService
    {
        private readonly List<Solicitud> _solicitudes = new List<Solicitud>();

        // Método 1: Crear una solicitud
        public async Task CrearSolicitudAsync(Solicitud solicitud)
        {
            await Task.Delay(100);
            _solicitudes.Add(solicitud);
            Console.WriteLine($"[Sistema]: Solicitud '{solicitud.Titulo}' creada con éxito.");
        }

        // Método 2: Buscar una solicitud específica por su número ID
        public async Task<Solicitud> ObtenerPorIdAsync(int id)
        {
            await Task.Delay(100);
            return _solicitudes.FirstOrDefault(s => s.Id == id);
        }

        // Método 3: Traer la lista completa de solicitudes
        public async Task<IEnumerable<Solicitud>> ObtenerTodasAsync()
        {
            await Task.Delay(100);
            return _solicitudes;
        }

        // Método 4: Filtrar y traer solicitudes por su estado
        public async Task<IEnumerable<Solicitud>> ObtenerPorEstadoAsync(EstadoSolicitud estado)
        {
            await Task.Delay(100);
            return _solicitudes.Where(s => s.Estado == estado);
        }
    }
}