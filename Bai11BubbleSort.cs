using System;
using System.Collections.Generic;

public class Bai11BubbleSort
{
    public static List<Product> SortByPrice(List<Product> listProduct)
    {
        List<Product> products = listProduct;
        int n = products.Count;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (products[j].Price > products[j+1].Price)
                {
                    Product temp = products[j];
                    products[j] = products[j+1];
                    products[j+1] = temp;
                }
            }
        }
        return products;
    }    
}

