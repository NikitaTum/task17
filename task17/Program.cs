// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите четрветь от 1 до 4: ");
int range = Convert.ToInt32(Console.ReadLine());


if (range == 1)
Console.WriteLine("X > 0 && Y > 0");
else if(range == 2)
Console.WriteLine("X < 0 && Y > 0");
else if(range ==3)
Console.WriteLine("X < 0 && Y < 0");
else if (range ==4)
Console.WriteLine("X > 0 && Y < 0");
else if (range > 4)
Console.WriteLine("Такой четверти нет");
else if (range < -4)
Console.WriteLine("Такой четверти нет");
