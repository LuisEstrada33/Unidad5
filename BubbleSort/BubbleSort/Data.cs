using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Data
    {
        public void AskValues()
        {
            int elements;
            int[] values;
            Console.Write("Número de elementos: ");
            elements = Convert.ToInt32(Console.ReadLine()); //Pide el número de elementos

            values = new int[elements]; //Inicializa el arreglo con los elementos indicados
            Console.Clear();
            Console.Write("Ingreso de datos: \n");

            for (int counter = 0; counter < elements; counter++)
            {
                Console.Write("Elemento {0}: ", counter + 1); //Pide los valores de cada elemento
                values[counter] = Convert.ToInt32(Console.ReadLine());
            }

            Bubble Order = new Bubble(); //Hace la instanciación a la clase Burbuja

            Order.BubbleSort(values); //Se llama al método de bulbasaur a través del objeto
        }
    }
}
