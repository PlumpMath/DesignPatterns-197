namespace State_Pattern___Mathematical_game
{
    class IntermediateState : GameLevelState
    {
        public IntermediateState(GameAccount g)
        {
            GAcct = g;
        }

        public override bool CheckAnswer(double answer)
        {
            if (FirstNumber*SecondNumber == answer)
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
            GAcct.State = new ExpertState(GAcct);
        }

        public override void Downgrade()
        {
            GAcct.State = new BeginnerState(GAcct);
        }

        public override string GetEquation()
        {
            FirstNumber = R.Next(1, 10);
            SecondNumber = R.Next(1, 10);
            Answer = FirstNumber*SecondNumber;
            return FirstNumber + " * " + SecondNumber + " = ?";
        }
    }
}