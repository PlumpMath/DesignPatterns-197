using System.Windows.Forms;

namespace State_Pattern___Mathematical_game
{
    class ExpertState : GameLevelState
    {
        private double _thirdNumber;

        public ExpertState(GameAccount g)
        {
            GAcct = g;
        }

        public override bool CheckAnswer(double answer)
        {
            if (FirstNumber*SecondNumber + _thirdNumber == answer)
            {
                GoodAttempt++;
                CheckStreak();
                return true;
            }
            GoodAttempt--;
            CheckStreak();
            return false;
        }

        public override void CheckStreak()
        {
            if (GoodAttempt > 2)
            {
                Upgrade();
            }
            if (GoodAttempt < 0)
            {
                Downgrade();
            }
        }

        public override void Upgrade()
        {
            MessageBox.Show("You have won the game, Congratulations on your undefeatable math powers!!!");
        }

        public override void Downgrade()
        {
            GAcct.State = new IntermediateState(GAcct);
        }

        public override string GetEquation()
        {
            FirstNumber = R.Next(1, 10);
            SecondNumber = R.Next(1, 10);
            _thirdNumber = R.Next(1, 20);
            Answer = FirstNumber*SecondNumber + _thirdNumber;
            return FirstNumber + " * " + SecondNumber + " + " + _thirdNumber;
        }
    }
}