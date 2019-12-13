using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorSample
{
    class Program
    {
        /*
        static void Process(IEnumerable e)
        {
            IEnumerator i = e.GetEnumerator();

            while (i.MoveNext())
            {
                Console.WriteLine(i.Current.ToString());
            }
        }
        */
        static void Main(string[] args)
        {
            /*
            IList persons;
            persons = new ArrayList(); //创建一个ArrayList类型的聚合对象
            persons.Add("张无忌");
            persons.Add("小龙女");
            persons.Add("令狐冲");
            persons.Add("韦小宝");
            persons.Add("袁紫衣");
            persons.Add("小龙女");

            Process(persons);
            Console.Read();
            */

            List<object> products = new List<object>();
		    products.Add("倚天剑");
		    products.Add("屠龙刀");
		    products.Add("断肠草");
		    products.Add("葵花宝典");
		    products.Add("四十二章经");
			
		    AbstractObjectList list;
		    AbstractIterator iterator;
		
		    list = new ProductList(products);   //创建聚合对象
		    iterator = list.CreateIterator();	//创建迭代器对象
		
		    Console.WriteLine("正向遍历：");	
		    while(!iterator.IsLast()) 
            {
			    Console.Write(iterator.GetNextItem() + "，");
			    iterator.Next();
		    }
		    Console.WriteLine();
		    Console.WriteLine("-----------------------------");
		    Console.WriteLine("逆向遍历：");
		    while(!iterator.IsFirst()) 
            {
                Console.Write(iterator.GetPreviousItem() + "，");
			    iterator.Previous();
		    }
            
            Console.Read();
        }
    }
}
