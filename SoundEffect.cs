using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    public class SoundEffect
    {
        public void greeting() {
            if (OperatingSystem.IsWindows())
            {
                try
                {
                    SoundPlayer myMusic = new SoundPlayer("Cyber bot.wav");
                    myMusic.Load(); // This might throw an exception if file not found
                    myMusic.Play();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not play sound: {ex.Message}");
                }
            }



        }
    }
}
