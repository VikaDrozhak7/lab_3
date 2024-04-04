using System.Collections.Generic;
using System.Linq;

public class LightElementNode : LightNode
{
    private static Dictionary<string, string> _tagNames = new Dictionary<string, string>();

    private string _tagName;
    private List<LightNode> _children;

    public LightElementNode(string tagName)
    {
        if (!_tagNames.ContainsKey(tagName))
        {
            _tagNames[tagName] = tagName;
        }

        _tagName = _tagNames[tagName];
        _children = new List<LightNode>();
    }

    public void AddChild(LightNode child)
    {
        _children.Add(child);
    }

    public override string OuterHTML
    {
        get
        {
            string childrenHTML = string.Join("", _children.ConvertAll(c => c.OuterHTML));
            return $"<{_tagName}>{childrenHTML}</{_tagName}>";
        }
    }
}
