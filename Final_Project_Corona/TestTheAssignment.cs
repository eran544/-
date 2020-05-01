using System;
using System.Linq;
using System.Text;

namespace Final_Project_Corona
{
    class TestTheAssignment
    {
        /* Instructions - Please read it:
         * The purpose of this code is to check and test
         * the correction of each task according to the
         * specifications detailed in the PDF.
         * HOW TO USE THIS FILE BY YOURSELF:
         * 1. Replace your own "TestTheAssignment.cs" file with this one
         * 2. On "Program.cs", at Main(): Write the following line:
         *    "TestTheAssignment.StartTest();"
         * 3. Run the project
         * 4. Watch the magic happens :)
         * 5. On task 1: Answer the question regarding the printing 
         * 6. Every test you pass will be followed by 2 messages colored green
         *    Every test that finished without exception but still failed:
         *          Will be seen by one green message and one red message.
         *    Every Test that will recieve Exception:
         *          Will be seen by 2 messages colored red, with details about the Exception.
         * 7. After the test of each task is completed you will see how points you were graded.
         *    You can easily spot it since it will be colored blue.
         * 8. To continue testing the next task, press Enter.
         * 9. If you got anymore questions, please dont hesitate asking Adir or me (Eran).
         * 
         * Copyright: Eran Salomon, Mekif Vav School, Beersheva, Israel.
         * Date: April - May 2020
         */



        //some print methods that were exctracted
        private static void PrintStarsAndPressEnter()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*******Press Enter to continue******");
        }

        private static void EndQNum(int num)
        {
            Console.WriteLine("***********FINISHED TASK" + num + "***********");
        }

