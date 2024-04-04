class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(new VectorRender());
        circle.Draw();

        Shape square = new Square(new RasterRender());
        square.Draw();

        Shape triangle = new Triangle(new VectorRender());
        triangle.Draw();
    }
}
 