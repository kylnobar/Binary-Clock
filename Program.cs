using System;

namespace Binary_Clock
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new BinaryClock())
                game.Run();
        }
    }
}
