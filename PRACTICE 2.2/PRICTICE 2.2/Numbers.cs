using System;

namespace PRICTICE_2._2
{
    class numbers
    {
        private int FirstNum;
        private int SecondNum;

        public numbers(int num1, int num2)
        {
            this.FirstNum = num1;
            this.SecondNum = num2;
        }

        public void info()
        {
            Console.WriteLine($"Первое число - {this.FirstNum}\nВторое число - {this.SecondNum}\n");
        }

        public void changeNums(int num1, int num2)
        {
            this.FirstNum = num1;
            this.SecondNum = num2;
            this.info();
        }

        public int sumOfNumbers()
        {
            return this.FirstNum + this.SecondNum;
        }

        public int isBigger()
        {
            if (this.FirstNum > this.SecondNum)
            {
                return FirstNum;
            }

            return SecondNum;
        }
    }
}