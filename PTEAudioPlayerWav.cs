using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Timer_Mic_PTE
{
    class PTEAudioPlayerWav : PTEAudioPlayer
    {
        SoundPlayer m_objPlayer;

        public PTEAudioPlayerWav()
        {

        }

        public PTEAudioPlayerWav(String strFileName)
        {
            m_strFileName = strFileName;
        }
        
        public override bool PlayAudio()
        {
            m_objPlayer = new SoundPlayer(@m_strFileName);
            m_objPlayer.Play();
            return true;
        }
        public override bool StopAudio()
        {
            m_objPlayer.Stop();
            return true;
        }

    }
}
