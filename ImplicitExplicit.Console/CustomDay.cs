using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicit.Console;
public struct CustomDay
{
    public int Day { get; set; }

    public CustomDay(int day)
    {
        if (day > 6)
            day = 6;

        Day = day;

        DayOfWeek = (DayOfWeek)day;
    }

    public DayOfWeek DayOfWeek { get; }

    public bool IsWeekDay => Day >= 1 && Day <= 5;

    public bool IsWeekend => Day == 0 || Day == 6;

    //public static implicit operator CustomDay(int day) => new CustomDay(day);

    //public static implicit operator int(CustomDay day) => day.Day;




    public static explicit operator CustomDay(int day) => new CustomDay(day);

    public static explicit operator int(CustomDay day) => day.Day;
}

public class UserEntity
{
    public int Id { get; set; }

    public static implicit operator UserEntity(UserViewModel userViewModel)
    {
        return new UserEntity()
        {
            Id = userViewModel.Id
        };
    }

    public static implicit operator UserViewModel(UserEntity userEntity)
    {
        return new UserViewModel()
        {
            Id = userEntity.Id,
            Permissions = new string[0] // service call
        };
    }
}

public class UserViewModel
{
    public int Id { get; set; }

    public string[] Permissions { get; set; }
}