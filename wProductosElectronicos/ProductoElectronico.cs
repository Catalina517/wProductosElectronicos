using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wProductosElectronicos
{
    public class ProductoElectronico
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }

        public ProductoElectronico(string nombre, decimal precio, int cantidadStock)
        {
            Nombre = nombre; 
            Precio = precio;
            CantidadStock = cantidadStock;
        }
    }

    public class Inventario
    {
        private List<ProductoElectronico> productos = new List<ProductoElectronico>();
        private string archivo = "inventario.txt";

        public Inventario()
        {
            CargarDesdeArchivo();
        }

        public void AgregarProducto(string nombre, decimal precio, int cantidadStock)
        {
            var productoExistente = productos.FirstOrDefault(p => p.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
            if (productoExistente != null)
            {
                productoExistente.CantidadStock += cantidadStock;
            }
            else
            {
                productos.Add(new ProductoElectronico(nombre, precio, cantidadStock));
            }
            GuardarEnArchivo();
        }

        public bool VenderProducto(string nombre, int cantidad)
        {
            nombre = nombre.Trim().ToLower(); 
            Console.WriteLine($"Buscando producto: '{nombre}'");

            if (productos.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return false;
            }

            foreach (var prod in productos)
            {
                Console.WriteLine($"En inventario: '{prod.Nombre.Trim().ToLower()}', Stock: {prod.CantidadStock}");
            }

   
            var producto = productos.FirstOrDefault(p => p.Nombre.Trim().ToLower() == nombre);

            if (producto == null)
            {
                MessageBox.Show($"El producto '{nombre}' no existe en el inventario.");
                return false;
            }

            if (producto.CantidadStock < cantidad)
            {
                MessageBox.Show($"Stock insuficiente. Solo hay {producto.CantidadStock} disponibles.");
                return false;
            }

            producto.CantidadStock -= cantidad;
            GuardarEnArchivo();

            Console.WriteLine($"Venta realizada: {nombre} - Cantidad vendida: {cantidad}");
            return true;
        }



        public List<ProductoElectronico> ObtenerInventario()
        {
            return productos;
        }

        public ProductoElectronico BuscarProducto(string nombre)
        {
            return productos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        private void GuardarEnArchivo()
        {
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                foreach (var producto in productos)
                {
                    writer.WriteLine($"{producto.Nombre};{producto.Precio};{producto.CantidadStock}");
                }
            }
        }

        private void CargarDesdeArchivo()
        {
            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    if (datos.Length == 3 && decimal.TryParse(datos[1], out decimal precio) && int.TryParse(datos[2], out int cantidad))
                    {
                        productos.Add(new ProductoElectronico(datos[0], precio, cantidad));
                    }
                }
            }
        }

    }
}

