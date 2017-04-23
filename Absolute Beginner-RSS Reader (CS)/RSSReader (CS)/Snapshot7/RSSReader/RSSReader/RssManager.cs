using System;
using System.Collections.Generic;
using System.Text;

namespace RSSReader
{


    class NewsItem
    {
        private string _title;
        private string _link;
        private string _description;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }



    class RssManager
    {

        // I've renamed this method  from RefreshRss to ProcessNewsFeed.  
        // I felt that was a better description of what it is doing.

        // Also, my goal was to keep this class generic, but I saw a 
        // big flaw in my plans to use it.  I would have to pass in
        // way too much information (like a reference to my instance
        // of the dataset!) for this to remain generic.  So I decided
        // instead of making the ProcessNewsFeed method do several
        // things (i.e., parsing the XML, saving it into the database,
        // etc.) I decided to scale this back and leave any application
        // specific persistence duties to the application that consumes
        // class.

        // So, I introduced a NewsItem class.  Each iteration through
        // the RSS XML will create a new instance of NewsItem that will
        // be added to the returnArrayList, which will ultimately returned 
        // to the method that consumes/calls ProcessNewsFeed.

        // So, I accomplish what I want (keeping the RssManager generic)
        // without losing desired functionality.  I've just had to switch
        // around where I originally delegated the persistence chores.

        public static System.Collections.ArrayList ProcessNewsFeed(string rssURL)
        {
            // Begin the WebRequest to the desired RSS Feed
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(rssURL);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            // Convert the RSS Feed into an XML document
            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);

            // This uses an XPath expression to get all nodes that fall 
            // under this path.
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            /* 
             * I'll use the new NewsItem class instead.  No need for these anymore:
             * 
            string title = "";
            string link = "";
            string description = "";
             */ 

            // Loop through the Item nodes from the RSS Feed and retrieve 
            // the Title, Link and Description.  Then we'll add it to the
            // database (if not already present.)

            System.Collections.ArrayList returnArrayList = new System.Collections.ArrayList();

            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssDetail;

                NewsItem tempNewsItem = new NewsItem();

                rssDetail = rssItems.Item(i).SelectSingleNode("title");
                if (rssDetail != null)
                {
                    tempNewsItem.Title = rssDetail.InnerText;  
                }
                else
                {
                    tempNewsItem.Title = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("link");
                if (rssDetail != null)
                {
                    tempNewsItem.Link = rssDetail.InnerText;
                }
                else
                {
                    tempNewsItem.Link = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("description");
                if (rssDetail != null)
                {
                    tempNewsItem.Description = rssDetail.InnerText;
                }
                else
                {
                    tempNewsItem.Description = "";
                }

                returnArrayList.Add(tempNewsItem);

            }

            return returnArrayList;

        }

    }
}
