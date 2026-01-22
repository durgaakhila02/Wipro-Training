using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> Books { get; } = new();
        public List<Borrower> Borrowers { get; } = new();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.First(b => b.ISBN == isbn && !b.IsBorrowed);
            var borrower = Borrowers.First(b => b.LibraryCardNumber == libraryCardNumber);

            book.Borrow();
            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var borrower = Borrowers.First(b => b.LibraryCardNumber == libraryCardNumber);
            var book = borrower.BorrowedBooks.First(b => b.ISBN == isbn);

            book.Return();
            borrower.ReturnBook(book);
        }

        public List<Book> ViewBooks() => Books;
        public List<Borrower> ViewBorrowers() => Borrowers;
    }
}
