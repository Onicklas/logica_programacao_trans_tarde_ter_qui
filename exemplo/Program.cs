/* escreva um programa que receba um nome completo do aluno, em seguida, solicite a nota das três provas realizadas. Ao final o programa deve exibir a situação do aluno, se nota maior ou igual a 7 aluno aprovado, se nota maior ou igual a 4 aluno em recuperação, notas abaixo de 4: aluno reprovado.*/
Console.WriteLine("Nome completo do aluno: ");
string n  = Console.ReadLine();
Console.WriteLine("Nota 1: ");
double nota1  = Double.Parse(Console.ReadLine());
Console.WriteLine("Nota 2: ");
double nota2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nota 3: ");
double nota3 = Double.Parse(Console.ReadLine());
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine($"o aluno foi aprovado.");
}
else if (media >= 4)
{
    Console.WriteLine("Recuperação!");
}
else
{
    Console.WriteLine("Reprovado!");
}
