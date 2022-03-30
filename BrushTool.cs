namespace DesignPattern_State
{
    public class BrushTool : Tool
    {
        // We specify the methods according to the Tool. Here, We set them for BrushTool.
        public void MouseDown()
        {
            System.Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Draw a line");
        }
    }
}