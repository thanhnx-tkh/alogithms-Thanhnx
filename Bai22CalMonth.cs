using System;

public class Bai22CalMonth
{


// Hãy viết function calMonth(money, rate) , trả về số tháng tiền cần gửi tiết kệm để tiền gốc + 
// lãi tăng gấp đôi so với tiền gốc.Money là số tiền gốc, rate là % lãi suất mỗi tháng. ví dụ calMount(1000, 5). 
//Viết bằng 2 cách, đệ qui và không dùng đệ qui

    public static double CalMonth(double money, double rate)
    {
        int month = 0;
        double doubleMoney = money * 2; 
        while ( money < doubleMoney)
        {
            month++;
            money += money*(rate/100);
        }
        return month;
    }
    public static double CalMonthDeQuy(double money, double rate, double totalMoney = 0, int month = 0)
    {
        if(month == 0)
        {
            totalMoney = money;
        }
        if(totalMoney >= money * 2)
        {
            return month;
        }

        totalMoney += totalMoney * (rate / 100);
        month++;

        return CalMonthDeQuy(money,rate, totalMoney, month);

    }
}

