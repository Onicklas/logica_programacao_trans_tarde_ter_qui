//Desenvolva um programa em C# que calcule a média de um aluno a partir de três notas fornecidas pelo usuário. O programa deve solicitar que o usuário insira as três notas e, em seguida, calcular a média aritmética dessas notas. Após calcular a média, o programa deve determinar a situação do aluno com base nos seguintes critérios: se a média for maior ou igual a 7, o aluno será considerado "Aprovado"; se a média estiver entre 4 (inclusivo) e 7 (exclusivo), o aluno estará "Em recuperação"; e se a média for menor que 4, o aluno será classificado como "Reprovado". O programa deve exibir a média calculada e a situação do aluno de forma clara e organizada. Este exercício tem como objetivo praticar o cálculo de médias e a utilização de estruturas condicionais em C#.
using System.Net.Http.Headers;

Console.WriteLine("Aluno 1");
Console.WriteLine("Nota: ");
int Nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Aluno 2");
Console.WriteLine("Nota: ");
int Nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Aluno 3");
Console.WriteLine("Nota: ");
int Nota3  = int.Parse(Console.ReadLine());

Console.Clear();
int Media = (Nota1 + Nota2 + Nota3) / 3;
Console.WriteLine("Média:  " + (Nota1 + Nota2 + Nota3) / 3);

if (Media >= 7)
{
    Console.WriteLine("Acima da média");
}
else
{
    Console.WriteLine("Abaixo da média");
}
Console.ReadKey();
