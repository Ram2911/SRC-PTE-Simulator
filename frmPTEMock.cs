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
using System.Xml;


namespace Timer_Mic_PTE
{

    public partial class frmPTEMock : Form
    {
        String m_strTaskPath = ""; 
        bool m_bPlayMode = true;
        int m_nReadCount = 25;
        int m_nRecordCount = 40;
        enum eState {
            eReadMode = 1,
            eRecordMode = 2,
            eLectureMode = 3
        }
        eState m_eTestState = eState.eReadMode;
        PTERecorder m_objRecorder;
        PTEAudioPlayer m_objRecordedAudioPlayer;     
        public frmPTEMock()
        {
            InitializeComponent();
            InitializeMock();
            InitializeDescribeImageTab();
            InitializeDescribeImageMock();
            InitializeRetellLectureTab();
            InitializeRetellLectureMock();
        }

        private void InitializeMock()
        {
            LoadPathConfiguration();
        }

        private void txtLecturePath_TextChanged(object sender, EventArgs e)
        {
            m_strRetellLecturePath = txtLecturePath.Text;
        }

        private void tabSpeaking_TabIndexChanged(object sender, EventArgs e)
        {
            InitializeMock();
            InitializeDescribeImageMock();
            InitializeDescribeImageTab();
            InitializeRetellLectureMock();
            InitializeRetellLectureTab();
        }

        //private void LoadDescribeImagePath()
        //{
        //    LoadPathConfiguration(m_strDescribeImagePath);
        //}

        //private void LoadRetellLecturePath()
        //{
        //    LoadPathConfiguration(m_strRetellLecturePath);
        //}

        private void LoadPathConfiguration()
        {
            //if (strPath.Length == 0)
            //    return;
            string strFile = ".\\" + PTEGlobalValues.gloConfigFileName;
            string strTabElement = "";
            string strElement = "";
            string strSection = "";
            if (!File.Exists(strFile))
            {
                return;
            }
            XmlTextReader textReader = new XmlTextReader(strFile);
            // Read until end of file
            while (textReader.Read())
            {
                XmlNodeType nType = textReader.NodeType;
                if (nType == XmlNodeType.Element || nType == XmlNodeType.Text)
                {
                    strElement = textReader.Name.ToString();
                    if (strElement.Equals(PTEGlobalValues.gloTagDescribeImage) || strElement.Equals(PTEGlobalValues.gloTagRetellLecture))
                    {
                        strTabElement = textReader.Name.ToString();
                        //Write Algo o fetch "Path" Element
                    }
                    if (strElement.Equals("Path"))
                    {
                        strSection = "Path";
                    }
                    if(strSection.Equals("Path"))
                    {
                        if (strTabElement.Equals(PTEGlobalValues.gloTagDescribeImage))
                        {
                            m_strDescribeImagePath = textReader.Value.ToString();
                        }
                        if (strTabElement.Equals(PTEGlobalValues.gloTagRetellLecture))
                        {
                            m_strRetellLecturePath = textReader.Value.ToString();
                        }
                        //strTabElement = textReader.Name.ToString();
                    }
                }
                // If node type us a declaration
                //if (nType == XmlNodeType.XmlDeclaration)
                //{
                //    Console.WriteLine("Declaration:" + textReader.Name.ToString());
                //    xd = xd + 1;
                //}
                //// if node type is a comment
                //if (nType == XmlNodeType.Comment)
                //{
                //    Console.WriteLine("Comment:" + textReader.Name.ToString());
                //    cc = cc + 1;
                //}
                //// if node type us an attribute
                //if (nType == XmlNodeType.Attribute)
                //{
                //    Console.WriteLine("Attribute:" + textReader.Name.ToString());
                //    ac = ac + 1;
                //}
                //    // if node type is an entity\
                //    if (nType == XmlNodeType.Entity)
                //    {
                //        Console.WriteLine("Entity:" + textReader.Name.ToString());
                //        et = et + 1;
                //    }
                //    // if node type is a Process Instruction
                //    if (nType == XmlNodeType.Entity)
                //    {
                //        Console.WriteLine("Entity:" + textReader.Name.ToString());
                //        pi = pi + 1;
                //    }
                //    // if node type a document
                //    if (nType == XmlNodeType.DocumentType)
                //    {
                //        Console.WriteLine("Document:" + textReader.Name.ToString());
                //        dc = dc + 1;
                //    }
                //    // if node type is white space
                //    if (nType == XmlNodeType.Whitespace)
                //    {
                //        Console.WriteLine("WhiteSpace:" + textReader.Name.ToString());
                //        ws = ws + 1;
                //    }
                // if node type is an element
            }
            textReader.Close();
        }

        private void SavePathConfiguration()
        {
            //For now, writing all tab configurations here. Later, these can be made into node classes that are generic for each tab
            string strFile = @".\\" + PTEGlobalValues.gloConfigFileName;
            try
            {
                if (File.Exists(strFile))
                {
                    //XmlWriter xmlClose = XmlWriter.(strFile);
                    //XmlWriter.Close(strFile);
                    File.Delete(strFile);
                }
                XmlWriter xmlWriter = XmlWriter.Create(strFile);

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement(PTEGlobalValues.gloModuleName);
                if (m_strDescribeImagePath != null)
                {
                    xmlWriter.WriteStartElement(PTEGlobalValues.gloTagDescribeImage);
                    xmlWriter.WriteStartElement("Path");
                    xmlWriter.WriteValue(m_strDescribeImagePath);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                }
                if (m_strRetellLecturePath != null)
                {
                    xmlWriter.WriteStartElement(PTEGlobalValues.gloTagRetellLecture);
                    xmlWriter.WriteStartElement("Path");
                    xmlWriter.WriteValue(m_strRetellLecturePath);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            } 
        }

        private void frmPTEMock_FormClosing(object sender, FormClosingEventArgs e)
        {
            //For Encrypting and DeCrypting File contents...
            SavePathConfiguration();
        }

        private void frmPTEMock_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            AboutPTE aboutWindow = new AboutPTE();
            aboutWindow.Show();
        }

    }
}
