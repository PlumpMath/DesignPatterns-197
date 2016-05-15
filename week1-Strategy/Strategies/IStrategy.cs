using System.Collections.Generic;

namespace DPR_assignments.Strategies
{
    public interface IStrategy
    {
        int MovementDirection(List<int> numberList, int currentPossition);
        int HighliteNumberIndex(List<int> numberList, int currentPossition);
        int DeleteNumberIndex(List<int> numberList, int currentPossition);
    }
}