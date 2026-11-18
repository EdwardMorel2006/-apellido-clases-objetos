using System;

namespace control_de_inventario
{
    internal class ClsProducto
    {
        private string codigo = "";
        private string nombre = "";
        private double precio;
        private int cantidad;

        // Constructor: usa las propiedades para que se ejecuten las validaciones.
        public ClsProducto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {//VALIDACION DEL NOMBRE EVITANDO UN ESPACIO EN BLANCO
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value.Trim();
            }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");
                precio = value;
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                cantidad = value;
            }
        }

        // Propiedad de solo lectura: se calcula sola.
        public double ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Imprime los datos del producto.
        public void MostrarInfo()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor Total: " + ValorTotal);
        }
    }
}
