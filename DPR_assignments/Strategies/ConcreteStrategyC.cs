using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DPR_assignments.Extra;

namespace DPR_assignments.Strategies
{
    public class ConcreteStrategyC : IStrategy
    {
        private bool upDirection = true;

        public int MovementDirection(List<int> numberList, int currentPossition)
        {
            if (numberList.Contains(currentPossition))
                return Constants.OnTargetCursor;
            if (Constants.MaxNumber == currentPossition)
                upDirection = false;
            if (Constants.MinNumber == currentPossition)
                upDirection = true;
            if (currentPossition < Constants.MaxNumber && upDirection)
                return Constants.MoveUpCursor;
            return Constants.MoveDownCursor;
        }

        public int HighliteNumber(List<int> numberList, int currentPossition)
        {
            int temp = 0;
            if (upDirection)
            {
                if (numberList.Max() > currentPossition)
                {
                    temp = numberList.OrderBy(x => x).SkipWhile(x => x < currentPossition).First();
                }
                else
                {
                    temp = numberList.OrderByDescending(x => x).TakeWhile(x => x < currentPossition).Last();
                }
            }
            else
            {
                if (numberList.Min() < currentPossition)
                {
                    temp = numberList.OrderBy(x => x).TakeWhile(x => x < currentPossition).Last();

                }
                else
                {
                    temp = numberList.OrderBy(x => x).SkipWhile(x => x < currentPossition).First();
                }
            }

            return numberList.FindIndex(x => x == temp);
        }

        public int DeleteNumberIndex(List<int> numberList, int currentPossition)
        {
            return numberList.FindIndex(x => x == currentPossition);
        }
    }
}