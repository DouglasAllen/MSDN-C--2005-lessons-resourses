using System;
using System.Collections.Generic;
using System.Text;

namespace RSSReader
{
    class RssManager
    {
        public static void RefreshRSS(string rssURL)
        {
            // Begin the WebRequest to the desired RSS Feed
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(rssURL);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            // Convert the RSS Feed into an XML document
            System.IO.Stream rssStream = myResponse.GetResponseStream();
            //TextReader rssTextReader = new StreamReader(rssStream);
            //XmlTextReader rssReader = new XmlTextReader(rssTextReader);
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);


            // This uses an XPath expression to get all nodes that fall 
            // under this path.
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            string title = "";
            string link = "";
            string description = "";

            // Loop through the Item nodes from the RSS Feed and retrieve 
            // the Title, Link and Description.  Then we'll add it to the
            // database (if not already present.)

            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssDetail;

                rssDetail = rssItems.Item(i).SelectSingleNode("title");
                if (rssDetail != null)
                {
                    title = rssDetail.InnerText;
                }
                else
                {
                    title = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("link");
                if (rssDetail != null)
                {
                    link = rssDetail.InnerText;
                }
                else
                {
                    link = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("description");
                if (rssDetail != null)
                {
                    description = rssDetail.InnerText;
                }
                else
                {
                    description = "";
                }

                // TODO: Check to make sure this news Item isn't already in the database

                // TODO: Add this newsItem to the database

                // TODO: Remove this test

                System.Windows.Forms.MessageBox.Show(title + link + description); 


            }


        }

    }
}
