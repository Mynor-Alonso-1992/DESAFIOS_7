using System;

class DescuentosCompras
{

    public static void Main(string[] args)
    {
        double[][] compras = new double[5][] {
            new double[] {50, 20, 100, 75, 60},
            new double[] {120, 80, 150, 200, 300},
            new double[] {30, 40, 50, 60, 70},
            new double[] {150, 200, 300, 400, 500},
            new double[] {10, 20, 30, 40, 50}
        };

        CalcularTotalesYDescuentos(compras);
    }

    static void CalcularTotalesYDescuentos(double[][] compras)
    {
        for (int i = 0; i < compras.Length; i++)
        {
            double total = 0;
            double descuento = 0;

            for (int j = 0; j < compras[i].Length; j++)
            {
                total += compras[i][j];
            }

            if (total >= 1000)
            {
                descuento = total * 0.2;
            }
            else if (total >= 100)
            {
                descuento = total * 0.1;
            }

            double totalPagar = total - descuento;

            Console.WriteLine("Cliente {0}:", i + 1);
            Console.WriteLine("Total compras: {0}", total);
            Console.WriteLine("Descuento: {0}", descuento);
            Console.WriteLine("Total a pagar: {0}", totalPagar);
            Console.WriteLine();
        }
    }
}
