namespace StatePattern
{
    class ConcreteStateB : States

    {
        public override void Handle(Context context)
        {
            context.States = new ConcreteStateA();
        }
    }
}