using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTLibrary
{
    public interface IStack<T>
    {
        void Push(T item); //inserta un elemento
        T Pop(); //Elimina y devuelve elemento del tope
        T Peek(); //Devuelve elemento del tope sin eliminarlo
        bool IsEmpty(); //indica si la pila estsa vacia
        int Count { get; } //Propiedad: numero de elementos

    }
}
