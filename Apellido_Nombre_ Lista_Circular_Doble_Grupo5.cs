//Lista circular doblemente enlazada    
//Grupo 5- Alan Guijarro, Jack Narváez, Isaac Haro, Martín Guerra
//Estructura de datos
//Paralelo 1
//Fecha de entrega: 18/10/2020

using System;

namespace ListaDoblementeEnlazadaCircular
{
    class Program
    {
        //Se crea la clase nodo
        class nodo
        {
            //Definición de variables
            public object valor;
            public nodo siguiente;
            public nodo anterior;

            //Métodos

            //nodo
            //Método constructor que nos permite inicializar los atributos de la clase
            public nodo()
            {
                valor = null;
                siguiente = null;
                anterior = null;
            }
        }
        //Se crea la clase ListaCircular2 que nos permitirá enlazar nodos para formar la lista circular doblmente enlazada 
        class ListaCircular2
        {
            //Definición de variables
            nodo final = new nodo();

            //Métodos

            //AgregarComienzo
            //Método que nos permite añadir datos por el inicio de la lista circular doblemente enlazada
            public void AgregarComienzo(object datonuevo)
            {
                if (final.valor == null)
                {
                    final.valor = datonuevo;
                    final.siguiente = final;
                    final.anterior = final;
                }
                else
                {
                    nodo Aux = new nodo();
                        
                    Aux.valor = datonuevo;
                    Aux.siguiente = final.siguiente;
                    final.siguiente = Aux;
                    Aux.anterior = final;
                    Aux.siguiente.anterior = Aux;
                }
            }

            //AgregarFinal
            //Método que nos permite añadir datos al final de la lista circular doblemente enlazada
            public void AgregarFinal(object datonuevo)
            {
                if (final.valor == null)
                {
                    final.valor = datonuevo;
                    final.siguiente = final;
                    final.anterior = final;
                }
                else
                {
                    nodo Aux = new nodo();

                    Aux.valor = datonuevo;
                    Aux.siguiente = final.siguiente;
                    final.siguiente = Aux;
                    Aux.anterior = final;
                    Aux.siguiente.anterior = Aux;
                    final = Aux;
                }
            }

            //RetiraComienzo
            //Método que nos permite retirar datos por el comienzo de la lista circular doblemente enlazada
            public void RetiraComienzo()
            {
                final.siguiente = final.siguiente.siguiente;
                final.siguiente.anterior = final;
            }

            //RetiraFinal 
            //Método que nos permite retirar datos por el final de lista circular doblemente enlazada
            public void RetiraFinal()
            {
                final = final.anterior;
                final.siguiente = final.siguiente.siguiente;
                final.siguiente.anterior = final;
            }

            //ImprimirLista 
            //Método que nos permite imprimir todos los nodos de nuestra lista circular doblemente enlazada
            public void ImprimirLista()
            {
                nodo aux = final.siguiente;

                while (aux != final)
                {
                    Console.WriteLine(aux.valor);
                    aux = aux.siguiente;
                }
                Console.WriteLine(final.valor);
            }
        }
        //Función Principal
        static void Main(string[] args)
        {
            //Ínstanciamos a nuestra clase ListaCircular2   
            ListaCircular2 miLista1 = new ListaCircular2();

            //Se llaman a los métodos de la clase
            Console.WriteLine("Ingreso datos por el inicio:");
            miLista1.AgregarComienzo("Dato1");
            miLista1.AgregarComienzo("Dato2");
            miLista1.ImprimirLista();

            Console.WriteLine("\nIngreso datos por el final:");
            miLista1.AgregarFinal("Final1");
            miLista1.AgregarFinal("Final2");
            miLista1.AgregarFinal("Final3");
            miLista1.AgregarFinal("Final4");
            miLista1.ImprimirLista();

            Console.WriteLine("\nRetiro por el comienzo:");
            miLista1.RetiraComienzo();
            miLista1.ImprimirLista();

            Console.WriteLine("\nRetiro por el final:");
            miLista1.RetiraFinal();
            miLista1.ImprimirLista();
        }
    }
}
