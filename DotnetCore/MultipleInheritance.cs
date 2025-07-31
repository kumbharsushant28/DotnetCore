using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal interface IPlayable
    {
        void Play();
    }

    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");

        }
    }

    internal interface MultipleInheritance
    {
        static void Main()
        {
            IPlayable music = new MusicPlayer();
            music.Play();
            IPlayable video = new VideoPlayer();
            video.Play();
            VideoPlayer v = new VideoPlayer();
            MusicPlayer m = new MusicPlayer();
            m.Play();
            v.Play();

        }
    }
}
