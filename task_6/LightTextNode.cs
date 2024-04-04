﻿public class LightTextNode : LightNode
{
    private string _text;

    public LightTextNode(string text)
    {
        _text = text;
    }

    public override string OuterHTML => _text;
}
