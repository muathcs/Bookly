namespace bookly.Models.Repo
{
    public class BookRepo
    {

        private static List<Book> books = new List<Book>()
        {
            new Book { BookId=1, Title="HEllo Kat", Description="Book about cats", Author="Jimmy Jom", pageNumber=285, price=20},
            new Book { BookId=2, Title="Code", Description="Book about Code", Author="Cody Code", pageNumber=385, price=10}
        };

        public static Book? getBookById(int id)
        {
            return books.Find(book => book.BookId == id);

        }
        
        public static List<Book> getAllBooks()
        {
            return books;
        }


    }
}
