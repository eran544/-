using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Corona
{
    public class BinNode<T>
    {
        //DO NOT CHANGE ANYTHING HERE!!!!!
        private T info;
        private BinNode<T> left;
        private BinNode<T> right;
        public BinNode(T info)
        {
            this.info = info;
            this.left = null;
            this.right = null;
        }
        public BinNode(BinNode<T> left, T info, BinNode<T> right)
        {
            this.info = info;
            this.left = left;
            this.right = right;
        }
        public T GetInfo()
        {
            return info;
        }
        public BinNode<T> GetLeft()
        {
            return left;
        }
        public BinNode<T> GetRight()
        {
            return right;
        }
        public void SetInfo(T info)
        {
            this.info = info;
        }
        public void SetLeft(BinNode<T> left)
        {
            this.left = left;
        }
        public void SetRight(BinNode<T> right)
        {
            this.right = right;
        }
        public override String ToString()
        {
            return info.ToString();
        }
    }
}
