using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApplication1
{
    public static class XmlNodeExtensions
    {
        public static XmlAttribute AddAttribute(this XmlNode node, string attName, string attValue)
        {
            XmlAttribute att = node.OwnerDocument.CreateAttribute(attName);
            att.Value = attValue;
            return node.Attributes.Append(att);
        }
        public static void RemoveNodeAttributes_allButListed(this XmlNode node, string[] attributes) // TODO finish this function
        {
            foreach (XmlAttribute attribute in node.Attributes)
            {
                if (attribute.Name == null)
                {
                    attribute.ParentNode.RemoveChild(attribute);
                }
            }

        }
        //Returns Parent Node
        public static XmlNode DesolveNodeToParent(this XmlNode node)
        {
            XmlNode ParentNode = node.ParentNode;
            XmlAttribute[] attArray = new XmlAttribute[node.Attributes.Count];
            node.Attributes.CopyTo(attArray, 0);

            while (node.ChildNodes.Count > 0)
            {
                ParentNode.AppendChild(node.ChildNodes[0]);
            }
            foreach (XmlAttribute attribute in attArray) // Copy all attributes to parent
            {
                ParentNode.Attributes.Append(attribute);
            }
            ParentNode.RemoveChild(node);
            return ParentNode;
        }

    }
}
