using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LinkAudio
    {
        public void audioScan()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\QLBH_ScanBardcode\QLBH_ScanBardcode\Audio\BarcodeEffect.wav");
            sound.Play();
        }
    }
}
