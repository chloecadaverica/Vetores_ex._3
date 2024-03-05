Console.Write("Digite a quantidade de valores que quer ler: ");

int n = int.Parse(Console.ReadLine());
double[] val = new double[n];
double soma = 0;

for (int i = 0; i < n; i++)
{
    Console.Write($"Digite o {i + 1}º valor: ");
    val[i] = double.Parse(Console.ReadLine());
    soma += val[i];
}

double media = soma / n;
Console.WriteLine($"A média aritmética dos valores é: {media}");