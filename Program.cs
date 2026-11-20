using System;

namespace control_de_inventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Guarda los tres productos.
            Producto[] productos = new Producto[3];

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Producto {i + 1}");

                string codigo = LeerTexto("Ingrese el código: ");
                string nombre = LeerNombre();
                decimal precio = LeerPrecio();
                int cantidad = LeerCantidad();

                // Crea el producto con los datos ingresados.
                productos[i] = new Producto(codigo, nombre, precio, cantidad);
            }

            Console.WriteLine("\nRESULTADOS");

            foreach (Producto producto in productos)
            {
                producto.MostrarInfo();
            }

            Console.ReadKey();
        }

        static string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine() ?? "";
        }

        static string LeerNombre()
        {
            while (true)
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(nombre))
                    return nombre;

                Console.WriteLine("El nombre no puede estar vacío.");
            }
        }

        static decimal LeerPrecio()
        {
            while (true)
            {
                Console.Write("Ingrese el precio (mayor que 0): ");
                string entrada = Console.ReadLine() ?? "";

                if (decimal.TryParse(entrada, out decimal precio) && precio > 0)
                    return precio;

                Console.WriteLine("Ingrese un precio válido mayor que 0.");
            }
        }

        static int LeerCantidad()
        {
            while (true)
            {
                Console.Write("Ingrese la cantidad (0 o mayor): ");
                string entrada = Console.ReadLine() ?? "";

                if (int.TryParse(entrada, out int cantidad) && cantidad >= 0)
                    return cantidad;

                Console.WriteLine("Ingrese una cantidad válida.");
            }
        }
    }
}
