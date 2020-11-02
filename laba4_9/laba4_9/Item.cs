using System;
namespace Lab4
{
    public class Item<T>
    {
        public T Value; //значение элемента
        public Item<T> Next; //указатель на след. элемент
        public Item(T value, Item<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
