namespace Ejemplo1.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre{ get; set; }
        public string Descripcion { get; }

        public int Cantidad { get; set; }

        public Producto(int idProducto, string Nombre,string Descripcion,int Cantidad)
        {
            this.IdProducto = idProducto;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;
        }
    }
}
