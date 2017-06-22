using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class XmlForm
    {
        public string name;
        public string fileName;
        public string defaultFilePath = null;
        public XmlDocument document;
        public XmlNode MainNode;
        public XmlForm(string NameToSet, string filePath)
        {
            name = NameToSet;
            fileName = "\\" + name + " Race.xml";
            document = new XmlDocument();
            defaultFilePath = filePath;
            MainNode = document.CreateNode(XmlNodeType.Element, name + "Results", "");
            document.AppendChild(MainNode);
        }
        public XmlForm(string NameToSet)
        {
            name = NameToSet;
            fileName = "\\" + name + " Race.xml";
            document = new XmlDocument();
            MainNode = document.CreateNode(XmlNodeType.Element, name + "Results", "");
            document.AppendChild(MainNode);
        }
        public void save(string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(path + fileName, settings);

            document.Save(writer);
            writer.Close();
        }
        public void save()
        {
            save(defaultFilePath);
        }

        public XmlNode ImportNode(XmlNode node)
        {
            XmlNode newNode = document.ImportNode(node, true);
            MainNode.AppendChild(newNode);
            return newNode;
        }
        public XmlNode ImportNode(XmlNode node, XmlNode targetParentNode)
        {
            XmlNode newNode = document.ImportNode(node, true);
            targetParentNode.AppendChild(newNode);
            return newNode;

        }
        public XmlNode CreateNode(string nodeName)
        {
            XmlNode node = document.CreateNode(XmlNodeType.Element, nodeName, "");
            return ImportNode(node);
        }
        public XmlNode CreateNode(string nodeName, XmlNode targetParentNode)
        {
            XmlNode node = document.CreateNode(XmlNodeType.Element, nodeName, "");
            return ImportNode(node, targetParentNode);
        }
        public void LoadXml(string Xml)
        {
            document.LoadXml(Xml);
            if (document.FirstChild.HasChildNodes) {
                MainNode = document.FirstChild;
            }else if(document.FirstChild.NextSibling != null)
            {
                MainNode = document.FirstChild.NextSibling;
            }
        }

    }
}
