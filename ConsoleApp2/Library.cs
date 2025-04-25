using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Library
    {
        public List<Book> books { set; get; }
        public List<Person> members { get; set; }
        public Library()
        {
            books = new List<Book>();
            members = new List<Person>();


        }
        public bool AddBook(Book book)
        {
            if (books.Contains(book))
            {
                return false;
            }
            books.Add(book);
            return true;
        }
        public bool AddMember(Person member)
        {
            if (members.Contains(member)){
                return false;
            }
            members.Add(member);
            return true;
        }
        public Book FindBookById(int id)
        {
            Book BookIsNotFound = null;
            foreach(Book b in books)
            {
               
                if (b.Id == id)
                {
                   
                    return b;
                }
                
            }
           
           
            return BookIsNotFound;
        }
        public Member FindMemberById(int id)
        {
            Member MemberIsNotFound = null;
            foreach(Member m in members)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            return MemberIsNotFound;
          

           
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine($"{string.Join("\n",books)}");
        }
        public void DisplayAllMembers()
        {
            Console.WriteLine($"{string.Join("\n", members)}");
        }
    }
}
