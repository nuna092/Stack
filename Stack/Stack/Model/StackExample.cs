using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    public class StackExample<T>
    {

        private List<T> _items = new List<T>();
        public int Count => _items.Count;

        public void Push(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _items.Add(item);
        }

        public T Peek()
        {
            var item = _items.LastOrDefault();

            if (item == null)
                ThorwNullReferenceException("Cтек пустой. Нет элементов.");

            return item;
        }

        public T Pop()
        {
            var item = _items.LastOrDefault();

            if (item == null)
                ThorwNullReferenceException("Cтек пустой. Нет элементов для получения.");

            _items.RemoveAt(_items.Count - 1);

            return item;
        }
        private void ThorwNullReferenceException(string message)
        {
            throw new NullReferenceException(message);
        }


    }
    }


