namespace Test.Scene.Game
{
    public struct LevelSelectMessage
    {
        public int Value { get; set; }

        public LevelSelectMessage(int value)
        {
            Value = value;
        }
    }
}
