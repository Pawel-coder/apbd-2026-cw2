// See https://aka.ms/new-console-template for more information

using Tutorial2;

Console.WriteLine("Hello, World!");
Console.WriteLine(StatisticsHelper.CalculateAverage(new int[3]{1,13,3}));
Console.WriteLine(StatisticsHelper.CalculateAverage(new int[3]{13,13,13}));
Console.WriteLine(StatisticsHelper.CalculateAverage(new int[3]{2,3,4}));
Console.WriteLine(StatisticsHelper.CalculateMin(new int[3]{4,5,6}));
Console.WriteLine(StatisticsHelper.CalculateMax(new int[3]{2,3,4})-StatisticsHelper.CalculateMin(new int[3]{2,3,4}));
Console.WriteLine("Goodbye, World!");