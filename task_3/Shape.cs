public abstract class Shape
{
    protected IRender render;
    public Shape(IRender render)
    {
        this.render = render;
    }
    public abstract void Draw();
}
