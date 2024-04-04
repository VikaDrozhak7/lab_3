public class VectorRender : IRender
{
    public void RenderShape(string shapeName)
    {
        Console.WriteLine($"Drawing {shapeName} as vector");
    }
}
