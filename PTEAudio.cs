using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;


namespace Timer_Mic_PTE
{
    class PTEAudio
    {
        int m_nAudioTrialCount = 0;
       
        public static String[] GetRecordedAudioFileList(string strPath, string strFileName)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(strPath);
            //strFileName += ".wav";
            int nFileCount = fileEntries.Count();
            string[] strArrayAudioFiles = new string[nFileCount];

            int nAudioArrayIndex = 0;
            if (nFileCount > 0)
            {
                foreach(string strFile in fileEntries)
                {
                    int nPosition = strFile.LastIndexOf(strFileName);
                    int nExtension = strFile.LastIndexOf(PTEGlobalValues.gloStrWaveFormat);
                    int nRecordString = strFile.LastIndexOf(PTEGlobalValues.gloStrRecording);
                    //To look for filename in files that have .wav extension 
                    //and has "RecOn" string (Recorded through your own mic)
                    if (nPosition > 0 && nExtension > 0 && nRecordString > 0)   
                    {
                        string strImageFile = strFile.Substring(nPosition);
                        strArrayAudioFiles[nAudioArrayIndex] = strImageFile;
                        nAudioArrayIndex++;
                    }

                }
            }

            strArrayAudioFiles = strArrayAudioFiles.Where(s => !String.IsNullOrEmpty(s)).ToArray(); 
            
            return strArrayAudioFiles;
        }
        public String GetRandomAudio(string strPath)
        {
            return FetchRandomAudio(strPath);
        }

        public static double GetAudioLength(string strFileName)
        {
            double dAudioLength = 0.0;
            double dNanoseconds = 0.0;
            ShellFile objShellFile = ShellFile.FromFilePath(strFileName);
            double.TryParse(objShellFile.Properties.System.Media.Duration.Value.ToString(), out dNanoseconds);
            if (dNanoseconds > 0)
            {
                // One million nanoseconds in 1 millisecond, but we are passing in 100ns units...
                double dMilliSecond = dNanoseconds * 0.0001;

                dAudioLength = dMilliSecond / 1000;
            }
            return dAudioLength;
        }

        //Private Functions...
        private String FetchRandomAudio(String strPath)
        {
            String strFileName = "";
            if (Directory.Exists(strPath))
            {
                strFileName = ProcessDirectory(strPath);
            }
            return strFileName;
        }
        private String ProcessDirectory(string strPath)
        {
            // Process the list of files found in the directory and get only relevant audio files and not the recorded ones.
            string[] fileEntries = GetRelevantAudioFiles(strPath);
            int nFileCount = fileEntries.Count();

            if (nFileCount > 0)
            {
                int nRandom = GenerateRandomNumber(nFileCount);

                String strRandomFile = fileEntries[nRandom];
                if (File.Exists(strRandomFile))
                {
                    return strRandomFile;
                }
            }

            MessageBox.Show("There are no audio files in this folder.\n\nPlease check and select appropriate path using Set Path option");
            return null;
        }

        private String[] GetRelevantAudioFiles(string strPath)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(strPath);
            int nFileCount = fileEntries.Count();
            string[] strEligibleFiles = new string[nFileCount];
            int nFileIndex = 0;
            if (nFileCount > 0)
            {
                foreach(string strFile in fileEntries)
                {
                    if (File.Exists(strFile))
                    {
                        String strExtension = FileUtilities.ExtractFileExtension(strFile);
                        int nRecordString = strFile.LastIndexOf(PTEGlobalValues.gloStrRecording);
                        //Tolook for filename in files that have .wav or .mp3 extension 
                        //and does not have "RecOn" string (Not recorded through your own mic)

                        if (IsFileTypeAudio(strExtension) == true && nRecordString <= 0)
                        {
                            strEligibleFiles[nFileIndex] = strFile;
                            nFileIndex++;
                        }
                    }
                }

            }

            strEligibleFiles = strEligibleFiles.Where(s => !String.IsNullOrEmpty(s)).ToArray();

            return strEligibleFiles;
        }

        private int GenerateRandomNumber(int nMaximum)
        {
            Random oRandomObject = new Random();
            int nRandomNumber = oRandomObject.Next(0, nMaximum);
            return nRandomNumber;
        }
        private bool IsFileTypeAudio(string strExtension)
        {
            string[] strImageExtensions = { ".wav", ".mp3"};
            foreach (string strElement in strImageExtensions)
            {
                if (strElement.Equals(strExtension.ToLower()))
                    return true;
            }
            return false;
        }
    }
}
