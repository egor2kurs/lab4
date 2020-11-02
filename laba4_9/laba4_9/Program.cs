using System;
using System.Buffers;
using System.Security.Cryptography.X509Certificates;

namespace Lab4
{

    class Program
    {
        static void Main(string[] args)
        {

            var list1 = new List<string>();
            var list2 = new List<string>();
  
            List<string>.Date date1 = new List<string>.Date();  //date
            list1.Add("1Первый");
            list1.Add("1Второй");
            list1.Add("1Третий");
            list2.Add("2Первый");
            list2.Add("2Второй");
            list2.Add("2Третий");
       
            var list3 = new List<string>();
            Console.WriteLine("Первый список:");
            Print(list1);
            Console.WriteLine(" \nВторой список:");
            Print(list2);
            Console.WriteLine("Проверка на равенство");
            if (list1 == list2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("Дата и время:");
            Console.WriteLine(date1.date);
            Console.WriteLine("Всего элементов в первом списке");
            Console.WriteLine(StatisticOperation.Counter(list1));
            list1 = list1 + list2;
            Print(list1);
            Console.WriteLine("Всего элементов в первом списке после сложения");
            Console.WriteLine(StatisticOperation.Counter(list1));
            var list3int = new List<int>();
            list3int.Add(1);
            list3int.Add(2);
            list3int.Add(3);
            list3int.Add(4);
            list3int.Add(5);
            list3int.Add(6);
            Console.WriteLine(" \nТретий список(int):");
            Print(list3int);
            list3int.Delete(3);
            Console.WriteLine(" \nТретий список(int) с удалённым элементом:");
            Print(list3int);
            list3int = (--list3int);
            Print(list3int);
            string str = "1234524ffgdfg";
            Console.WriteLine(str.Last_num_in_string());
            Console.WriteLine();
            Console.ReadLine();
            List<IComparable>.Output_Autor();
        }
        static void Print(List<string> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + " -> ");
                node = node.Next;
            }
            Console.WriteLine();
        }
        static void Print(List<int> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + "->");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
