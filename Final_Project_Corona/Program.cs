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

        static void CheckYourselfForCompilationErrors()
        {
            //Q1
            int[] arr = new int[62];
            Q1(arr);
            //Q2
            bool[] arr2 = new bool[0];
            Q2(arr2);
            //Q3a - check if constructor and gets work properly
            Sofa stam = new Sofa("Stam model", "Stan country", 0);
            string st = stam.GetModel();
            st = stam.GetCountry();
            double num = stam.GetPrice();
            //Q3b - check if you can send proparly
            Sofa[] stamArr = { stam, stam, stam };
            Sofa[] stamResult = ThreeSofas(stamArr, 0);

            //Q4
            HandWeight handWeight = new HandWeight();
            bool stamBool = handWeight.IsBalanced();
            HandWeight handWeight1 = new HandWeight(3);
            HandWeight.MoveWeight(handWeight, handWeight1);
            HandWeight handWeight2 = new HandWeight(3.14, 3);
            st = handWeight.ToString();

            //Q5
            Node<int> stamNode = new Node<int>(1);
            stamNode.SetNext(new Node<int>(2));
            TwinList twinList = new TwinList(stamNode);
            Node<int> stamNode1 = twinList.GetOdd();
            Node<int> stamNode2 = twinList.GetEven();
            Node<int> stamNode3 = twinList.SwitchChain();

            //Q6
            int stamNum = StringToInt("15");
            stamNum = CalcStr("1", "1", '+');
            Stack<char> stamStack = new Stack<char>();
            stamStack.Push('=');
            stamStack.Push('1');
            stamStack.Push('+');
            stamStack.Push('1');
            stamNum = MathStack(stamStack);

            //Q7
            BinNode<int> stamTree = new BinNode<int>(1);
            stamBool = IsStatic(stamTree);
            stamBool = IsVeryStatic(stamTree);

            //Q8
            //car
            Car stamCar = new Car(123, 5, 4, "Me", 5);
            stamNum = stamCar.GetLicensePlate();
            stamNum = stamCar.GetNumOfSeats();
            stamNum = stamCar.GetNumOfWheels();
            stamCar.SellVehicle("You");
            st = stamCar.GetOwner();
            stamCar.SetAmount(2);
            num = stamCar.GetAmount();
            num = stamCar.GetCapacity();
            stamCar.FuelUp();
            st = stamCar.ToString();

            //Bicycle
            Bicycle bicycle = new Bicycle(123, 1, 2, "Me");
            stamNum = bicycle.GetLicensePlate();
            stamNum = bicycle.GetNumOfSeats();
            stamNum = bicycle.GetNumOfWheels();
            bicycle.SellVehicle("You");
            st = bicycle.GetOwner();
            bicycle.Ride(5);
            bicycle.Charge(5);
            st = stamCar.ToString();

            //Bus
            Bus bus = new Bus(123, 50, 10, "Dan Beersheva", 100, 8);
            stamNum = bus.GetLicensePlate();
            stamNum = bus.GetNumOfSeats();
            stamNum = bus.GetNumOfWheels();
            bus.SellVehicle("Metropoline");
            st = bus.GetOwner();
            bus.SetAmount(2);
            num = bus.GetAmount();
            num = bus.GetCapacity();
            bus.FuelUp();
            st = bus.ToString();
            stamNum = bus.GetBusLine();
            bus.ChangeBusLine(25);

        }

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

        //Q6a
        //Note: using int.Parse() is not allowed
        public static int StringToInt(string num)
        {
            int output = 0;
            for (int i=0; i<num.Length; i++)
            {
                output *= 10;
                int digit = num[i] - '0';
                output += digit;
            }
            return output;
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