        private static void BeginQNum(int num)
        {
            Console.WriteLine("************BEGIN TASK" + num + "*************");
        }
        //adding color to easily spot passed and failed teasts
        private static void PassedTest(int numTest)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passed Test " + numTest);
            Console.ResetColor();
        }
        private static void FinishedWithoutException()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************Finished without exception***************");
            Console.ResetColor();
        }
        private static void FailedWithoutException(int numTest, int expected, int recieved)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed test " + numTest + " expected: " + expected + ", but recieved: " + recieved);
            Console.ResetColor();
        }
        private static void FailedWithoutException(int numTest, bool expected, bool recieved)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed test " + numTest + " expected: " + expected + ", but recieved: " + recieved);
            Console.ResetColor();
        }

        private static void FailedWithoutException(int numTest, string expected, string recieved)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed test " + numTest + " expected: " + expected + ", but recieved: " + recieved);
            Console.ResetColor();
        }
        private static void RecievedException(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Recieved Exception: " + e.Message);
            Console.ResetColor();

        }
        private static void FailedWithExceptions(int numTest)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed test " + numTest);
            Console.ResetColor();
        }
        private static void Recieved(double maxGrade, double grade)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Recived " + grade + "/" + maxGrade);
            Console.ResetColor();
        }

        private static void TestForNumAndLetter(int num, char letter)
        {
            Console.WriteLine("**********************TESTS FOR "+num +""+ letter + "**********************");
        }
        private static void TestStarted(string str, int numTest)
        {
            Console.WriteLine("Test " + numTest + " started! sent: " + str);
        }
        private static void TestStarted(string num1, string num2, char op, int numTest)
        {
            Console.WriteLine("Test " + numTest + " started! sent:");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2 + ", op = "+op);
        }



        //some auxileries methodes for comparing

        private static bool CompareSofas(MySofa s1, Sofa s2)
        {
            return s1.Country.ToLower() == s2.GetCountry().ToLower() &&
                   s1.Model.ToLower() == s2.GetModel().ToLower() &&
                   Math.Abs(s1.Price - s2.GetPrice()) < 0.01;
        }

        /* This Methods removes all whitespaces in a string
         * used to test ToString() methods
         * credit: https://stackoverflow.com/a/14591148
         */
        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray());
        }
        private static bool Exists(MySofa mySofa, Sofa[] sofas)
        {
            bool ans = false;
            foreach (Sofa sofa in sofas)
                ans = ans || CompareSofas(mySofa, sofa);
            return ans;
        }
        private static bool CompareArrSofas(MySofa[] sofasExpected, Sofa[] sofasRecieved)
        {
            
            if (sofasExpected == null && sofasRecieved == null)
                return true;
            if (sofasExpected == null ^ sofasRecieved == null)
                return false;
            if (sofasExpected.Length != sofasRecieved.Length)
                return false;
            bool ans = true;
            foreach (MySofa sofa in sofasExpected)
                ans = ans && Exists(sofa, sofasRecieved);
            return ans;
        }

        private static string StringifySofa(Sofa sofa)
        {
            return "<Model: \"" + sofa.GetModel() + "\", Country: \"" + sofa.GetCountry() + "\", Price = " + sofa.GetPrice() + ">";
        }
        private static string StringifyMySofa(MySofa sofa)
        {
            return "<Model: \"" + sofa.Model + "\", Country: \"" + sofa.Country + "\", Price = " + sofa.Price + ">";
        }

        private static bool CompareToString(string s1, string s2)
        {
            return RemoveWhitespace(s1).ToLower().Equals(RemoveWhitespace(s2).ToLower());
        }

        private static bool CompareTrees(BinNode<int> b1, BinNode<int> b2)
        {
            if (b1 == null && b2 == null)
                return true;
            if (b1 == null && b2 != null || b1 != null && b2 == null)
                return false;
            return b1.GetInfo() == b2.GetInfo() && CompareTrees(b1.GetLeft(), b2.GetLeft())
                && CompareTrees(b1.GetRight(), b2.GetRight());
        }

        private static bool CompareNodes(Node<int> n1, Node<int> n2)
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

        //this methods recieved input whether the printing was correct
        private static bool ManualPrintCheck(int num)
        {
            Console.WriteLine("The number that should have been printed (in cyan) is " + num);
            Console.WriteLine("Is this number correct? y/n");
            char c = ' ';
            while (c != 'y' && c != 'n')
            {
                try
                {
                    c = char.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
                //in case by mistake input was in wrong format
                if (c != 'y' && c != 'n')
                    Console.WriteLine("Wrong Input, try again");
            }
            return c == 'y';
        }

        //methods that presents arrays as strings

        private static string ArrToString(int[] arr)
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

        private static string ArrToString(bool[] arr)
        {
            if (arr == null)
                return "NULL";
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

        private static string ArrToString(MySofa[] arr)
        {
            if (arr == null)
                return "NULL";
            string s = "[\n";
            int n = arr.Length;
            if (n == 0)
                return "[]";
            for (int i = 0; i < n - 1; i++)
            {
                s += "Sofa " + i + ": " + StringifyMySofa(arr[i]) + "\n";
            }
            s += "Sofa " + (n-1) + ": " + StringifyMySofa(arr[n-1]) + "\n]";
            return s;
        }

        private static double GraderQ1(int[] arr, int numTest, int expected, int expectedSum)
        {
            int grade = 0;
            int recieved1;
            Console.WriteLine("Test "+ numTest + "a started! sent: \n" + ArrToString(arr));
            try
            {
                Console.WriteLine("**************begin Q1 ouput***************");
                //color user output in cyan
                Console.ForegroundColor = ConsoleColor.Cyan;
                recieved1 = Program.Q1(arr);
                Console.ResetColor();
                FinishedWithoutException();
                if (recieved1 == expected)
                {
                    grade += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Passed Test " + numTest + "a");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failed test " + numTest + "a: expected: " + expected + ", but recieved: " + recieved1);
                    Console.ResetColor();
                }
            }
            catch (Exception e)
            {
                RecievedException(e);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed test " + numTest + "a");
                Console.ResetColor();
            }
            
            if (ManualPrintCheck(expectedSum))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Passed Test " + numTest + "b");
                Console.ResetColor();
                grade += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed test " + numTest + "b");
                Console.ResetColor();
            }
            return grade;
        }

        

        private static double TestQ1()
        {
            BeginQNum(1);
            double maxGrade = 4;
            double grade;
            int[] arr1 = new int[62];
            int[] arr2 = new int[62];
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = i * 21;
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i * 21 - 3;
            }
            grade = GraderQ1(arr1, 1, 30, 23478) + GraderQ1(arr2, 2, 29, 23349);
            EndQNum(1);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }



        private static double GraderQ2(bool[] arr, int numTest, bool expected)
        {
            Console.WriteLine("Test " + numTest + " started! sent: \n" + ArrToString(arr));
            bool recieved;
            double grade = 0;
            try
            {
                recieved = Program.Q2(arr);
                FinishedWithoutException();
                if (recieved == expected)
                {
                    grade = 0.5;
                    PassedTest(numTest);
                }
                else
                    FailedWithoutException(numTest, expected, recieved);
            }
            catch (Exception e)
            {
                RecievedException(e);
                FailedWithExceptions(numTest);
            }
            return grade;
        }


        private static double TestQ2()
        {
            BeginQNum(2);
            double maxGrade = 5;
            double grade = 0;
            bool[] arr1 = new bool[0];
            grade += GraderQ2(arr1, 1, true);
            bool[] arr2 = { true };
            grade += GraderQ2(arr2, 2, true);
            bool[] arr3 = { false };
            grade += GraderQ2(arr3, 3, true);
            bool[] arr4 = { true, true };
            grade += GraderQ2(arr4, 4, false);
            bool[] arr5 = { true, true };
            grade += GraderQ2(arr5, 5, false);
            bool[] arr6 = { false, false };
            grade += GraderQ2(arr6, 6, false);
            bool[] arr7 = { true, false };
            grade += GraderQ2(arr7, 7, true);
            bool[] arr8 = { false, true };
            grade += GraderQ2(arr8, 8, true);
            bool[] arr9 = { false, true, false, false };
            grade += GraderQ2(arr9, 9, false);
            bool[] arr10 = { true, false, true, true };
            grade += GraderQ2(arr10, 10, false);



            EndQNum(2);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }
        private static double GradeClassSofa(MySofa sent, int numTest)
        {
            {
                Console.WriteLine("Test " + numTest + " started! sent: \n" + StringifyMySofa(sent));
                bool recieved;
                try
                {
                    Sofa studentSofa = new Sofa(sent.Model, sent.Country, sent.Price);
                    recieved = CompareSofas(sent, studentSofa);
                    FinishedWithoutException();
                    if (recieved)
                    {
                        PassedTest(numTest);
                        return 0.75;
                    }
                    else
                    {
                        FailedWithoutException(numTest, StringifyMySofa(sent), StringifySofa(studentSofa));
                        return 0;
                    }
                }
                catch (Exception e)
                {
                    RecievedException(e);
                    FailedWithExceptions(numTest);
                    return 0;
                }
            }
        }

        private static Sofa[] MySofaToStudentsSofa(MySofa[] arr)
        {
            if (arr == null)
                return null;
            Sofa[] output = new Sofa[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                output[i] = new Sofa(arr[i].Model, arr[i].Country, arr[i].Price);
            }
            return output;
        }
        private static MySofa[] StudentsSofaToMySofa(Sofa[] arr)
        {
            if (arr == null)
                return null;
            MySofa[] output = new MySofa[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                output[i] = new MySofa(arr[i].GetModel(), arr[i].GetCountry(), arr[i].GetPrice());
            }
            return output;
        }
        private static double GradeThreeSofa(MySofa[] sent, double budget, MySofa[] expected, int numTest)
        {
            {
                Console.WriteLine("Test " + numTest + " started! sent: \n" + ArrToString(sent) + "\nwith budget = "+ budget);
                Sofa[] studentSofaArr = MySofaToStudentsSofa(sent);
                Sofa[] recieved;
                try
                {
                    recieved = Program.ThreeSofas(studentSofaArr, budget);
                    FinishedWithoutException();
                    if (CompareArrSofas(expected, recieved))
                    {
                        PassedTest(numTest);
                        return 1.5;
                    }
                    else
                    {
                        FailedWithoutException(numTest, ArrToString(expected), ArrToString(StudentsSofaToMySofa(recieved)));
                        return 0;
                    }
                }
                catch (Exception e)
                {
                    RecievedException(e);
                    FailedWithExceptions(numTest);
                    return 0;
                }
            }
        }

        private static SofaWithResults SofaGenerator1()
        {
            MySofa[] arr =
            {
                new MySofa("Kosher Model", "Israel", 500.24),
                new MySofa("Mama Sofa", "Italy", 624.75),
                new MySofa("La Sofa", "Spain", 328.93),
                new MySofa("Ljublisofa", "Slovenia", 221.28),
                new MySofa("Mi Fan Sofa", "China", 990.5),
                new MySofa("Namastofa", "India", 384.75)
            };
            MySofa[] result = { arr[1], arr[4], arr[5] };
            double budget = 2000;
            return new SofaWithResults(arr, result, budget);
        }

        private static SofaWithResults SofaGenerator2()
        {
            MySofa[] arr =
{
                new MySofa("Unemployed Sofa", "South Africa", 1426.17),
                new MySofa("Apologizing Sofa", "Canada", 1431.11),
                new MySofa("LMFAO Sofa", "United States", 847.96),
                new MySofa("Moscofa", "Russia", 2221.28),
                new MySofa("Abu Sofa", "Saudi Arabia", 1739.99),
                new MySofa("Tudu Bom Sofa", "Brazil", 666.66),
                new MySofa("Hopping Sofa", "Australia", 456.78)
            };
            MySofa[] result = null;
            double budget = 5400.29;
            return new SofaWithResults(arr, result, budget);
        }

        private static SofaWithResults SofaGenerator3()
        {
            MySofa[] arr =
            {
                new MySofa("My Precious Sofa", "Mordor", 2062.12),
                new MySofa("Wingardium Levisofa", "Hogwarts", 9091.98),
                new MySofa("SpongeBob SquareSofa", "Bikini Bottom", 5284.59),
                new MySofa("The Hunger Sofa", "12th district", 1166.33),
                new MySofa("Dinosofa", "Jurassic Park", 4312.06),
                new MySofa("Spider Sofa", "Springfield", 1975.91),
                new MySofa("I am your Sofa", "Death Star", 7571.80),
                new MySofa("Soofie Doobie Do", "Coolsville", 6110.40) 
            };
            MySofa[] result = { arr[5], arr[6], arr[7] };
            double budget = 15658.11;
            return new SofaWithResults(arr, result, budget);
        }
        private static double TestQ3()
        {
            BeginQNum(3);
            double maxGrade = 6;
            double grade = 0;
            MySofa test1 = new MySofa("Kosher Model", "Israel", 999.99);
            grade += GradeClassSofa(test1, 1);
            MySofa test2 = new MySofa("Wingardium Levisofa", "Hogwarts", 729.99);
            grade += GradeClassSofa(test2, 2);
            SofaWithResults sofa1 = SofaGenerator1();
            grade += GradeThreeSofa(sofa1.Sofas, sofa1.Budget, sofa1.Result, 3);
            SofaWithResults sofa2 = SofaGenerator2();
            grade += GradeThreeSofa(sofa2.Sofas, sofa2.Budget, sofa2.Result, 4);
            SofaWithResults sofa3 = SofaGenerator3();
            grade += GradeThreeSofa(sofa3.Sofas, sofa3.Budget, sofa3.Result, 5);

            EndQNum(3);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }

       

        private static double Q4StringGrader(HandWeight hw, string expected, int numTest)
        {
            TestStarted(expected, numTest);
            string recieved;
            try
            {
                recieved = hw.ToString();
                FinishedWithoutException();
                if (CompareToString(expected, recieved))
                {
                    PassedTest(numTest);
                    return 0.75;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e);
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double Q4BoolGrader(HandWeight hw, string hwString, bool expected, int numTest)
        {
            TestStarted(hwString, numTest);
            bool recieved;
            try
            {
                recieved = hw.IsBalanced();
                FinishedWithoutException();
                if (recieved == expected)
                {
                    PassedTest(numTest);
                    return 0.75;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e);
                FailedWithExceptions(numTest);
                return 0;
            }
        }



        private static double TestQ4()
        {
            BeginQNum(4);
            double maxGrade = 6;
            double grade = 0;
            HandWeight hw1 = new HandWeight();
            HandWeight hw2 = new HandWeight(2.5);
            HandWeight hw3 = new HandWeight(3.14, 2);
            string expected0 = "<Left: 0, Right: 0>";
            string expected25 = "<Left: 2.5, Right: 2.5>";
            string expectedpi = "<Left: 3.14, Right: 2>";
            grade += Q4StringGrader(hw1, expected0, 1);
            grade += Q4StringGrader(hw2, expected25, 2);
            grade += Q4StringGrader(hw3, expectedpi, 3);
            grade += Q4BoolGrader(hw1, expected0, true, 4);
            grade += Q4BoolGrader(hw2, expected25, true, 5);
            grade += Q4BoolGrader(hw3, expectedpi, false, 6);
            HandWeight.MoveWeight(hw1, hw2);
            grade += Q4StringGrader(hw1, expected25, 7);
            grade += Q4StringGrader(hw2, expected0, 8);



            EndQNum(4);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }
        private static double TestQ5()
        {
            BeginQNum(5);
            double maxGrade = 8;
            double grade = 0;

            EndQNum(5);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }

        private static double Q6aGrader(string str, int numTest)
        {
            TestStarted(str, numTest);
            int expected = int.Parse(str);
            int recieved;
            try
            {
                recieved = Program.StringToInt(str);
                FinishedWithoutException();
                if (recieved == expected)
                {
                    PassedTest(numTest);
                    return 0.5;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e);
                FailedWithExceptions(numTest);
                return 0;
            }
        }



        private static double Q6bGrader(string num1, string num2, char op, int numTest, int expected)
        {
            TestStarted(num1, num2, op, numTest);
            int recieved;
            try
            {
                recieved = Program.CalcStr(num1, num2, op);
                FinishedWithoutException();
                if (recieved == expected)
                {
                    PassedTest(numTest);
                    return 0.5;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double Q6cGrader(Stack<char> st, int expected, int numTest)
        {
            TestStarted("Stack - view code and details", numTest);
            int recieved;
            try
            {
                recieved = Program.MathStack(st);
                FinishedWithoutException();
                if (recieved == expected)
                {
                    PassedTest(numTest);
                    return 1;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static StackWithResult StackGenerator1()
        {
            //9123 + 42657 = 51690
            Stack<char> s = new Stack<char>();
            //junk
            s.Push('3');
            s.Push('3');
            s.Push('3');
            //starting here
            s.Push('=');
            s.Push('7');
            s.Push('6');
            s.Push('5');
            s.Push('2');
            s.Push('4');
            s.Push('+');
            s.Push('3');
            s.Push('2');
            s.Push('1');
            s.Push('9');
            return new StackWithResult(s, 51690);
        }
        private static StackWithResult StackGenerator2()
        {
            //5713-3570 = 2143
            Stack<char> s = new Stack<char>();
            //starting here
            s.Push('=');
            s.Push('0');
            s.Push('7');
            s.Push('5');
            s.Push('3');
            s.Push('-');
            s.Push('3');
            s.Push('1');
            s.Push('7');
            s.Push('5');
            return new StackWithResult(s, 2143);
        }
        private static StackWithResult StackGenerator3()
        {
            //532 * 121 = 64372
            Stack<char> s = new Stack<char>();
            //starting here
            s.Push('1');
            s.Push('2');
            s.Push('1');
            s.Push('*');
            s.Push('2');
            s.Push('3');
            s.Push('5');
            return new StackWithResult(s, 64372);
        }
        private static StackWithResult StackGenerator4()
        {
            // 3445 / 569 = 6
            Stack<char> s = new Stack<char>();
            //starting here
            s.Push('1');
            s.Push('=');
            s.Push('9');
            s.Push('6');
            s.Push('5');
            s.Push('/');
            s.Push('5');
            s.Push('4');
            s.Push('4');
            s.Push('3');
            return new StackWithResult(s, 6);
        }

        private static StackWithResult StackGenerator5()
        {
            //98732 - 64118 = 34614
            Stack<char> s = new Stack<char>();
            //starting here
            s.Push('8');
            s.Push('1');
            s.Push('1');
            s.Push('4');
            s.Push('6');
            s.Push('-');
            s.Push('2');
            s.Push('3');
            s.Push('7');
            s.Push('8');
            s.Push('9');
            return new StackWithResult(s, 34614);
        }

        private static double StackGenerator(int num)
        {
            StackWithResult result = num switch
            {
                1 => StackGenerator1(),
                2 => StackGenerator2(),
                3 => StackGenerator3(),
                4 => StackGenerator4(),
                5 => StackGenerator5(),
                //not likely to happen, but still
                _ => throw new NotSupportedException("This should not happen in StackGenerator"),
            };
            return Q6cGrader(result.Stack, result.Result, num);
        }



        private static double TestQ6()
        {
            BeginQNum(6);
            double maxGrade = 8;
            double grade = 0;
            TestForNumAndLetter(6, 'a');
            grade += Q6aGrader("0", 1);
            grade += Q6aGrader("567", 2);
            Console.WriteLine();

            TestForNumAndLetter(6, 'b');

            grade += Q6bGrader("247", "669", '+', 1, 916);
            grade += Q6bGrader("149", "567", '-', 2, -418);
            grade += Q6bGrader("2673", "1597", '*', 3, 4268781);
            grade += Q6bGrader("15684", "221", '/', 4, 70);
            Console.WriteLine();

            TestForNumAndLetter(6, 'c');
            for (int i = 1; i <= 5; i++)
                grade += StackGenerator(i);

            EndQNum(6);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }



        private static double TestQ7()
        {
            BeginQNum(7);
            double maxGrade = 8;
            double grade = 0;

            EndQNum(7);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }
        private static double TestQ8()
        {
            BeginQNum(8);
            double maxGrade = 15;
            double grade = 0;

            EndQNum(8);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
            return grade;
        }

        public static double StartTest()
        {
            double grade = 0;
            const int MAX_GRADE = 60;
            grade += TestQ1(); // OK
            grade += TestQ2(); // OK   
            grade += TestQ3(); // OK 
            grade += TestQ4(); // OK
            grade += TestQ5(); // not written yet 
            grade += TestQ6(); // OK
            grade += TestQ7(); // not written yet 
            grade += TestQ8(); // not written yet 
            Console.WriteLine("***************FINISHED ALL TESTS******************");
            Console.WriteLine("Final grade for automatic tests: " + grade + "/" + MAX_GRADE);
            return grade;
        }
    }

    //additional classes for testing.
    class DifferentArrayLengthException : Exception
    {
        //An exception I've made to handle Comparing Arrays
        public DifferentArrayLengthException(string message) : base(message)
        {
        }
    }
    class SofaWithResults
    {
        //Data structure to return the sofa arr, the result arr, and budget
        public SofaWithResults(MySofa[] sofas, MySofa[] result, double budget)
        {
            Sofas = sofas;
            Result = result;
            Budget = budget;
        }
        public double Budget { get; set; }
        internal MySofa[] Sofas { get; set; }
        internal MySofa[] Result { get; set; }
    }

    class StackWithResult
    {
        //Data structure to return both the stack and the expected results
        public StackWithResult(Stack<char> stack, int result)
        {
            Stack = stack;
            Result = result;
        }

        public Stack<char> Stack { get; set; }
        public int Result { get; set; }
    }
    class MySofa
    {
        // This is my solution for this simple class
        // Created to test the funcuionality of students' solution for the Sofa class
        // (And the whole Q3)

        public string Model { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }

        public MySofa(string model, string country, double price)
        {
            this.Model = model;
            this.Country = country;
            this.Price = price;
        }

    }
}
