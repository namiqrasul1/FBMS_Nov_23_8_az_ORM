using Lesson6Loadings.Data;
using Lesson6Loadings.Models;
using Microsoft.EntityFrameworkCore;

// IQueryable 
// IEnumerable

// LINQ
// Method contextObj.Books.ToList();
// Query  (from book in books select book).ToList()

using var context = new LibraryContext();

//var books = context.Books.ToList();
//var books = (from book in context.Books select book).ToList();
//var books = context.Books.FromSqlRaw("Select * From Books").ToList();

//foreach (var item in context.Books)
//{
//    Console.WriteLine(item.Name);
//}


//foreach (var book in books)
//{
//    Console.WriteLine(book.Name);
//}


//var count = context.Books.ToList().Count();
//var count = context.Books.Count(b => b.Quantity < 5);
//Console.WriteLine(count);

//var obj = context.Books;

//var students = context.Students.Select(s => new { Name = s.FirstName, Surname = s.LastName }).ToList();


//var book = context.Books.FirstOrDefault(b => b.Name == "SQL");
//if (book is not null)
//    Console.WriteLine(book.Name);


#region Eager Loading

// Include
// ThenInclude

//var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.Name == "SQL");

//if(book is not null)
//{
//    Console.WriteLine(book.Name);
//    Console.WriteLine(book.Author.FirstName);

//}

//var authors = context.Authors.Include(a => a.Books).ToList();


//var book = context.Books.Include(b => b.Author).Include(b => b.SCards).FirstOrDefault(b => b.Name == "SQL");

// author => book, scards

//var authors = context.Authors.Include(a => a.Books).ThenInclude(b => b.SCards).ToList();





#endregion

#region Auto Loading

//List<Book> books = context.Books.ToList();
//var authors = context.Authors.ToList();



#endregion

#region Explicit Loading


//var book = context.Books.FirstOrDefault(b => b.Id == 1);

//if(book is not null)
//{
//    context.Entry(book).Collection(b => b.SCards).Load();
//    context.Entry(book).Reference(b => b.Author).Load();
//}



#endregion

#region Lazy Loading

var book = context.Books.FirstOrDefault(b => b.Id == 1000);

Console.WriteLine(book?.Author.FirstName);




#endregion

Console.WriteLine();
Console.WriteLine();