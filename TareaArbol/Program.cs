/*Escribir un programa que contenga:
1. Árbol Binario
2. Árbol con múltiples hijos
3. Contar Niveles
4. Contar Hojas
5. Contar Nodos
6. Navegación Horizontal
7. Expresión matemática con Operaciones Básicas (+ - * /) */

using System;

namespace TareaArbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo nodoraiz1 = new Nodo()
            {

                Valor = "/",
                nivel=0,
                Hijos = {
                    new Nodo{
                        Valor="*",
                        Hijos={
                            new Nodo{
                                Valor="2"
                            },
                            new Nodo{
                                Valor ="8"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="2"
                            },
                            new Nodo{
                                Valor="9"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="4"
                            },
                            new Nodo{
                                Valor="3"
                            }
                           
                        }
                    }
                    


                },
            };
            ControladorArbol controladorArbol = new ControladorArbol();
            Console.WriteLine($"El Número de Hojas del Árbol es de: {controladorArbol.ContarHojas(nodoraiz1)}");
            Console.WriteLine($"El Número de Niveles del Árbol es de: {controladorArbol.ContarNiveles(nodoraiz1)}");
            Console.WriteLine($"El Número de Nodos del Árbol es de: {controladorArbol.ContarNodos(nodoraiz1)}");
        }
    }
}