try
{
    Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ МЫ ОПРЕДЕЛИМ в какой строке находится значение с порядковым номером ВВЕДИТЕ n:");
    int n = int.Parse(Console.ReadLine());
    int kolonka = 5;
    int stolb = (n - 1) / kolonka;
    int rowNumber = stolb + 1;
    Console.WriteLine("Значение с порядковым номером " + n + " находится в строке " + rowNumber);
}
catch
{
    Console.WriteLine("введите правильно");
}
