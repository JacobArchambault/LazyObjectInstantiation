using System;
using System.Collections.Generic;
using System.Text;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        // Assume these methods do something useful.
        public void Play() { /* Play a song */}
        public void Pause() { /* Pause the song */}
        public void Stop() { /* Stop playback*/}
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
        {
            Console.WriteLine("Creating AllTracksObject!");
            return new AllTracks();
        });
        public AllTracks GetAllTracks()
        {
            // Return all of the songs.
            return allSongs.Value;
        }
    }
}
