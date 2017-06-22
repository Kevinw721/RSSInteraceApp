using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string APURL = "https://api.ap.org/v2/elections/{electionDate}?apikey={APIKey}[{OtherParameters}]";
        private string APIKey = "NA";
        private string ElectionDate = "2016-11-08";

        private XmlForm ProtoTypeXmlForm = new XmlForm("Prototype");
        private Timer myTimer = new Timer();

        private int tickerTimeLimitMinutes = 5;
        private int pullInterval_seconds = 30;
        private int tickerTimeLimit_TimeLeft = 0;

        public string myFilePath = @"c:\Users\XPression\Desktop";
        public string myImageFolderPath = @"c:\Users\XPression\Desktop";

        public Form1()
        {
            InitializeComponent();
            //Reinstate all saved preferences
            myFilePath = Properties.Settings.Default.RawXMLFilePath;
            myImageFolderPath = Properties.Settings.Default.ImageFilePath;
            ApiLinkCommands.Text = Properties.Settings.Default.APILinkSettings;

            APURL = APURL.Replace("{APIKey}", APIKey);
            PullStatus.Text = "";
            localFilePathDisplay.Text = myFilePath;
            ImageFolderPathDisplay.Text = myImageFolderPath;

            tickerTimeLimit_TimeLeft = tickerTimeLimitMinutes * 60;

            if (File.Exists(myFilePath + ProtoTypeXmlForm.fileName))
            {
                ProtoTypeXmlForm.LoadXml(File.ReadAllText(myFilePath + ProtoTypeXmlForm.fileName));
            }
        }

        private string createFinalPullString()
        {
            Properties.Settings.Default.APILinkSettings = ApiLinkCommands.Text;
            Properties.Settings.Default.Save();

            string newApUrl = APURL.Replace("{electionDate}", ElectionDate);
            newApUrl = newApUrl.Replace("[{OtherParameters}]", ApiLinkCommands.Text);
            return newApUrl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            saveXmlToPrototype();
        }
        private void saveXmlToPrototype()
        {
            string myXML = pullXMLFromURL(createFinalPullString());
            if (myXML != null)
            {
                ProtoTypeXmlForm.LoadXml(myXML);
                ProtoTypeXmlForm.save(myFilePath);
            }
        }
        private string pullXMLFromURL(string myURL)
        {
            PullStatus.Text = "Pulling From Website";
            Update(); // Update form to show pull status

            try
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    string downloadedXml= client.DownloadString(myURL); //Pull xml from AP Website 

                    PullStatus.Text = "Pull Complete";
                    Update();

                    return downloadedXml;
                }

            }
            catch (System.Net.WebException e)
            {
                if(e.Status == System.Net.WebExceptionStatus.ProtocolError)
                {
                    PullStatus.Text = "Protocol Error " + e.Message;
                    Update();
                }else
                {
                    PullStatus.Text = "Pull Error";
                    Update();
                }
                
            }
        return null;
        }

        private void saveXMLDoc(XmlDocument xmlDoc, string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(filePath, settings);

            xmlDoc.Save(writer);
            writer.Close();
        }

        private void FormatXML_Click(object sender, EventArgs e)
        {
            reformatXML();
        }
        private void reformatXML()
        {
            PullStatus.Text = "Formatting";
            Update();
            if (!ProtoTypeXmlForm.MainNode.HasChildNodes) {
                MessageBox.Show("Prototype Xml not found, please pull.");
                PullStatus.Text = "Formatting Failed: Prototype Xml Missing";
                Update();
                return;
            }
            ElectionsXmlBuilder.BuildFromXml(ProtoTypeXmlForm, myImageFolderPath);

            PullStatus.Text = "Done Formatting";
            Update();
        }

        private void LocalXMLPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog mySaveFileDialog = new FolderBrowserDialog())
            {
                if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    myFilePath = mySaveFileDialog.SelectedPath;
                    Properties.Settings.Default.RawXMLFilePath = myFilePath;
                    Properties.Settings.Default.Save();
                    localFilePathDisplay.Text = myFilePath;
                }
            }
            
        }

        private void SetImageFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog mySaveFileDialog = new FolderBrowserDialog())
            {
                if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    myImageFolderPath = mySaveFileDialog.SelectedPath;
                    Properties.Settings.Default.ImageFilePath = myImageFolderPath;
                    Properties.Settings.Default.Save();
                    ImageFolderPathDisplay.Text = myImageFolderPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTimer.Interval = (1000); // tick every second
            myTimer.Tick += new EventHandler(myTimer_Tick);
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            int tillNextPull = tickerTimeLimit_TimeLeft % pullInterval_seconds;
            if (tickerTimeLimit_TimeLeft % pullInterval_seconds == 0)
            {
                myTimer.Stop();
                saveXmlToPrototype();
                reformatXML();
                myTimer.Start();
            }

            if (tickerTimeLimit_TimeLeft > 0)
            {
                tickerTimeLimit_TimeLeft -= 1;
                TimeSpan result = TimeSpan.FromSeconds(tickerTimeLimit_TimeLeft);


                timeLeftLabel.Text = result.ToString();
                progressBarTillPull.Value = 100 * tillNextPull / pullInterval_seconds ;

            }
            else
            {
                myTimer.Stop();
                timeLeftLabel.Text = "No Longer Pulling";
            }

        }

        private void timerRefreshButton_Click(object sender, EventArgs e)
        {
            tickerTimeLimit_TimeLeft = tickerTimeLimitMinutes * 60;
        }

        private void StartPullTimerButton_Click(object sender, EventArgs e)
        {
            if (myTimer.Enabled)
            {
                StartPullTimerButton.Text = "Restart Timer";
                myTimer.Stop();
            }
            else
            {
                StartPullTimerButton.Text = "Stop Timer";
                tickerTimeLimit_TimeLeft = tickerTimeLimitMinutes * 60;
                myTimer.Start();
            }
        }
    }
}
