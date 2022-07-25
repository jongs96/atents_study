using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//절차지향
//함수지향
//객체지향 4대 특성
namespace cs_study_JS
{
    //abstract class SoundFile
    //{
    //    protected string name;
    //    public SoundFile(string file)
    //    {
    //        name = file;
    //    }
    //    public abstract void Play();
    //}//부모class

    //class Wave : SoundFile
    //{
    //    public override void Play()
    //    {
    //        Console.WriteLine($"[Wave]{name}을 플레이 합니다.");
    //    }
    //}//wave만 지원하게 만들었었다.
    //enum SoundType
    //{
    //    WAVE, MP3, OGG
    //}
    //class MusicPlayer
    //{
    //    public void Play(SoundType st, string file)
    //    {//wave플레이
    //        //switch (st)
    //        //{
    //        //    case SoundType.MP3:
    //        //        Console.WriteLine($"[MP3]{file}을 플레이 합니다.");
    //        //        break;
    //        //    case SoundType.WAVE:
    //        //        Console.WriteLine($"[Wave]{file}을 플레이 합니다.");
    //        //}
    //    }
    //}
    abstract class SoundFile
    {
        protected string name;
        public SoundFile(string file)
        {
            name = file;
        }
        public abstract void Play();
    }

    class Wave : SoundFile
    {
        public Wave(string file) : base(file)
        {

        }
        public override void Play()
        {
            Console.WriteLine($"[Wave]{name}을 플레이 합니다.");
        }
    }

    class Mp3 : SoundFile
    {
        public Mp3(string file) : base(file)
        {

        }
        public override void Play()
        {
            Console.WriteLine($"[Mp3]{name}을 플레이 합니다.");
        }
    }

    class Mp4 : SoundFile
    {
        public Mp4(string file) : base(file)
        {

        }
        public override void Play()
        {
            Console.WriteLine($"[Mp4]{name}을 플레이 합니다.");
        }
    }

    enum SoundType
    {
        WAVE, MP3, OGG
    }

    class MusicPlayer
    {
        public void Play(SoundFile sf)
        {
            sf.Play();
        }
    }
    class Program
    {
        static void Main(string[] args)// main 함수 생성규칙.
        {
            MusicPlayer player = new MusicPlayer();
            player.Play(new Mp4("안녕"));
        }
    }
}