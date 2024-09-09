using System;
using System.Collections.Generic;

public class Bai5LinearSearch
{
    public Product FindProductByCategory(List<Product> listProduct, int categoryId)
    {
        for (int i = 0; i < listProduct.Count; i++)
        {
            if (listProduct[i].CategoryId == categoryId)
            {
                return listProduct[i];
            }
        }
        return null;
    }
}

