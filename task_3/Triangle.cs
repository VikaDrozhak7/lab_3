public class Triangle : Shape
{
    public Triangle(IRender render) : base(render) { }

    public override void Draw()
    {
        render.RenderShape("Triangle");
    }
}
