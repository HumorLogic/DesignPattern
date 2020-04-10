using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.结构型模式.适配器模式.Example2
{
    class program
    {
        static void Main(string[] arg)
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "东风破.mp3");
            audioPlayer.Play("mp4", "黑暗森林.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
            audioPlayer.Play("MP4", "mind me.mp4");
        }
    }

   public interface MediaPlayer
    {
        void Play(string audioType, string fileName);
    }

    public interface AdavanceMediaPlayer
    {
        public void PlayVlc(string fileName);
        public void PlayMp4(string fileName);
    }

    public class VlcPlayer : AdavanceMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            return;
        }

        public void PlayVlc(string fileName)
        {
                Console.WriteLine("Playing vlc file. Name: {0}", fileName);
         }
     }


    public class Mp4Player : AdavanceMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: {0}", fileName);
           
        }

        public void PlayVlc(string fileName)
        {
            return;
        }
    }

    public class MediaAdapter : MediaPlayer
    {
        AdavanceMediaPlayer adavanceMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower() == "vlc")
            {
                adavanceMediaPlayer = new VlcPlayer();
            }
            else if (audioType.ToLower() == "mp4")
            {
                adavanceMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "vlc")
            {
                adavanceMediaPlayer.PlayVlc(fileName);
            }
            else if (audioType.ToLower() == "mp4")
            {
                adavanceMediaPlayer.PlayMp4(fileName);
            }
        }
    }

    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "mp3")
            {
                Console.WriteLine("Playing mp3 file. Name: {0}", fileName);
            }else if (audioType.ToLower() == "vlc" || audioType.ToLower() == "mp4")
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. [{0}] format not supported", audioType);
            }
        }
    }
}
