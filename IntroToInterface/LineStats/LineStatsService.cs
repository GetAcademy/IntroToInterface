namespace IntroToInterface.LineStats
{
    internal class LineStatsService
    {
        private ILineReader _lineReader;

        public LineStatsService(ILineReader lineReader)
        {
            _lineReader = lineReader;
        }

        public Stats Count(string word)
        {
            var total = 0;
            var exactCount = 0;
            var ignoreCaseCount = 0;
            var wordUpper = word.ToUpper();
            string line = null;
            while ((line = _lineReader.GetLine()) != null)
            {
                total++;
                if (line.Contains(word)) exactCount++;
                if (line.ToUpper().Contains(wordUpper)) ignoreCaseCount++;
            }
            return new Stats(total, exactCount, ignoreCaseCount);
        }

        //public static Stats Count(string filename, string word)
        //{
        //    var total = 0;
        //    var exactCount = 0;
        //    var ignoreCaseCount = 0;
        //    var wordUpper = word.ToUpper();
        //    using var fileStream = new FileStream(filename, FileMode.Open);
        //    using var reader = new StreamReader(fileStream);
        //    string line = null;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        total++;
        //        if (line.Contains(word)) exactCount++;
        //        if (line.ToUpper().Contains(wordUpper)) ignoreCaseCount++;
        //    }
        //    return new Stats(total, exactCount, ignoreCaseCount);
        //}
    }
}
