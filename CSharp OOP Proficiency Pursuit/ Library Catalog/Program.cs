using System;
namespace LibraryCatable;
class Library
{
    string Name;
    string Address;
    List<string> Books = new List<string>();
    List<string> Media = new List<string>();
    void AddBook(Book book)
    {

    }
    void RemoveBook(Book book)
    {


    }

    void AddMediaItem(MediaItem mediaItem)
    {
    }

    void RemoveMediaItem(MediaItem mediaItem)
    {

    }
    void PrintCatalog(){

    }
}
class Book {

    string Title;
    string Author;
    string ISBN;
    int PublicationYear;

}
 class MediaItem{

    string Title;
    string MediaType;
    int Duration ;

 }
 class Program {
    void Main(string[] args ){
        printCatalog();

    }
 }