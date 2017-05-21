using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Timer_Mic_PTE
{
    class PTEImages
    {
        int m_imageTrialCount = 0;

        public bool LoadRandomImage(ref System.Windows.Forms.PictureBox imgControl, String strPath)
        {

            String strImageFile = FetchRandomImage(strPath);
            if (strImageFile.Length == 0)
                return false;
            imgControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgControl.Image = Image.FromFile(strImageFile);
            imgControl.Tag = strImageFile;
            return true;
        }

        private String FetchRandomImage(String strPath)
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
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(strPath);
            string strFileName = "";
            int nFileCount = fileEntries.Count();

            if(nFileCount>0)
            {
                int nRandom = GenerateRandomNumber(nFileCount);

                String strRandomFile = fileEntries[nRandom];
                if (File.Exists(strRandomFile))
                {
                    String strExtension = FileUtilities.ExtractFileExtension(strRandomFile);
                    if (IsFileTypeImage(strExtension) == true)
                    {
                        strFileName = strRandomFile;
                        m_imageTrialCount = 0;
                    }
                    else
                    {
                        m_imageTrialCount++;
                        if (m_imageTrialCount < 10) //Might end up in an infinite loop... if this is NotFiniteNumberException done
                            ProcessDirectory(strPath);  //Call Recursively until an image file is found. 
                        else
                            MessageBox.Show("There are no image files in this folder.\n\nPlease check and select appropriate path using Set Path option");
                    }
                }
            }
            return strFileName;
            //// Recurse into subdirectories of this directory.
            //string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            //foreach (string subdirectory in subdirectoryEntries)
            //    ProcessDirectory(subdirectory);
        }
        private int GenerateRandomNumber(int nMaximum)
        {
            Random oRandomObject = new Random();
            int nRandomNumber = oRandomObject.Next(0, nMaximum);
            return nRandomNumber;
        }
        private bool IsFileTypeImage(string strExtension)
        {
            string[] strImageExtensions = {".jpg", ".jpeg", ".jpe",".jfif",".bmp", ".dib", ".rle", ".gif", ".png", ".tif", ".tiff"};
            foreach(string strElement in strImageExtensions)
            {
                if(strElement.Equals(strExtension.ToLower()))
                    return true;
            }
            return false;
        }
    }
}
