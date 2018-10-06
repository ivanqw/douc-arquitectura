using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//propias
using CapaConexion;
using CapaModelo;

namespace CapaNegocio
{
    public class Negocio
    {
        

        private ConexionSQL conexion;
        public ConexionSQL Conexion { get => conexion; set => conexion = value; }

        public void configurarConexion()
        {
            this.Conexion = new ConexionSQL
            {
                NombreBaseDatos = "tipoPrueba2",
                NombreTabla = "Producto",
                CadenaConexion = @"Data Source=DESKTOP-L0UMAD2\SQLEXPRESS01;Initial Catalog=tipoPrueba2;Integrated Security=True"
            };
        }

        public void InsertProducto(Producto producto)
        {
            this.configurarConexion();
            this.Conexion.CadenaSQL = "INSERT INTO PRODUCTO (cod_producto, nom_producto, precio_unitario, stock ) values ('"
                + producto.Codigo + "', '"
                + producto.Nombre + "', "
                + producto.Precio + ", "
                + producto.Stock + "); ";
            this.Conexion.EsSelect = false;
            this.Conexion.conectar();
        }

        public void RestaStock(Producto producto)
        {
            this.configurarConexion();
            this.Conexion.CadenaSQL = "UPDATE PRODUCTO SET " +
                                                    " stock = " + producto.Stock
                                                    + " where cod_producto = '" + producto.Codigo + "';";
            this.Conexion.EsSelect = false;
            this.Conexion.conectar();
        }


        public String calculoIva( int precio)
        {
            Double Iva = 0.19;
            double valor_iva = Iva * precio;
            return valor_iva.ToString();
        }
        public int PrecioNeto(int cantidad, int precio)
        {
            int result = cantidad * precio;
            return result;
        }
        public String PrecioTOTAL(int neto, double iva)
        {
            double total = (neto + iva);
            return Math.Truncate(total).ToString();
        }

        public Producto BuscarProducto(string codigo)
        {
            this.configurarConexion();
            this.Conexion.CadenaSQL = "SELECT * FROM producto where cod_producto = '" + codigo + "'";

            this.Conexion.EsSelect = true;
            this.Conexion.conectar();
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            dt = this.Conexion.DbDataSet.Tables[this.Conexion.NombreTabla];
            try
            {
                auxProducto.Codigo = (String)dt.Rows[0]["cod_producto"];
                auxProducto.Nombre = (String)dt.Rows[0]["nom_producto"];
                auxProducto.Precio = (int)dt.Rows[0]["precio_unitario"];
                auxProducto.Stock = (int)dt.Rows[0]["stock"];
            }
            catch (Exception)
            {
                MessageBox.Show("No existe con codigo" + codigo, "Error");
                
            }
            return auxProducto;
        } //Fin buscar

    }

    public class NegocioVenta
    {
        
        private ConexionSQL conexion;
        public ConexionSQL Conexion { get => conexion; set => conexion = value; }

        public void configurarConexion()
        {
            this.Conexion = new ConexionSQL
            {
                NombreBaseDatos = "tipoPrueba2",
                NombreTabla = "Venta",
                CadenaConexion = @"Data Source=DESKTOP-L0UMAD2\SQLEXPRESS01;Initial Catalog=tipoPrueba2;Integrated Security=True"
            };

        }
        public void Insert(Venta venta)
        {
            this.configurarConexion();
            this.Conexion.CadenaSQL = "INSERT INTO " + this.Conexion.NombreTabla + "(cliente, cod_producto, cantidad, total_neto ) values ('"
                + venta.Cliente + "', '"
                + venta.Cod_producto + "', "
                + venta.Cantidad + ", "
                + venta.Neto + "); ";
            this.Conexion.EsSelect = false;
            this.Conexion.conectar();
        }
        public DataSet listarFilas()
        //muestra las filas en el data grid
        {
            this.configurarConexion();
            this.Conexion.CadenaSQL = "Select * from " + this.Conexion.NombreTabla;
            this.Conexion.EsSelect = true;
            this.Conexion.conectar();
            return this.Conexion.DbDataSet;
        }


        public String totalVentas()
        {
            String totalVentas = String.Empty;
            this.configurarConexion();
            this.Conexion.CadenaSQL = "select sum(total_neto) as result from " + this.Conexion.NombreTabla;

            this.Conexion.EsSelect = true;
            this.Conexion.conectar();
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            dt = this.Conexion.DbDataSet.Tables[this.Conexion.NombreTabla];
            try
            {
                totalVentas = ((int)dt.Rows[0]["result"]).ToString();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex , "Error");
            }
            return totalVentas;
        } //Fin buscar
    }
}
