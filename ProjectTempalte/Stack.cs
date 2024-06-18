using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTempalte
{
    public class Stack<T>
    {
        private T[] values; // здесь будут храниться значения
        private int size;   // количество значений, хранимых на стеке. но не фактических, а "валидных"

        public int Size { get => size; }

        // TODO:
        // Добавить параметр по умолчанию capacity
        // Иницилизировать поля класса в соответствии с принимаемыми аргументами
        public Stack()
        {
        }

        // TODO:
        // Проверить, что ёмкость позволяет добавить элемент в массив
        // Если нет, изменить фактический размер массива и добавить элемент
        // Увеличить значение size
        public void Push(T value)
        {
            // Для изменения размера массива можно
            // либо создайте новый массив и перенесите в него элементы из старого,
            // либо воспользуйтесь функцией Array.Resize
        }

        // TODO:
        // Проверить, есть ли элементы в массиве values (обратитесь к переменной size)
        // Если нет, выдать ошибку
        // Если да, вернуть последний элемент и "удалить верхний элемент" (уменьшить значение size)
        public T Pop()
        {
            return default(T); // Заглушка
        }

        // TODO:
        // Аналогично предыдущему, но ничего не удаляем
        public T Peek()
        {
            return default(T); // Заглушка
        }

        public bool IsEmpty()
        {
            return true; // TODO: поменять
        }
    }
}
