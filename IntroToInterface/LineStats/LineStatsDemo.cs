namespace IntroToInterface.LineStats
{
    internal class LineStatsDemo
    {
        public static void Run()
        {
            //var stats = LineStatsService.Count("LineStats/TextFile1.txt", "er");
            var fileLineReader = new FileLineReader("LineStats/TextFile1.txt");
            var keyboardLineReader = new KeyboardLineReader();
            var lineStatsService = new LineStatsService(keyboardLineReader);
            //var lineStatsService = new LineStatsService(fileLineReader);
            var stats = lineStatsService.Count("er");
            Console.WriteLine(stats);
        }
    }
}
