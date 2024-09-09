using System;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public int Price { get; set; }

    public Product()
    {
    }
    public Product(int id, string name, int categoryId, int price)
    {
        this.Id = id;
        this.Name = name;
        this.CategoryId = categoryId;
        this.Price = price;

    }

}