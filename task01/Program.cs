using System;

namespace task01
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

            Console.ReadKey();
        }
    }
}



