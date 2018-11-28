using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_2QuickSort
{
    class Data
    {
        Queue<double> values = new Queue<double>(); //Queue that stores the entered values
        public void EnterValue()
        {
            double[] Array; //Fix that will be sent as parameter
            bool continuee = true;
            while (continuee) //Mientras la condición sea verdadera
            {
                try
                {
                    Console.Clear();
                    Console.Write("Available options: \n1.- Enter Value \n2.- Order \n3.- Predefined \n4.- Exit \nOption: "); //Available options
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Enter Value: ");
                            values.Enqueue(Convert.ToDouble(Console.ReadLine())); //Receive the value type
                            break;
                        case 2:
                            Array = new double[values.Count]; //Se inicializa el arreglo con la longitud de la cola
                            for (int counter = 0; counter < values.Count; counter++) //Aquí se llena el arreglo con los valores de la cola
                                Array[counter] = values.ElementAt(counter);
                            Console.Clear();
                            Sorting order = new Sorting(); //Se hace la instanciación de la clase 
                            order.QuickSort(Array, 0, values.Count - 1); //Se hace la llamada al método, se envia como parametro el arreglo, 0 para indicar que es el primer elemento del arreglo y valores.Count - 1 para indicar el último elemento del arreglo
                            order.Order(Array, values.Count); //Aquí se imprime el arreglo ordenado
                            values.Clear(); //Se limpia la cola
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Los predefinidos disponibles son: \n1.- Conjunto 1 \n2.- Conjunto 2 \n3.- Conjunto 3 \n4.- Conjunto 4 \nConjunto seleccionado: ");
                            if (Predefined(Convert.ToInt32(Console.ReadLine())).Count != 0)
                            {
                                Array = new double[values.Count]; //Se inicializa el arreglo con la longitud de la cola
                                for (int contador = 0; contador < values.Count; contador++) //Aquí se llena el arreglo con los valores de la cola
                                    Array[contador] = values.ElementAt(contador);
                                Console.Clear();
                                Sorting Ordena = new Sorting(); //Se hace la instanciación de la clase 
                                Ordena.QuickSort(Array, 0, values.Count - 1); //Se hace la llamada al método, se envia como parametro el arreglo, 0 para indicar que es el primer elemento del arreglo y valores.Count - 1 para indicar el último elemento del arreglo
                                Ordena.Order(Array, values.Count); //Aquí se imprime el arreglo ordenado
                                values.Clear(); //Se limpia la cola
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            continuee = false;
                            Console.Write("Bye"); //Si se indica la opción 3 se cierra el programa
                            break;
                        default: //De no ser una opción válida se despliega el mensaje y vuelve a iniciar
                            Console.Clear();
                            Console.WriteLine("Ingrese una opción válida");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); //Si hay un error, se lanza el mensaje de la excepción
                    Console.ReadKey();
                }
            }
        }

        public Queue<double> Predefined(int option) //Método que regresa como valor una cola
        {
            switch (option)
            {
                case 1:
                    values.Enqueue(11);
                    values.Enqueue(2);
                    values.Enqueue(3);
                    values.Enqueue(14);
                    values.Enqueue(18);
                    values.Enqueue(4);
                    values.Enqueue(5);
                    values.Enqueue(-3);
                    values.Enqueue(-1);
                    values.Enqueue(6);
                    values.Enqueue(9);
                    return values;
                case 2:
                    values.Enqueue(1);
                    values.Enqueue(3);
                    values.Enqueue(5);
                    values.Enqueue(7);
                    values.Enqueue(8);
                    values.Enqueue(3);
                    values.Enqueue(9);
                    values.Enqueue(0.7071);
                    values.Enqueue(16.5664);
                    values.Enqueue(12);
                    values.Enqueue(0);
                    values.Enqueue(10);
                    return values;
                case 3:
                    values.Enqueue(3);
                    values.Enqueue(7);
                    values.Enqueue(15);
                    values.Enqueue(1.333333);
                    values.Enqueue(155);
                    values.Enqueue(100);
                    values.Enqueue(15);
                    values.Enqueue(1.7320);
                    values.Enqueue(5);
                    values.Enqueue(2);
                    values.Enqueue(3);
                    values.Enqueue(2);
                    return values;
                case 4:
                    values.Enqueue(8);
                    values.Enqueue(19);
                    values.Enqueue(7);
                    values.Enqueue(3);
                    values.Enqueue(15);
                    values.Enqueue(23);
                    values.Enqueue(34);
                    values.Enqueue(27);
                    values.Enqueue(89);
                    values.Enqueue(101);
                    return values;
                default:
                    Console.WriteLine("Opción no válida");
                    return values;
            }
        }
    }
}
