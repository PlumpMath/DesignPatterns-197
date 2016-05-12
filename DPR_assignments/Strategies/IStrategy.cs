using System.Collections.Generic;

namespace DPR_assignments.Strategies
{
    public interface IStrategy
    {
        int AlgorithMethod(List<int> numberList, int currentPossition);
    }
}