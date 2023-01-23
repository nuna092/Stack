using Stack.Model;
using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {         
            var stack = new StackExample<int>();

            stack.Push(2);
            stack.Push(3);
            stack.Push(34);
            stack.Push(-1);
            stack.Push(0);
            Console.Write($"Стек содержит {stack.Count} элементов.");

            var item1 = stack.Pop();
            Console.WriteLine($"Верхний элемент {item1}.");
            var item2 = stack.Pop();
            Console.WriteLine($"Предпоследний элемент {item2}.");

            stack.Push(88);
            var item3 = stack.Peek();
            Console.WriteLine($"Новый верхний элемент {item3}.");
            var item4 = stack.Peek();
            Console.WriteLine($"Новый верхний элемент {item4}.");

            Console.ReadLine();
        }
    }
}

