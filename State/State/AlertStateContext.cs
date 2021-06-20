namespace State
{
    public class AlertStateContext
    {
        public IMobileAlert currentState;
        public AlertStateContext()
        {
            currentState = new Vibration();
        }

        public void setState(IMobileAlert state)
        {
            currentState = state;
        }

        public void alert()
        {
            currentState.Alert();
        }
    }
}