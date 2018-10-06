using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Producto
    {
        private String codigo, nombre;
        private int precio, stock;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
    public class Venta
    {
        private String cliente, cod_producto;
        private int cantidad, neto;
        public string Cliente { get => cliente; set => cliente = value; }
        public string Cod_producto { get => cod_producto; set => cod_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Neto { get => neto; set => neto = value; }
    }
}
