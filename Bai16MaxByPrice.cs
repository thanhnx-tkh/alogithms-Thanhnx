using System;
using System.Collections.Generic;

public class Bai16MaxByPrice
{
    public static Product MaxByPrice(List<Product> listProduct)
    {
        List<Product> products = listProduct;
        Product productMaxPrice = products[0];
        for (int i = 0; i < products.Count; i++)
        {
            if (productMaxPrice.Price < products[i].Price)
            {
                productMaxPrice = products[i];
            }
        }
        return productMaxPrice;
    }
}

