using P02.Graphic_Editor.Models.Interfaces;

namespace P02.Graphic_Editor.Models
{
    class Program
    {
        static void Main()
        {
            GraphicEditor graphicEditor = new GraphicEditor();
            graphicEditor.DrawShape(new Circle());
        }
    }
}
