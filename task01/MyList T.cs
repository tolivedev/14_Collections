using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task01
{

    class MyList<T>: IEnumerable<T>, IEnumerator, IEnumerator<T>
    {
        private T[] arr = new T[0];
        private int position = -1;
        public T this[int index] { get { return arr[index]; } }


        public void Add(T element)
        {
            //создаём временный и переносим все элементы старого
            T[] temporaryArr = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temporaryArr[i] = arr[i];
            }
            temporaryArr[arr.Length] = element;//дописываем в конец нов элемент
            arr = temporaryArr;
        }
        public void Clear() => arr = new T[0];
        public int Count => arr.Length; //return arr.Length;
        public object Current => arr[position]; 

        T IEnumerator<T>.Current => arr[position];

        public IEnumerator<T> GetEnumerator() => this as IEnumerator<T>;
        public bool MoveNext()
        {

            if (position < arr.Length - 1)
            {
                position++;
                return true;
            }
            else { Reset(); return false; }
            //throw new NotImplementedException();
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
