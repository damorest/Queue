using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            public void Enqueue(string a)
            {
                this.data.Add(a);
               /* Array.Resize(ref this.data, data.Length + 1);

                string item = this.data[this.data.Length];*/
            }

        }
        
        static void Main(string[] args) {


            List<string> arr = new List<string>()   {
        "bird",
        "frog",
        "dog"
    }; //{ "c", "num1", "num2" };
           MyQueue test = new MyQueue(arr);
            test.Enqueue("aaaaa");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            /*MyQueue myQueue = new MyQueue(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(myQueue.data[i]);
            }*/

        }
    }
}
