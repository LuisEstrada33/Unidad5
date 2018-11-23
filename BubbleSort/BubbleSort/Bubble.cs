using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Bubble
    {
        public void BubbleSort(int[] Values) //Método que recibe como parámetro un arreglo
        {
            Console.Clear();
            Console.WriteLine("Valores ingresados: ");

            foreach (var deploy in Values)
            {
                Console.Write(deploy + " "); //Se despliega cada uno de los elementos del arreglo
            }

            int temp; //Se inicializa el temporal para el ordenamiento

            for (int counter = 0; counter < Values.Length; counter++) //For para que se acomode cada uno de los elementos
            {                               //se realiza el segundo for la cantidad de veces como elementos tenga el arreglo
                for (int counter2 = 1; counter2 < Values.Length; counter2++) //Aquí se van a comparar los valores de los elementos
                {
                    if (Values[counter2 - 1] > Values[counter2]) //Si el valor anterior es mayor que el actual
                    {
                        temp = Values[counter2]; //Se guarda el actual
                        Values[counter2] = Values[counter2 - 1]; //Se sustituye el actual por el anterior
                        Values[counter2 - 1] = temp;//Al anterior se le asigna el actual
                    }
                }
            }

            Console.WriteLine("\nValores ordenados: ");

            foreach (var desplegar in Values)
            {
                Console.Write(desplegar + " "); //Se despliega la lista ordenada
            }

            Console.ReadKey();
        }
    }
}
