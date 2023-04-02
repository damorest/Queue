using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue
{
    internal class Program
    {
        class MyQueue
        {
            public List<string> data;
            public MyQueue(List<string> initialData)
            {
                this.data = initialData;
            }
            public void Enqueue(string a) // Додати елемент в кінець списку.
            {
                this.data.Add(a);
            }
            public void MyPeek(List<string> f) // Отримати перший елемент списку.
            {
                Console.WriteLine(f.First());

                //return firstEl;
            }
            public void MyClear(List<string> fin) // Очищуємо чергу
            {
               fin.Clear();               
            }
            public void MyContains(string example) //Повертає true, якщо item є у списку.
            {
                foreach (var item in this.data)
                {
                    if (item == example)
                    { 
                        Console.WriteLine(true);
                    }
                }
            }
            public void Print(List<string> arr)
            {
                this.data = arr;
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            public void MyDequeue(List<string> arr) //Отримуємо і видаляємо перший елемент списку.
            {
                MyPeek(arr);
                arr.RemoveAt(0);
            }
        }
        
        static void Main(string[] args) {


            List<string> arr = new List<string>();
            
           MyQueue test = new MyQueue(arr);
            test.Enqueue("cat");
            test.Enqueue("cow");
            test.Enqueue("bird");
            test.Enqueue("dog");
            test.Enqueue("volf");
            
            test.Print(arr);
            test.MyDequeue(arr);
            test.Print(arr);
            //test.MyPeek(arr);
            //test.MyContains("dog");
          // test.MyClear(arr);

           
        }
    }
}
