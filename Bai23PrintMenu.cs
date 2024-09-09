using System;
using System.Collections.Generic;

public class Menu
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Parent_id { get; set; }
    public Menu(int id, string title, int parenId)
    {
        this.Id = id;
        this.Title = title;
        this.Parent_id = parenId;
    }
}

public class Bai23PrintMenu
{
    public static void PrintMenu(Menu[] menus)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            Console.WriteLine("Menu: " + (i + 1));
            Console.WriteLine("--Id:");
            Console.WriteLine("----" + menus[i].Id);
            Console.WriteLine("--title:");
            Console.WriteLine("----" + menus[i].Title);

            Console.WriteLine("--parent_id:");
            Console.WriteLine("----" + menus[i].Parent_id);

        }
    }
}