using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApplication1
{
    public static class ElectionsXmlBuilder
    {
        public static void BuildFromXml(XmlForm ProtoTypeXmlForm, string imageFolderPath)
        {
            XmlForm presidentForm = new XmlForm("Presidential", ProtoTypeXmlForm.defaultFilePath);
            XmlForm congressionalForm = new XmlForm("Congressional", ProtoTypeXmlForm.defaultFilePath);
            XmlForm senateForm = new XmlForm("Senate", ProtoTypeXmlForm.defaultFilePath);

            XmlNodeList raceNodes = ProtoTypeXmlForm.document.SelectNodes("//Race");

            XmlNodeList ReportingUnitNodes = ProtoTypeXmlForm.document.SelectNodes("//ReportingUnit");
            foreach (XmlNode node in ReportingUnitNodes)
            {
                node.DesolveNodeToParent();
            }

            foreach (XmlNode raceNode in raceNodes)
            {
                XmlNodeList candidateNodes = raceNode.SelectNodes("./Candidate");
                double totalRaceVotes = GetTotalVotesFromCandidates(candidateNodes);
                raceNode.AddAttribute("TotalVotes", totalRaceVotes.ToString("N0"));
                AddVotePercentToCandidates(candidateNodes, totalRaceVotes);

                string officeName = raceNode.Attributes["OfficeName"].Value;

                switch (officeName)
                {
                    case "President":

                        XmlNode presidentRaceNode = presidentForm.ImportNode(raceNode);
                        XmlNodeList presidentCandidateNodes = presidentRaceNode.SelectNodes("./Candidate");
                        AddImageLinksToCandidates(presidentCandidateNodes, imageFolderPath);
                        break;
                    case "U.S. House":

                        string currentStatePostal = raceNode.Attributes["StatePostal"].Value;
                        XmlNode stateNode = congressionalForm.MainNode.SelectSingleNode("./State[@StateCode='" + currentStatePostal + "']");

                        if (stateNode == null)
                        {
                            stateNode = congressionalForm.CreateNode("State");
                            stateNode.AddAttribute("StateCode", currentStatePostal);
                            stateNode.AddAttribute("Name", raceNode.Attributes["Name"].Value);
                        }
                        XmlNode congressRaceNode = congressionalForm.ImportNode(raceNode, stateNode);
                        break;
                    case "U.S. Senate":
                        XmlNode senateRaceNode = senateForm.ImportNode(raceNode);
                        break;
                    default:
                        break;
                }
            }

            presidentForm.save();
            senateForm.save();
            congressionalForm.save();
        }
        private static double GetTotalVotesFromCandidates(XmlNodeList candidates)
        {
            double totalRaceVoteCount = 0;

            foreach (XmlNode candidate in candidates)
            {
                string lastName = candidate.Attributes["Last"] != null ? candidate.Attributes["Last"].Value : null;
                if (lastName != null)
                {
                    totalRaceVoteCount += Int32.Parse(candidate.Attributes["VoteCount"].Value);
                }

            }
            return totalRaceVoteCount;
        }
        private static void AddVotePercentToCandidates(XmlNodeList candidates, double totalVotes)
        {
            foreach (XmlNode candidate in candidates)
            {
                double VotePercent = Math.Round(100 * Double.Parse(candidate.Attributes["VoteCount"].Value) / totalVotes, 1);
                candidate.AddAttribute("VotePercent", VotePercent.ToString());
            }
        }
        private static void AddImageLinksToCandidates(XmlNodeList candidates, string imageFolderPath)
        {
            foreach (XmlNode candidate in candidates)
            {
                string lastName = candidate.Attributes["Last"] != null ? candidate.Attributes["Last"].Value : null;
                string firstName = candidate.Attributes["First"] != null ? candidate.Attributes["First"].Value : null;

                candidate.AddAttribute("Image", imageFolderPath + "\\" + lastName + firstName + ".png");
            }
        }

    }

}
