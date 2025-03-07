using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wProductosElectronicos
{
    public partial class Form1 : Form
    {
        private Inventario inventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            if (decimal.TryParse(txtPrecioProducto.Text, out decimal precio) && int.TryParse(txtCantidadStock.Text, out int cantidad))
            {
                inventario.AgregarProducto(nombre, precio, cantidad);
                ActualizarLista();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para precio y cantidad.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtBusqueda.Text.Trim(); 

            if (string.IsNullOrEmpty(nombreProducto))
            {
                lblResultado.Text = "Ingrese un nombre de producto.";
                return;
            }

            ProductoElectronico producto = inventario.BuscarProducto(nombreProducto);

            if (producto != null)
            {
                lblResultado.Text = $"Stock disponible: {producto.CantidadStock}";
            }
            else
            {
                lblResultado.Text = "Producto no encontrado.";
            }
        }

        
        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del producto.");
                return;
            }

            if (!int.TryParse(txtCantidadVenta.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para vender.");
                return;
            }

            if (inventario.VenderProducto(nombre, cantidad))
            {
                MessageBox.Show($"Venta realizada: {cantidad} unidad(es) de '{nombre}'.");
                ActualizarLista();
            }
        }



        public void ActualizarLista()
        {
            listBoxInventario.Items.Clear();
            foreach (var producto in inventario.ObtenerInventario())
            {
                listBoxInventario.Items.Add($"{producto.Nombre} - ${producto.Precio} - Stock: {producto.CantidadStock}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadStock.Clear();
            txtBuscarProducto.Clear();
            txtCantidadVenta.Clear();
        }
    }
}



