using NUnit.Framework;
using LibraryManagement;

namespace LibraryManagement.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
        }

        //  Add Book
        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var book = new Book("C# Basics", "John", "ISBN001");

            _library.AddBook(book);

            Assert.AreEqual(1, _library.Books.Count);
        }

        //Register Borrower
        [Test]
        public void RegisterBorrower_ShouldAddBorrower()
        {
            var borrower = new Borrower("Akhila", "CARD001");

            _library.RegisterBorrower(borrower);

            Assert.AreEqual(1, _library.Borrowers.Count);
        }

        //Borrow Book
        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var book = new Book("C# Basics", "John", "ISBN001");
            var borrower = new Borrower("Akhila", "CARD001");

            _library.AddBook(book);
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("ISBN001", "CARD001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        //Return Book
        [Test]
        public void ReturnBook_ShouldMakeBookAvailable()
        {
            var book = new Book("C# Basics", "John", "ISBN001");
            var borrower = new Borrower("Akhila", "CARD001");

            _library.AddBook(book);
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("ISBN001", "CARD001");
            _library.ReturnBook("ISBN001", "CARD001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        //  View Books and Borrowers
        [Test]
        public void ViewBooksAndBorrowers_ShouldReturnLists()
        {
            _library.AddBook(new Book("Book1", "Author1", "ISBN1"));
            _library.RegisterBorrower(new Borrower("User1", "CARD1"));

            Assert.AreEqual(1, _library.ViewBooks().Count);
            Assert.AreEqual(1, _library.ViewBorrowers().Count);
        }
    }
}
