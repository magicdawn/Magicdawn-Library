using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Un4seen.Bass;
namespace Magicdawn
{
    /// <summary>
    /// BassPlayer封装
    /// </summary>
    public class BassPlayer : System.Runtime.ConstrainedExecution.CriticalFinalizerObject,IDisposable
    {
        int stream;
        /// <summary>
        /// 构造函数
        /// </summary>
        public BassPlayer()
        {
            Bass.BASS_Init(-1,44100,BASSInit.BASS_DEVICE_DEFAULT,System.IntPtr.Zero);
        }

        /// <summary>
        /// 加载一首歌曲
        /// </summary>
        /// <param name="url"></param>
        public void LoadSong(string url)
        {
            stream = Bass.BASS_StreamCreateFile(url,0,0,BASSFlag.BASS_SAMPLE_FLOAT);
        }

        public void PlaySong()
        {
            Bass.BASS_ChannelPlay(stream,false);
        }

        public void PauseSong()
        {
            Bass.BASS_ChannelPause(stream);
        }

        public void StopSong()
        {
            Bass.BASS_ChannelStop(stream);
        }

        ~BassPlayer()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool disposing)
        {
            if(disposing)
            {
                //显式调用,可访问
            }
            Bass.BASS_Free();
        }
    }
}
