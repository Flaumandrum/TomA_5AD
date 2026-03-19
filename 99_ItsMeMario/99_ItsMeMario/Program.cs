using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace _99_itsMeMario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Velden

            Dictionary  <string, int> _noten = new Dictionary<string, int>();
            //int[] _noten = new int[] { 262, 294, 330, 379, 392, 440, 494 };

            _noten.Add("Do4", 262);
            _noten.Add("Re4",294);
            _noten.Add("Mi4", 330);
            _noten.Add("Fa4",349);
            _noten.Add("Sol4",392); 
            _noten.Add("La4",440); 
            _noten.Add("Si4",494);


            PlayTone(330, 0.250); // 330 Hz for 300 ms
            PlayTone(330, 0.200);
            PlayTone(330, 0.200);



            List<string> scale = new List<string> { "Do4", "Re4", "Mi4", "Fa4", "Sol4", "La4", "Si4"};


            
        }


        static void PlayTone(double freq, double seconds, float volume = 0.25f)
        {
            var waveOut = new WaveOutEvent();
            var signal = new SignalGenerator()
            {
                Gain = volume,
                Frequency = freq,
                Type = SignalGeneratorType.Sin
            };

            // Take first 'seconds' from the infinite generator
            var take = signal.Take(TimeSpan.FromSeconds(seconds));
            waveOut.Init(take);
            waveOut.Play();
            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(1);
            }
            waveOut.Dispose();
        }

    }
}
