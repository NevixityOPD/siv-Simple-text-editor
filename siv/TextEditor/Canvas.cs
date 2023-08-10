using System;

namespace siv.TextEditor
{
    public class Canvas
    {
        public string[] textLines;
        public textMode currentTextMode;
        
        public Canvas()
        {
            textLines = new string[1];
            currentTextMode = textMode.Write;
        }

        public void Render()
        {
            for(int i = 0; i < textLines.Length; i++)
            {
                Console.Write($"{textLines[i]}\n");
            }
        }

        public void AcceptInput()
        {
            Array.Resize(ref textLines, textLines.Length + 1);
            string? buffer = Console.ReadLine();
            textLines[TextEditor.yTextLines] += buffer;
            TextEditor.yTextLines += 1;
        }
    }
}