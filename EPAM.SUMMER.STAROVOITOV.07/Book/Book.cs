using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book: IEquatable<Book>, IComparable<Book>
    {
        public Book(string author, string title, int pages, int year)
        {
            Author = author;
            Title = title;
            Pages = pages;
            Year = year;
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }

        public bool Equals(Book other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return FullPropertyEquals(other);
        }

        public int CompareTo(Book other)
        {
            if (ReferenceEquals(other, null))
                throw new ArgumentNullException();
            if (Year > other.Year)
                return 1;
            if (Year < other.Year)
                return -1;
            return 0;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book)
            {
                return Equals((Book)obj);
            }
            else
            {
                return false;
            }
        }

        private bool FullPropertyEquals(Book other)
        {
            if (Author != other.Author)
                return false;
            if (Title != other.Title)
                return false;
            if (Pages != other.Pages || Year != other.Year)
                return false;
            return true;
        }
    }
}
