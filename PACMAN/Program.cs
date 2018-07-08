using System;
//using XNAPacMan;

namespace PACMAN
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        static XNAPacMan.XNAPacMan game;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var game = new Game1())
            //    game.Run();
            /*MonoMac.AppKit.NSApplication.Init();

            using (var p = new MonoMac.Foundation.NSAutoreleasePool())
            {
                MonoMac.AppKit.NSApplication.SharedApplication.Delegate = new AppDelegate();
                MonoMac.AppKit.NSApplication.Main(args);
            }*/
            game = new XNAPacMan.XNAPacMan();
            game.Run();
        }
    }
#endif
}
