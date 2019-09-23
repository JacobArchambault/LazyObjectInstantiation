﻿using System;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instatiation *****\n");

            // No allocation of AllTracks object here!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();

            // Allocation of AllTracks happens when you call GetAllTracks().
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}
