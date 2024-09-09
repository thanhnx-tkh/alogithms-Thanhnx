using System;
using System.Collections.Generic;

public class Bai15MinByPrice
{
    public static Product MinByPrice(List<Product> listProduct)
    {
        List<Product> products = listProduct;
        Product productMinPrice = products[0];
        for (int i = 0; i < products.Count; i++)
        {
            if (productMinPrice.Price > products[i].Price )
            {
                productMinPrice = products[i];
            }
        }
        return productMinPrice;
    }
}

