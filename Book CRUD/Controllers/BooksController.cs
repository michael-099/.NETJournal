using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;
namespace book;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{


    private List<Books> books = new List<Books>
{
    new Books { Id = "003", Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic Fiction" },
    new Books { Id = "004", Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic Fiction" },
    new Books { Id = "005", Title = "1984", Author = "George Orwell", Genre = "Dystopian Fiction" },
    new Books { Id = "006", Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy" },
    new Books { Id = "007", Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Coming-of-Age Fiction" },
    new Books { Id = "008", Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Classic Romance" },
    new Books { Id = "009", Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Genre = "Fantasy" },
    new Books { Id = "010", Title = "The Harry Potter series", Author = "J.K. Rowling", Genre = "Fantasy" },
    new Books { Id = "011", Title = "The Chronicles of Narnia", Author = "C.S. Lewis", Genre = "Fantasy" },
    
};


    [HttpGet("{id}")]

    public ActionResult GetBook(string id)
    {
        var theBook = (Books?)null;
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Id == id)
            {
                theBook = books[i];
                return Ok(theBook);
            }
        }

        if (theBook == null)
        {
            return (NotFound());

        }
        else
        {
            return Ok(theBook);
        }

    }
    [HttpPost]
    public IActionResult postbook(string Id, string Title, string Author, string Genre)
    {
        books.Add(new Books { Id = Id, Title = Title, Author = Author, Genre = Genre });
        return Ok(books);
    }
    [HttpDelete("{id}")]
    public IActionResult deletebook(string id)
    {
        Books toBeDeleted = (Books?)null;
        for (int i = 0; i < books.Count(); i++)
        {

            if (books[i].Id == id)
            {
                toBeDeleted = books[i];
                books.Remove(toBeDeleted);
                return Ok(books);
            }



        }
        return NotFound();


    }


    [HttpPatch("{id}")]
    public IActionResult patchbook(string id, [FromBody]string title)
    {

        for (int i = 0; i < books.Count; i++)
        {
            if (id == books[i].Id)
            {
                books[i].Title = title;
                return Ok(books);
            }
        }
        return NotFound();

    }
    [HttpPut("{id}")]
    public IActionResult Putbook(string id, [FromBody] Books b)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Id == id)
            {
                books[i] = b;
                return Ok(books);
            }


        }
        return NotFound();
    }
}




