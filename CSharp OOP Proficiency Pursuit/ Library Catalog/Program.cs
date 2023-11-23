using System;
using LibraryCatable;
namespace LibraryCatable;
class Library
{
    string Name;
    string Address;
    List<Book> Books = new List<Book>();
    List<MediaItem> Media = new List<MediaItem>();
    void AddBook(Book book)
    {
        Books.Add(book);

    }
    void RemoveBook(Book book)
    {
        Books.Remove(book);


    }

    void AddMediaItem(MediaItem mediaItem)
    {
        Media.Add(book);
    }

    void RemoveMediaItem(MediaItem mediaItem)
    {
        Media.Remove(mediaItem);
    }
    public static void PrintCatalog()
    {
        Console.WriteLine("----CATALOG ----");
        Console.WriteLine("Book Catalog");
        for (int i=0 ;i<=Books.Length ;i++){
            Console.WriteLine(Books[i].Name);
        }
         Console.WriteLine("Media Catalog");
          for (int i=0 ;i<=Media.Length ;i++){
            Console.WriteLine(Media[i].Name);
        }



    }
}
class Book
{

    string Title;
    string Author;
    string ISBN;
    int PublicationYear;

    Book(string title, string author, string isbn, int puplicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }

}
class MediaItem
{

    string Title;
    string MediaType;
    int Duration;
    MediaItem(string title, string mediaType, int duration;){
    Title=title;
    MediaType=mediaType;
    Duration=duration;


}
}
class Program
{
    void Main(string[] args)
    {  Library 
        printCatalog();

    }
}