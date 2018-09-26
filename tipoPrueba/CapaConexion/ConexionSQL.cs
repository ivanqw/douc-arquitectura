using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*permite agregar alertas de pantalla*/
using System.Windows.Forms;

namespace CapaConexion
{
    public class ConexionSQL
    {
        private string nombreBaseDatos;
        private string nombreTabla;
        private string cadenaConexion;
        private string cadenaSQL;
        private Boolean esSelect;
        private SqlConnection dbConnection;
        private DataSet dbDataSet;
        private SqlDataAdapter dbDataAdapter;

        public string NombreBaseDatos { get => nombreBaseDatos; set => nombreBaseDatos = value; }
        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public string CadenaSQL { get => cadenaSQL; set => cadenaSQL = value; }
        public Boolean EsSelect { get => esSelect; set => esSelect = value; }
        public SqlConnection DbConnection { get => dbConnection; set => dbConnection = value; }
        public DataSet DbDataSet { get => dbDataSet; set => dbDataSet = value; }
        public SqlDataAdapter DbDataAdapter { get => dbDataAdapter; set => dbDataAdapter = value; }

        //abrir conexion

        public void abrir()
        {
            try
            {
                this.DbConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al abrir la Conexion" + ex.Message);
            }
        }//fin abrir
        
        //cerrar conexion
        public void cerrar()
        {
            try
            {
                this.DbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la Conexion" + ex.Message);
            }
        }// fin cerrar

        //conectar
        public void conectar()
        {
            if(this.NombreBaseDatos.Length == 0)
            {
                MessageBox.Show("error nombre base de datos");
                return;
            }
            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("error nombre tabla de datos");
                return;
            }
            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("error cadena conexion de datos");
                return;
            }
            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("error cadena SQL");
                return;
            }

            try
            {
                this.DbConnection = new SqlConnection(this.cadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error cadena SQL" + ex.Message);
                return;
            }
            this.abrir();

            //envio de instrucciones 

            if (this.EsSelect) //Select
            {
                this.DbDataSet = new DataSet();
                try
                {
                    this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.DbConnection);
                    this.dbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al cargar data set" + ex.Message);
                }
            }
            else
            {
                try
                {
                    SqlCommand variableSql = new SqlCommand(this.CadenaSQL, this.DbConnection);
                    variableSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error instruccion sql" + ex.Message);
                }
            }
            this.cerrar();
        }//fin conectar

    }

}
