using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Sorting
    {
        public void Ordenar(int[] Temporal)
        {
            RadixSort(ref Temporal);
            List<int> negative = new List<int>(); //Lista de valores negativos ordenados
            List<int> array = new List<int>(); //Lista de valores ordenados positivos
            foreach (var item in Temporal)
            {
                if (item < 0) //Si es menor que 0 se agrega a la lista de negativos
                {
                    negative.Add(item);

                }
                else //Si no es negativo se agrega a la lista de ordenados positivos
                    array.Add(item);
            }
            foreach (var item in negative)
                Console.Write(item + " "); //Se imprimen los valores acomodados
            foreach (var item in array)
                Console.Write(item + " ");
        }

        private void RadixSort(ref int[] a) //Arreglo como ref para modificarlo en otro método
        {
            // Arreglo temporal 
            int[] temp = new int[a.Length];

            // Número de bits de la longitud del grupo
            int r = 4; // Se puede usar como 2, 8 o 16 para comprobar si es mas rápido 

            // La cantidad de bits del tipo int
            int b = 32;

            // Conteo y prefijo del arreglo (o cifra significativa)
            int[] count = new int[1 << r];
            int[] significativa = new int[1 << r];

            // Número de grupos
            int groups = (int)Math.Ceiling(b / (double)r);

            // Mascara para identificar los grupos 
            int mask = (1 << r) - 1;

            // Empieza el algoritmo 
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                // Se reinicia el conteo del array
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                // Cuenta los elementos del grupo de posición c
                for (int i = 0; i < a.Length; i++)
                    count[(a[i] >> shift) & mask]++;

                // Cálculo de prefijo o cifra significativa
                significativa[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    significativa[i] = significativa[i - 1] + count[i - 1];

                // desde a[] hasta t[] elementos ordenados por el grupo de posición c
                for (int i = 0; i < a.Length; i++)
                    temp[significativa[(a[i] >> shift) & mask]++] = a[i];

                // a[]=t[] y empieza otra vez hasta el último grupo
                temp.CopyTo(a, 0);
            }
            //El arreglo ahora está ordenado
        }
    }
}
