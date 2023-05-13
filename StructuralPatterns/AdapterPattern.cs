/*************************************************************************************
 *
 * 文 件 名：	AdapterPattern.cs
 * 描 述：   适配器模式
 *
 * 版 本：	v1.0
 * 创 建 者：	BiaoWang
 * 创 建 时 间：	2023/5/13 15:38
 * 
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.StructuralPatterns
{
    /// <summary>
    /// 创建2个 为媒体播放器和更高级的媒体播放器 的接口
    /// </summary>
    public interface MediaPlayer
    {
        public void Play(string audioType, string fileName);
    }

    public interface AdvancedMediaPlayer
    {
        public void PlayVlc(string fileName);
        public void PlayMp4(string fileName);
    }

    /// <summary>
    /// 创建2个实现了AdvancedMediaPlayer接口的实体类
    /// </summary>
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name:" + fileName);
        }

        public void PlayMp4(string fileName)
        {
            // 什么也不做
        }
    }

    public class MP4Player : AdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name:" + fileName);
        }

        public void PlayVlc(string fileName)
        {
            // 什么也不做
        }
    }

    /// <summary>
    /// 创建实现了MediaPlayer接口的适配器类
    /// </summary>
    public class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMediaPlayer = new MP4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMediaPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }

    /// <summary>
    /// 创建实现了 MediaPlayer 接口的实体类。
    /// </summary>
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file. Name:" + fileName);
            }
            else if (audioType.Equals("vlc") || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Invalid media. {audioType} format not supported");
            }
        }
    }
}
