using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("book.txt");

        LightElementNode root = new LightElementNode("div");

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            LightElementNode node;

            if (i == 0)
            {
                node = new LightElementNode("h1");
            }
            else if (line.Length < 20)
            {
                node = new LightElementNode("h2");
            }
            else if (line.StartsWith(" "))
            {
                node = new LightElementNode("blockquote");
            }
            else
            {
                node = new LightElementNode("p");
            }

            node.AddChild(new LightTextNode(line));
            root.AddChild(node);
        }
        string htmlText = root.OuterHTML;
        Console.WriteLine($"HTML верстка займає {htmlText.Length} байтів в пам'яті.");
        Console.WriteLine(root.OuterHTML);
    }
}
