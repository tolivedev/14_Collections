using System;

namespace task03
{

    class Program
    {
        static void Main(string[] args)
        {
            MyList<object> myList = new MyList<object>();
            myList.Add("first");
            myList.Add('C');
            myList.Add(139);
            myList.Add(myList);

            foreach (object item in myList)
            {
                Console.WriteLine(item);
            }

            object[] lst = myList.GetArray();
            Console.ReadKey();
        }
    }
}
