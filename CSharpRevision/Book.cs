using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    class Book
    {
        //static variable has just one value for the class
        static int nextBookID = 1;
        private int bookID;
        private string title;
        private string author;
        private int publicationYear;


        public Book()
        {
            //default constructor
            //each time a book is created its id is set and the nextbookID for the class is increased
            bookID = nextBookID;
            nextBookID++;
        }
        public Book(string newTitle, string newAuthor, int pubYear) : this()
        {
            //constructor with parameters. :this ensures the default constructor is alwatys called first.
            title = newTitle;
            author = newAuthor;
            publicationYear = pubYear;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        //public property Author uses lambda notation
        public string Author { get => author; set => author = value; }

        public int BookID
        {//bookID is read only.  It cannot be set to a new value
            get { return bookID; }
        }

        public int PublicationYear
        {   //a restricition on what publication year can be set to (20th Century)
            //beware!
            get { return publicationYear; }
            set
            {
                if (value >= 1900 && value < 2000) { publicationYear = value; }
            }
        }


        public override string ToString()
        {
            return title;
        }

        public string Info()
        {
            return title + "; " + author + "; " + publicationYear;
        }
    }
}
