using BookStoreApp.Models;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {
        
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string title, string author) {
            return DataSource().Where(x => x.title.Contains(title) || x.author.Contains(author)).ToList(); 
        }

        public List<BookModel> DataSource()
        {
                return new List<BookModel>(){ 

                    new BookModel(){Id=1, title="Home", author = "Jerry", description="Life and Death"},
                    new BookModel(){Id=2, title="Away", author = "Justice", description="Life and Death"},
                    new BookModel(){Id=3, title="Lost", author = "Yaw", description="Life and Death"},
                    new BookModel(){Id=4, title="Seen", author = "Nitro", description="Life and Death"},
                    new BookModel(){Id=5, title="Gone", author = "Boat", description="Life and Death"},
            };
        }
    }
}
