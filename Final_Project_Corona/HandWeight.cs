using System;
using System.Text;

namespace Final_Project_Corona
{
    class HandWeight
    {
        //Q4
        double leftWeight;
        double rightWeight;
        //do not add any other fields in this question

        //Complete those methods as requested in the assignment
        public HandWeight(double leftWeight, double rightWeight)
        {
            this.leftWeight = leftWeight;
            this.rightWeight = rightWeight;
        }
        public HandWeight(double weight)
        {
            this.leftWeight = weight;
            this.rightWeight = weight;
        }
        public HandWeight()
        {
            this.leftWeight = 0;
            this.rightWeight = 0;
        }
        public bool IsBalanced()
        {
            return leftWeight == rightWeight;
        }
        public static void MoveWeight(HandWeight handWeight1, HandWeight handWeight2)
        {
            HandWeight temp = handWeight1;
            handWeight1 = handWeight2;
            handWeight2 = temp;
        }

        /* Note:
         * Please make sure ToSting() returns the string EXACTLY as specified
         * Failure to do so will cause failure in our tests.
         * If you have any questions about how to do so - 
         * please contact your teacher.
         */
        public override string ToString()
        {
            return "<Left: " + leftWeight + ", Right: " + rightWeight + ">";
        }

    }
}
