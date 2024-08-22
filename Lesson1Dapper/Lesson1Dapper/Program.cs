using Dapper;
using Lesson1Dapper.Models;
using Lesson1Dapper.Models.DTOs;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Channels;

var builder = new ConfigurationBuilder();
builder.AddJsonFile(@"C:\Users\namiqrasullu\Desktop\FBMS_Nov_23_8_az_ORM\Lesson1Dapper\Lesson1Dapper\appsettings.json");
var config = builder.Build();


//var conStr = @"Data Source=STHQ0118-01;Initial Catalog=Library;Integrated Security=true;";

//var conStr = @"Data Source=STHQ0118-01;Initial Catalog=Library;User ID=admin;Password=admin";
var conStr = config.GetConnectionString("Default");


// Data Source=STHQ0118-01;Initial Catalog=FoodyByteDb;User ID=admin;Password=********;
using var sqlConnection = new SqlConnection(conStr); // using sonda dispose edir

#region Quering

//var query = @"SELECT * FROM Books";
////var result = sqlConnection.Query(query);
//var result = sqlConnection.Query<Book>(query).ToList();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}

#endregion

#region Querying Scalar Values

////var query = "SELECT COUNT(*) FROM Books WHERE [Name] LIKE 'S%'";
//var query = "SELECT SUM(Pages) FROM Books WHERE [Name] LIKE 'S%'";
////var result = sqlConnection.ExecuteScalar(query); // returns object
//var result = sqlConnection.ExecuteScalar<int>(query); // returns <T>

//Console.WriteLine(result);


#endregion

#region Querying Single Row

// QuerySingle => tekdirse hemin elementi, choxdursa exception, yoxdursa exception
// QuerySingle<T> => tekdirse hemin elementi, choxdursa exception, yoxdursa exception
// QuerySingleOrDefault => tekdirse hemin elementi, choxdursa exception, yoxdursa default value
// QuerySingleOrDefault<T> => tekdirse hemin elementi, choxdursa exception, yoxdursa default value

//var query = "SELECT * FROM Books WHERE Id = 800";
//var result = sqlConnection.QuerySingle(query);
//var result = sqlConnection.QuerySingle<Book>(query);
//var result = sqlConnection.QuerySingleOrDefault<Book>(query);


// QueryFirst => varsa birincini qaytarir, yoxdusa exception
// QueryFirst<T> => varsa birincini qaytarir, yoxdusa exception
// QueryFirstOrDefault => varsa birincini qaytarir, yoxdusa dafault value
// QueryFirstOrDefault<T> => varsa birincini qaytarir, yoxdusa default value

//var query = "select * from books where [Name] like 'Sasdasd%'";

//var result = sqlConnection.QueryFirst(query);
//var result = sqlConnection.QueryFirst<Book>(query);
//var result = sqlConnection.QueryFirstOrDefault<Book>(query);


//var input = Console.ReadLine();
//var query = $"Select * From Books Where Id = {input}"; // olmaz
//var query = $"Select * From Books Where Id = @id"; // bele olar

//var book = sqlConnection.QueryFirstOrDefault<Book>(query, param: new { id = 5});

//Console.WriteLine(book?.Name);

#endregion

#region Querying Multiple Rows

//var query = $"Select * From Books";

////var books = sqlConnection.Query(query).ToList();
//var books = sqlConnection.Query<Book>(query).ToList();

//foreach (var item in books)
//{
//    Console.WriteLine(item.Name);
//}


//var query = $"Select * From Books Where Pages < @p";

//var books = sqlConnection.Query<Book>(query, param: new { p = 100 });

//foreach (var item in books)
//{
//    Console.WriteLine(item.Name);
//}

#endregion

#region Spesific Columns

//var query = "Select [Name], Id, YearPress From Books";
//var book = sqlConnection.QueryFirst<Book>(query);

//var query = "Select [Name], Pages, Comment, Quantity From Books";

//var books = sqlConnection.Query<BookDto>(query).ToList();



#endregion

#region OneToMany Querying

//var query = "SELECT * FROM Books B JOIN Authors A ON B.Id_Author = A.Id";

//var books = sqlConnection.Query<Book, Author, Book>(query,
//    map: (book, author) =>
//    {
//        book.Author = author;
//        return book;
//    }, splitOn: "Id");


//foreach (var book in books)
//    Console.WriteLine($"{book.Name} - {book.Author.FirstName}");


//var sqlQuery = "Select * From Authors A Join Books B On A.Id = B.Id_Author";

//var authorDict = new Dictionary<int, Author>();

//var author = sqlConnection.Query<Author, Book, Author>(sqlQuery,
//    map: (author, book) =>
//    {
//        if(!authorDict.TryGetValue(author.Id, out Author currentAuthor))
//        {
//            currentAuthor = author;
//            authorDict.Add(author.Id, currentAuthor);
//        }

//        if(book is not null)
//        {
//            book.Author = currentAuthor;
//            currentAuthor.Books.Add(book);
//        }

//        return currentAuthor;

//    }, splitOn: "Id");

#endregion

#region CreateUpdateDelete

//var cmd = @"insert into Authors(Id, FirstName, LastName) values(@Id, @FirstName, @LastName)";

////var anonymousObject = new { Id = 22, FirstName = "Tahir", LastName = "Aliyev" };
////sqlConnection.Execute(cmd, param: anonymousObject);

//var author = new Author { Id = 23, FirstName = "Huseyn", LastName = "Hasanzade" };
//sqlConnection.Execute(cmd, author);

//var cmd = @"insert into Authors(Id, FirstName, LastName) values(@Id, @FirstName, @LastName)";

//var authors = new List<Author>()
//{
//    new() { Id = 22, FirstName = "Tahir", LastName = "Aliyev" },
//    new() { Id = 23, FirstName = "Huseyn", LastName = "Hasanzade" }
//};

//sqlConnection.Execute(cmd, param: authors);





//int.TryParse(Console.ReadLine(), out int id);
//var cmd = "Delete From Authors Where Id = @Id";

//sqlConnection.Execute(cmd, param: new { Id = 23 });

//var cmd = "Update Authors Set LastName = @NewLastName Where Id = @Id";

//sqlConnection.Execute(cmd, param: new { NewLastName = "Nesbozade", Id = 21 });

#endregion

#region StoredProcedure

//var procName = "sp_get_author_books_by_id";

//var parameters = new { authorId = 5 };
//var result = sqlConnection.Query(sql: procName, 
//                                param: parameters, 
//                                commandType: CommandType.StoredProcedure);

var procName = "sp_get_author_books_with_count";

var parameters = new DynamicParameters();
parameters.Add("authorId", 5, DbType.Int32, ParameterDirection.Input);
parameters.Add("count", null, DbType.Int32, ParameterDirection.Output);

var result = sqlConnection.Query(procName, parameters, commandType: CommandType.StoredProcedure);

var count = parameters.Get<int>("count");
Console.WriteLine(count);


#endregion

Console.WriteLine();
Console.WriteLine();