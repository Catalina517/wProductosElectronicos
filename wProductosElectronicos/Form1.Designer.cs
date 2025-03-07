namespace wProductosElectronicos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxInventario = new System.Windows.Forms.ListBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.lblCantidadVenta = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblVenderProducto = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(138, 83);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(138, 150);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(138, 218);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadStock.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(8, 86);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(116, 16);
            this.lblNombreProducto.TabIndex = 3;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(12, 156);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(106, 16);
            this.lblPrecioProducto.TabIndex = 4;
            this.lblPrecioProducto.Text = "Precio Producto:";
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Location = new System.Drawing.Point(12, 221);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(101, 16);
            this.lblCantidadStock.TabIndex = 5;
            this.lblCantidadStock.Text = "Cantidad Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Control de Inventario de Productos Electrónicos";
            // 
            // listBoxInventario
            // 
            this.listBoxInventario.FormattingEnabled = true;
            this.listBoxInventario.ItemHeight = 16;
            this.listBoxInventario.Location = new System.Drawing.Point(15, 319);
            this.listBoxInventario.Name = "listBoxInventario";
            this.listBoxInventario.Size = new System.Drawing.Size(306, 180);
            this.listBoxInventario.TabIndex = 8;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(656, 322);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarProducto.TabIndex = 9;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(656, 370);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadVenta.TabIndex = 10;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Location = new System.Drawing.Point(399, 92);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(119, 16);
            this.lblBuscarProducto.TabIndex = 11;
            this.lblBuscarProducto.Text = "Producto a buscar:";
            // 
            // lblCantidadVenta
            // 
            this.lblCantidadVenta.AutoSize = true;
            this.lblCantidadVenta.Location = new System.Drawing.Point(451, 370);
            this.lblCantidadVenta.Name = "lblCantidadVenta";
            this.lblCantidadVenta.Size = new System.Drawing.Size(119, 16);
            this.lblCantidadVenta.TabIndex = 12;
            this.lblCantidadVenta.Text = "Cantidad de venta:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(536, 86);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 22);
            this.txtBusqueda.TabIndex = 15;
            // 
            // lblVenderProducto
            // 
            this.lblVenderProducto.AutoSize = true;
            this.lblVenderProducto.Location = new System.Drawing.Point(451, 325);
            this.lblVenderProducto.Name = "lblVenderProducto";
            this.lblVenderProducto.Size = new System.Drawing.Size(120, 16);
            this.lblVenderProducto.TabIndex = 16;
            this.lblVenderProducto.Text = "Producto a vender:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(473, 198);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(486, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(95, 257);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(94, 41);
            this.btnAgregarProducto.TabIndex = 19;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 514);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblVenderProducto);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblCantidadVenta);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.txtCantidadVenta);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.listBoxInventario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantidadStock);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxInventario;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.Label lblCantidadVenta;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblVenderProducto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}

