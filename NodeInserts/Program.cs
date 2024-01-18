using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);
            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();
            Console.WriteLine(IsShabatRecieverExist(shabatShalom, 22, 1, 2024));
            Console.WriteLine(DeleteReciever(shabatShalom, "Ofek"));
        }
        public static bool IsShabatRecieverExist(Node<ShabatRecievers> list, int day, int month, int year)
        {
            Node<ShabatRecievers> head = list;
            while (head != null)
            {
                if (head.GetValue().GetDay() == day && head.GetValue().GetMonth() == month && head.GetValue().GetYear() == year)
                    return true;
                head = head.GetNext();
            }
            return false;
        }
        public static Node<ShabatRecievers> DeleteReciever(Node<ShabatRecievers> list, string parent)
        {
            Node<ShabatRecievers> head = list;
            if (head != null && head.GetValue().GetParent1() == parent || head.GetValue().GetParent2() == parent)
            {
                head = head.GetNext();
                list.SetNext(null);
                Console.WriteLine($"{parent} is sick");
                return head;
            }
            while (head.HasNext())
            {
                if (head.GetNext().GetValue().GetParent1() == parent || head.GetNext().GetValue().GetParent2() == parent)
                {
                    head.SetNext(head.GetNext().GetNext());
                    Console.WriteLine($"{parent} is sick");
                }
            }
            return list;
        }
    }
}