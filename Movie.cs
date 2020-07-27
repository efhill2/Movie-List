using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Movie_List
{
    class Movie
    {
        private string Title;
        private string Category;

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }

        public string catergory
        {
            get { return Category; }
            set { Category = value; }
        }

        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }

    }
}
