namespace State
{
    internal class Vibration : IMobileAlert
    {
        public void Alert()
        {
            System.Console.WriteLine("set vibrate");
        }
    }
}