using System;
using System.Collections.Generic;

public class Menu
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ParentId { get; set; }
}

public class Bai23PrintMenu
{
    public static void PrintMenu(List<Menu> menus)
    {
        foreach (var menu in menus)
        {
            if (menu.ParentId == 0)
            {
                PrintMenuRecursive(menu, menus, 0);
            }
        }
    }

    private static void PrintMenuRecursive(Menu menu, List<Menu> menus, int depth)
    {
        Console.WriteLine($"{new string('-', depth * 2)} {menu.Title}");

        foreach (var submenu in menus)
        {
            if (submenu.ParentId == menu.Id)
            {
                PrintMenuRecursive(submenu, menus, depth + 1);
            }
        }
    }
}
