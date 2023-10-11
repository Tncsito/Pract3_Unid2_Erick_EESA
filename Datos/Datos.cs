using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1_Erick_EESA.Datos
{
    internal class Datos
    {
        public void nomberguan()
        {
            int[,] a = new int[3, 3] { {5, 2, 3}, {8, 2, 4 }, {4, 3, 1 } };
            for (int fila = 0; fila < a.GetLength(0); fila++)
            {
                for (int columna = 0; columna < a.GetLength(1); columna++)
                {
                    Console.Write(a[fila, columna] + " ");
                }
                Console.WriteLine("\n");
            }
        }
        //###################################################
        public void nombertu()
        {
            string[,] letra = new string[2, 2] { { "Rojo", "Verde"}, { "Azul", "Amarillo"} };
            for (int fila = 0; fila < letra.GetLength(0); fila++)
            {
                for (int columna = 0; columna < letra.GetLength(1); columna++)
                {
                    Console.Write(letra[fila, columna] + " ");
                }
                Console.WriteLine("\n");
            }
        }
        //##################################################
        public void nombertri()
        {
            double[,] b = new double[4, 3] { { 3.5, 5.2, 4.9}, { 1.8, 2.4, 7.5}, { 4.2, 1.9, 8.2}, { 6.5, 4.6, 2.3} };

            /*double fila = 0.0;
                double i = 0.0;
                for (double cont = 0; cont < b.GetLength(0); cont++)
                {
                    i += b[fila, cont];
                    fila++;
                }
            */
            double suma = 0.0;

            int filas = b.GetLength(0);
            int columnas = b.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += b[i, j];
                }
            }
            Console.WriteLine($"La suma de todo el arreglo double es: {suma}");
        }
        //#################################################
        public void nomberfor()
        {
            char[,] carac = new char[2, 4] { { 'A', 'B', 'C', 'D'}, { 'E', 'F', 'G', 'H'} };
            for (int fila = 0; fila < carac.GetLength(0); fila++)
            {
                for (int columna = 0; columna < carac.GetLength(1); columna++)
                {
                    Console.Write(carac[fila, columna] + " ");
                }
                Console.WriteLine("\n");
            }
        }
        //################################################
    }
}
