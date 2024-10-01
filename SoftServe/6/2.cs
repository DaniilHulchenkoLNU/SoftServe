using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace ffff;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public Book(string title, string author, int pageCount)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
    }
}




public class Library
{
    private IEnumerable<Book> _books;

    public IEnumerable<Book> Books { get; }

    public Predicate<Book> Filter { get; set; }

    public Library(IEnumerable<Book> books)
    {
        Books = books;
        Filter = book => true;
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new MyEnumerator(Books, Filter);
    }
}


public class MyEnumerator : IEnumerator<Book>
{
    private readonly IEnumerable<Book> _books; 
    private readonly Predicate<Book> _filter; 
    private IEnumerator<Book> _internalEnumerator; 

    
    public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
    {
        _books = books;
        _filter = filter;
        _internalEnumerator = _books.GetEnumerator();
    }


    public Book Current => _internalEnumerator.Current;

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        while (_internalEnumerator.MoveNext())
        {
            if (_filter(_internalEnumerator.Current))
            {
                return true;
            }
        }
        return false; 
    }


    public void Reset()
    {
        _internalEnumerator = _books.GetEnumerator();
    }

    public void Dispose()
    {
        _internalEnumerator.Dispose();
    }
}


public static class MyUtils
{
    public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book> filter)
    {
        var library = new Library(books);
        library.Filter = filter; 

        var filteredBooks = new List<Book>();
        var enumerator = library.GetEnumerator();

        while (enumerator.MoveNext())
        {
            filteredBooks.Add(enumerator.Current);
        }

        return filteredBooks; 
    }
}

