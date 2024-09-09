using System;

public class Bai21CalSalary
{
    public static double CalSalary(double salary, int n)
    {
        for (int i = 0; i < n; i++)
        {
            salary += (salary * 0.1);
        }

        return salary;
    }

    public static double CalSalaryDeQuy(double salary, int n)
    {
        if( n == 0)
        {
            return salary;
        }
        salary = CalSalaryDeQuy(salary, n - 1) * 0.1 + CalSalaryDeQuy(salary, n - 1);
        return salary;
    }


}

