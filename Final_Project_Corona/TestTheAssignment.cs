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
        * Note: In case of Stack Overflow Exception in our automatic testing, made due to incorrect recursive implementation:
        * Since that exception cannot be caught by try-catch,  we will replace it by
        * throwing new NotImplementedException, dropping all the points of this function, 
        * even if it did pass one or more of previous tests.
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
        private static void PassedTest(int numTest, int expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passed Test " + numTest + ", recieved as expected: " + expected);
            Console.ResetColor();
        }
        private static void PassedTest(int numTest, bool expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passed Test " + numTest + ". Recieved as expected: " + expected);
            Console.ResetColor();
        }
        private static void PassedTest(int numTest, MySofa[] expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passed Test " + numTest + ". Recieved as expected: " + ArrToString(expected));
            Console.ResetColor();
        }
        private static void PassedTest(int numTest, string expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passed Test " + numTest + ". Recieved as expected: " + expected);
            Console.ResetColor();
        }
        private static void PassedTest(int numTest, double expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passed Test " + numTest + ". Recieved as expected: " + expected);
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
        private static void FailedWithoutException(int numTest, double expected, double recieved)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed test " + numTest + " expected: " + expected + ", but recieved: " + recieved);
            Console.ResetColor();
        }
        /*
        private static void RecievedException(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Recieved Exception: " + e.Message);
            Console.ResetColor();

        }
        */
        private static void RecievedException(Exception e, MySofa expected)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected: " + StringifyMySofa(expected) + " but recieved Exception: " + e.Message);
            Console.ResetColor();
        }
        private static void RecievedException(Exception e, int expected)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected: " + expected + " but recieved Exception: " + e.Message);
            Console.ResetColor();
        }
        private static void RecievedException(Exception e, string expected)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected: " + expected + " but recieved Exception: " + e.Message);
            Console.ResetColor();
        }
        private static void RecievedException(Exception e, bool expected)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected: " + expected + " but recieved Exception: " + e.Message);
            Console.ResetColor();
        }
        private static void RecievedException(Exception e, MySofa[] expected)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected: " + ArrToString(expected) + " but recieved Exception: " + e.Message);
            Console.ResetColor();
        }
        private static void RecievedException(Exception e, double expected)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected: " + expected + " but recieved Exception: " + e.Message);
            Console.ResetColor();
        }
        private static void RecievedExceptionAtConstructor(Exception e, string where)
        {
            RecievedException(e, "Constrctor of " + where);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Since it recieved Exception in constrctor of " + where + ":" +
                " No tests will be applied to this case");
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
            Console.WriteLine("**********************TESTS FOR " + num + "" + letter + "**********************");
        }
        private static void TestStarted(string str, int numTest)
        {
            Console.WriteLine("Test " + numTest + " started! sent: " + str);
        }
        private static void TestStarted(string num1, string num2, char op, int numTest)
        {
            Console.WriteLine("Test " + numTest + " started! sent:");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2 + ", op = " + op);
        }
        const int GET_CHAIN = 1;
        const int GET_EVEN = 2;
        const int GET_ODD = 3;
        const int SWTCH = 4;
        private static string TestStarted(TwinListWithResult twinList, int numTest, int type)
        {
            return type switch
            {
                GET_CHAIN => "Test " + numTest + " started!" +
                " Testing GetChain. Sent: " + twinList.Node.ToString(),
                GET_EVEN => "Test " + numTest + " started!" +
                " Testing GetEven. Sent: " + twinList.Node.ToString(),
                GET_ODD => "Test " + numTest + " started!" +
                " Testing GetOdd. Sent: " + twinList.Node.ToString(),
                SWTCH => "Test " + numTest + " started!" +
                " Testing SwitchChain. Sent: " + twinList.Node.ToString(),
                _ => throw new NotSupportedException("This should not happen in TestStarted TwinList"),
            };
        }
        private static void ObjectOrientedStarted(string vehicle)
        {
            Console.WriteLine("Object Oriented Test Started - Begin: " + vehicle);
        }
        private static void ObjectOrientedFinished(string vehicle, double grade, int maxGrade)
        {
            Console.WriteLine("Object Oriented Test for " + vehicle + " has ended!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Recieved "+grade+"/"+maxGrade);
            Console.WriteLine();
            Console.ResetColor();
        }
        private static void FinishTaskMesseges(int num, double maxGrade, double grade)
        {
            EndQNum(num);
            Recieved(maxGrade, grade);
            PrintStarsAndPressEnter();
            Console.ReadLine();
        }



        //some auxileries methodes for comparing

        private static bool EqualsDouble(double num1, double num2)
        {
            return Math.Abs(num1 - num2) < 0.01;
        }
        private static bool CompareSofas(MySofa s1, Sofa s2)
        {
            return s1.Country.ToLower() == s2.GetCountry().ToLower() &&
                   s1.Model.ToLower() == s2.GetModel().ToLower() &&
                    EqualsDouble(s1.Price, s2.GetPrice());
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
        private static string StringifyCar(Car car)
        {
            string output =
            "license Plate: " + car.GetLicensePlate() + " num of seats: " + car.GetNumOfSeats()
            + " num of wheels: " + car.GetNumOfWheels() + " Owner: " + car.GetOwner();
            output += " missing for full capacity: " + (car.GetCapacity() - car.GetAmount());
            return output;

        }
        private static string StringifyBus(Bus bus)
        {
            string output =
            "license Plate: " + bus.GetLicensePlate() + " num of seats: " + bus.GetNumOfSeats()
            + " num of wheels: " + bus.GetNumOfWheels() + " Owner: " + bus.GetOwner();
            output += " missing for full capacity: " + (bus.GetCapacity() - bus.GetAmount());
            output += " bus line: " + bus.GetBusLine();
            return output;
        }
        private static string StringifyBicycle(Bicycle bicycle)
        {
            string output =
            "license Plate: " + bicycle.GetLicensePlate() + " num of seats: " + bicycle.GetNumOfSeats()
            + " num of wheels: " + bicycle.GetNumOfWheels() + " Owner: " + bicycle.GetOwner();
            output += " current precentage: " + bicycle.GetCurrentPrecentage();
            return output;
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

        private static bool YesOrNoCheck()
        {
            Console.WriteLine("Is this printing correct? y/n");
            char c = ' ';
            while (c != 'y' && c != 'n')
            {
                try
                {
                    c = char.Parse(Console.ReadLine());
                }
                catch (Exception) { }
                //in case by mistake input was in wrong format
                finally
                {
                    if (c != 'y' && c != 'n')
                        Console.WriteLine("Wrong Input, try again");
                }
            }
            return c == 'y';
        }

        //this methods recieved input whether the printing was correct
        private static bool ManualPrintCheck(int num)
        {
            Console.WriteLine("The number that should have been printed (in cyan) is " + num);
            return YesOrNoCheck();
        }
        private static bool ManualPrintCheck(Bicycle bicycle)
        {
            //I know I don't have to do this function again since bus inherit vehicle
            //but it might fail our tests if student will not do as well
            Console.WriteLine("Testing bicycle.Tostring() manually");
            Console.WriteLine("Should print:\n" + StringifyBicycle(bicycle));
            Console.WriteLine("Output is in Cyan");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(bicycle.ToString());
            Console.ResetColor();
            return YesOrNoCheck();
        }
        private static bool ManualPrintCheck(Bus bus)
        {
            //Again, I know I don't have to do this function again since bus inherit car
            //but it might fail our tests if student will not do as well
            Console.WriteLine("Testing bus.Tostring() manually");
            Console.WriteLine("Should print:\n" + StringifyBus(bus));
            Console.WriteLine("Output is in Cyan");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(bus.ToString());
            Console.ResetColor();
            return YesOrNoCheck();
        }

        private static bool ManualPrintCheck(Car car)
        {
            Console.WriteLine("Testing car.Tostring() manually");
            Console.WriteLine("Should print:\n" + StringifyCar(car));
            Console.WriteLine("Output is in Cyan");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(car.ToString());
            Console.ResetColor();            
            return YesOrNoCheck();
        }

        //methods that presents arrays as strings

        private static string ArrToString(int[] arr)
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
            s += "Sofa " + (n - 1) + ": " + StringifyMySofa(arr[n - 1]) + "\n]";
            return s;
        }

        private static string AuxBinTree(BinNode<int> binNode)
        {
            if (binNode == null)
                return "";
            return AuxBinTree(binNode.GetLeft()) + " " + binNode.GetInfo() +
                AuxBinTree(binNode.GetRight());
        }

        private static string BinTreeInOrder(BinNode<int> binNode)
        {
            return "In Order: " + ('[' + AuxBinTree(binNode) + ']').Remove(1,1);
        }

        private static double GraderQ1(int[] arr, int numTest, int expected, int expectedSum)
        {
            int grade = 0;
            int recieved1;
            Console.WriteLine("Test " + numTest + "a started! sent: \n" + ArrToString(arr));
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
                    Console.WriteLine("Passed Test " + numTest + "a. Expected result was " + expected);
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
                RecievedException(e, expected);
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
            FinishTaskMesseges(1, maxGrade, grade);
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
                if (!recieved ^ expected)
                {
                    grade = 0.5;
                    PassedTest(numTest, expected);
                }
                else
                    FailedWithoutException(numTest, expected, recieved);
            }
            catch (Exception e)
            {
                RecievedException(e, expected);
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

            FinishTaskMesseges(2, maxGrade, grade);
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
                    RecievedException(e, sent);
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
            Console.WriteLine("Test " + numTest + " started! sent: \n" + ArrToString(sent) + "\nwith budget = " + budget);
            Sofa[] recieved;
            try
            {
                Sofa[] studentSofaArr = MySofaToStudentsSofa(sent);
                recieved = Program.ThreeSofas(studentSofaArr, budget);
                FinishedWithoutException();
                if (CompareArrSofas(expected, recieved))
                {
                    PassedTest(numTest, expected);
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
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }



        private static SofaWithResults SofaGenerator1()
        {
            MySofa[] arr =
            {
                new MySofa("Kosher Model", "Israel", 500.24),
                new MySofa("Mama Sofa", "Italy", 624.75),
                new MySofa("Lá Sofá", "Spain", 328.93),
                new MySofa("Ljublisofa", "Slovenia", 221.28),
                new MySofa("Mi Fan Sofa", "China", 990.5),
                new MySofa("Namastofa", "India", 384.75)
            };
            MySofa[] result = { arr[1], arr[4], arr[5] };
            double budget = 2000;
            //this case incorrect implementation such as looking for any 3 sofas
            //still return the expected result
            return new SofaWithResults(arr, result, budget);
        }

        private static SofaWithResults SofaGenerator2()
        {
            MySofa[] arr =
{
                new MySofa("Queen's Sofa", "United Kindom", 1426.17),
                new MySofa("Apologizing Sofa", "Canada", 1431.11),
                new MySofa("LMFAO Sofa", "United States", 847.96),
                new MySofa("Moscofa", "Russia", 2221.28),
                new MySofa("Abu Sofa", "Saudi Arabia", 1739.99),
                new MySofa("Tudu Bom Sofa", "Brazil", 666.66),
                new MySofa("Hopping Sofa", "Australia", 456.78)
            };
            MySofa[] result = null;
            double budget = 4293.33;
            //note: incorrect implemetation (looking for any 3 sofas
            //instead of 3 different sofas) - will result 3 apologizing sofas
            //and fail the test
            return new SofaWithResults(arr, result, budget);
        }

        private static SofaWithResults SofaGenerator3()
        {
            MySofa[] arr =
            {
                new MySofa("My Precious Sofa", "Mordor", 2062.12),
                new MySofa("Spider Sofa", "Springfield", 5219.37),
                new MySofa("Soofie Doobie Do", "Coolsville", 5284.59),
                new MySofa("The Hunger Sofa", "12th district", 1166.33),
                new MySofa("Dinosofa", "Jurassic Park", 4312.06),
                new MySofa("Wingardium Levisofa", "Hogwarts", 1975.91),
                new MySofa("I am your Sofa", "Death Star", 7571.80),
                new MySofa("SpongeBob SquareSofa", "Bikini Bottom", 6110.4),

            };
            MySofa[] result = { arr[5], arr[6], arr[7] };
            double budget = 15658.11;
            //note: incorrect implemetation (looking for any 3 sofas
            //instead of 3 different sofas - will result 3 spider sofas
            //and fail the test
            return new SofaWithResults(arr, result, budget);
        }

        private static double SofaGenerator(int num)
        {
            //this works only with VS 2019
            //replaced from switch statement to switch expression
            SofaWithResults result = num switch
            {
                1 => SofaGenerator1(),
                2 => SofaGenerator2(),
                3 => SofaGenerator3(),
                _ => throw new NotSupportedException("This should not happen in SofaGenerator")
            };
            return GradeThreeSofa(result.Sofas, result.Budget, result.Result, num);
        }
        private static double TestQ3()
        {
            BeginQNum(3);
            double maxGrade = 6;
            double grade = 0;
            TestForNumAndLetter(3, 'a');
            MySofa test1 = new MySofa("Kosher Model", "Israel", 999.99);
            grade += GradeClassSofa(test1, 1);
            MySofa test2 = new MySofa("Wingardium Levisofa", "Hogwarts", 729.99);
            grade += GradeClassSofa(test2, 2);
            TestForNumAndLetter(3, 'b');
            for (int i = 1; i < 4; i++)
            {
                grade += SofaGenerator(i);
            }

            FinishTaskMesseges(3, maxGrade, grade);
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
                    PassedTest(numTest, expected);
                    return 0.75;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
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
                if (!recieved ^ expected)
                {
                    PassedTest(numTest, expected);
                    return 0.75;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }



        private static double TestQ4()
        {
            BeginQNum(4);
            double maxGrade = 6;
            double grade = 0;
            HandWeight hw1, hw2, hw3;
            try
            {
                hw1 = new HandWeight();
                hw2 = new HandWeight(2.5);
                hw3 = new HandWeight(3.14, 2);
            }
            catch (Exception e)
            {
                RecievedExceptionAtConstructor(e, "HandWeight");
                FinishTaskMesseges(4, maxGrade, grade);
                return grade;
            }
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



            FinishTaskMesseges(4, maxGrade, grade);
            return grade;
        }

        private static double GetChainGrader(TwinListWithResult MyTwinList, TwinList result, int numTest)
        {
            Console.WriteLine(TestStarted(MyTwinList, numTest, GET_CHAIN));
            Node<int> expected = MyTwinList.Node;
            try
            {
                Node<int> recieved = result.GetChain();
                FinishedWithoutException();
                if (CompareNodes(expected, recieved))
                {
                    PassedTest(numTest, expected.ToString());
                    return 0.6;
                }
                FailedWithoutException(numTest, expected.ToString(), recieved.ToString());
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected.ToString());
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double GetOddGrader(TwinListWithResult MyTwinList, TwinList result, int numTest)
        {
            Console.WriteLine(TestStarted(MyTwinList, numTest, GET_ODD));
            Node<int> expected = MyTwinList.Odd;
            try
            {
                Node<int> recieved = result.GetOdd();
                FinishedWithoutException();
                if (CompareNodes(expected, recieved))
                {
                    PassedTest(numTest, expected.ToString());
                    return 1;
                }
                FailedWithoutException(numTest, expected.ToString(), recieved.ToString());
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected.ToString());
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double GetEvenGrader(TwinListWithResult MyTwinList, TwinList result, int numTest)
        {
            Console.WriteLine(TestStarted(MyTwinList, numTest, GET_EVEN));
            Node<int> expected = MyTwinList.Even;
            try
            {
                Node<int> recieved = result.GetEven();
                FinishedWithoutException();
                if (CompareNodes(expected, recieved))
                {
                    PassedTest(numTest, expected.ToString());
                    return 1;
                }
                FailedWithoutException(numTest, expected.ToString(), recieved.ToString());
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected.ToString());
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double SwitchChainGrader(TwinListWithResult MyTwinList, TwinList result, int numTest)
        {
            Console.WriteLine(TestStarted(MyTwinList, numTest, SWTCH));
            Node<int> expected = MyTwinList.Swtch;
            try
            {
                Node<int> recieved = result.SwitchChain();
                FinishedWithoutException();
                if (CompareNodes(expected, recieved))
                {
                    PassedTest(numTest, expected.ToString());
                    return 1.4;
                }
                FailedWithoutException(numTest, expected.ToString(), recieved.ToString());
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected.ToString());
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double TwinListGrader(TwinListWithResult twinList, TwinList result, int type, int numTest)
        {
            return type switch
            {
                GET_CHAIN => GetChainGrader(twinList, result, numTest),
                GET_EVEN => GetEvenGrader(twinList, result, numTest),
                GET_ODD => GetOddGrader(twinList, result, numTest),
                SWTCH => SwitchChainGrader(twinList, result, numTest),
                _ => throw new NotSupportedException("This should not happen in TwinListGrader"),
            };
        }

        private static TwinListWithResult TwinListGenerator1()
        {
            //0 -> 1 -> 2 -> 3 -> 4
            Node<int> mainNode = new Node<int>(0);
            mainNode.SetNext(new Node<int>(1));
            mainNode.GetNext().SetNext(new Node<int>(2));
            mainNode.GetNext().GetNext().SetNext(new Node<int>(3));
            mainNode.GetNext().GetNext().GetNext().SetNext(new Node<int>(4));
            //even: 0 -> 2 -> 4
            Node<int> evenNode = new Node<int>(0);
            evenNode.SetNext(new Node<int>(2));
            evenNode.GetNext().SetNext(new Node<int>(4));
            //odd: 1 -> 3
            Node<int> oddNode = new Node<int>(1);
            oddNode.SetNext(new Node<int>(3));

            //switch: 1 -> 0 -> 3 -> 2 -> 4
            Node<int> switchNode = new Node<int>(1);
            switchNode.SetNext(new Node<int>(0));
            switchNode.GetNext().SetNext(new Node<int>(3));
            switchNode.GetNext().GetNext().SetNext(new Node<int>(2));
            switchNode.GetNext().GetNext().GetNext().SetNext(new Node<int>(4));

            return new TwinListWithResult(mainNode, oddNode, evenNode, switchNode);


        }
        private static TwinListWithResult TwinListGenerator2()
        {
            //0 -> 1 -> 2 -> 3
            Node<int> mainNode = new Node<int>(0);
            mainNode.SetNext(new Node<int>(1));
            mainNode.GetNext().SetNext(new Node<int>(2));
            mainNode.GetNext().GetNext().SetNext(new Node<int>(3));

            //even: 0 -> 2
            Node<int> evenNode = new Node<int>(0);
            evenNode.SetNext(new Node<int>(2));

            //odd: 1 -> 3
            Node<int> oddNode = new Node<int>(1);
            oddNode.SetNext(new Node<int>(3));

            //switch: 1 -> 0 -> 3 -> 2
            Node<int> switchNode = new Node<int>(1);
            switchNode.SetNext(new Node<int>(0));
            switchNode.GetNext().SetNext(new Node<int>(3));
            switchNode.GetNext().GetNext().SetNext(new Node<int>(2));

            return new TwinListWithResult(mainNode, oddNode, evenNode, switchNode);
        }


        private static double TwinListGenerator(int num)
        {
            TwinListWithResult result = num switch
            {
                1 => TwinListGenerator1(),
                2 => TwinListGenerator2(),
                _ => throw new NotSupportedException("This should not happen in TwinListGenerator"),
            };
            double grade = 0;
            TwinList twinList;
            try
            {
                twinList = new TwinList(result.Node);
            }
            catch (Exception e)
            {
                RecievedExceptionAtConstructor(e, "TwinList");
                return 0;
            }
            if (num == 1)
                num = 0;
            else num = 4;
            for (int i = 1; i <= 4; i++)
            {
                grade += TwinListGrader(result, twinList, i, i + num);
            }
            return grade;
        }

        private static double TestQ5()
        {
            BeginQNum(5);
            double maxGrade = 8;
            double grade = 0;
            grade += TwinListGenerator(1);
            grade += TwinListGenerator(2);

            FinishTaskMesseges(5, maxGrade, grade);
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
                    PassedTest(numTest, expected);
                    return 0.5;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
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
                    PassedTest(numTest, expected);
                    return 0.5;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double Q6cGrader(Stack<char> st, int expected, int numTest)
        {
            TestStarted(st.ToString(), numTest);
            int recieved;
            try
            {
                recieved = Program.MathStack(st);
                FinishedWithoutException();
                if (recieved == expected)
                {
                    PassedTest(numTest, expected);
                    return 1;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
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
            //123456789 * 0 = 0
            Stack<char> s = new Stack<char>();
            //starting here
            s.Push('0');
            s.Push('*');
            s.Push('1');
            s.Push('2');
            s.Push('3');
            s.Push('4');
            s.Push('5');
            s.Push('6');
            s.Push('7');
            s.Push('8');
            s.Push('9');
            return new StackWithResult(s, 0);
        }


        private static double StackGenerator(int num)
        {
            //this works only with VS 2019
            //replaced from switch statement to switch expression
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

            FinishTaskMesseges(6, maxGrade, grade);
            return grade;
        }


        private static double Q7aGrader(BinNode<int> root, bool expected, int numTest)
        {
            TestStarted(BinTreeInOrder(root), numTest);
            bool recieved;
            try
            {
                recieved = Program.IsStatic(root);
                FinishedWithoutException();
                if (!recieved ^ expected)
                {
                    PassedTest(numTest, expected);
                    return 1;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double Q7bGrader(BinNode<int> root, bool expected, int numTest)
        {
            TestStarted(BinTreeInOrder(root), numTest);
            bool recieved;
            try
            {
                recieved = Program.IsVeryStatic(root);
                FinishedWithoutException();
                if (!recieved ^ expected)
                {
                    PassedTest(numTest, expected);
                    return 1;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static TreeWithResult TreeGenerator1()
        {
            //only root - should return true
            return new TreeWithResult(new BinNode<int>(8), true);
        }
        private static TreeWithResult TreeGenerator2()
        {
            //root 8, left 6. right 5 - should return false
            BinNode<int> tree = new BinNode<int>(8);
            tree.SetLeft(new BinNode<int>(6));
            tree.SetRight(new BinNode<int>(5));
            return new TreeWithResult(tree, false);
        }
        private static TreeWithResult TreeGenerator3()
        {
            /*root 8
             * left 6
             * right 5 
             * right right 3
             * right right left 2
             * should return true
             */
            BinNode<int> tree = new BinNode<int>(8);
            tree.SetLeft(new BinNode<int>(6));
            tree.SetRight(new BinNode<int>(5));
            tree.GetRight().SetRight(new BinNode<int>(4));
            tree.GetRight().GetRight().SetLeft(new BinNode<int>(2));
            return new TreeWithResult(tree, true);
        }
        private static TreeWithResult TreeGenerator4()
        {
            /* root 21
             * right 5 
             * right right 3
             * right right right 9
             * left 6 
             * left left 2
             * left left right 4
             * left left right left 4
             * left left right right 5
             * should return false
             */
            BinNode<int> tree = new BinNode<int>(21);
            tree.SetLeft(new BinNode<int>(6));
            tree.GetLeft().SetLeft(new BinNode<int>(2));
            tree.GetLeft().SetRight(new BinNode<int>(4));
            tree.GetLeft().GetRight().SetLeft(new BinNode<int>(4));
            tree.GetLeft().GetRight().SetRight(new BinNode<int>(5));
            tree.SetRight(new BinNode<int>(5));
            tree.GetRight().SetRight(new BinNode<int>(3));
            tree.GetRight().GetRight().SetRight(new BinNode<int>(9));
            return new TreeWithResult(tree, false);
        }
        private static TreeWithResult TreeGenerator5()
        {
            //only root - should return true
            //took the same as TreeGenerator1()
            return TreeGenerator1();
        }
        private static TreeWithResult TreeGenerator6()
        {
            /* root 9
             * left 6
             * right 3 
             * right right 3
             * right right right 1
             * right right left 2
             * should return true
             */
            BinNode<int> tree = new BinNode<int>(9);
            tree.SetLeft(new BinNode<int>(6));
            tree.SetRight(new BinNode<int>(3));
            tree.GetRight().SetRight(new BinNode<int>(3));
            tree.GetRight().GetRight().SetLeft(new BinNode<int>(2));
            tree.GetRight().GetRight().SetRight(new BinNode<int>(1));
            return new TreeWithResult(tree, true);
        }
        private static TreeWithResult TreeGenerator7()
        {
            //The same as TreeGenerator3() but false
            //the tree is static but not bery static
            TreeWithResult tree = TreeGenerator3();
            tree.Result = false;
            return tree;
        }
        private static TreeWithResult TreeGenerator8()
        {
            //the same as TreeGenerator4() but root is 20
            //the tree is static but not very static
            TreeWithResult tree = TreeGenerator4();
            tree.Tree.SetInfo(20);
            return tree;
        }

        private static double TreeGenerator(int num)
        {
            //this works only with VS 2019
            //replaced from switch statement to switch expression
            TreeWithResult result = num switch
            {
                1 => TreeGenerator1(),
                2 => TreeGenerator2(),
                3 => TreeGenerator3(),
                4 => TreeGenerator4(),
                5 => TreeGenerator5(),
                6 => TreeGenerator6(),
                7 => TreeGenerator7(),
                8 => TreeGenerator8(),
                _ => throw new NotSupportedException("This should not happen in TreeGenerator"),
            };
            if (num <= 4)
                return Q7aGrader(result.Tree, result.Result, num);
            return Q7bGrader(result.Tree, result.Result, num);
        }

        private static double TestQ7()
        {
            BeginQNum(7);
            double maxGrade = 8;
            double grade = 0;
            TestForNumAndLetter(7, 'a');
            int i;
            for (i = 1; i < 9; i++)
            {
                if (i == 5)
                    TestForNumAndLetter(7, 'b');
                grade += TreeGenerator(i);
            }
            FinishTaskMesseges(7, maxGrade, grade);
            return grade;
        }

        const double PRICE_PER_LITER = 4.9;
        private const double MAX_PRECENTAGE = 100;
        private const int PERCENTAGE_PER_KM = 5;
        private const double PERCENTAGE_PER_MINUTE = 3;
        private static double TestCarGet(Car car, int liscencePlate, int numOfSeats, int numOfWheels, int capacity, int amount, string name)
        {
            int count = 0;
            const double VALUE = 0.25;
            TestStarted("getters of car", 1);
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 0:
                            if (car.GetLicensePlate() == liscencePlate) count++;
                            break;
                        case 1:
                            if (car.GetNumOfSeats() == numOfSeats) count++;
                            break;
                        case 2:
                            if (car.GetNumOfWheels() == numOfWheels) count++;
                            break;
                        case 3:
                            if (car.GetCapacity() == capacity) count++;
                            break;
                        case 4:
                            if (car.GetAmount() == amount) count++;
                            break;
                        default:
                            if (car.GetOwner() == name) count++;
                            break;

                    }
                }
                catch (Exception e)
                {
                    RecievedException(e, "one of car getters, please check");
                    FailedWithExceptions(1);
                    continue;
                }
            }
            if (count == 6)
            {
                PassedTest(1, "getters of car");
            }
            else
            {
                FailedWithoutException(1, "car getters", "error in one or more getters");
            }
            return count * VALUE;

        }
        private static double TestBusGet(Bus bus, int liscencePlate, int numOfSeats, int numOfWheels, int capacity, int amount, string name, int busLine)
        {
            int count = 0;
            const double VALUE = 0.15;
            TestStarted("getters of car", 1);
            for (int i = 0; i < 7; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 0:
                            if (bus.GetLicensePlate() == liscencePlate) count++;
                            break;
                        case 1:
                            if (bus.GetNumOfSeats() == numOfSeats) count++;
                            break;
                        case 2:
                            if (bus.GetNumOfWheels() == numOfWheels) count++;
                            break;
                        case 3:
                            if (bus.GetCapacity() == capacity) count++;
                            break;
                        case 4:
                            if (bus.GetAmount() == amount) count++;
                            break;
                        case 5:
                            if (bus.GetBusLine() == busLine) count++;
                            break;
                        default:
                            if (bus.GetOwner() == name) count++;
                            break;

                    }
                }
                catch (Exception e)
                {
                    RecievedException(e, "one of bicycle getters, please check");
                    FailedWithExceptions(1);
                    continue;
                }
            }
            if (count == 7)
            {
                PassedTest(1, "getters of bicycle");
            }
            else
            {
                FailedWithoutException(1, "bicycle getters", "error in one or more getters");
            }
            return count * VALUE;
        }
        private static double TestBicycleGet(Bicycle bicycle, int liscencePlate, int numOfSeats, int numOfWheels, double currentPrecentage, string name)
        {
            int count = 0;
            const double VALUE = 0.3;
            TestStarted("getters of bicycle", 1);
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 0:
                            if (bicycle.GetLicensePlate() == liscencePlate) count++;
                            break;
                        case 1:
                            if (bicycle.GetNumOfSeats() == numOfSeats) count++;
                            break;
                        case 2:
                            if (bicycle.GetNumOfWheels() == numOfWheels) count++;
                            break;
                        case 3:
                            if (bicycle.GetCurrentPrecentage() == currentPrecentage) count++;
                            break;
                        default:
                            if (bicycle.GetOwner() == name) count++;
                            break;

                    }
                }
                catch (Exception e)
                {
                    RecievedException(e, "one of bicycle getters, please check");
                    FailedWithExceptions(1);
                    continue;
                }
            }
            if (count == 5)
            {
                PassedTest(1, "getters of bicycle");
            }
            else
            {
                FailedWithoutException(1, "bicycle getters", "error in one or more getters");
            }
            return count * VALUE;
        }
        private static double SellCarTest(Car car, string newName)
        {
            TestStarted("Sell Car", 2);
            string recieved;
            try
            {
                car.SellVehicle(newName);
                recieved = car.GetOwner();
                FinishedWithoutException();
                if (recieved == newName)
                {
                    PassedTest(2, newName);
                    return 0.2;
                }
                FailedWithoutException(2, newName, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, newName);
                FailedWithExceptions(2);
                return 0;
            }
        }
        private static double SellBusTest(Bus bus, string newName)
        {
            TestStarted("Sell bus", 2);
            string recieved;
            try
            {
                bus.SellVehicle(newName);
                recieved = bus.GetOwner();
                FinishedWithoutException();
                if (recieved == newName)
                {
                    PassedTest(2, newName);
                    return 0.25;
                }
                FailedWithoutException(2, newName, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, newName);
                FailedWithExceptions(2);
                return 0;
            }
        }
        private static double SellBicycleTest(Bicycle bicycle, string newName)
        {
            TestStarted("Sell bicycle", 2);
            string recieved;
            try
            {
                bicycle.SellVehicle(newName);
                recieved = bicycle.GetOwner();
                FinishedWithoutException();
                if (recieved == newName)
                {
                    PassedTest(2, newName);
                    return 0.5;
                }
                FailedWithoutException(2, newName, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, newName);
                FailedWithExceptions(2);
                return 0;
            }
        }
        private static double ChangeLineTest(Bus bus, int newLine, int numTest)
        {
            TestStarted("Change busLine to " + newLine, numTest);
            int recieved;
            try
            {
                bus.ChangeBusLine(newLine);
                recieved = bus.GetBusLine();
                FinishedWithoutException();
                if (recieved == newLine)
                {
                    PassedTest(numTest,newLine);
                    return 0.5;
                }
                FailedWithoutException(numTest, newLine, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, newLine);
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double SetAmountCar(Car car, double changedCapacity, double newAmount, double value, int numTest)
        {
            TestStarted("Change amount in car to " + changedCapacity, numTest);
            double recieved;
            try
            {
                car.SetAmount(changedCapacity);
                recieved = car.GetAmount();
                FinishedWithoutException();
                if (recieved == newAmount)
                {
                    PassedTest(numTest, newAmount);
                    return value;
                }
                FailedWithoutException(numTest, newAmount, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, newAmount);
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double SetAmountBus(Bus bus, double changedCapacity, int newAmount, double value, int numTest)
        {
            TestStarted("Change amount in bus to " + changedCapacity, numTest);
            double recieved;
            try
            {
                bus.SetAmount(changedCapacity);
                recieved = bus.GetAmount();
                FinishedWithoutException();
                if (recieved == newAmount)
                {
                    PassedTest(numTest, newAmount);
                    return value;
                }
                FailedWithoutException(numTest, newAmount, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, newAmount);
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double RideTest(Bicycle bicycle, int kmRode, double expected, double value, int numTest)
        {
            TestStarted("Ride() for " + kmRode + " km", numTest);
            double recieved;
            try
            {
                bicycle.Ride(kmRode);
                recieved = bicycle.GetCurrentPrecentage();
                FinishedWithoutException();
                if (EqualsDouble(expected, recieved))
                {
                    PassedTest(numTest, expected);
                    return value;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double ChargeTest(Bicycle bicycle, int minCharged, double expected, double value, int numTest)
        {
            TestStarted("Charge() for " + minCharged + " minutes", numTest);
            double recieved;
            try
            {
                bicycle.Charge(minCharged);
                recieved = bicycle.GetCurrentPrecentage();
                FinishedWithoutException();
                if (EqualsDouble(expected, recieved))
                {
                    PassedTest(numTest, expected);
                    return value;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double FuelUpTest(Car car, double priceForFuel, int numTest)
        {
            TestStarted("FuelUp() car", numTest);
            double recieved;
            try
            {
                recieved = car.FuelUp();
                FinishedWithoutException();
                if (recieved == priceForFuel)
                {
                    PassedTest(numTest, priceForFuel);
                    return 1.5;
                }
                FailedWithoutException(numTest, priceForFuel, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, priceForFuel);
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double FuelUpTestBus(Bus bus, double priceForFuel, int numTest)
        {
            TestStarted("FuelUp() bus", numTest);
            double recieved;
            try
            {
                recieved = bus.FuelUp();
                FinishedWithoutException();
                if (recieved == priceForFuel)
                {
                    PassedTest(numTest, priceForFuel);
                    return 1.5;
                }
                FailedWithoutException(numTest, priceForFuel, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, priceForFuel);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double CheckAmount(Car car, double expected, int numTest)
        {
            TestStarted("Check amount after FuelUp() car", numTest);
            double recieved;
            try
            {
                recieved = car.GetAmount();
                FinishedWithoutException();
                if (EqualsDouble(expected, recieved))
                {
                    PassedTest(numTest, expected);
                    return 0.5;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }
        private static double CheckAmountBus(Bus bus, int expected, int numTest)
        {
            TestStarted("Check amount after FuelUp() bus", numTest);
            double recieved;
            try
            {
                recieved = bus.GetAmount();
                FinishedWithoutException();
                if (recieved == expected)
                {
                    PassedTest(numTest, expected);
                    return 0.5;
                }
                FailedWithoutException(numTest, expected, recieved);
                return 0;

            }
            catch (Exception e)
            {
                RecievedException(e, expected);
                FailedWithExceptions(numTest);
                return 0;
            }
        }

        private static double CarGrader()
        {
            double grade = 0;
            int maxGrade = 5;
            ObjectOrientedStarted("Car");
            int liscencePlate = 123, numOfSeats = 5, numOfWheels = 4, capacity = 40, amount = 0;
            string name = "Yankale";

            Car car;
            try
            {
                car = new Car(liscencePlate, numOfSeats, numOfWheels, name, capacity);
            }
            catch (Exception e)
            {
                RecievedExceptionAtConstructor(e, "Car");
                return 0;
            }
            //up to 1.5
            grade += TestCarGet(car, liscencePlate, numOfSeats, numOfWheels, capacity, amount, name);
            //max: 1.8
            if (ManualPrintCheck(car))
                grade += 0.3;
            string newName = "Yoskale";
            int newAmount = 5;
            //max: 2
            grade += SellCarTest(car, newName);
            //SetAmount 3 times - this one is way over capacity - total - 3
            grade += SetAmountCar(car, capacity * 2, amount, 0.4, 3);
            //this one is with negative capacity
            grade += SetAmountCar(car, capacity * -1, amount, 0.4, 4);
            //this one should work
            grade += SetAmountCar(car, newAmount, newAmount, 0.2, 5);
            //fuelUp() for 1.5 points - max 4.5
            double priceForFuel = (capacity - newAmount) * PRICE_PER_LITER;
            grade += FuelUpTest(car, priceForFuel, 6);
            //check that amount == capacity at the end for 0.5 points - max 5 points
            grade += CheckAmount(car, capacity, 7);
            ObjectOrientedFinished("Car", grade, maxGrade);
            return grade;

        }

        private static double BusGrader()
        {
            double grade = 0;
            int maxGrade = 5;
            ObjectOrientedStarted("Bus");
            int liscencePlate = 456, numOfSeats = 50, numOfWheels = 8, capacity = 100, amount = 0, busLine = 8;
            string name = "Dan Beersheva";

            Bus bus;
            try
            {
                bus = new Bus(liscencePlate, numOfSeats, numOfWheels, name, capacity, busLine);
            }
            catch (Exception e)
            {
                RecievedExceptionAtConstructor(e, "Bus");
                return 0;
            }
            //up to 1.05
            grade += TestBusGet(bus, liscencePlate, numOfSeats, numOfWheels, capacity, amount, name, busLine);
            //max: 1.25
            if (ManualPrintCheck(bus))
                grade += 0.2;
            string newName = "Metropoline";
            int newAmount = 20;
            //max: 1.5
            grade += SellBusTest(bus, newName);
            int newLine = 370;
            //for 0.5 point - max 2
            grade += ChangeLineTest(bus, newLine, 3);
            //SetAmount 3 times - this one is way over capacity - max for all 3 is 3
            grade += SetAmountBus(bus, capacity * 2, amount, 0.4, 4);
            //this one is with negative capacity
            grade += SetAmountBus(bus, capacity * -1, amount, 0.4, 5);
            //this one should work
            grade += SetAmountBus(bus, newAmount, newAmount, 0.2, 6);
            //fuelUp() for 1.5 points - max 4.5
            double priceForFuel = (capacity - newAmount) * PRICE_PER_LITER;
            grade += FuelUpTestBus(bus, priceForFuel, 7);
            //check that amount == capacity at the end for 0.5 points - max 5 points
            grade += CheckAmountBus(bus, capacity, 8);
            ObjectOrientedFinished("Bus", grade, maxGrade);
            return grade;
        }


        private static double BicycleGrader()
        {
            double grade = 0;
            int maxGrade = 5;
            ObjectOrientedStarted("Bicycle");
            int liscencePlate = 789, numOfSeats = 1, numOfWheels = 2;
            double currentPrecentage = 50;
            string name = "Moishe";

            Bicycle bicycle;
            try
            {
                bicycle = new Bicycle(liscencePlate, numOfSeats, numOfWheels, name);
            }
            catch (Exception e)
            {
                RecievedExceptionAtConstructor(e, "Bicycle");
                return 0;
            }
            //up to 1.5
            grade += TestBicycleGet(bicycle, liscencePlate, numOfSeats, numOfWheels, currentPrecentage, name);
            //max: 2
            if (ManualPrintCheck(bicycle))
                grade += 0.5;
            string newName = "Ronkiflitz";
            int kmRode = 8;
            double newPrecentage = currentPrecentage - kmRode * PERCENTAGE_PER_KM; //should be 10%
            int minCharged = 27;//should chrarge to 91%
            //riding and charging not until the end - 0.5 each
            grade += SellBicycleTest(bicycle, newName);
            grade += RideTest(bicycle, kmRode, newPrecentage, 0.25, 3);
            newPrecentage += minCharged * PERCENTAGE_PER_MINUTE;//should be 91
            grade += ChargeTest(bicycle, minCharged, newPrecentage, 0.25, 4);
            //riding more then possible, if they have 91% they can ride 18km
            //each ride and charge - 0.75 point
            kmRode = 30;
            newPrecentage = 0;
            grade += RideTest(bicycle, kmRode, newPrecentage, 1, 5);
            //charging for 33.33 minutes should supply 100% from 0%
            minCharged = 35;
            newPrecentage = MAX_PRECENTAGE;
            grade += ChargeTest(bicycle, minCharged, newPrecentage, 1, 6);
            ObjectOrientedFinished("Bicycle", grade, maxGrade);
            return grade;
        }

        private static double TestQ8()
        {
            BeginQNum(8);
            double maxGrade = 15;
            double grade = 0;
            grade += CarGrader();
            grade += BusGrader();
            grade += BicycleGrader();
            FinishTaskMesseges(8, maxGrade, grade);
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
            grade += TestQ5(); // OK 
            grade += TestQ6(); // OK
            grade += TestQ7(); // OK 
            grade += TestQ8(); // OK 
            Console.WriteLine("***************FINISHED ALL TESTS******************");
            Console.WriteLine("Final grade for automatic tests: " + grade + "/" + MAX_GRADE);
            return grade;
        }
    }

    //additional classes for testing.
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
            Model = model;
            Country = country;
            Price = price;
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
    class TwinListWithResult
    {
        //Data structure to hold all the outputs of TwinList
        public TwinListWithResult(Node<int> node, Node<int> odd,
            Node<int> even, Node<int> swtch)
        {
            Node = node;
            Odd = odd;
            Even = even;
            Swtch = swtch;
        }

        public Node<int> Node { get; set; }
        public Node<int> Odd { get; set; }
        public Node<int> Even { get; set; }
        public Node<int> Swtch { get; set; }

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

    class TreeWithResult
    {

        public TreeWithResult(BinNode<int> tree, bool result)
        {
            Tree = tree;
            Result = result;
        }

        public BinNode<int> Tree { get; set; }
        public bool Result { get; set; }
    }
}
