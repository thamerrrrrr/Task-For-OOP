using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Member:Person
    {
        public List<Book> BorrowedBooks { set; get; }
     
        public Member(int id,string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"the id is{Id} and name is {Name}");
            
        }
        public bool BorrowBook(Book book)
        {
    
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                return true;
            }
            return false;
        }
        public bool ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                return true;
                
            }
            return false;
        }
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"{String.Join("\n", BorrowedBooks)}");
        }
        public override string ToString()
        {
            return $"the id is{Id} and name is {Name}";
        }


    }
}
