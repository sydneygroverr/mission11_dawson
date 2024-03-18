namespace mission11_dawson.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books {get; }

    }
}
