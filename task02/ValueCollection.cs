using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task02
{
    sealed class ValueCollection<T> : IEnumerable<object>
    {
        private T[] TValueArr;
        IEnumerator<object> This;

        public ValueCollection(IEnumerator<object> inst)
        {
            TValueArr = new T[0];
            This = inst;

        }
        public int Length => TValueArr.Length;
        public T this[int index]
        {
            get { return TValueArr[index]; }
            set
            {
                T[] tmpArr = new T[TValueArr.Length + 1];
                for (int i = 0; i < TValueArr.Length; i++)
                {
                    tmpArr[i] = TValueArr[i];
                }
                tmpArr[TValueArr.Length] = value;
                TValueArr = tmpArr;
            }
        }
        //public object Current => throw new NotImplementedException();

        public void Add(T element)
        {
            T[] tmpArr = new T[TValueArr.Length + 1];
            for (int i = 0; i < TValueArr.Length; i++)
            {
                tmpArr[i] = TValueArr[i];
            }
            tmpArr[TValueArr.Length] = element;
            TValueArr = tmpArr;
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
