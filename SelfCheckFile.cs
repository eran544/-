using System;
using System.Text;

namespace Final_Project_Corona
{
    class TestTheAssignment
    {
        public static void CheckYourselfForCompilationErrors()
        {
            /* How to use this function:
             * 1. Copy & Paste this function to be as a seperate function in file TestTheAssignment.cs
             * 2. Check if you have any compilation errors in this function
             * If you find Some, then change your code (Not this function!!!)
             * so it will not have any compilation code
             * If there is no compilation errors then it's awesome because we can test your work
             * however it doesn't say anything about the quality of your assignment 
             * nor what your grade should be.
             * Note: There is no need to call this function at all, just check for errors
             * however, you can use this file by your own to test your own work
             * GOOD LUCK!
             * 
             */
            //Q1
            int[] arr = new int[62];
            Program.Q1(arr);
            //Q2
            bool[] arr2 = new bool[0];
            Program.Q2(arr2);
            //Q3a - check if constructor and gets work properly
            Sofa stam = new Sofa("Stam model", "Stan country", 0);
            string st = stam.GetModel();
            st = stam.GetCountry();
            double num = stam.GetPrice();
            //Q3b - check if you can send proparly
            Sofa[] stamArr = { stam, stam, stam };
            Sofa[] stamResult = Program.ThreeSofas(stamArr, 0);

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
            int stamNum = Program.StringToInt("15");
            stamNum = Program.CalcStr("1", "1", '+');
            Stack<char> stamStack = new Stack<char>();
            stamStack.Push('=');
            stamStack.Push('1');
            stamStack.Push('+');
            stamStack.Push('1');
            stamNum = Program.MathStack(stamStack);

            //Q7
            BinNode<int> stamTree = new BinNode<int>(1);
            stamBool = Program.IsStatic(stamTree);
            stamBool = Program.IsVeryStatic(stamTree);

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
        /* Note:
         * 
         * 
         * do not add anything here, this is used for writing the code that tests you assignment
         */
    }
}
