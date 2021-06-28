using System; 
using System.Linq;
using System.Collections.Generic;

namespace TareaArbol
{
    internal class ControladorArbol
    {
        internal int ContarHojas(Nodo nodo1)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo1.Hijos)
            {
                acumulador += actual.Valor.Count() + actual.Hijos.Count();
            }
            return acumulador;
        }

        internal int ContarNodos(Nodo nodo1)
        {
            int acumulador = 0;
            acumulador+=nodo1.nodoRaiz1+nodo1.Hijos.Count();
            foreach (Nodo actual in nodo1.Hijos)
            {
                acumulador+=actual.Hijos.Count;
            }
            return acumulador;
        }
        internal int ContarNiveles(Nodo nodo1){
         int acumulador=0;
         foreach (Nodo actual in nodo1.Hijos)
         {
             acumulador+=actual.Valor.Count();
         }
            return acumulador;
        }
       
    }
}