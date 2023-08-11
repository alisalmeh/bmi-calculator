using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek4.BMI_Refactor
{
    public class Calculator
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        private double _bmiResult;
        private Status _result;
        private enum Status
        {
            Underweight,
            Normal,
            Overweight,
            Obese
        }

        public void CalculateBmi()
        {
            _bmiResult = Math.Round(Weight / Math.Pow(Height, 2), 2);

            if (_bmiResult <= 18.4)
            {
                _result = Status.Underweight;
            }
            else if (_bmiResult > 18.4 && _bmiResult <= 24.9)
            {
                _result = Status.Normal;
            }
            else if (_bmiResult > 24.9 && _bmiResult <= 39.9)
            {
                _result = Status.Overweight;
            }
            else
            {
                _result = Status.Obese;
            }
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"Dear {Name}, \n\t Your BMI score is: {_bmiResult}; \n\t Your status is: {_result};";
        }
    }
}