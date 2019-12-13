using System;

namespace ScreenStateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.OnClick();
            screen.OnClick();
            screen.OnClick();

            Console.Read();
        }
    }
}
