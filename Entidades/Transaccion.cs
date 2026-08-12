namespace APIBIBLIOTECA.Capamodelo
{
    public class Transaccion
    {
        public int Id { get; set; }
        public string TipoTransaccion { get; set; } // "Préstamo" o "Devolución"
        public int IdLibro { get; set; }
        public Libro Libro { get; set; } // Relación con la clase Libro
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } // Relación con la clase Usuario
        public DateTime Fecha { get; set; }
    }
}
