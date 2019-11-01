using System;
using System.Collections.Generic;
using System.Text;

namespace Mediateka.Classes
{
    class MediaPlayer
    {
        enum streamFile
        {
            mp3,
            mp4,
            avi
        };

        enum staticFile
        {
            bmp,
            jpg,
            svg
        }

        public string Name { get; private set; }

        public void PlayFile(string Name) { }

        public void PauseFile(string Name) { }

        public void StopFile(string Name) { }

  
    }
}
