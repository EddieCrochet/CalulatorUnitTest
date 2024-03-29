﻿using System;

namespace CalulatorUnitTest.Services
{
    public class Calculator
    {
        bool _isDirty;

        string _operation;
        decimal _state;

        public decimal Display { get; private set; }

        public void Enter(decimal number)
        {
            _state = number;
            _isDirty = true;
        }

        public void PressPlus()
        {
            _operation = "+";
            if (_isDirty) Calculate();
        }

        public void PressEquals()
        {
            if (_isDirty) Calculate();
        }

        void Calculate()
        {
            switch (_operation)
            {
                case "+":
                    Display += _state;
                    break;
            }

            _isDirty = false;
        }
        public int Add(int num1, int num2)
        {
            int res = num1 + num2;
            return res;
        }

        public int Sub(int num1, int num2)
        {
            int res = num1 - num2;
            return res;
        }
    }
}
