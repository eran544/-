using System;
using System.Text;

namespace Final_Project_Corona
{
    class TestTheAssignment
    {
        /* Note:
         * 
         * 
         * do not add anything here, this is used for writing the code that tests you assignment
         */
         public static bool CompareSofas(Sofa s1, Sofa s2)
        {
            return s1.GetCountry().ToLower() == s2.GetCountry().ToLower() &&
                   s1.GetModel().ToLower() == s2.GetModel().ToLower() &&
                   Math.Abs(s1.GetPrice() - s2.GetPrice()) < 0.01;
        }

        public static bool CompareArrSofas(Sofa[] sofasExpected, Sofa[] sofasRecieved)
        {
            bool ans = true;
            int n = sofasExpected.Length;
            for (int i = 0; i < n; i++)
            {
                ans = ans && CompareSofas(sofasExpected[i], sofasRecieved[i]);
            }
            return ans;
        }

        public static string StringifySofa(Sofa sofa)
        {
            return "<Model: " + sofa.GetModel() + ", Country: " + sofa.GetCountry() + ", Price = " + sofa.GetPrice() + ">";
        }

        public static bool CompareToString(string s1, string s2)
        {
            return s1.Trim(' ').ToLower() == s2.Trim(' ').ToLower();
        }
        public static bool ManualPrintCheck(int num)
        {
            Console.WriteLine("The number that should have been printed is " + num);
            Console.WriteLine("Is this number correct? y/n");
            char c = ' ';
            while (c != 'y' && c != 'n')
            {
                c = char.Parse(Console.ReadLine());
                if (c != 'y' && c != 'n')
                    Console.WriteLine("Wrong Input, try again");
            }
            return c == 'y';
        }

        public static bool CompareTrees(BinNode<int> b1, BinNode<int> b2)
        {
            if (b1 == null && b2 == null)
                return true;
            if (b1 == null && b2 != null || b1 != null && b2 == null)
                return false;
            return b1.GetInfo() == b2.GetInfo() && CompareTrees(b1.GetLeft(), b2.GetLeft())
                && CompareTrees(b1.GetRight(), b2.GetRight());
        }

        public static bool CompareNodes(Node<int> n1, Node<int> n2)
        {
            Node<int> head1 = n1, head2 = n2;
            while (head1 != null && head2 != null)
            {
                if (head1.GetInfo() != head2.GetInfo())
                    return false;
                head1 = head1.GetNext();
                head2 = head2.GetNext();
            }
            return (head1 == null && head2 == null);
        }

        public static string ArrToString(int[] arr)
        {
            string s = "[";
            int n = arr.Length;
            if (n == 0)
                return "[]";
            for (int i = 0; i < n-1; i++)
            {
                s += arr[i] + ", ";
            }
            s += arr[n - 1] + "]";
            return s;
        }

        public static string ArrToString(bool[] arr)
        {
            string s = "[";
            int n = arr.Length;
            if (n == 0)
                return "[]";
            for (int i = 0; i < n - 1; i++)
            {
                s += arr[i] + ", ";
            }
            s += arr[n - 1] + "]";
            return s;
        }

        public static string ArrToString(Sofa[] arr)
        {
            string s = "[\n";
            int n = arr.Length;
            if (n == 0)
                return "[]";
            for (int i = 0; i < n - 1; i++)
            {
                s += "Sofa " + i + ": " + StringifySofa(arr[i]) + "\n";
            }
            s += "Sofa " + (n-1) + ": " + StringifySofa(arr[n-1]) + "\n]";
            return s;
        }

        public static double GraderQ1(int[] arr, int numTest, int expected, int expectedSum)
        {
            int grade = 0;
            int recieved1;
            Console.WriteLine("Test "+ numTest + "a started! sent: \n" + ArrToString(arr));
            try
            {
                Console.WriteLine("**************begin Q1 input***************");
                recieved1 = Program.Q1(arr);
                Console.WriteLine("**************finished without exception***************");
                if (recieved1 == expected)
                {
                    grade += 1;
                    Console.WriteLine("Passed Test " + numTest + "a");
                }
                else
                    Console.WriteLine("Failed test " + numTest+ "a: expected: " + expected + ", but recieved: " + recieved1);
            }
            catch (Exception e)
            {
                Console.WriteLine("*****************Recieved Exception: " + e.Message);
                Console.WriteLine("Failed test " + numTest + "a");
            }
            bool res = ManualPrintCheck(expectedSum);
            if (res)
            {
                Console.WriteLine("Passed Test " + numTest + "b");
                grade += 1;
            }
            else
                Console.WriteLine("Failed test " + numTest + "b");
            return grade;
        }

