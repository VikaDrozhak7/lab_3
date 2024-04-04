public class Circle : Shape
{
    public Circle(IRender render) : base(render) { }

    public override void Draw()
    {
        render.RenderShape("Circle");
    }
}
