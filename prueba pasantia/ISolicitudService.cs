using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionApp
{
    public interface ISolicitudService
    {
        Task CrearSolicitudAsync(Solicitud solicitud);
        Task<Solicitud> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Solicitud>> ObtenerTodasAsync();
        Task<IEnumerable<Solicitud>> ObtenerPorEstadoAsync(EstadoSolicitud estado);

    }
}