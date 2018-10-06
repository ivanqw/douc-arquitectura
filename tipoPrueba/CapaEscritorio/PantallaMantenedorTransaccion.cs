using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;
using CapaNegocio;
namespace CapaEscritorio

{
    public partial class PantallaMantenedorTransaccion : Form
    {
        public PantallaMantenedorTransaccion()
        {
            InitializeComponent();
            noEditables();
        }

        private void noEditables()
        {
            this.txtPiezasTotales.ReadOnly = true;
            this.txtKilosTotales.ReadOnly = true;
            this.txtPiezasTotales.BackColor = Color.White;
            this.txtKilosTotales.BackColor = Color.White;

        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaTextBoxVacios(this))
            {
                if(int.Parse(this.txtPiezasTotales.Text) >= 0)
                {
                    try
                    {
                        Transaccion auxTransaccion = new Transaccion();
                        Negocio auxNegocio = new Negocio();

                        auxTransaccion.Cod_producto = this.txtCodigoProducto.Text;
                        auxTransaccion.Nom_producto = this.txtNombreProducto.Text;
                        auxTransaccion.Peso_producto = int.Parse(this.txtPesoProducto.Text);
                        auxTransaccion.Piezas_producidas = int.Parse(this.txtPiezasProducidas.Text);
                        auxTransaccion.Piezas_malas = int.Parse(this.txtPiezasMalas.Text);

                        
                        auxTransaccion.Piezas_totales = int.Parse(this.txtPiezasTotales.Text);
                        auxTransaccion.Kilos_totales = int.Parse(this.txtKilosTotales.Text);
                        
                        /*
                        auxNegocio.totalesTransanccion(auxTransaccion);
                        */
                        auxNegocio.grabarTransaccion(auxTransaccion);

                        this.limpiar(this);
                        MessageBox.Show("Transacción guardada","exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio el siguiente error" + ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Las piezas malas no pueden ser mayor a los producidas");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son ogligatorios");
            }  
        }


        public bool ValidaTextBoxVacios(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void limpiar(Form formulario)
        {
            foreach(Control control in formulario.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    control.Text = string.Empty;
                }   
            }
            this.txtPiezasTotales.Text = string.Empty;
            this.txtKilosTotales.Text = string.Empty;
            /*
            this.txtCodigoProducto.Text = "";
            this.txtNombreProducto.Text ="";
            this.txtPesoProducto.Text = "";
            this.txtPiezasProducidas.Text = "";
            this.txtPiezasMalas.Text = "";
            
            */
        }

        private void producidasVsMalas()
        {
            if (this.txtPiezasProducidas.Text.Length > 0 && this.txtPiezasMalas.Text.Length > 0 )
            {
                if (int.Parse(this.txtPiezasMalas.Text) > int.Parse(this.txtPiezasProducidas.Text)) {
                    this.txtPiezasMalas.BackColor = Color.Orange;
                    this.txtPiezasProducidas.BackColor = Color.Orange;
                    MessageBox.Show("Las piezas malas no pueden ser mayor a los producidas");
                    return;
                }
                else
                {
                    this.txtPiezasProducidas.BackColor = Color.White;
                    this.txtPiezasMalas.BackColor = Color.White;
                }  
            }
        }
        private void calculoPiezasTotal()
        {
            
            int total;
            if (this.txtPiezasProducidas.Text != "")
            {
                int malas = 0;
                if(this.txtPiezasMalas.Text != "")
                {
                    malas = int.Parse(this.txtPiezasMalas.Text);
                }
                total = int.Parse(this.txtPiezasProducidas.Text) - malas;
                this.txtPiezasTotales.Text = total.ToString();
            }
        }
        private void soloNumeros(KeyPressEventArgs e)
        {
            /*variable KeyPressEventArgs e // viene del evento keypress*/
            //si se ingresa un caracter numero y un caracter diferente de borrar
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números Positivos");
                //cancela texto ingresado
                e.Handled = true;
            }
        }

        private void txtPiezasProducidas_TextChanged(object sender, EventArgs e)
        {
            producidasVsMalas();
            calculoPiezasTotal();
        }

        private void txtPiezasMalas_TextChanged(object sender, EventArgs e)
        {
            producidasVsMalas();
            calculoPiezasTotal();
        }

        private void pesoTotal()
        {
            
            if (this.txtPiezasTotales.Text.Length > 0 && this.txtPesoProducto.Text.Length > 0)
            {
                int piezas = int.Parse(this.txtPiezasTotales.Text);
                int peso = int.Parse(this.txtPesoProducto.Text);
                int total = piezas * peso;
                this.txtKilosTotales.Text = total.ToString();
            }
        }

        private void txtPiezasProducidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtPiezasMalas_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtPiezasTotales_TextChanged(object sender, EventArgs e)
        {
            pesoTotal();
        }

        private void txtPesoProducto_TextChanged(object sender, EventArgs e)
        {
            pesoTotal();
        }

        private void txtPesoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            PantallaListar pListar = new PantallaListar();
            pListar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Environment.Exit(0);
        }
    }
}
