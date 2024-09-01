using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson5CodeFirst.Models;

#region Default Convension
//public class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<Product> Products { get; set; }
//}

//public class Product
//{
//    public int Id { get; set; }
//    public double Price { get; set; }
//    public int CategoryId { get; set; }
//    public Category Category { get; set; }
//}
#endregion

#region Data Annotation

//public class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<Product> Products { get; set; }
//}

//public class Product
//{
//    public int Id { get; set; }
//    public double Price { get; set; }
//    [ForeignKey(nameof(Models.Category))]
//    public int CategoryId { get; set; }
//    public Category Category { get; set; }
//}

#endregion

#region Fluent Api

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public double Price { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}

#endregion