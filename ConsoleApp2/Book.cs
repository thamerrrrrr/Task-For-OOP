using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }

        public int Id { set; get; }
        public string Title { set; get; }
         public string AuthorName { set; get; }
        public bool IsAvailable { set; get; }

        public void DisplayInfo()
        {
            Console.WriteLine(ToString());

        }
        public override string ToString()
        {
            return $"Id is{Id} and title is {Title} and author is {AuthorName}";
        }

    }
}
