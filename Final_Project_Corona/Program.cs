using System;

namespace Final_Project_Corona
{
    class Program
    {
        /* note:
         * 
         * 
         * in each place where it is written "throw new NotImplementedException();"
         * replace with your own code.
         * Remember: No compilation error should be at the end
         * GOOD LUCK!!!
         */

        

        static void Main()
        {
            TestTheAssignment.StartTest();
        }

        public static int Q1(int[] arr)
        {
            int sum = 0, count = 0;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] >= 100 && arr[i] <= 999)
                    sum += arr[i];
                if (arr[i] > 669)
                    count++;
            }
            Console.WriteLine("Sum of 3 digits numbers: " + sum);
            return count;
        }

        public static bool Q2(bool[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] == arr[i + 1])
                    return false;
            }
            return true;
        }

        //Q3b
        public static Sofa[] ThreeSofas(Sofa[] sofas, double budget)
        {
            for (int i=0; i<sofas.Length-2; i++)
            {
                for (int j=i+1; j<sofas.Length-1; j++)
                {
                    for (int k=j+1; k<sofas.Length; k++)
                    {
                        if (sofas[i].GetPrice() + sofas[j].GetPrice() + sofas[k].GetPrice() == budget)
                            return new Sofa[] { sofas[i], sofas[j], sofas[k] };
                    }
                }
            }
            return null;
        }

        //Auxilary recursive function for Q6a
        private static int StringToInt(string num, int n)
        {
            if (num.Length == 0)
                return n;
            n *= 10;
            int digit = num[0] - '0';
            n += digit;
            return StringToInt(num.Substring(1), n);
        }

        //Q6a
        //Note: using int.Parse() is not allowed
        public static int StringToInt(string num)
        {
            //Calling to auxilary recursive function
            return StringToInt(num, 0);
        }

        //Q6b
        public static int CalcStr(string num1, string num2, char op)
        {
            if (op == '+')
                return StringToInt(num1) + StringToInt(num2);
            if (op == '-')
                return StringToInt(num1) - StringToInt(num2);
            if (op == '*')
                return StringToInt(num1) * StringToInt(num2);
            //else: op == '/'
            return StringToInt(num1) / StringToInt(num2);
        }

        //Q6c
        public static int MathStack(Stack<char> st)
        {
            string num1 ="", num2="";
            char op;
            while (st.Top() != '+' && st.Top() != '-' && st.Top() != '*' && st.Top() != '/')
            {
                char dig = st.Pop();
                num1 += dig;
            }
            op = st.Pop();
            while (!st.IsEmpty() && st.Top() != '=')
            {
                char dig = st.Pop();
                num2 += dig;
            }
            return CalcStr(num1, num2, op);

        }

        //auxilaries for IsStatic
        public static bool IsLeaf(BinNode<int> t)
        {
            return t.GetLeft() == null && t.GetRight() == null;
        }
        public static int SumLeafs(BinNode<int> t)
        {
            if (t == null)
                return 0;
            if (IsLeaf(t))
                return t.GetInfo();
            return SumLeafs(t.GetLeft()) + SumLeafs(t.GetRight());
        }

        //Q7a
        public static bool IsStatic(BinNode<int> tree)
        {
            if (tree == null || IsLeaf(tree))
                return true;
            return tree.GetInfo() == SumLeafs(tree.GetLeft()) + SumLeafs(tree.GetRight());
        }

        //Q7b
        public static bool IsVeryStatic(BinNode<int> tree)
        {
            if (tree == null || IsLeaf(tree))
                return true;
            return IsStatic(tree) && IsVeryStatic(tree.GetLeft()) && IsVeryStatic(tree.GetRight());
        }
    }
}
