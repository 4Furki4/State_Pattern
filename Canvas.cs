namespace DesignPattern_State
{
    public class Canvas
    {
        private Tool currentTool; // Selection and Brush Tool are extented by Tool interface so, there're also a interface.
        

        public Tool CurrentTool { get => currentTool; set => currentTool = value; } // we set currentTool either Selection or Brush to use methods. 

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }
        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }
    }
}