using System;
using System.Text;

namespace Final_Project_Corona
{
    class TwinList
    {
        //Q5
        //add fileds as you wish
        private Node<int> chain;


        //Complete those methods as requested in the assignment

        public TwinList(Node<int> chain)
        {
            this.chain = chain;
        }
        public Node<int> GetEven()
        {
            int i = 1;
            Node<int> n = chain, output = new Node<int>(chain.GetInfo());
            n = n.GetNext();
            Node<int> holder = output;
            while (n != null)
            {
                if (i%2 == 0)
                {
                    holder.SetNext(new Node<int>(n.GetInfo()));
                    holder = holder.GetNext();
                }
                n = n.GetNext();
                i++;
            }
            return output;
        }
        public Node<int> GetOdd()
        {
            int i = 0;
            Node<int> n = chain, output = new Node<int>(chain.GetNext().GetInfo());
            n = n.GetNext().GetNext();
            Node<int> holder = output;
            while (n != null)
            {
                if (i % 2 == 1)
                {
                    holder.SetNext(new Node<int>(n.GetInfo()));
                    holder = holder.GetNext();
                }
                n = n.GetNext();
                i++;
            }
            return output;
        }

        public Node<int> GetChain()
        {
            return chain;
        }
        
        public Node<int> SwitchChain()
        {
            Node<int> odd = GetOdd(), even = GetEven();
            Node<int> output = new Node<int> (odd.GetInfo());
            output.SetNext(new Node<int> (even.GetInfo()));
            Node<int> holderOutput = output.GetNext();
            odd = odd.GetNext();
            even = even.GetNext();
            while (odd != null)
            {
                holderOutput.SetNext(new Node<int>(odd.GetInfo()));
                holderOutput = holderOutput.GetNext();
                holderOutput.SetNext(new Node<int>(even.GetInfo()));
                holderOutput = holderOutput.GetNext();
                odd = odd.GetNext();
                even = even.GetNext();
            }
            if (even != null)
                holderOutput.SetNext(new Node<int>(even.GetInfo()));
            return output;
           
        }
    }
}
