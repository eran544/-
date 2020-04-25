using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Corona
{
    public class Node<T>
    {
        //DO NOT CHANGE ANYTHING HERE!!!!!
        private T info;
        private Node<T> next;

        public Node(T info)
        {
            this.info = info;
            this.next = null;
        }

        public Node(T info, Node<T> next)
        {
            this.info = info;
            this.next = next;
        }

        public T GetInfo()
        {
            return info;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetInfo(T info)
        {
            this.info = info;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public override String ToString()
        {
            return info + "-->" + next;
        }
    }
}
