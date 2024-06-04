using AP1_P1_KimberlinSantiago.Models;
using System.Collections.Generic;
using System.Linq;
using AP1_P1_KimberlinSantiago.Models;

namespace AP1_P1_KimberlinSantiago.Services
{
    public class ArticuloService
    {
        private List<Articulo> articulos = new List<Articulo>();

        public IEnumerable<Articulo> All
        {
            get
            {
                return articulos;
            }
        }

        public Articulo GetById(int id)
        {
            return articulos.FirstOrDefault(a => a.ArticuloId == id);
        }

        public void Add(Articulo articulo)
        {
            articulos.Add(articulo);
        }

        public void Update(Articulo articulo)
        {
            var existingArticulo = GetById(articulo.ArticuloId);
            if (existingArticulo != null)
            {
                existingArticulo.Descripcion = articulo.Descripcion;
                existingArticulo.Costo = articulo.Costo;
                existingArticulo.Ganancia = articulo.Ganancia;
                existingArticulo.Precio = articulo.Precio;
            }
        }

        private object GetById(object articuloId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var articulo = GetById(id);
            if (articulo != null)
            {
                articulos.Remove(articulo);
            }
        }
    }

    internal class Articulo
    {
        public int ArticuloId { get; internal set; }
        public object Descripcion { get; internal set; }
        public object Costo { get; internal set; }
        public object Ganancia { get; internal set; }
        public object Precio { get; internal set; }
    }
}
