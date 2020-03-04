using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rudin.MusicMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudin.MusicMethods.Tests
{
    [TestClass()]
    public class MusicPlayerTests
    {
        [TestMethod()]
        public void PlaySongTest()
        {
            MusicHandler music_player = MusicHandler.Instance;
            music_player.PlaySong("test.wav");
            System.Threading.Thread.Sleep(2000);
        }

        [TestMethod()]
        public void StopSongTest()
        {
            MusicHandler music_player = MusicHandler.Instance;
            music_player.PlaySong("test.wav");
            System.Threading.Thread.Sleep(1000);
            music_player.StopSong();
            System.Threading.Thread.Sleep(2000);
        }
    }
}