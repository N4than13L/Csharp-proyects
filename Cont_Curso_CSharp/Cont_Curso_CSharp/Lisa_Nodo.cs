using System;
using System.Collections.Generic;
using System.Text;

namespace Cont_Curso_CSharp
{
    public class Lisa_Nodo
    {
        private Nodo primero;
        private int size;

        public Lisa_Nodo()
        {
            primero = null;
            size = 0;
        }

        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            Nodo valor_1, valor_2;

            if (primero == null)
            {
                primero = nuevo;
                primero.siguiente = null;
            }
            else
            {
                valor_1 = primero;

                while(valor_1 != null)
                {
                    valor_2 = valor_1.siguiente;

                    if(nuevo.dato <= valor_1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        if(nuevo.dato >valor_1.dato &&valor_2 == null)
                        {
                            valor_1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            if (valor_1.dato < nuevo.dato && valor_2.dato >= nuevo.dato)
                            {
                                valor_1.siguiente = nuevo;
                                nuevo.siguiente = valor_2;
                                break;
                            }
                            else
                            {
                                valor_1 = valor_1.siguiente;
                            }
                        }
                    }
                }
            }
            size++;
        }
        

        public void ListaVacia()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacia.");
            }
            else
            {
                Console.WriteLine("La Lista tiene datos");
            }
        }

        public void Listar()
        {
            Nodo actual = primero;

            while(actual != null)
            {
                Console.Write("[" + actual.dato + "]->");
                actual = actual.siguiente;
            }
        }

        public void Borrar_primero()
        {
            primero = primero.siguiente;
        }

        public void Eliminar_ultimo()
        {
            Nodo anterior = primero;
            Nodo actual = primero;

            while(actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            anterior.siguiente = null;
        }

        public void Borrar_posicion_de_nodo(int p)
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            int dato = 0;

            if(p > 0)
            {
                while (dato != p && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    dato++;
                }
                anterior.siguiente = actual.siguiente;

            }
        }

        public Nodo Buscar_valor(int n)
        {
            Nodo p = primero;

            if (p == null)
            {
                Console.WriteLine("La lista no tiene datos");
            }
            else
            {
                while (p.siguiente != null || p.siguiente == null)
                {
                    if (p.dato == n)
                    {
                        return p;
                    }
                    else
                    {
                        if (p.siguiente == null)
                        {
                            return null;
                        }
                    }
                    p = p.siguiente;
                }
            }
            return null;
        }
        public void Sustituir(int origin, int nuevo)
        {
            Nodo pos = Buscar_valor(origin);

            if(pos != null || pos == null)
            {
                pos.dato = nuevo;
            }
        }
        public int Size()
        {
            return size;

        }




        
    }
}
