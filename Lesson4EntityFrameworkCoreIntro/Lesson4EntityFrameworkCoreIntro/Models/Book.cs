namespace Lesson4EntityFrameworkCoreIntro.Models;

internal class Book : BaseEntity
{
    public string Name { get; set; }
    public string? Comment { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    public int Id_Themes { get; set; }
    public int? Id_Author { get; set; }
    public int Id_Category { get; set; }
    public int Id_Press { get; set; }
    public int Quantity { get; set; }

}
