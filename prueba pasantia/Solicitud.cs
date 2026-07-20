using System;
namespace GestionApp
{
    public class Solicitud
    {
        public int Id { get; set; }
        public string Titulo { get; set;}
        public string Descripcion { get; set; }
        public EstadoSolicitud Estado {  get; set; }
        public int UsuarioId {  get; set; }
        public DateTime FechaCreacion { get; set; }


         public Solicitud(int id, string titulo, string descrpcion, int usuarioId)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descrpcion;
            UsuarioId = usuarioId;
            Estado = EstadoSolicitud.Pendiente;
            FechaCreacion = DateTime.Now;
        }

    }
}