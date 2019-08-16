using System;

namespace CalulatorUnitTest.Services
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int res = num1 + num2;
            return res;
        }

        public int Sub(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
