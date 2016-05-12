using System;
using System.Collections.Generic;
using DPR_assignments.Extra;

namespace DPR_assignments
{
    public class HelperClass
    {
        List<int> _numberList = new List<int>();
        Random rr = new Random();

        public HelperClass()
        {
            GenerateNumbers();
        }

        private void GenerateNumbers()
        {
            while (_numberList.Count < Constants.AmountOfNumbers)
            {
                int temp = NewNumberValue();
                if (!_numberList.Contains(temp))
                {
                    _numberList.Add(temp);
                }
            }
        }

        private int NewNumberValue()
        {
            return rr.Next(Constants.MinNumber, Constants.MaxNumber);
        }

        public List<int> GetNumberList()
        {
            return _numberList;
        }

        public void run()
        {
            
        }


    }
}