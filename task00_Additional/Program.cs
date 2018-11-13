using System;
using System.Collections;

namespace task00_Additional
{
    class UserCollection
    {
        static public IEnumerable ReturnEvenNumbers(int[] argz)
        {
            for (int i = 0; i < argz.Length; i++)
                if (argz[i] != 0 && argz[i] % 2 == 0)
                    yield return argz[i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intCol = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            IEnumerable UC = UserCollection.ReturnEvenNumbers(intCol);
            foreach (var item in UC)//UserCollection.ReturnEvenNumbers(intCol))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
