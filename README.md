A# Control de inventario TecnoPunto

**Autores:** [Daniel Eduardo Dupuy 2024-3865. Eddy Antonio Mora Díaz 0224-2026.  Edward Alberto Morel Ramirez 2025-1672.  ]  

**Tema:** Clases, objetos y propiedades  
**Profesor:** Gamalier Reyes del Carmen

## Descripción

Programa de consola en C# que representa productos del inventario de la tienda TecnoPunto. Cada producto tiene código, nombre, precio y cantidad. El programa valida los datos y calcula el valor total en existencia multiplicando el precio por la cantidad.

## Datos de entrada

El programa recibe los datos de cada producto:

- Código
- Nombre
- Precio
- Cantidad disponible

## Datos que procesa

- Comprueba que el nombre no esté vacío.
- Comprueba que el precio sea mayor que cero.
- Comprueba que la cantidad no sea negativa.
- Calcula el valor total de cada producto: `precio × cantidad`.
- Maneja los datos inválidos mostrando un mensaje claro.

## Datos de salida

Muestra en consola la información de cada producto:

- Código
- Nombre
- Precio
- Cantidad
- Valor total en existencia

## Archivos del proyecto

- `Producto.cs`: contiene la clase `Producto`, sus propiedades, validaciones y el cálculo del valor total.
- `Program.cs`: contiene el punto de inicio del programa y crea y muestra al menos tres productos.

## Cómo ejecutar

Abre la solución en Visual Studio y ejecuta el proyecto de consola. El programa mostrará en pantalla la información de los productos.

## Repositorio

[Ver el repositorio en GitHub](PEGA_AQUÍ_EL_ENLACE_DE_TU_REPOSITORIO)
