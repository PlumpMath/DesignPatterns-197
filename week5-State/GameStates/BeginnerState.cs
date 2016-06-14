namespace State_Pattern___Mathematical_game
{
    public class BeginnerState : GameLevelState
    {
        public BeginnerState(GameAccount state)
        {
            GAcct = state;
        }

        public override bool CheckAnswer(double answer)
        {
            if (FirstNumber + SecondNumber == answer)
            {
                GoodAttempt++;
                CheckStreak();
                return true;
            }
            GoodAttempt--;
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
            GAcct.State = new IntermediateState(GAcct);
        }

        public override void Downgrade()
        {
        }

        public override string GetEquation()
        {
            FirstNumber = R.Next(1, 20);
            SecondNumber = R.Next(1, 20);
            Answer = FirstNumber + SecondNumber;
            return FirstNumber + " + " + SecondNumber + " = ?";
        }
    }
}