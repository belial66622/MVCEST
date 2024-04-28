namespace Test.Scene.Game
{
    public struct ResetTimeMessage
    {
        public int Value { get; set; }

        public ResetTimeMessage(int value)
        {
            Value = value;
        }
    }
}
