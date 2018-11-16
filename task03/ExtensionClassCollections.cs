using System;
using System.Collections.Generic;
using System.Text;

namespace task03
{
    static class ExtensionClassCollections
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            if (list is MyList<T>)
            {
                var i = (list as MyList<T>).Count;
                T[] tmpArr = new T[i];
                int j = 0;
                foreach (var item in list)
                {
                    tmpArr[j] = item;
                    j++;
                }
                return tmpArr;
            }
            else
            {
                List<T> tmpLst = new List<T>();
                T[] returnarray;
                int i = 0;
                foreach (var item in list)
                {
                    tmpLst.Add(item);               
                }
                returnarray = new T[tmpLst.Count];
                foreach (var item in tmpLst)
                {
                    returnarray[i] = item;
                    i++;
                }
                return returnarray;
            }
            //return null;

        }
    }
}
