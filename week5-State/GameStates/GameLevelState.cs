using System;

namespace State_Pattern___Mathematical_game
{
    public abstract class GameLevelState
    {
        protected double FirstNumber;
        protected double SecondNumber;
        protected double Answer;
        protected int GoodAttempt;
        protected Random R = new Random();
        protected GameAccount GAcct;


        public int GoodAttempts
        {
            get { return GoodAttempt; }
        }

        public abstract bool CheckAnswer(double answer);

        public abstract string GetEquation();

        public abstract void CheckStreak();

        public abstract void Upgrade();

        public abstract void Downgrade();
    }
}