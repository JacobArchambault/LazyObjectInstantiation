using System;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Fun with Lazy Instatiation *****\n");

            // No allocation of AllTracks object here!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();

            // Allocation of AllTracks happens when you call GetAllTracks().
            MediaPlayer yourPlayer = new MediaPlayer();
            _ = yourPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}
