using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudin.MusicMethods
{
    public interface IMusicPlayer
    {
        void Play(string song_location);
        void Stop();
    }
}
