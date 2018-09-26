using CapaConexion;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Negocio
    {
        private ConexionSQL conect1;
        public ConexionSQL Conect1 { get => conect1; set => conect1 = value; }
        public void configurarConexion()
        {
            this.Conect1 = new ConexionSQL();
            this.Conect1.NombreBaseDatos = "tipoPrueba";
            this.Conect1.NombreTabla = "transaccion";
            this.Conect1.CadenaConexion = @"Data Source=DESKTOP-L0UMAD2\SQLEXPRESS01;Initial Catalog=tipoPrueba;Integrated Security=True";
        }
        public void grabarTransaccion(Transaccion transaccion)
        {
            this.configurarConexion();
            this.Conect1.CadenaSQL = "INSERT INTO " + this.Conect1.NombreTabla
                + "(cod_producto, nom_producto, peso_producto, piezas_producidas, piezas_malas,piezas_totales, kilos_totales) values ('"
                + transaccion.Cod_producto + "', '"
                + transaccion.Nom_producto + "', "
                + transaccion.Peso_producto + ", "
                + transaccion.Piezas_producidas + ", "
                + transaccion.Piezas_malas + ", "
                + transaccion.Piezas_totales + ", "
                + transaccion.Kilos_totales + ");";
            this.Conect1.EsSelect = false;
            this.Conect1.conectar();
        }

        public DataSet listarFilas()
        {
            this.configurarConexion();
            this.Conect1.CadenaSQL = "Select nom_producto,piezas_totales, kilos_totales from " + this.Conect1.NombreTabla;
            this.Conect1.EsSelect = true;
            this.Conect1.conectar();
            return this.Conect1.DbDataSet;
        }
    }
}
