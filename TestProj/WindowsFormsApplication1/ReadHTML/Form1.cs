using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace ReadHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("HTMLPage_DEMO.htm");
            xmldoc.GetElementById("Test").Value = "New";
            //xmldoc.XPathSelectElements("./module[id=\"176\"]");

            FileStream fs = File.OpenRead("HTMLPage_DEMO.htm");
            StreamReader sr = new StreamReader(fs);
            string content=sr.ReadToEnd();

        }
        private string GetFileCOntent(string filePath)
        {
            string content = string.Empty;
            try
            {
                StreamReader sr = new StreamReader(filePath);
                content = sr.ReadToEnd();
            }
            catch { }
            return content;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = GetFileCOntent("HTMLPage_DEMO.htm");
            
            //this.webBrowser1.Document.GetElementById("Test").GetAttribute("value");
        }
    }
}
