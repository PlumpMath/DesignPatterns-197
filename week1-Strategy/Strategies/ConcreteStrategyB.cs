using System;
using System.Collections.Generic;
using System.Linq;
using DPR_assignments.Extra;

namespace DPR_assignments.Strategies
{
    public class ConcreteStrategyB : IStrategy
    {
        public int MovementDirection(List<int> numberList, int currentPossition)
        {
            int closests = numberList.Aggregate((x, y) => Math.Abs(x - currentPossition) < Math.Abs(y - currentPossition) ? x : y);

            if (closests > currentPossition)
                return Constants.MoveUpCursor;
            if (closests < currentPossition)
                return Constants.MoveDownCursor;

            return Constants.OnTargetCursor;
        }

        public int HighliteNumberIndex(List<int> numberList, int currentPossition)
        {
            int closests = numberList.OrderBy(item => Math.Abs(currentPossition - item)).First();

            return numberList.FindIndex(x => x == closests);
        }

        public int DeleteNumberIndex(List<int> numberList, int currentPossition)
        {
            return numberList.FindIndex(x => x == currentPossition);
        }
    }
}