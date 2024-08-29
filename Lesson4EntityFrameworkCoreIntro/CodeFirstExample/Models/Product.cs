﻿namespace CodeFirstExample.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Desc { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }
}
