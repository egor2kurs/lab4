using System;


namespace Lab4
{
    public class Owner
    {
        public int ID;
        public string name;
        public string organisation;
        public Owner()
        {
            ID = 0;
            name = null;
            organisation = null;
        }
        public Owner(int ID, string name, string organisation)
        {
            this.ID = ID;
            this.name = name;
            this.organisation = organisation;
        }
       public static Owner egor = new Owner(123, "egor", "sharaga");
    }
    public class List<T> where T : IComparable
    {
        private const string V = "";
        private Item<T> head;
        private Item<T> tail;
        private int count;
        
        public class Date
        {
            public DateTime date = DateTime.Now;
            public Date()
            {

            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public Item<T> First
        {
            get
            {
                return head;
            }
        }
        public List()
        {

        }
        public void AddAfter(Item<T> node, T value)
        {
            Item<T> newNode = new Item<T>(value, node.Next);
            node.Next = newNode;

            count++;
        }
        public void Add(T value)
        {
            if (head == null)
            {
                head = tail = new Item<T>(value, null);
                count++;
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.Next;
            }
        }
        public Item<T> Find(T value)
        {
            Item<T> ptr = head;
            while (ptr != null)
            {
                if (ptr.Value.CompareTo(value) == 0)
                    return ptr;
                ptr = ptr.Next;
            }
            return null;
        }
        public static List<T> operator +(List<T> list1, List<T> list2) //перегрузка сложения 
        {
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null)
            {
                node1 = node1.Next;
                if (node1.Next == null)
                {
                    node1.Next = node2;
                    break;
                }
            }
            return list1;
        }
        public static List<T> operator --(List<T> list) //перегурзка дикримент
        {
            var node = list.head;
            list.head = null;
            list.head = node.Next;
            return list;
        }
        public static bool operator ==(List<T> list1, List<T> list2) //перегрузка на сравнение
        {
            bool check = false;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 0)
                {
                    check = true;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
        public static bool operator !=(List<T> list1, List<T> list2) //Перегрузка на неравность
        {
            bool check = true;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 0)
                {
                    check = false;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
        public void Delete(T data)
        {
            if(head != null)
            {
                if (head.Value.Equals(data))
                {
                    head = head.Next;
                    count--;
                    return;
                }
                var current = head.Next;
                var previous = head;
                while(current != null)
                {
                    if (current.Value.Equals(data))
                    {
                        previous.Next = current.Next;
                        count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }
        public static void Output_Autor()
        {
            Console.WriteLine("Выполнил: №" + Convert.ToString(Owner.egor.ID) + " " + Owner.egor.name + " из " + Owner.egor.organisation);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");
        }
    }
    public static class StatisticOperation
    {
        public static int Counter(List<string> list)
        {
            int count = 0;
            var node = list.First;
            while (node != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }


        public static char Last_num_in_string(this string str1)
        {
            char g = ' ';
            int i = 0;
            while (i + 1 <= str1.Length)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str1[i].ToString() == j.ToString())
                    {
                        g = str1[i];
                    }
                }
                i++;
            }
            return g;
        }
    }


}
