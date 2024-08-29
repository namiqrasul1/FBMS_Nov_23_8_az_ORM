using Lesson3DapperPractice.Data;
using System.Configuration;

using var database = new Database(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);


try
{
    var student = database.Login(5);
    Console.WriteLine(student?.FirstName);
}
catch (Exception)
{
    Console.WriteLine("student not found");
}
