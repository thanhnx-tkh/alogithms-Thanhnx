using System;
using System.Collections.Generic;

public class Bai6LinearSearch
{
    public Product FindProductByPrice(List<Product> listProduct, int price)
    {
        for (int i = 0; i < listProduct.Count; i++)
        {
            if (listProduct[i].Price == price)
            {
                return listProduct[i];
            }
        }
        return null;
    }
}

