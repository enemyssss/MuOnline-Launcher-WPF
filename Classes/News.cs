using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline_Launcher_WPF.Classes
{
    class News
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }

        public News(string title, string text, DateTime date)
        {
            Title = title;
            Text = text;
            Date = date;
        }
    }
}
