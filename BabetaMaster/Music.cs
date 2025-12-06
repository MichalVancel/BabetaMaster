using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace BabetaMaster
{
    public class Music
    {
        private string Path = @"C:\Users\Lenovo\Desktop\Prax\SoundsBabeta\";
        protected string SoundName {  get; set; }
        private SoundPlayer player;
        public Music(string soundName)
        {
            SoundName = soundName;
        }
        public void Play()
        {
            string saundFile = Path + SoundName;
            SoundPlayer player = new SoundPlayer(saundFile);
            player.Play();
        }
        public void Stop()
        {
            if (player != null)
                player.Stop();
        }
    }
}
