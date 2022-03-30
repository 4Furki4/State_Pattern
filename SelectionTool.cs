namespace DesignPattern_State
{
    public class SelectionTool : Tool
    {
        // We specify the methods according to the Tool. Here, We set them for SelectionTool.
        public void MouseDown()
        {
            System.Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Draw a dashed rectangle");
        }
    }
}