using Dapper;
using Lesson3DapperPractice.Models;
using System.Data.SqlClient;

namespace Lesson3DapperPractice.Data;

internal class Database : IDisposable
{
    public SqlConnection Connection { get; set; }
	public Database(string connectionString)
	{
		Connection = new SqlConnection(connectionString);
	}

	public Student? Login(int id)
	{
		var query = "Select * From Students Where Id = @id";
		//var student = Connection.QuerySingleOrDefault(query, param: new { id = id });
		var student = Connection.QuerySingleOrDefault<Student>(query, param: new { id });
		return student;
	}

	public List<Book> GetAllBooks()
	{
		var query = "Select * From Books Where Quantity > 0";
		var books = Connection.Query<Book>(query).ToList();
		return books;
	}

	// getTakenBooks(studId) 
	// takebook(studId, bookId)











    public void Dispose()
    {
        Connection.Dispose();
		GC.SuppressFinalize(this);
    }

	~Database()
	{
		Dispose();
	}
}
