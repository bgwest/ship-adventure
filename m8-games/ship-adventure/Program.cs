using System;
using GameStateManagementSample;

namespace ship_adventure
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new GameStateManagementGame())
                game.Run();
        }
    }
}
