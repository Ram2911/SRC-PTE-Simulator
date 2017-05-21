using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Timer_Mic_PTE
{
    class PTERecorder
    {
        //This is for Recording Voice...
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        String m_strFileName;


        public PTERecorder(String strFileName)
        {
            m_strFileName = strFileName;
            record("open new Type waveaudio Alias recsound", "", 0, 0);
        }

        public bool StartMicRecording()
        {

            record("record recsound", "", 0, 0);
            return true;
        }

        public bool StopMicRecording()
        {

            //FileUtilities objFileUtilities = new FileUtilities();

            String strShortPath = FileUtilities.FetchShortPathName(m_strFileName);
            String strAudioInput = string.Format("save recsound \"{0}\"", strShortPath);
            int nSuccess = record(string.Format("{0}", strAudioInput), null, 0, 0);
            if (nSuccess != 0)
                MessageBox.Show("Recording could not be saved. \n\nPlease check the length of file name");
            record("close recsound ", "", 0, 0);
            return true;
        }
    }
}
