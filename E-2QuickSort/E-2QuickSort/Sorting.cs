using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_2QuickSort
{
    class Sorting
    {

        public int ObtainPivot(double[] Array, int left, int right) //Aquí es donde se acomodan los elementos, se toma el pivote y los
        {                                                                       //menores que este van a la izquierda y los mayores a la derecha
            double Pivot = Array[right]; //Se toma como pivote el último elemento del arreglo

            int smallest = (left - 1); //Indice del elemento mas pequeño
            for (int counter = left; counter < right; counter++) //Se hace el recorrido desde la izquierda hasta la derecha
            {
                if (Array[counter] <= Pivot) //Si el elemento de la izquierda es menor que el pivote o igual a este
                {
                    smallest++; //Se incrementa el indice

                    double temp1 = Array[smallest]; //Se guarda el elemento del arreglo con el indice "Pequeno"
                    Array[smallest] = Array[counter]; //Se hace el cambio de el valor, similar al arreglo de burbuja
                    Array[counter] = temp1; //Se regresa el valor guardado al arreglo
                }
            }

            double temp = Array[smallest + 1];  //Similar a lo anterior, se guarda un valor (esta vez de la derecha)
            Array[smallest + 1] = Array[right]; //Se hace el intercambio
            Array[right] = temp; //Se retorna el valor guardado

            return smallest + 1; //Retorna el indice incrementado en 1
        }

        public void QuickSort(double[] array, int left, int right) //Es donde se hace el método recursivo
        {
            if (left < right) //Si la Izquierda es menor que la derecha
            {
                //particion es el indice que se recibe de el metodo ObtenerPivote
                int particion = ObtainPivot(array, left, right);

                QuickSort(array, left, particion - 1); //Se hace la recursividad con la Derecha disminuida en 1
                QuickSort(array, particion + 1, right); //Se hace la recursividad con la izquierda aumentada, con esto se va recorriendo el arreglo
            }                                               //Mientras se va acomodando en el metodo ObtenerPivote
        }

        public void Order(double[] array, int n) //En este método se despliega el arreglo ordenado
        {
            Console.WriteLine("Arreglo ordenado: ");
            for (int counter = 0; counter < n; ++counter)  //n es la longitud del arreglo
                Console.Write(array[counter] + " ");

            Console.WriteLine();
        }
    }
}
