using Dapper;
using Lesson1Dapper.Models;
using Microsoft.Extensions.Configuration;
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

#endregion


Console.WriteLine();
Console.WriteLine();