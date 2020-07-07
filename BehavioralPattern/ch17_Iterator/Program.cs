using System;
using System.Collections.Generic;
using ch17_Iterator.Sales;
using System.Collections;

namespace ch17_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Sales
            {
                List<object> products = new List<object>();
                products.Add("倚天剑");
                products.Add("屠龙刀");
                products.Add("断肠草");
                products.Add("葵花宝典");
                products.Add("四十二章经");

                AbstractObjList list = new ProductList(products);
                AbstractorIterator iterator = list.CreateIterator();
                System.Console.WriteLine("Loop in order...");
                while(!iterator.IsLast()){
                    System.Console.Write($"{iterator.GetNextItem()}, ");
                    iterator.Next();
                }
                System.Console.WriteLine();
                System.Console.WriteLine("----------------------------------");
                System.Console.WriteLine("Loop in reverse order...");
                while(!iterator.IsFirst()){
                    System.Console.Write($"{iterator.GetPreviousItem()}, ");
                    iterator.Previous();
                }
            }

            // 2. IEnumerable, IEnumerator
            // ArrayList,   ArrayListEnumeratorSimple
            
            // 3. TV
            // AbstractObjList => List<Channel>
            // AbstractIterator => ChannelIterator

            // 4. Extend ArrayList
            // ReverseArrayList

            // 5. Class
            // AbstractObjList => List<Student>
            // AbstractIterator => StudentIterator (Order By Age Desc)

            // 6. Pagination
            // AbstractObjList => List<string>
            // AbstractIterator => PaginationString


            Console.ReadLine();
        }

        static void Process(IEnumerable e){
            IEnumerator i = e.GetEnumerator();
            while(i.MoveNext()){
                System.Console.WriteLine(i.Current.ToString());
            }
        }
    }
}
