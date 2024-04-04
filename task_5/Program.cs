class Program
{
    static void Main(string[] args)
    {
        LightElementNode table = new LightElementNode("table", true, false);
        table.AddClass("my-table");

        LightElementNode tr = new LightElementNode("tr", true, false);
        table.AddChild(tr);

        LightElementNode td1 = new LightElementNode("td", false, false);
        td1.AddChild(new LightTextNode("Cell 1"));
        tr.AddChild(td1);

        LightElementNode td2 = new LightElementNode("td", false, false);
        td2.AddChild(new LightTextNode("Cell 2"));
        tr.AddChild(td2);

        Console.WriteLine(table.OuterHTML);
    }
}
