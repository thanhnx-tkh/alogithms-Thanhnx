using System;
using System.Collections.Generic;

public class Bai4LinearSearch
{
    public Product FindProduct(List<Product> listProduct,string nameProduct) {
        for (int i = 0; i < listProduct.Count; i++)
        {
            if (String.Compare(listProduct[i].Name, nameProduct, true) == 0)
            {
                return listProduct[i];
            }
        }
        return null;
    }

}

