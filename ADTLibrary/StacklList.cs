using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTLibrary
{
    public class StackList<T> : IStack<T> //implementacion
    {
        private readonly List<T> _items = new();

        public int Count => _items.Count;

        public bool IsEmpty() => _items.Count == 0;

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("La pila está vacía.");
            return _items[^1]; //returns las element in the stack
        }

        public T Pop()
        {//LIFO
            if (IsEmpty()) throw new InvalidOperationException("La pila está vacía.");
            var last = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            return last;
        }

        public void Push(T item) => _items.Add(item);
    }

    public class Instrumento //clase con dos variables y el override
    {
        public string Serie { get; }
        public string Modelo { get; }

        public Instrumento(string serie, string modelo)
        {
            Serie = serie.Trim(); //cleans any whitespace
            Modelo = modelo.Trim();
        }

        public override string ToString() //meustra mis datos ya que el programa no sabe el contenido dentro del objeto (pila)
        {
            return $"[Serie: {Serie}, Modelo: {Modelo}]";
        }
    }

}
