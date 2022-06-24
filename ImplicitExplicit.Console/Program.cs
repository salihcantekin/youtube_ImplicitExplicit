
#region Unused

//int i1 = 1;

//int i2 = 2;

//i1 = i2;

////bool valid = i1;

////DateTime dt = "salih";

//long longNumber = i1;

//i1 = (int)longNumber;



//double doubleNumber = 2.5;

////i1 = doubleNumber;

//doubleNumber = i1;


//string text = "salih";

//bool isName = (bool)text;

#endregion

using ImplicitExplicit.Console;

int dayNumber = 9;

//CustomDay myAnotherDay = dayNumber;

//int day = myAnotherDay;

CustomDay myAnotherDay = (CustomDay)dayNumber;

int day = (int)myAnotherDay;



Console.WriteLine("\n\nPress [ENTER] to exit");
Console.ReadLine();

