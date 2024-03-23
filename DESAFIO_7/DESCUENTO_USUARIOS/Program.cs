using System;
using System.Collections.Generic;

class Program
{
    static List<double> CalcularDescuentoCompras(List<List<double>> compras)
    {
        List<double> descuentos = new List<double>();

        foreach (List<double> cliente in compras)
        {
            double totalCompras = 0;
            foreach (double compra in cliente)
            {
                totalCompras += compra;
            }

            double descuento = 0;

            if (totalCompras >= 100 && totalCompras <= 1000)
            {
                descuento = totalCompras * 0.10;
            }
            else if (totalCompras > 1000)
            {
                descuento = totalCompras * 0.20;
            }

            descuentos.Add(descuento);
        }

        return descuentos;
    }

    static void Main(string[] args)
    {
        List<List<double>> comprasClientes = new List<List<double>>()
        {
            new List<double> { 120, 150, 90, 200, 110 },
            new List<double> { 900, 800, 950, 1000, 1100 },
            new List<double> { 80, 90, 110, 95, 120 },
            new List<double> { 500, 600, 700, 800, 900 },
            new List<double> { 1050, 950, 1100, 1200, 1300 },
            // Añadir más listas según sea necesario
        };

        List<double> descuentosClientes = CalcularDescuentoCompras(comprasClientes);

        for (int i = 0; i < descuentosClientes.Count; i++)
        {
            Console.WriteLine($"Cliente {i + 1}: Descuento aplicado: {descuentosClientes[i]:0.00}");
        }
    }
}
