using System;

namespace siv.TextEditor
{
    public static class TextEditor
    {
        public static int yTextLines = 0;

        public static string fileName = "NewTextFile.txt";
        public static string filePath = $"/home/{Environment.UserName}/{fileName}";

        public static Canvas textCanvas = new Canvas();

        public static void StartTextEditor()
        {
            Console.Clear();
            Other.ConsoleFunction.PrintTopBar("Siv Text editor | Created by Nevixity | Press Ctrl + F to open file", ConsoleColor.Green);
            Console.SetCursorPosition((Console.WindowWidth - "Siv Text editor by Nevixity".Length) / 2, 5);
            Console.WriteLine("Siv Text editor by Nevixity");
            Console.SetCursorPosition((Console.WindowWidth - "Inspired by ziv (Winksplorer)".Length) / 2, 6);
            Console.WriteLine("Inspired by ziv (Winksplorer)");

            Console.SetCursorPosition((Console.WindowWidth - "Press any key to enter text editor...".Length) / 2, 15);
            Console.WriteLine("Press any key to enter text editor...");
            ConsoleKeyInfo ck = Console.ReadKey();
            if((ck.Modifiers == ConsoleModifiers.Control) && ck.Key == ConsoleKey.F)
            {
                Console.Clear();
                Console.WriteLine("Enter file path : ");
                string? path = Console.ReadLine();
                if(path == null)
                {
                    Console.WriteLine("Path is null.");
                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        textCanvas.textLines = File.ReadAllLines(path);
                        ReadWriteMode();
                    }
                    catch
                    {
                        Console.WriteLine("Invalid path.");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                ReadWriteMode();
            }
        }

        private static void ReadWriteMode()
        {
            Console.Clear();
            while(true)
            {
                Console.Clear();
                Other.ConsoleFunction.PrintTopBar($"Siv Text editor | {fileName} | {textCanvas.currentTextMode.ToString()}", ConsoleColor.Green);
                if(textCanvas.currentTextMode == textMode.Write)
                {
                    textCanvas.Render();
                    textCanvas.AcceptInput();
                }
                else if(textCanvas.currentTextMode == textMode.Read)
                {
                    textCanvas.Render();
                    Console.ReadKey();
                }
            }
        }
    }
}