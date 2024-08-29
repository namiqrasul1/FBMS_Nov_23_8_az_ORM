using Lesson4EntityFrameworkCoreIntro.Data;
using Lesson4EntityFrameworkCoreIntro.Models;
using Microsoft.EntityFrameworkCore;

using var context = new LibraryDbContext();

//var books =  context.Books.Where(b => b.Pages < 100).Select(b => new { b.Name, b.YearPress }).ToList();

//foreach (var book in books)
//{
//    Console.WriteLine(book.Name);
//}

//Console.WriteLine();
//Console.WriteLine();

// IQueryable
// IEnumerable 

//var author = new Author
//{
//    Id = 24,
//    FirstName = "Zeynal",
//    LastName = "asdasd"
//};

//context.Authors.Add(author);
//context.SaveChanges();

//var author = context.Authors.FirstOrDefault(a => a.Id == 24);

//if(author is not null)
//{
//    author.LastName = "Selimli";
//    context.Authors.Update(author);
//    context.SaveChanges();
//}

//var author = context.Authors.FirstOrDefault(a => a.Id == 24);
//if(author is not null)
//{
//    context.Authors.Remove(author);
//    context.SaveChanges();
//}


//var authors = context.Authors; // query hazirlanir => IQueryable

//foreach (var item in authors)
//{
//    Console.WriteLine(item.FirstName);
//}

//var authors1 = context.Authors.ToList(); 
// IEnumerable kechende
// Ramda map olduqda
// foreach

//context.Authors.FromSqlRaw("");


// yanashma
// CodeFirst
// DatabaseFirst


var author = context.Authors.AsNoTracking().FirstOrDefault(a => a.Id == 24);

author.LastName = "";

//context.Authors.Update(author);

var ee = context.Entry(author);
Console.WriteLine(ee.State);

context.SaveChanges();


//var author = new Author
//{
//    Id = 25,
//    FirstName = "Namiq",
//    LastName = "Rasul"
//};

//Console.WriteLine(context.Entry(author).State);

//context.Authors.Add(author);

//Console.WriteLine(context.Entry(author).State);

