using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace text_to_speech_convertor_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SpeechSynthesizer synth = new SpeechSynthesizer();
           synth.Speak("Hello, welcome to Text to Speech conversion app"); 
        }
    }
}