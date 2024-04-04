public class RasterRender : IRender
{
    public void RenderShape(string shapeName)
    {
        Console.WriteLine($"Drawing {shapeName} as pixels");
    }
}
