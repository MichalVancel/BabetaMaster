using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace BabetaMaster
{
    internal class Babeta
    {
        private string Path = 
        protected private string SoundName { get; set; }
        public void MakeSound()
        {
            string saundFile = Path + SoundName;
            SoundPlayer player = new SoundPlayer(saundFile);
            player.PlaySync();
        }
    }
}
