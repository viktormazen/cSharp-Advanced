using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class Medium
    {
        public delegate void NewsDelegate(object obj, NewsEventsArgs e);
        public event NewsDelegate EventBreakingNews;

        public void SendBreakingNews(string title, string content, DateTime date)
        {
            NewsEventsArgs BreakingNews = new NewsEventsArgs(title, content, date);
            if(EventBreakingNews == null)
            {
                Console.WriteLine("No subs");
                return;
            }
            EventBreakingNews(this, BreakingNews);
        }
    }
    public class NewsEventsArgs : EventArgs
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public NewsEventsArgs(string title, string content, DateTime date)
        {
            this.Title = title;
            this.Content = content;
            this.Date = date;
        }
    }
}
