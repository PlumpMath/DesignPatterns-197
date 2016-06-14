using System.Windows.Forms;

namespace State_Pattern___Mathematical_game
{
    public class GameAccount
    {
        private string name; //never used
        private Label _lbl;
        private Label _lbl2;

        public GameLevelState State { get; set; }

        public GameAccount(string Name, Label Lbl, Label Lbl2)
        {
            State = new BeginnerState(this);
            name = Name;
            _lbl = Lbl;
            _lbl2 = Lbl2;
            GetEquation();
        }

        public void ConfirmAnswer(double answer)
        {
            if (State.CheckAnswer(answer))
            {
                _lbl2.Text = "Correct! ," + State.GetType().Name + " Score: " + State.GoodAttempts;
                GetEquation();
                return;
            }
            _lbl2.Text = "Not Correct! ," + State.GetType().Name + "Score: " + State.GoodAttempts;
            GetEquation();
        }

        public void GetEquation()
        {
            _lbl.Text = State.GetEquation();
        }
    }
}