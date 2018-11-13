using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace InterIEnumerable
{

    class MyDictionary<TKey, TValue> //Пользовательская реализация Dictionary<>
    {
        //Приватные поля доступные только для чтения
        private readonly TKey[] key; //Массив ключей
        private readonly TValue[] value; //Массив зачений
        private readonly int lenght; //Размер словаря

        public int Lenght //свойство для роботы с полем lenght 
        {
            get //Аксессор
            {
                return lenght;
            }
        }

        public MyDictionary(int n) //Пользовательский конструктор
        {
            //Инициализация полей класса
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }

        public string this[int index] //Индексатор
        {
            get //Аксессор
            {
                if (index >= 0 && index < key.Length) //Проверка наявности элемента в словаре
                    return key[index] + " - " + value[index]; //Если элемент существует вернуть строковое представление ключа и значения запрашиваемой записи
                return "Попытка обращения за пределы массива.";
            }
        }

        public void Add(int i, TKey k, TValue l) //Метод добавления записи в словарь
        {
            key[i] = k;
            value[i] = l;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность словаря:");
            int n = Convert.ToInt32(Console.ReadLine()); //Запись значения полученного от пользователя конвертированного в Int

            var dictionary = new MyDictionary<string, string>(n); //Создание переменной типа MyDictionary и закрытие типами string

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "стол", "table"); //Вызов метода добавления новой записи в словарь
            }

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]); //Отображение значений словаря
            }

            Console.WriteLine(dictionary[1]); //Отображение определенной записи словаря по указанному ключу
            Console.WriteLine(dictionary.Lenght);

            // Delay.
            Console.ReadKey();
        }
    }
}



