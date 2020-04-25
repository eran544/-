using System;

namespace Final_Project_Corona
{
	public class Stack<T>
	{

		//DO NOT CHANGE ANYTHING HERE!!!!!
		private Node<T> head;

		public Stack()
		{
			this.head = null;
		}
		public void Push(T x)
		{
			Node<T> temp = new Node<T>(x);
			temp.SetNext(head);
			head = temp;
		}

		public T Pop()
		{
			T x = head.GetInfo();
			head = head.GetNext();
			return x;
		}

		public T Top()
		{
			return head.GetInfo();
		}

		public bool IsEmpty()
		{
			return head == null;
		}

		public override string ToString()
		{
			String s = "[";
			Node<T> p = this.head;
			while (p != null)
			{
				s = s + p.GetInfo().ToString();
				if (p.GetNext() != null)
					s = s + ",";
				p = p.GetNext();
			}
			s = s + "]";
			return s;
		}
	}
}