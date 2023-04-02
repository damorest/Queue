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
            public string MyPeek(List<string> f) // Отримати перший елемент списку.
            {
               
                return f.First();
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

            //Реалізуємо чергу до лікаря

            List<string> arr = new List<string>();
            
           MyQueue  pacientList = new MyQueue(arr);
            
            // Заповнюємо список

            pacientList.Enqueue("Артур");
            pacientList.Enqueue("Олег");
            pacientList.Enqueue("Валентина");
            pacientList.Enqueue("Ярослав");
            pacientList.Enqueue("Алевтина");
            pacientList.Enqueue("Стас");

            Console.WriteLine("Список пацiєнтiв : ");
            pacientList.Print(arr);

            //Перевіряємо чи є перший відвідувач
            pacientList.MyContains(pacientList.MyPeek(arr));


            // Починаємо прийом

            while (arr.Count > 0)
            {
                Console.WriteLine($"Заходить {pacientList.MyPeek(arr)}");
                pacientList.MyDequeue(arr);

                if (arr.Count == 0)
                    Console.WriteLine("Прийом пацiєнтiв закiнчено");
            }
            pacientList.Print(arr); // Перевіряємо, чи список насправді пустий.
        }
    }
}
