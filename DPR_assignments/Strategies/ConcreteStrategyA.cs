using System.Collections.Generic;
using DPR_assignments.Extra;

namespace DPR_assignments.Strategies
{
    public class ConcreteStrategyA : IStrategy
    {
        public int MovementDirection(List<int> numberList, int currentPossition)
        {
            if (numberList[0] > currentPossition)
            {
                return Constants.MoveUpCursor;
            }
            if (numberList[0] < currentPossition)
            {
                return Constants.MoveDownCursor;
            }
            return Constants.OnTargetCursor;

        }

        public int HighliteNumberIndex(List<int> numberList, int currentPossition)
        {
            return 0;
        }

        public int DeleteNumberIndex(List<int> numberList, int currentPossition)
        {
            return numberList.FindIndex(x => x == currentPossition);
        }
    }
}