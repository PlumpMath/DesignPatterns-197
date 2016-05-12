using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DPR_assignments.Extra;
using DPR_assignments.Strategies;

namespace DPR_assignments
{
    public class HelperClass
    {
        List<IStrategy> _strategies = new List<IStrategy>();
        List<int> _numberList = new List<int>();
        Random rr = new Random();

        public HelperClass()
        {
            GenerateNumbers();
            _strategies.Add(new ConcreteStrategyA());
            _strategies.Add(new ConcreteStrategyB());
            _strategies.Add(new ConcreteStrategyC());
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

        public void Update(TrackBar trackBar, ListBox listBox, int selectedMethod)
        {
            int tempOffSet = -1;
            int tempTargetIndex = -1;
            int tempRemoveIndex = -1;
            switch (selectedMethod)
            {
                case (int) Constants.radioButtonCase.radeioButton1:
                    tempOffSet = _strategies[0].MovementDirection(_numberList, trackBar.Value);
                    if (tempOffSet == Constants.OnTargetCursor)
                    {
                        tempRemoveIndex = _strategies[0].DeleteNumberIndex(_numberList, trackBar.Value);
                        _numberList.RemoveAt(tempRemoveIndex);
                        GenerateNumbers();
                        listBox.DataSource = null;
                        listBox.DataSource = _numberList;
                    }
                    tempTargetIndex = _strategies[0].HighliteNumberIndex(_numberList, trackBar.Value);
                    listBox.SelectedIndex = tempTargetIndex;
                    break;
                case (int)Constants.radioButtonCase.radeioButton2:
                    tempOffSet = _strategies[1].MovementDirection(_numberList, trackBar.Value);
                    if (tempOffSet == Constants.OnTargetCursor)
                    {
                        tempRemoveIndex = _strategies[1].DeleteNumberIndex(_numberList, trackBar.Value);
                        _numberList.RemoveAt(tempRemoveIndex);
                        GenerateNumbers();
                        listBox.DataSource = null;
                        listBox.DataSource = _numberList;
                    }
                    tempTargetIndex = _strategies[1].HighliteNumberIndex(_numberList, trackBar.Value);
                    listBox.SelectedIndex = tempTargetIndex;
                    break;
                case (int)Constants.radioButtonCase.radeioButton3:
                    tempOffSet = _strategies[2].MovementDirection(_numberList, trackBar.Value);
                    if (tempOffSet == Constants.OnTargetCursor)
                    {
                        tempRemoveIndex = _strategies[2].DeleteNumberIndex(_numberList, trackBar.Value);
                        _numberList.RemoveAt(tempRemoveIndex);
                        GenerateNumbers();
                        listBox.DataSource = null;
                        listBox.DataSource = _numberList;
                    }
                    tempTargetIndex = _strategies[2].HighliteNumberIndex(_numberList, trackBar.Value);
                    listBox.SelectedIndex = tempTargetIndex;
                    break;
            }

            if (tempOffSet != Constants.OnTargetCursor)
            {
                trackBar.Value += tempOffSet;
            }
        }
    }
}