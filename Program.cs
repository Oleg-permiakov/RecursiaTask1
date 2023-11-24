// Задайте значение М и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N
Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

void Funcia(int numberM, int numberN) {
if ((numberM - 1) == numberN)
{
    return;
}
Funcia(numberM, numberN - 1);   
Console.Write(" " + numberN);

}
Funcia(numberM, numberN);
Console.WriteLine(" - Конец");



