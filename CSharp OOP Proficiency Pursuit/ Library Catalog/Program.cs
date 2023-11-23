using System;
using LibraryCatable;
namespace LibraryCatable;
public class Library
{
    string Name { get; set; }
    string Address;
    public List<Book> Books = new List<Book>();
    public List<MediaItem> Media = new List<MediaItem>();
    public void AddBook(Book book)
    {
        Books.Add(book);

    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);


    }

    public void AddMediaItem(MediaItem mediaItem)
    {
        Media.Add(mediaItem);
    }

    public void RemoveMediaItem(MediaItem mediaItem)
    {
        Media.Remove(mediaItem);
    }
    public void PrintCatalog()
    {
        Console.WriteLine("----CATALOG ----");
        Console.WriteLine(".....................");
        Console.WriteLine("Book Catalog");
        Console.WriteLine(".....................");
        if (Books.Count > 0)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine(Books[i].Title);
            }
        }
        else
        {
            Console.WriteLine("empty Book Catalog");
        }
        if (Media.Count > 0)
        {
            Console.WriteLine(".....................");

            Console.WriteLine("Media Catalog");
            Console.WriteLine(".....................");

            for (int i = 0; i < Media.Count; i++)
            {
                Console.WriteLine(Media[i].Title);
            }
        }
        else
        {
            Console.WriteLine("empty Media Catalog");
        }



    }
}
public class Book
{

    public string Title;
    public string Author;
    public string ISBN;
    public int PublicationYear;

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }

}
public class MediaItem
{

    public string Title;
    public string MediaType;
    public int Duration;
    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;


    }
}
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", 1960);
        Book book2 = new Book("1984", "George Orwell", "9780451524935", 1949);
        Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 1925);
        Book book4 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "9780590353427", 1997);
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        MediaItem media1 = new MediaItem("Inception", "Movie", 148);
        MediaItem media2 = new MediaItem("The Dark Knight", "Movie", 152);
        MediaItem media3 = new MediaItem("Breaking Bad", "TV Show", 62);
        MediaItem media4 = new MediaItem("The Shawshank Redemption", "Movie", 142);
        library.AddMediaItem(media1);
        library.AddMediaItem(media2);
        library.AddMediaItem(media3);
        library.AddMediaItem(media4);


        library.PrintCatalog();
    }
}