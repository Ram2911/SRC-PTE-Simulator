using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
namespace Timer_Mic_PTE
{
    class FileUtilities
    {
        //[DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        //private static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string longPath,
        //                                            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int length);

        [DllImport("kernel32", EntryPoint = "GetShortPathName", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetShortPathName(string longPath, StringBuilder shortPath, int bufSize);

        public static string FetchShortPathName(String strFullPath)
        {

            String strDirectoryPath = ExtractDirectoryPath(strFullPath);
            String strFileNameExtension = ExtractFileNameWithExtension(strFullPath);

            string strShortPath = string.Empty;

            long lStringLength = 0;

            var buffer = new StringBuilder(256);

            // Get the length of the path 
            lStringLength = GetShortPathName(strDirectoryPath, buffer, buffer.Capacity);


            if (lStringLength == 0) throw new System.ComponentModel.Win32Exception();
            strShortPath = buffer.ToString();

            strShortPath += strFileNameExtension;

            return strShortPath;
        }
        public static String ExtractDirectoryPath(String strFullPath)
        {

            int nPosition = strFullPath.LastIndexOf("\\");

            String strNoFileExtension = strFullPath.Substring(0, nPosition);

            return strNoFileExtension;
        }
        public static String ExtractFilePath(String strFullPath)
        {
            int nPosition = strFullPath.LastIndexOf(".");
            String strNoFileExtension = strFullPath.Substring(0, nPosition);

            return strNoFileExtension;
        }
        public static String ExtractFileNameWithExtension(String strFullPath)
        {
            int nPosition = strFullPath.LastIndexOf("\\");
            String strExtension = strFullPath.Substring(nPosition);

            return strExtension;
        }
        public static String ExtractFileExtension(String strFullPath)
        {
            int nPosition = strFullPath.LastIndexOf(".");
            String strExtension = strFullPath.Substring(nPosition);

            return strExtension;
        }
        public static String ExtractFileNameWithoutExtension(String strFullPath)
        {
            String strFileWithExtension = ExtractFileNameWithExtension(strFullPath);
            int nPosition = strFileWithExtension.LastIndexOf(".");

            return strFileWithExtension.Substring(0,nPosition);
        }

    }
}
