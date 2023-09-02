using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class Review
    {
        private User author;
        private string title;
        private string text;
        private Date date;
        private bool isPositive;
        public Date Date { get{return date;} set{date = value;} }
        public string Text { get{return text;} set{text = value;}}
        public string Title { get{return title;} set{title = value;}}
        public User Author { get{return author;} set{author = value;} }
        public bool IsPositive { get{return isPositive;} set{isPositive = value;}}

        public Review(bool isPositive, string title, string text, Date date, User author)
        {
            this.IsPositive = isPositive;
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Date = date;
        }
    }
}