using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Datos
    {
        Queue<int> values = new Queue<int>(); //Cola que va almacenando los valores ingresados
        public void Entervalues()
        {
            int[] Array; //Arreglo que será enviado como parámetro
            bool continuee = true;
            while (continuee) //Mientras la condición sea verdadera
            {
                try
                {
                    Console.Clear();
                    Console.Write("Opciones disponibles: \n1.- Ingresar valor \n2.- Ordenar \n3.- Predefinidos \n4.- Salir \nOpción deseada: "); //Opciones disponibles
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Ingrese valor: ");
                            values.Enqueue(Convert.ToInt32(Console.ReadLine())); //Recibe el valor tecleado
                            break;
                        case 2:
                            Array = new int[values.Count]; //Se inicializa el arreglo con la longitud de la cola
                            for (int counter = 0; counter < values.Count; counter++) //Aquí se llena el arreglo con los valores de la cola
                                Array[counter] = values.ElementAt(counter);
                            Console.Clear();
                            Sorting Ordenar = new Sorting(); //Se hace la instanciación de la clase 
                            Ordenar.Ordenar(Array); //Se hace la llamada al método, se envia como parametro el arreglo
                            values.Clear(); //Se limpia la cola
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Los predefinidos disponibles son: \n1.- Conjunto 1 \n2.- Conjunto 2 \n3.- Conjunto 3 \n4.- Conjunto 4 \n5.- Conjunto 5 \nConjunto seleccionado: ");
                            if (Predefined(Convert.ToInt32(Console.ReadLine())).Count != 0)
                            {
                                Array = new int[values.Count]; //Se inicializa el arreglo con la longitud de la cola
                                for (int counter = 0; counter < values.Count; counter++) //Aquí se llena el arreglo con los valores de la cola
                                    Array[counter] = values.ElementAt(counter);
                                Console.Clear();
                                Sorting Ordena = new Sorting(); //Se hace la instanciación de la clase 
                                Ordena.Ordenar(Array); //Se hace la llamada al método, se envia como parametro el arreglo
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

        public Queue<int> Predefined(int opcion) //Método que regresa como valor una cola
        {
            switch (opcion)
            {
                case 1:
                    values.Enqueue(3);
                    values.Enqueue(6);
                    values.Enqueue(9);
                    values.Enqueue(5);
                    values.Enqueue(1);
                    values.Enqueue(4);
                    values.Enqueue(7);
                    values.Enqueue(2);
                    values.Enqueue(1);
                    values.Enqueue(3);
                    return values;
                case 2:
                    values.Enqueue(8);
                    values.Enqueue(3);
                    values.Enqueue(9);
                    values.Enqueue(3);
                    values.Enqueue(11);
                    values.Enqueue(7);
                    values.Enqueue(1);
                    values.Enqueue(27);
                    values.Enqueue(12);
                    return values;
                case 3:
                    values.Enqueue(10);
                    values.Enqueue(40);
                    values.Enqueue(36);
                    values.Enqueue(5);
                    values.Enqueue(24);
                    values.Enqueue(2);
                    values.Enqueue(5);
                    values.Enqueue(8);
                    return values;
                case 4:
                    values.Enqueue(55);
                    values.Enqueue(42);
                    values.Enqueue(0);
                    values.Enqueue(-3);
                    values.Enqueue(0);
                    values.Enqueue(-1);
                    values.Enqueue(2);
                    values.Enqueue(4);
                    values.Enqueue(7);
                    return values;
                case 5:
                    values.Enqueue(25);
                    values.Enqueue(108);
                    values.Enqueue(1024);
                    values.Enqueue(12);
                    values.Enqueue(351);
                    values.Enqueue(251);
                    values.Enqueue(39);
                    return values;
                default:
                    Console.WriteLine("Opción no válida");
                    return values;
            }
        }
    }
}
