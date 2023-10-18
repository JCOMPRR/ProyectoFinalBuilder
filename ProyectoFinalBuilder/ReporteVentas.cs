using System.Text;

namespace ProyectoFinalBuilder
{
    public class ReporteVentas
    {
        public string Nombre;
        public DateTime Fecha;
        public List<string> Productos = new List<string>();
        public List<int> Cantidades = new List<int>();
        public decimal totalVentas;

        public void AgregarTitulo(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarFecha(DateTime fecha)
        {
            Fecha = fecha;
        }

        public void AgregarProductos(string producto, int cantidad, int precio)
        {
            Productos.Add(producto);
            Cantidades.Add(cantidad);
            totalVentas += precio * cantidad; 
        }

        public string GetReporte()
        {
            var detalle = new StringBuilder();
            for (int i = 0; i < Productos.Count; i++)
            {
                detalle.AppendLine($"{Productos[i]} - {Cantidades[i]}");
            }
            var reporte = $"" +
                $"Titulo: {Nombre}" +
                $"Fecha: {Fecha}" +
                $"Detalle: {detalle.ToString()}" +
                $"Total: {totalVentas}";
            
            return reporte;
        }
    }
}
