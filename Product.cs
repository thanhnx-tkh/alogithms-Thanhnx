using System;

public class Product
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public int Price { get; set; }
    public int Quality { get; set; }
    public string NameCategory { get; set; }


    public Product(string name, int price, int quality ,int categoryId)
    {
        this.Quality = quality;
        this.Name = name;
        this.CategoryId = categoryId;
        this.Price = price;
    }

}