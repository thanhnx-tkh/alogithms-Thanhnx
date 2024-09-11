    using System;
using System.Collections.Generic;

public class Demo
{
    public static void Print(List<Product> products)
    {
        Console.WriteLine("---------------------------------------");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine("Stt: " + (i + 1) + " Name: " + products[i].Name + " Price: " + products[i].Price + " Quality: " + products[i].Quality + " CategoryId: " + products[i].CategoryId);
        }
        Console.WriteLine("---------------------------------------");
    }
    public static void Print(List<Category> categories)
    {
        Console.WriteLine("---------------------------------------");
        for (int i = 0; i < categories.Count; i++)
        {
            Console.WriteLine("Stt: " + (i + 1) + " Id: " + categories[i].Id + " Name: " + categories[i].Name);
        }
        Console.WriteLine("---------------------------------------");
    }

    public static void Print(List<Product> products, List<Category> categories)
    {
        Console.WriteLine("---------------------------------------");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine("Stt: " + (i + 1) + " Name: " + products[i].Name + " CategoryId: " + products[i].CategoryId + "Category Name: " +Bai13InsertionSort.GetCategoryById(categories, products[i].CategoryId).Name);
        }
        Console.WriteLine("---------------------------------------");
    }

    public static void Print1(List<Product> products)
    {
        Console.WriteLine("---------------------------------------");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine("Stt: " + (i + 1) + " Name: " + products[i].Name + " CategoryId: " + products[i].CategoryId + " Category Name: "+ products[i].NameCategory);
        }
        Console.WriteLine("---------------------------------------");
    }

    //static void Main(string[] args)
    //{
    //    //List<Product> products = new List<Product>();

    //    //products.Add(new Product("RAM", 50, 2, 2));
    //    //products.Add(new Product("HDD", 70, 1, 2));
    //    //products.Add(new Product("CPU", 750, 10, 1));
    //    //products.Add(new Product("Main", 400, 3, 1));
    //    //products.Add(new Product("Keyboard", 30, 8, 4));
    //    //products.Add(new Product("Mouse", 25, 50, 4));
    //    //products.Add(new Product("VGA", 60, 35, 3));
    //    //products.Add(new Product("Monitor", 120, 28, 2));
    //    //products.Add(new Product("Case", 120, 28, 5));    



    //    //List<Category> categories = new List<Category>();
    //    //categories.Add(new Category(1, "Computer"));
    //    //categories.Add(new Category(2, "Memory"));
    //    //categories.Add(new Category(3, "Card"));
    //    //categories.Add(new Category(4, "Accesory"));
    //    //categories.Add(new Category(5, "Base"));


    //    //Print(products);
    //    //Print(categories);
    //    //Print(Bai11BubbleSort.SortByPrice(products));
    //    //Print(Bai12InsertionSort.SortByName(products));
    //    //Print(Bai13InsertionSort.SortByCategoryName(products, categories), categories);
    //    //Print1(Bai14MapProductByCategory.MapProductByCategory(products, categories));
    //    //Console.WriteLine(Bai15MinByPrice.MinByPrice(products).Price);
    //    //Console.WriteLine(Bai16MaxByPrice.MaxByPrice(products).Price);
    //    //Console.WriteLine(Bai21CalSalary.CalSalaryDeQuy(20, 4));
    //    //Console.WriteLine(Bai21CalSalary.CalSalaryDeQuy(20, 4));

    //    //Console.WriteLine(Bai22CalMonth.CalMonth(20, 5));
    //    //Console.WriteLine(Bai22CalMonth.CalMonthDeQuy(10000, 80));


    //    //Menu[] menus = new Menu[]
    //    //{
    //    //    new Menu(1, "Thể thao", 0),
    //    //    new Menu(2, "Xã hội", 0),
    //    //    new Menu(3, "Thể thao trong nước", 1),
    //    //    new Menu(4, "Giao thông", 2),
    //    //    new Menu(5, "Môi trường", 2),
    //    //    new Menu(6, "Thể thao quốc tế", 1),
    //    //    new Menu(7, "Môi trường đô thị", 5),
    //    //    new Menu(8, "Giao thông ùn tắc", 4)
    //    //};

    //    //Bai23PrintMenu.PrintMenu(menus);

    //    //Queue<int> queue = new Queue<int>();
    //    //queue.Push(1);
    //    //queue.Push(2);
    //    //queue.Push(3);

    //    //Console.WriteLine("--------Queue-------");


    //    //Console.WriteLine(queue.Get());
    //    //Console.WriteLine(queue.Get());
    //    //Console.WriteLine(queue.Get());


    //    //Stack<int> stack = new Stack<int>();

    //    //stack.Push(1);
    //    //stack.Push(2);
    //    //stack.Push(3);

    //    //Console.WriteLine("--------Stack-------");

    //    //Console.WriteLine(stack.Get());
    //    //Console.WriteLine(stack.Get());
    //    //Console.WriteLine(stack.Get());

    //    // Dữ liệu mẫu menu
    //    //List<Menu> menus = new List<Menu>
    //    //{
    //    //    new Menu { Id = 1, Title = "Thể thao", ParentId = 0 },
    //    //    new Menu { Id = 2, Title = "Xã hội", ParentId = 0 },
    //    //    new Menu { Id = 3, Title = "Thể thao trong nước", ParentId = 1 },
    //    //    new Menu { Id = 4, Title = "Giao thông", ParentId = 2 },
    //    //    new Menu { Id = 5, Title = "Môi trường", ParentId = 2 },
    //    //    new Menu { Id = 6, Title = "Thể thao quốc tế", ParentId = 1 },
    //    //    new Menu { Id = 7, Title = "Môi trường đô thị", ParentId = 5 },
    //    //    new Menu { Id = 8, Title = "Giao thông ùn tắc", ParentId = 4 }
    //    //};

    //    //Bai23PrintMenu.PrintMenu(menus);
    //    Console.ReadLine();

    //}

}

