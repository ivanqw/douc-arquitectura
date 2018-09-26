namespace CapaEscritorio
{
    partial class PantallaMantenedorTransaccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPesoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPiezasProducidas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiezasMalas = new System.Windows.Forms.TextBox();
            this.txtPiezasTotales = new System.Windows.Forms.TextBox();
            this.txtKilosTotales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKilosTotales = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(232, 88);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(236, 20);
            this.txtCodigoProducto.TabIndex = 0;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(113, 91);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoProducto.TabIndex = 1;
            this.lblCodigoProducto.Text = "Codigo Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(232, 126);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(236, 20);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtPesoProducto
            // 
            this.txtPesoProducto.Location = new System.Drawing.Point(232, 169);
            this.txtPesoProducto.Name = "txtPesoProducto";
            this.txtPesoProducto.Size = new System.Drawing.Size(236, 20);
            this.txtPesoProducto.TabIndex = 3;
            this.txtPesoProducto.TextChanged += new System.EventHandler(this.txtPesoProducto_TextChanged);
            this.txtPesoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoProducto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso Producto";
            // 
            // txtPiezasProducidas
            // 
            this.txtPiezasProducidas.Location = new System.Drawing.Point(116, 332);
            this.txtPiezasProducidas.Name = "txtPiezasProducidas";
            this.txtPiezasProducidas.Size = new System.Drawing.Size(108, 20);
            this.txtPiezasProducidas.TabIndex = 6;
            this.txtPiezasProducidas.TextChanged += new System.EventHandler(this.txtPiezasProducidas_TextChanged);
            this.txtPiezasProducidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiezasProducidas_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Piezas Producidas";
            // 
            // txtPiezasMalas
            // 
            this.txtPiezasMalas.Location = new System.Drawing.Point(263, 332);
            this.txtPiezasMalas.Name = "txtPiezasMalas";
            this.txtPiezasMalas.Size = new System.Drawing.Size(108, 20);
            this.txtPiezasMalas.TabIndex = 8;
            this.txtPiezasMalas.TextChanged += new System.EventHandler(this.txtPiezasMalas_TextChanged);
            this.txtPiezasMalas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiezasMalas_KeyPress);
            // 
            // txtPiezasTotales
            // 
            this.txtPiezasTotales.Location = new System.Drawing.Point(411, 332);
            this.txtPiezasTotales.Name = "txtPiezasTotales";
            this.txtPiezasTotales.Size = new System.Drawing.Size(108, 20);
            this.txtPiezasTotales.TabIndex = 9;
            this.txtPiezasTotales.TextChanged += new System.EventHandler(this.txtPiezasTotales_TextChanged);
            // 
            // txtKilosTotales
            // 
            this.txtKilosTotales.Location = new System.Drawing.Point(556, 332);
            this.txtKilosTotales.Name = "txtKilosTotales";
            this.txtKilosTotales.Size = new System.Drawing.Size(108, 20);
            this.txtKilosTotales.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Piezas Malas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Piezas Totales";
            // 
            // lblKilosTotales
            // 
            this.lblKilosTotales.AutoSize = true;
            this.lblKilosTotales.Location = new System.Drawing.Point(553, 307);
            this.lblKilosTotales.Name = "lblKilosTotales";
            this.lblKilosTotales.Size = new System.Drawing.Size(67, 13);
            this.lblKilosTotales.TabIndex = 13;
            this.lblKilosTotales.Text = "Kilos Totales";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(149, 393);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(263, 393);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(368, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PantallaMantenedorTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblKilosTotales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKilosTotales);
            this.Controls.Add(this.txtPiezasTotales);
            this.Controls.Add(this.txtPiezasMalas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPiezasProducidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesoProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Name = "PantallaMantenedorTransaccion";
            this.Text = "PantallaMantenedorTransaccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPesoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPiezasProducidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiezasMalas;
        private System.Windows.Forms.TextBox txtPiezasTotales;
        private System.Windows.Forms.TextBox txtKilosTotales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKilosTotales;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
    }
}