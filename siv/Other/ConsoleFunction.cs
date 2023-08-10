using System;

namespace siv.Other
{
    public static class ConsoleFunction
    {
        public static void PrintTopBar(string Text, ConsoleColor topBarColor)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = topBarColor;
            Console.Write(Text);
            for(int i = 0; i < Console.WindowWidth - Text.Length; i++)
            {
                Console.Write(' ');
            }
            Console.ResetColor();
        }

        public static void PrintBottomBar(string Text, ConsoleColor bottomBarColor)
        {
            Console.SetCursorPosition(0, Console.WindowHeight);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = bottomBarColor;
            Console.Write(Text);
            for(int i = 0; i < Console.WindowWidth - Text.Length; i++)
            {
                Console.Write(' ');
            }
        }
    }
}