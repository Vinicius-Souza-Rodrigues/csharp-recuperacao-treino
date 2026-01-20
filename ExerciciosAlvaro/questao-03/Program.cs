List<double> listaMedias = new List<double>();
string quantidadeEstagiarios = "";

int quantidadeEstagiariosConvertido = 0;
double mediaAlunoConvertido = 0;
double mediaTurma = 0;
int quantidadeAlunosAprovados = 0;
int quantidadeAlunosReprovados = 0;
string desempenhoTurma = "";
double maiorMedia = 0;
double menorMedia = 0;
 
while(true)
{
    Console.WriteLine("Digite a quantidade de alunos que uma turma de estagiarios deve ter: ");
    quantidadeEstagiarios = Console.ReadLine();

    if (!int.TryParse(quantidadeEstagiarios, out quantidadeEstagiariosConvertido) || string.IsNullOrWhiteSpace(quantidadeEstagiarios) || quantidadeEstagiariosConvertido <= 1)
        Console.WriteLine("Não foi possivel converter esse valor ou a quantidade de estagiarios é ");
    else
        break;
}

int id = 0;

while(id <= quantidadeEstagiariosConvertido)
{
    while(true)
    {
        Console.WriteLine("Digite a média do aluno de 0 a 10: ");
        string mediaAluno;
        if (double.TryParse(mediaAluno, out mediaAlunoConvertido) || mediaAlunoConvertido < 0 || mediaAlunoConvertido > 10)
            Console.WriteLine("O valor não pode ser convertido ou o dado inserido é invalido");
        else
            break;
    }

    if (mediaAlunoConvertido > maiorMedia)
        maiorMedia = mediaAlunoConvertido;

    if (mediaAlunoConvertido < menorMedia)
        menorMedia = mediaAlunoConvertido;

    if (mediaAlunoConvertido >= 7)
        quantidadeAlunosAprovados++;
    else if(mediaAlunoConvertido <= 5)
        quantidadeAlunosReprovados++;

    mediaTurma += mediaAlunoConvertido;

    listaMedias.Add(mediaAlunoConvertido);
    id++;
}

mediaTurma /= listaMedias.Count;

if (mediaTurma >= 8)
    desempenhoTurma = "Excelente";
else if (mediaTurma >= 6)
    desempenhoTurma = "Boa";
else if (mediaTurma >= 5)
    desempenhoTurma = "Regular";
else
    desempenhoTurma = "Fraca";

Console.WriteLine("=== RELATÓRIO DA TURMA ===");
for(int i = 0; i < listaMedias.Count; i++)
    Console.WriteLine($"Nota {i+1}: {listaMedias[i]}");

Console.WriteLine($"Média Turma: {mediaTurma}");
Console.WriteLine($"Maior: {maiorMedia}");
Console.WriteLine($"Menor: {menorMedia}");
Console.WriteLine($"Aprovados: {quantidadeAlunosAprovados}");
Console.WriteLine($"Reprovados: {quantidadeAlunosReprovados}");
Console.WriteLine($"Desempenho: {desempenhoTurma}");
