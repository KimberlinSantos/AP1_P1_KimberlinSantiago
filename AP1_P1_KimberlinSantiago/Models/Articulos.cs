namespace AP1_P1_KimberlinSantiago.Models
{
    public class Articulos
    {
        //ArticuloID, DESCRIPCION,COSTO,GANANCIA,PRECIO.

        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; }
      
        public decimal Precio { get; set; }

        public Articulos(int ArticuloId, string Descripcion, decimal Costo, decimal Ganancia, decimal Precio)
        {
            ArticuloId = ArticuloId;
            Descripcion = Descripcion;
            Costo = Costo;
            Ganancia = Ganancia;
            Precio = Precio;
        }
    }
}

    

