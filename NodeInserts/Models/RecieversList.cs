using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class RecieversList
    {
        private Node<ShabatRecievers> lst;
        private Node<ShabatRecievers> tail;
        public RecieversList()
        {
            lst = null;
            tail = null;
        }
        public void AddReciever(ShabatRecievers reciever)
        {
            if (lst == null)
            {
                lst = new Node<ShabatRecievers>(reciever);
                tail = lst;
            }
            else
            {
                tail.SetNext(new Node<ShabatRecievers>(reciever));
                tail = tail.GetNext();
            }
        }
        public void DeleteReciever(string name)
        {
            Node<ShabatRecievers> prv;
            Node<ShabatRecievers> next;
        }
    }
}
