Console.WriteLine("Número1: ");
int Num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Número2: ");
int Num2 = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("+ : " + (Num1 + Num2));
Console.WriteLine("- : " + (Num1 - Num2));
Console.WriteLine("* : " + (Num1 * Num2));
if (Num1 != 0)
{
    Console.WriteLine("/ : " + (Num1 / Num2));
}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É PERMITIDA!");
}
Console.WriteLine("======================");
Console.WriteLine("Números são iguas?" + (Num1 == Num2));
Console.WriteLine("Número 1 é maior que o 2? " + (Num1 > Num2));
Console.WriteLine("Número 1 é menor que o 2? " + (Num1  < Num2));
Console.WriteLine("Número 1 é maior igual o 2? " + (Num1 >= Num2));
Console.WriteLine("Número 1 é maior igual o 2? " + (Num1 <= Num2));
