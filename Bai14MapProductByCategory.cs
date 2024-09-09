using System;
using System.Collections.Generic;

public class Bai14MapProductByCategory
{
    public static List<Product> MapProductByCategory(List<Product> listproduct, List<Category> categories)
    {
        List<Product> products = listproduct; 
        for (int i = 0; i < products.Count; i++)
        {
            products[i].NameCategory = GetNameCategoryById(categories, products[i].CategoryId);
        }
        return products;
      
    }
    public static string GetNameCategoryById(List<Category> categories, int id)
    {
        for (int i = 0; i < categories.Count; i++)
        {
            if (categories[i].Id == id)
            {
                return categories[i].Name;
            }
        }
        return null;
    }
}

