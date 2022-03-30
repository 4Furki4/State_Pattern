using System;

namespace DesignPattern_State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas(); 
            canvas.CurrentTool= new SelectionTool(); //We set canvas instance as SelectionTool to use its methods.
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.CurrentTool= new BrushTool(); //We changed it to Brushtool.
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
