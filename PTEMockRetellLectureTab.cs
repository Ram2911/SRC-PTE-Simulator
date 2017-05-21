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
        String m_strRetellLecturePath = ""; 
        int m_nLectureCount = 0;
        private void InitializeRetellLectureTab()
        {
            m_bPlayMode = true;
            m_nReadCount = 10;
            m_nRecordCount = 40;
        }
        private void InitializeRetellLectureMock()
        {
            groupLecture.Enabled = false;
            btnPlayLecture.Visible = true;
            btnStopLecture.Visible = false;
            progressLectureStart.Minimum = 0;
            progressLectureStart.Maximum = 10;
            progressLectureStop.Minimum = 0;
            progressLectureStop.Maximum = 40;
            progressLectureStart.Value = 0;
            progressLectureStart.Refresh();
            progressLectureStop.Value = 0;
            progressLectureStart.Refresh();
            progressLecture.Minimum = 0;
            progressLecture.Value = 0;
            progressLecture.Refresh();
            txtLectureRecordStartTime.Text = "";
            txtLectureRecordStopTime.Text = "";
            txtLecturePath.Text = m_strRetellLecturePath;
            m_nReadCount = 0;
            m_nRecordCount = 0;
            timerRecordLecture.Stop();
            timerReadLecture.Stop();
            timerTextUpdateLecture.Stop();
            chkPlayLecture.Checked = false;
            cmbLectureList.Items.Clear();
            cmbLectureList.Text = "";
        }

        private void btnBrowseLecture_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            m_strRetellLecturePath = folderBrowserDialog.SelectedPath;
            txtLecturePath.Text = m_strRetellLecturePath;
        }

        private void chkPlayLecture_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlayLecture.Checked == true)
            {
                btnPlayLecture.Visible = true;
                btnStopLecture.Visible = false;
                groupLecture.Enabled = true;
                LoadRetellLectureRecordings();
            }
            else
                groupLecture.Enabled = false;

        }

        private void btnLoadLecture_Click(object sender, EventArgs e)
        {
            InitializeMock();
            InitializeRetellLectureTab();
            InitializeRetellLectureMock();
            chkPlayLecture.Checked = false;
            m_eTestState = eState.eLectureMode;

            //Add code to load a lecture in mp3 and start here...

            PTEAudio objLecture = new PTEAudio();
            String strLectureName = objLecture.GetRandomAudio(txtLecturePath.Text);
            if (strLectureName.Length == 0)
            {
                MessageBox.Show("There are no Lecture / Audio files in the folder");
                return;
            }
            imageHolder.Tag = strLectureName;
            double dAudioLength = PTEAudio.GetAudioLength(strLectureName);
            m_nLectureCount = Convert.ToInt32(dAudioLength) + 1;
            timerLecture.Interval = Convert.ToInt32(dAudioLength * 1000) + 1;
            progressLecture.Maximum = m_nLectureCount;
            progressLecture.Increment(1);
            PTEAudioPlayer objRecordedAudioPlayer = new PTEAudioPlayerMP3(strLectureName);
            objRecordedAudioPlayer.PlayAudio();
            timerLecture.Start();
            timerTextUpdateLecture.Start();
            String strMicFileName = FormulateLectureAudioName();
            m_objRecorder = new PTERecorder(strMicFileName);
            LoadRetellLectureRecordings();
        }

        private void timerLecture_Tick(object sender, EventArgs e)
        {
            m_eTestState = eState.eReadMode;
            timerReadLecture.Start();
            progressLecture.Increment(1);
        }

        private void btnPlayLecture_Click(object sender, EventArgs e)
        {
            UpdateLecturePlayButton();
            if (imageHolder.Tag == null)
                return;
            String strAudioName = imageHolder.Tag.ToString();
            String strPath = FileUtilities.ExtractDirectoryPath(strAudioName);
            String strSelectedAudioItem = cmbLectureList.SelectedItem.ToString();
            strAudioName = strPath + strSelectedAudioItem;
            m_objRecordedAudioPlayer = new PTEAudioPlayerWav(strAudioName);
            m_objRecordedAudioPlayer.PlayAudio();
        }

        private void btnStopLecture_Click(object sender, EventArgs e)
        {
            UpdateLecturePlayButton();
            if (m_objRecordedAudioPlayer != null)
            {
                m_objRecordedAudioPlayer.StopAudio();
            }
        }

        private void UpdateLecturePlayButton()
        {
            if (m_bPlayMode == true)
            {
                m_bPlayMode = false;
                btnPlayLecture.Visible = false;
                btnStopLecture.Visible = true;
            }
            else
            {
                btnPlayLecture.Visible = true;
                btnStopLecture.Visible = false;
                m_bPlayMode = true;
            }

        }

        private void timerTextUpdateLecture_Tick(object sender, EventArgs e)
        {
            if (m_eTestState == eState.eReadMode)
            {
                if (m_nReadCount <= 0)
                    m_nReadCount = 11;

                m_nReadCount--;
                m_nRecordCount = 40;
                txtLectureRecordStartTime.Text = m_nReadCount.ToString();
                txtLectureRecordStopTime.Text = "";
                progressLectureStart.Increment(1);
            }
            else if (m_eTestState == eState.eRecordMode)
            {
                if (m_nRecordCount <= 0)
                    m_nRecordCount = 41;
                m_nReadCount = 10;
                m_nRecordCount--;
                txtLectureRecordStopTime.Text = m_nRecordCount.ToString();
                txtLectureRecordStartTime.Text = "";
                progressLectureStop.Increment(1);
            }
            else if (m_eTestState == eState.eLectureMode)
            {
                progressLecture.Increment(1);
            }

        }

        private void timerReadLecture_Tick(object sender, EventArgs e)
        {
            m_eTestState = eState.eRecordMode;
            m_objRecorder.StartMicRecording();
            SystemSounds.Beep.Play();
            timerRecordLecture.Start();
            timerReadLecture.Stop();
            progressLectureStart.Increment(1);
        }

        private void timerRecordLecture_Tick(object sender, EventArgs e)
        {
            m_eTestState = eState.eReadMode;
            m_objRecorder.StopMicRecording();
            timerReadLecture.Stop();
            timerRecordLecture.Stop();
            timerTextUpdateLecture.Stop();
        }

        private String FormulateLectureAudioName()
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
        private void LoadRetellLectureRecordings()
        {
            if (imageHolder.Tag == null)
                return; 
            String strAudioName = imageHolder.Tag.ToString();

            //FileUtilities objFileUtilities = new FileUtilities();
            String strPath = FileUtilities.ExtractDirectoryPath(strAudioName);
            String strFileName = FileUtilities.ExtractFileNameWithoutExtension(strAudioName);

            if (strAudioName != null && strAudioName.Length != 0)
            {
                cmbLectureList.Items.Clear();
                //FileUtilitiesAudio objFileUtilitiesAudio = new FileUtilitiesAudio();

                string[] strArrayAudioFiles = PTEAudio.GetRecordedAudioFileList(strPath, strFileName);

                cmbLectureList.Items.AddRange(strArrayAudioFiles);
            }
        }

     }
}