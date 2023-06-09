﻿namespace IntroToInterface.TextTools
{
    internal class TextToolDemo
    {
        public static void Run()
        {
            var a = new CenteredHeader("Overskrift 1");
            var b = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
            var c = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
            var d = new CenteredHeader("Overskrift 2");
            var e = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");

            var b1 = new BulletPoint("a");
            var b2 = new BulletPoint("b");
            var b3 = new BulletPoint("c");
            //a.Show();
            //b.Show();
            //c.Show();
            //d.Show();
            //e.Show();
            //object o1 = 5;
            //object o2 = "Tkjh";
            //object o3 = c;
            //object o4 = d;

            var documentParts = new IDocumentPart[] { a, b, c, d, e, b1, b2, b3 };
            foreach (var part in documentParts)
            {
                part.Show();
                //var centeredHeader = part as CenteredHeader;
                //if (centeredHeader != null)
                //{
                //    centeredHeader.Show();
                //}

                //var indentedParagraph = part as IndentedParagraph;
                //if (indentedParagraph != null)
                //{
                //    indentedParagraph.Show();
                //}
                //if (part is CenteredHeader)
                //{
                //    var centeredHeader = (CenteredHeader)part;
                //    centeredHeader.
                //}
            }

        }
    }
}
