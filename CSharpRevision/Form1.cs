using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CSharpRevision
{
    public partial class Form1 : Form
    {

        //a list to maintain objects of the book class
        private List<Book> AllBooks = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            //read in some book data
            ReadBookFile();
            DisplayBooks();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            StartForm frmA = new StartForm();
            frmA.Show();
        }


        private void Play()
        {
            Person p1 = new Person(16, "Jim");
            Car car1 = new Car("TC991", "Ford");
            Car car2 = new Car("JA436", "Volvo");
            p1.MyCars.Add(car1);
            p1.MyCars.Add(car2);
            car1.Owner = p1;
            car2.Owner = p1;

            Trade t = new Trade();

            string str;
            Book book, newBook;


            //remove this line before it drives you crazy!
            MessageBox.Show("use this method to try out your own code");

            newBook = new Book();
            newBook = new Book("Brideshead Revisited", "Evelyn Waugh", 1945);

            //refer to the first book object in the List
            book = AllBooks[0];
            str = book.Title;
            book.Title = "I changed this";


            //Some code to play with the list
            AllBooks.RemoveAt(1);
            AllBooks.Insert(4, new Book());
            book = AllBooks[4];
            AllBooks.Remove(book);
            foreach (Book b in AllBooks)
            {
                //do something
            }
        }

        public void DisplayBooks()
        {
            //make sure listbox is empty
            lstBooks.Items.Clear();
            //Add the book titles to the listBox
            foreach (Book b in AllBooks)
            {
                lstBooks.Items.Add(b);
            }
            //Select the first item
            lstBooks.SelectedIndex = 0;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            Book book = (Book)lstBooks.SelectedItem;
            lblInfo.Text = book.Info();
            

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayBooks();
            lblInfo.Text = "";
        }



        private void ReadBookFile()
        {
            //read data from a file into Book objects
            Book book;
            string[] strArray;

            //open file
            var myfile = new StreamReader("../../book.txt");

            while (!myfile.EndOfStream)
            {
                //read line and split into substrings
                strArray = myfile.ReadLine().Split(',');
                //call book constructor using info from line of file
                book = new Book(strArray[0], strArray[1], Convert.ToInt32(strArray[2]));
                //add object to List
                AllBooks.Add(book);
            }
            myfile.Close();
        }
    }
}
