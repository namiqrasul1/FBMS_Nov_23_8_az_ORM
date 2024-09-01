using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson5CodeFirst.Models;

#region Default Convension

//public class Author
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<Book> Books { get; set; }
//}

//public class Book
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<Author> Authors { get; set; }
//}

#endregion

#region Data Annotation

//public class Author
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<AuthorBook> Books { get; set; }
//}

//public class AuthorBook
//{
//    [ForeignKey(nameof(Models.Book))]
//    public int BookId { get; set; }

//    [ForeignKey(nameof(Models.Author))]
//    public int AuthorId { get; set; }

//    public Author Author { get; set; }
//    public Book Book { get; set; }
//}

//public class Book
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<AuthorBook> Authors { get; set; }
//}

#endregion


#region Fluent Api

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<AuthorBook> Books { get; set; }
}

public class AuthorBook
{
    public int BookId { get; set; }

    public int AuthorId { get; set; }

    public Author Author { get; set; }
    public Book Book { get; set; }
}

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<AuthorBook> Authors { get; set; }
}

#endregion