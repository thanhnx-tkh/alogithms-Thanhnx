using System;
using System.Collections.Generic;

public class Bai13InsertionSort
{
    public static List<Product> SortByCategoryName(List<Product> listProduct, List<Category> listCategory)
    {
        List<Product> products = listProduct;
        List<Category> categories = listCategory;

        for (int i = 0; i < products.Count; i++)
        {
            Product product = products[i];
            char valueToInsert = GetCategoryById(categories, product.CategoryId).Name[0];
            int holePosition = i;
            while (holePosition > 0 && GetCategoryById(categories, products[holePosition - 1].CategoryId).Name[0] > valueToInsert)
            {
                products[holePosition] = products[holePosition - 1];
                holePosition = holePosition - 1;
            }
            products[holePosition] = product;
        }
        return products;
    }
    public static Category GetCategoryById(List<Category> categories, int id)
    {
        for (int i = 0; i < categories.Count; i++)
        {
            if (categories[i].Id == id)
            {
                return categories[i];
            }
        }
        return null;
    }
}