        public static double TestAssignment1()
        {
            Console.WriteLine("*******BEGIN Q1***********");
            double maxGrade = 4;
            double grade;
            int[] arr1 = new int[62];
            int[] arr2 = new int[62];
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = i * 21;
            for (int i = 0; i<arr2.Length; i++)
            {
                arr2[i] = i * 21 - 3;
            }
            grade = GraderQ1(arr1, 1, 30, 23478) + GraderQ1(arr2, 2, 29, 23349);
            Console.WriteLine("*******FINISHED Q1********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return grade;
        }

        public static double GraderQ2(bool[] arr, int numTest, bool expected)
        {
            Console.WriteLine("Test " + numTest + "a started! sent: \n" + ArrToString(arr));
            bool recieved;
            double grade = 0;
            try
            {
                recieved = Program.Q2(arr);
                if (recieved == expected)
                {
                    grade = 0.5;
                    Console.WriteLine("Passed Test " + numTest);
                }
                else
                    Console.WriteLine("Failed test " + numTest + " expected: " + expected + ", but recieved: " + recieved);
            }
            catch (Exception e)
            {
                Console.WriteLine("*****************Recieved Exception: " + e.Message);
                Console.WriteLine("Failed test " + numTest);
            }
            return grade;
        }
        public static double TestAssignment2()
        {
            Console.WriteLine("*******BEGIN Q2***********");
            double maxGrade = 5;
            double grade = 0;
            bool[] arr1 = new bool[0];
            grade += GraderQ2(arr1, 1, true);
            bool[] arr2 = { true };
            grade += GraderQ2(arr2, 2, true);
            bool[] arr3 = { false };
            grade += GraderQ2(arr3, 3, true);



            Console.WriteLine("*******FINISHED Q2********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }
        public static double TestAssignment3()
        {
            Console.WriteLine("*******BEGIN Q3***********");
            double maxGrade = 6;
            double grade = 0;

            Console.WriteLine("*******FINISHED Q3********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }
        public static double TestAssignment4()
        {
            Console.WriteLine("*******BEGIN Q4***********");
            double maxGrade = 6;
            double grade = 0;

            Console.WriteLine("*******FINISHED Q4********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }
        public static double TestAssignment5()
        {
            Console.WriteLine("*******BEGIN Q5***********");
            double maxGrade = 8;
            double grade = 0;

            Console.WriteLine("*******FINISHED Q5********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }
        public static double TestAssignment6()
        {
            Console.WriteLine("*******BEGIN Q6***********");
            double maxGrade = 8;
            double grade = 0;

            Console.WriteLine("*******FINISHED Q6********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }
        public static double TestAssignment7()
        {
            Console.WriteLine("*******BEGIN Q7***********");
            double maxGrade = 8;
            double grade = 0;

            Console.WriteLine("*******FINISHED Q7********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }
        public static double TestAssignment8()
        {
            Console.WriteLine("*******BEGIN Q8***********");
            double maxGrade = 15;
            double grade = 0;

            Console.WriteLine("*******FINISHED Q8********");
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.WriteLine("**************************");
            Console.ReadLine();
            return 0;
        }

        public static double StartTest()
        {
            double grade = 0;
            grade += TestAssignment1(); // OK
            grade += TestAssignment2(); //testing    
            grade += TestAssignment3(); //in- 
            grade += TestAssignment4();
            grade += TestAssignment5();
            grade += TestAssignment6();
            grade += TestAssignment7();
            grade += TestAssignment8();
            Console.WriteLine("***************FINISHED ALL TESTS******************");
            Console.WriteLine("Final grade for automatic tests: " + grade);
            return grade;
        }
    }
}
