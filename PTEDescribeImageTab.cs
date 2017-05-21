using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Media;

namespace Timer_Mic_PTE
{

    public partial class frmPTEMock : Form
    {
        String m_strDescribeImagePath = ""; 
        private void InitializeDescribeImageTab()
        {
            m_bPlayMode = true;
            m_nReadCount = 25;
            m_nRecordCount = 40;
        }
        private void InitializeDescribeImageMock()
        {
            groupDIAudio.Enabled = false;
            buttonDIPlay.Visible = true;
            buttonDIPause.Visible = false;
            progressDIRead.Minimum = 0;
            progressDIRead.Maximum = 25;
            progressDIRecord.Minimum = 0;
            progressDIRecord.Maximum = 40;
            progressDIRead.Value = 0;
            progressDIRead.Refresh();
            progressDIRecord.Value = 0;
            progressDIRecord.Refresh();
            textReadTime.Text = "";
            textRecordTime.Text = "";
            txtPath.Text = m_strDescribeImagePath;
            m_nReadCount = 0;
            m_nRecordCount = 0;
            timerRecord.Stop();
            timerRead.Stop();
            timerTextUpdate.Stop();
            chkDIPlayMode.Checked = false;
            cmbDIRecordings.Items.Clear();
            cmbDIRecordings.Text = "";
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            m_strDescribeImagePath = folderBrowserDialog.SelectedPath;
            txtPath.Text = m_strDescribeImagePath;
        }

        private void chkDIPlayMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDIPlayMode.Checked == true)
            {
                buttonDIPlay.Visible = true;
                buttonDIPause.Visible = false;
                groupDIAudio.Enabled = true;
                LoadDescribeImageRecordings();
            }
            else
                groupDIAudio.Enabled = false;

        }

        private void butNextImage_Click(object sender, EventArgs e)
        {
            InitializeMock();
            InitializeDescribeImageTab();
            InitializeDescribeImageMock();
            chkDIPlayMode.Checked = false;
            m_eTestState = eState.eReadMode;
            buttonDIPlay.Visible = false;
            buttonDIPause.Visible = false;
            PTEImages objImage = new PTEImages();
            objImage.LoadRandomImage(ref imageHolder, txtPath.Text);
            String strMicFileName = FormulateAudioName();
            timerRead.Start();
            timerTextUpdate.Start();
            m_objRecorder = new PTERecorder(strMicFileName);
            LoadDescribeImageRecordings();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            UpdateDescribeImagePlayButton();
            if (imageHolder.Tag == null)
                return;
            String strAudioName = imageHolder.Tag.ToString();
            String strPath = FileUtilities.ExtractDirectoryPath(strAudioName);
            String strSelectedAudioItem = cmbDIRecordings.SelectedItem.ToString();
            strAudioName = strPath + strSelectedAudioItem;
            //double dAudioLength = PTEAudio.GetAudioLength(strAudioName);

            m_objRecordedAudioPlayer = new PTEAudioPlayerWav(strAudioName);
            m_objRecordedAudioPlayer.PlayAudio();
        }

        private void buttonDIPause_Click(object sender, EventArgs e)
        {
            UpdateDescribeImagePlayButton();
            if (m_objRecordedAudioPlayer != null)
            {
                m_objRecordedAudioPlayer.StopAudio();
            }
        }

        private void UpdateDescribeImagePlayButton()
        {
            if (m_bPlayMode == true)
            {
                m_bPlayMode = false;
                buttonDIPlay.Visible = false;
                buttonDIPause.Visible = true;
            }
            else
            {
                buttonDIPlay.Visible = true;
                buttonDIPause.Visible = false;
                m_bPlayMode = true;
            }

        }

        private void timerTextUpdate_Tick(object sender, EventArgs e)
        {
            if (m_eTestState == eState.eReadMode)
            {
                if (m_nReadCount <= 0)
                    m_nReadCount = 26;

                m_nReadCount--;
                m_nRecordCount = 40;
                textReadTime.Text = m_nReadCount.ToString();
                textRecordTime.Text = "";
                progressDIRead.Increment(1);
            }
            else if (m_eTestState == eState.eRecordMode)
            {
                if (m_nRecordCount <= 0)
                    m_nRecordCount = 41;
                m_nReadCount = 25;
                m_nRecordCount--;
                textRecordTime.Text = m_nRecordCount.ToString();
                textReadTime.Text = "";
                progressDIRecord.Increment(1);
            }

        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            m_eTestState = eState.eRecordMode;
            m_objRecorder.StartMicRecording();
            SystemSounds.Beep.Play();
            timerRecord.Start();
            timerRead.Stop();
            progressDIRead.Increment(1);
        }

        private void timerRecord_Tick(object sender, EventArgs e)
        {
            m_eTestState = eState.eReadMode;
            m_objRecorder.StopMicRecording();
            timerRead.Stop();
            timerRecord.Stop();
            timerTextUpdate.Stop();
        }

        private String FormulateAudioName()
        {
            String strAudioName = "";

            if (imageHolder.Tag != null)
            {
                strAudioName = imageHolder.Tag.ToString();
                int nPosition = strAudioName.LastIndexOf(".");
                String strNoExtension = strAudioName.Substring(0, nPosition);
                DateTime dtTime = DateTime.Now;

                //Appending Date and Time to maintain the Uniqueness of the audio for an image
                //Format DateTime
                String strDateTime = dtTime.Day + "_" + dtTime.Month + "_" + dtTime.Year + "_" + dtTime.Hour + "_" + dtTime.Minute + "_" + dtTime.Second;
                strAudioName = strNoExtension + PTEGlobalValues.gloStrRecording + "_" + strDateTime;
                strAudioName += PTEGlobalValues.gloStrWaveFormat;
            }

            return strAudioName;
        }
        private void LoadDescribeImageRecordings()
        {
            if (imageHolder.Tag == null)
                return;
            String strAudioName = imageHolder.Tag.ToString();

            //FileUtilities objFileUtilities = new FileUtilities();
            String strPath = FileUtilities.ExtractDirectoryPath(strAudioName);
            String strFileName = FileUtilities.ExtractFileNameWithoutExtension(strAudioName);

            if (strAudioName != null && strAudioName.Length != 0)
            {
                cmbDIRecordings.Items.Clear();
                //FileUtilitiesAudio objFileUtilitiesAudio = new FileUtilitiesAudio();

                string[] strArrayAudioFiles = PTEAudio.GetRecordedAudioFileList(strPath, strFileName);

                cmbDIRecordings.Items.AddRange(strArrayAudioFiles);
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            m_strTaskPath = txtPath.Text;
        }

    }
}