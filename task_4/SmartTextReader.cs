using System;
using System.IO;

public class SmartTextReader
{
    public virtual char[][] ReadText(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        char[][] text = new char[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
            text[i] = lines[i].ToCharArray();
        }
        return text;
    }
}
