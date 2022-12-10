// See https://aka.ms/new-console-template for more information
using BL;

Console.WriteLine("Enter path:");

string? filePath = Console.ReadLine();

if (!string.IsNullOrEmpty(filePath))
{
    List<BO.Elf>? list = Elf.ReadFileElfData(filePath);

    if (list == null) Console.WriteLine(0);
    else Console.WriteLine(Elf.GetHighestAmountOfCaloriesForListOfElves(list));
}