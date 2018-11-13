using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task02
{
    class KeyCollection<T>:  IEnumerable<object> // IEnumerable<T>, 
    {
        private T[] TKeyArr;// = new T[0];
        //private int position = -1;
        IEnumerator<object> This;

        public T this[int index] => TKeyArr[index];

        public int Length => TKeyArr.Length;

        public KeyCollection(IEnumerator<object> inst)
        {
            TKeyArr = new T[0];
            This = inst;
        }

        public void Add(T element)
        {
            T[] tmpArr = new T[TKeyArr.Length + 1];
            for (int i = 0; i < TKeyArr.Length; i++)
            {
                tmpArr[i] = TKeyArr[i];
            }
            tmpArr[TKeyArr.Length] = element;
            TKeyArr = tmpArr;
        }

        public IEnumerator<object> GetEnumerator()
        {
            return This;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<object>).GetEnumerator();
        }
    }
}
