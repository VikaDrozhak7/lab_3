using System.Collections.Generic;
using System.Linq;

public class LightElementNode : LightNode
{
    private string _tagName;
    private bool _isBlock;
    private bool _isSelfClosing;
    private List<string> _classes;
    private List<LightNode> _children;

    public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
    {
        _tagName = tagName;
        _isBlock = isBlock;
        _isSelfClosing = isSelfClosing;
        _classes = new List<string>();
        _children = new List<LightNode>();
    }

    public void AddClass(string className)
    {
        _classes.Add(className);
    }

    public void AddChild(LightNode child)
    {
        _children.Add(child);
    }

    public override string OuterHTML
    {
        get
        {
            string classAttribute = _classes.Any() ? $" class=\"{string.Join(" ", _classes)}\"" : "";
            string childrenHTML = string.Join(_isBlock ? "\n" : "", _children.Select(c => c.OuterHTML));
            return _isSelfClosing
                ? $"<{_tagName}{classAttribute} />"
                : $"<{_tagName}{classAttribute}>{childrenHTML}</{_tagName}>";
        }
    }

    public override string InnerHTML => string.Join(_isBlock ? "\n" : "", _children.Select(c => c.OuterHTML));
}
