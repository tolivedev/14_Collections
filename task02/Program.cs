using System;
using System.Collections;
using System.Collections.Generic;

namespace task02
{
    //Dictionary
    class MyDictionary<TKey, TValue> : IEnumerator<object>
    {
        // представим наши пары ключ-значение как два перечислимых(IEnumerable)
        public KeyCollection<TKey> Keys;
        public ValueCollection<TValue> Values;
        private int position = -1;

        public MyDictionary()
        {
            Keys = new KeyCollection<TKey>(this);
            Values = new ValueCollection<TValue>(this);
        }
        public void Add(TKey key, TValue value)
        {
            Keys.Add(key);
            Values.Add(value);
        }

        public bool MoveNext()
        {
            if (position < Keys.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
           (this as IEnumerator).Reset();
        }

        public object Current => Keys[position] + " " + Values[position];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Values.Length)
                {
                    return Values[index].ToString();
                }
                return "Выход за пределы массива";
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            MyDictionary<string, object> MyDic = new MyDictionary<string, object>();

            MyDic.Add("first", "perviy");
            MyDic.Add("Si", 'C');
            MyDic.Add("one hundred thirty nine", 139);
            MyDic.Add("MyDic", MyDic);


            // foreach - приводит коллекцию к интерфейсному типу IEnumerable.
            // Своими словами - foreach,для его работы, проверяет наличие метода GetEnumerator() в экземпляре, поскольку метод был реализован с явным указанием имени типа, он является private, и для того, чтобы его стало видно, необходимо привестись с данному типу(IEnumerable) 
            IEnumerable enumerable = MyDic.Keys as IEnumerable;
            #if false
            // foreach - приводит коллекцию к интерфейсному типу вызывая метод - GetEnumerator().            
            IEnumerator enumerator = enumerable.GetEnumerator();

    
            while (enumerator.MoveNext()) // Перемещаем курсор на 1 шаг вперед (с -1 на 0) и т.д.
            {
                Object element = enumerator.Current as Object;

                Console.WriteLine("Value: {0}", element.ToString());
            }
            Console.WriteLine(new string('+', 60));
            
            enumerator.Reset();
                #endif
            foreach (var item in MyDic.Keys)
            {
                //Object element = enumerator.Current as Object;
                Console.WriteLine(  item.ToString());
                //Console.WriteLine("Value: {0}", element.ToString());
            }

            Console.WriteLine(new string('*', 60));

            foreach (var item in MyDic.Keys)
            {
                //Object element = enumerator.Current as Object;
                Console.WriteLine(item.ToString());
                //Console.WriteLine("Value: {0}", element.ToString());
            }
            Console.ReadKey();
        

        }
    }
}
