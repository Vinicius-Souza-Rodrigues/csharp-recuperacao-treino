string nomeAluno = "";
string quantidadeAulasSemestre = "";
string quantidadePresencaSemestre = "";
string numero1 = "";
string numero2 = "";
string numero3 = "";

int quantidadeAulasSemestreConvertido = 0;
int quantidadePresencaSemestreConvertido = 0;
double numero1Convertido = 0;
double numero2Convertido = 0;
double numero3Convertido = 0;

StatusAlunos situacaoAluno;
double percentualFrequencia = 0;
double mediaAluno = 0;

while (true)
{
    Console.WriteLine("Digite o nome do aluno: ");
    nomeAluno = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomeAluno))
        Console.WriteLine("O valor digitado é invalido");
    else
        break;
}

while(true)
{
    Console.WriteLine("Digite o número de aulas do semestre: ");
    quantidadeAulasSemestre = Console.ReadLine();

    if (!int.TryParse(quantidadeAulasSemestre, out quantidadeAulasSemestreConvertido) 
    || quantidadeAulasSemestreConvertido <= 0 
    || string.IsNullOrWhiteSpace(quantidadeAulasSemestre))
        Console.WriteLine("O valor digitado não pode ser convertido ou está errado ");
    else
        break;
}

while(true)
{
    Console.WriteLine("Digite o número de presença do aluno no semestre: ");
    quantidadePresencaSemestre = Console.ReadLine();

    if (!int.TryParse(quantidadePresencaSemestre, out quantidadePresencaSemestreConvertido) 
    || quantidadePresencaSemestreConvertido <= 0 
    || string.IsNullOrWhiteSpace(quantidadePresencaSemestre) 
    || quantidadePresencaSemestreConvertido > quantidadeAulasSemestreConvertido)
        Console.WriteLine("O valor digitado não pode ser convertido ou está errado ");
    else
        break;
}

percentualFrequencia = ((double)quantidadePresencaSemestreConvertido / quantidadeAulasSemestreConvertido) * 100;

while(true)
{
    Console.WriteLine("Digite o primeiro número");
    numero1 = Console.ReadLine();

    if (!double.TryParse(numero1, out numero1Convertido) || string.IsNullOrWhiteSpace(numero1) || numero1Convertido < 0 || numero1Convertido > 10 )
        Console.WriteLine("O valor digitado não pode ser convertido ou está errado");
    else
        break;
}

while(true)
{
    Console.WriteLine("Digite o segundo número");
    numero2 = Console.ReadLine();

    if (!double.TryParse(numero2, out numero2Convertido) || string.IsNullOrWhiteSpace(numero2) || numero2Convertido < 0 || numero2Convertido > 10 )
        Console.WriteLine("O valor digitado não pode ser convertido ou está errado");
    else
        break;
}

while(true)
{
    Console.WriteLine("Digite o terceiro número");
    numero3 = Console.ReadLine();

    if (!double.TryParse(numero3, out numero3Convertido) || string.IsNullOrWhiteSpace(numero3) || numero3Convertido < 0 || numero3Convertido > 10 )
        Console.WriteLine("O valor digitado não pode ser convertido ou está errado");
    else
        break;
}

mediaAluno = (numero1Convertido * 0.1) + (numero2Convertido * 0.4) + (numero3Convertido * 0.5);

if (mediaAluno >= 7)
    situacaoAluno = StatusAlunos.Aprovado;

else if (mediaAluno >= 5)
    situacaoAluno = StatusAlunos.Recuperacao;

else
    situacaoAluno = StatusAlunos.Reprovado;

if (percentualFrequencia < 75)
    situacaoAluno = StatusAlunos.Reprovado;

Console.WriteLine("=== BOLETIM FINAL ===");
Console.WriteLine($"Aluno: {nomeAluno}");
Console.WriteLine($"Nota 1: {numero1Convertido}, Nota 2: {numero2Convertido}, Nota 3: {numero3Convertido}");
Console.WriteLine($"Média: {mediaAluno:f2}");
Console.WriteLine($"Frequência: {percentualFrequencia:f2}%\n");
Console.WriteLine($"Situação aluno: {situacaoAluno}");

enum StatusAlunos
{
    Aprovado,
    Reprovado,
    Recuperacao
}
