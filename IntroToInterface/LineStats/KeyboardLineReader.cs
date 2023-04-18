namespace IntroToInterface.LineStats
{
    internal class KeyboardLineReader : ILineReader
    {
        public string GetLine()
        {
            var line = Console.ReadLine();
            return string.IsNullOrEmpty(line) ? null : line;
        }
    }
}
