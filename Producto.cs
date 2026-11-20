using System;

namespace control_de_inventario
{
    // Representa un producto del inventario.
    internal class Producto
    {
        // Campos privados: guardan los datos internamente.
        private string codigo = "";
        private string nombre = "";
        private decimal precio;
        private int cantidad;

        // Permite consultar y asignar el código del producto.
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        // El nombre no puede estar vacío.
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                nombre = value;
            }
        }

        // El precio debe ser mayor que cero.
        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que 0.");

                precio = value;
            }
        }

        // La cantidad puede ser cero, pero no negativa.
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

        // Propiedad de solo lectura: calcula precio por cantidad.
        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Constructor: recibe los datos y los asigna usando las validaciones.
        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Muestra en pantalla toda la información del producto.
        public void MostrarInfo()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio:F2}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Valor total: {ValorTotal:F2}");
            Console.WriteLine("------------------------------");
        }
    }
}
