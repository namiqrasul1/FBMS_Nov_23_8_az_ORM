using Lesson7Coding.Data;
using Lesson7Coding.Models;
//using System.Configuration;


using var context = new LibraryContext();
//void printAllAuthors()
//{
//    var authors = context.Authors.ToList();
//    foreach (var author in authors)
//    {
//        Console.WriteLine($"{author.FirstName} {author.LastName}");
//    }
//}

//void AddAuthor()
//{
//    var name = "Ferid";
//    var surname = "Aliyev";
//    var author = new Author { Id = 1000, FirstName = name, LastName = surname };
//    context.Authors.Add(author);
//    context.SaveChanges();
//}

//Console.WriteLine("1. All Authors");
//Console.WriteLine("2. Add new Author");
//var ch = int.Parse(Console.ReadLine()!);

//switch (ch)
//{
//    case 1:
//        printAllAuthors(); break;
//    case 2:
//        AddAuthor(); break;
//    default:
//        break;
//}


//var student = context.Students.FirstOrDefault(x => x.Id == 2);
//if(student is not null)
//{
//    student.LastName = "Kamiloglu";
//    context.Students.Update(student);
//    context.SaveChanges();
//}
