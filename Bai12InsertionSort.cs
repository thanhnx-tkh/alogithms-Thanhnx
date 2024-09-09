using System;
using System.Collections.Generic;

public class Bai12InsertionSort
{
    public static List<Product> SortByName(List<Product> listProduct)
    {
        List<Product> products = listProduct;

        for (int i = 0; i < products.Count; i++)
        {
            Product product = products[i];
            int valueToInsert = products[i].Name.Length;
            int holePosition = i;
            while (holePosition > 0 && products[holePosition - 1].Name.Length > valueToInsert)
            {
                products[holePosition] = products[holePosition - 1];
                holePosition = holePosition - 1;
            }
            products[holePosition] = product;
        }
        return products;
    }
}

