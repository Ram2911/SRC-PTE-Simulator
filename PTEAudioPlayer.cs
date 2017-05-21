using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace Timer_Mic_PTE
{
    class PTEAudioPlayer
    {
        protected String m_strFileName = "";
        public PTEAudioPlayer()
        {
        }
        protected PTEAudioPlayer(String strFileName)
        {
            m_strFileName = strFileName;
        }
        public virtual bool PlayAudio()
        {
            //m_strFileName = strFileName;
            //SoundPlayer objPlayer = new SoundPlayer(m_strFileName);
            //objPlayer.Play();
            return false;
        }
        public virtual bool StopAudio()
        {
            return false;
        }
    }
}
