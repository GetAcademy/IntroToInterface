namespace IntroToInterface.TextTools
{
    internal class BulletPoint : IDocumentPart
    {
        private string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }
    }
}
