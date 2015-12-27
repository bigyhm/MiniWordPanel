using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DocumentFormat.OpenXml;

namespace MiniWordPanel
{
    public partial class MiniwordPanelForm : Form
    {
        #region Parameters

        public string GREPath = ".\\Dictionary\\GRE.xml";
        public string TOEFLPath = ".\\Dictionary\\TOEFL.xml";
        public string NodeValuesReturn;
        public string[] WordString;
        public int ICount = 0;
        private WordUniverse ChinaIns;
        public Random r = new Random();

        #endregion

        public MiniwordPanelForm()
        {
            InitializeComponent();
        }

        #region Delete the balnk of a string.

        /// <summary>
        /// Delete the balnk of a string.
        /// </summary>
        public string DeleteBlankOfString(string StringNeedModify)
        {
            string StringModified = StringNeedModify;
            StringModified = StringNeedModify.Replace("\\s", "");
            StringModified = StringNeedModify.Replace("\\n", "");
            StringModified = StringNeedModify.Replace("\\r", "");
            StringModified = StringNeedModify.Replace("\\t", "");
            StringModified = StringNeedModify.Replace("  ", "");

            return StringModified;
        }

        #endregion

        #region XmlNodeReader
        //Read the node of a xml file
        public string XmlNodeReader(string XmlFilePath)
        {
            #region Parameters
            // Temp variable for collecting value
            string TmpValue = string.Empty;
            string RetValue = string.Empty;
            #endregion
            // Read the XML
            XmlDocument Xmldocument = new XmlDocument();
            try
            {
                Xmldocument.Load(XmlFilePath);

                //XmlTextReader xmlReader = new XmlTextReader(XmlFilePath);            
                XmlNodeList XmlNodeListValus = Xmldocument.SelectSingleNode("wordbook").ChildNodes;

                foreach (XmlNode node in XmlNodeListValus)
                {
                    TmpValue = string.Empty;

                    foreach (XmlNode nodeInside in node)
                    {
                        XmlElement xe = (XmlElement)nodeInside;
                        if (!String.IsNullOrEmpty(TmpValue))
                        {
                            TmpValue = TmpValue + "@" + xe.InnerText;
                        }
                        else
                        {
                            TmpValue = xe.InnerText;
                        }
                    }
                    if (!String.IsNullOrEmpty(RetValue))
                    {
                        RetValue = RetValue + "|" + TmpValue;
                    }
                    else
                    {
                        RetValue = TmpValue;
                    }
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Exception occourred." + e.Message);
            }
            return DeleteBlankOfString(RetValue);
        }

        //Read the word, translate and phonetic.
        public string ReadXMLFileAndExtractValue(string XmlFilePath)
        {
            // Temp variable for collecting value
            string NodeValues = string.Empty;
            NodeValues = XmlNodeReader(XmlFilePath);
            return NodeValues;
        }

        #endregion

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!(ChooseCheckedListBox.GetSelected(0)) && !(ChooseCheckedListBox.GetSelected(1)) && !(ChooseCheckedListBox.GetSelected(2)) && !(ChooseCheckedListBox.GetSelected(3)))
            {
                MessageBox.Show("Nothing selected.没有选中词典。");
            }
            else
            {
                //Read xml values from the files
                if (ChooseCheckedListBox.SelectedItem.ToString() == "GRE")
                {
                    NodeValuesReturn = ReadXMLFileAndExtractValue(GREPath);
                }
                if (ChooseCheckedListBox.SelectedItem.ToString() == "TOEFL")
                {
                    NodeValuesReturn = ReadXMLFileAndExtractValue(TOEFLPath);
                }
                WordString = NodeValuesReturn.Split('|');
                ChinaIns = new WordUniverse();
                ChinaIns.Visible = true;
                this.Visible = false;
                this.WordPanelTimer.Enabled = true;
                ChinaIns.FormClosing += this.onexit;
            }
        }

        #region Delegate

        private void WordPanelTimer_Tick(object sender, EventArgs e)
        {
            ICount = r.Next(0, WordString.Count() - 1);
            string[] wordString = WordString[ICount].Split('@');
            string WordPh = wordString[0] + "  " + wordString[2];
            string Translate = wordString[1];
            object[] ps = new object[] { WordPh, Translate };
            ChinaIns.BeginInvoke(new Action<string, string>(ChinaIns.ChangeWord), ps);
        }

        public void onexit(object sender, FormClosingEventArgs e)
        {
            this.Visible = true;
            this.WordPanelTimer.Enabled = false;
            this.WordPanelTimer.Dispose();
        }

        #endregion

        #region MenuBox information.

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact David Yin.联系殷大卫 bigyhm@gmail.com");
        }

        private void explanationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是一个背单词的小工具，点击开始后，待文件加载完毕，悬浮窗口会每隔10秒显示下一个单词。");
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is nothing can be copied.无数据可被拷贝。");
        }

        #endregion
    }
}
