//Lista enlazada circular
//Grupo 5- Alan Guijarro, Jack Narváez, Isaac Haro, Martín Guerra
//Estructura de datos
//Paralelo 1
//Fecha de entrega: 18/10/2020

using System;

namespace ListaCircular
{
    class Program
    {
        //Se crea la clase nodo
        class nodo
        {
            //Definición de variables
            public object valor;
            public nodo siguiente;


            //Métodos

            //nodo
            //Método constructor que nos permite inicializar los atributos de la clase
            public nodo()
            {
                valor = null;
                siguiente = null;
            }
        }
        //Se crea la clase ListaCircular que nos permitirá enlazar nodos para formar la lista
        class ListaCircular
        {
            //Definición de variables
            nodo final = new nodo();            

            //Métodos

            //AñadirComienzo
            //Método que nos permite añadir datos por el inicio de la lista enlazada circular
            public void AñadirComienzo(object datonuevo)
            {
                if (final.valor== null) {
                    final.valor = datonuevo;
                    final.siguiente = final;
                } else {
                    nodo aux = new nodo();

                    aux.valor = datonuevo;
                    aux.siguiente = final.siguiente;
                    final.siguiente = aux;
                }
            }

            //AñadirFinal
            //Método que nos permite añadir datos al final de la lista enlazada circular
            public void AñadirFinal(object datonuevo)
            {
                if (final.valor == null)
                {
                    final.valor = datonuevo;
                    final.siguiente = final;
                }
                else
                {
                    nodo aux = new nodo();

                    aux.valor = datonuevo;
                    aux.siguiente = final.siguiente;
                    final.siguiente = aux;
                    final = aux;
                }   
            }

            //RetirarComienzo
            //Método que nos permite retirar datos por el comienzo de la lista enlazada circular
            public void RetiraComienzo()
            {
                final.siguiente = final.siguiente.siguiente;
            }

            //RetiraFinal
            //Método que nos permite retirar datos por el final de lista enlazada circular
            public void RetiraFinal()
            {                
                nodo aux = final;

                while (aux.siguiente!=final) {
                    aux = aux.siguiente;
                }
                final = aux;
                final.siguiente = final.siguiente.siguiente;
            }

            //ImprimirLista
            //Método que nos permite imprimir todos los nodos de nuestra lista enlazada circular
            public void ImprimirLista() {
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
            //Ínstanciamos a nuestra clase ListaCircular
            ListaCircular miLista1 = new ListaCircular();

            //Se llaman a los métodos de la clase
            Console.WriteLine("Ingreso datos por el inicio:");
            miLista1.AñadirComienzo("Dato1");
            miLista1.AñadirComienzo("Dato2");
            miLista1.AñadirComienzo("Dato3");
            miLista1.AñadirComienzo("Dato4");
            miLista1.ImprimirLista(); 

            Console.WriteLine("\nIngreso datos por el final:");
            miLista1.AñadirFinal("Final1");
            miLista1.AñadirFinal("Final2");
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
