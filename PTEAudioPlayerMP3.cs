using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;

namespace Timer_Mic_PTE
{
    class PTEAudioPlayerMP3 : PTEAudioPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        int m_nAudioLength = 0;

        public PTEAudioPlayerMP3()
        {

        }
        public PTEAudioPlayerMP3(String strFileName)
        {
            m_strFileName = strFileName;
        }

        public override bool PlayAudio()
        {
            string strFormat = @"open ""{0}"" type mpegvideo alias MediaFile";
            string strCommand = String.Format(strFormat, m_strFileName);
            mciSendString(strCommand, null, m_nAudioLength, IntPtr.Zero);

            mciSendString("play MediaFile", null, m_nAudioLength, IntPtr.Zero);
            return true;
        }
        public override bool StopAudio()
        {
            mciSendString("stop MediaFile", null, m_nAudioLength, IntPtr.Zero);
            return true;
        }

        public bool CloseAudio(String strFileName)
        {
            mciSendString("close MediaFile", null, m_nAudioLength, IntPtr.Zero);
            return true;
        }
    }
}
