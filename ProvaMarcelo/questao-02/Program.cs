int quantidadeAlunos;
string NomeAluno;
decimal notaAluno1;
decimal notaAluno2;
decimal notaAluno3;
decimal mediaAluno = 0;
int quantidadeAlunoAprovados = 0;
int quantidadeAlunoRecuperacao = 0;
int quantidadeAlunoReprovados = 0;
SituacaoAluno situacaoAluno;

List<string> listaAlunos = [];
List<decimal> listaNotas1 = [];
List<decimal> listaNotas2 = [];
List<decimal> listaNotas3 = [];
List<decimal> listaMedia = [];
List<SituacaoAluno> listaSituacaoAluno = [];

Console.WriteLine("Digite a quantidade de alunos: ");
while (!int.TryParse(Console.ReadLine(), out quantidadeAlunos) || quantidadeAlunos <= 0)
    Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

for (int i = 0; i < quantidadeAlunos; i++)
{
    Console.WriteLine("Digite o nome do aluno: ");
    NomeAluno = Console.ReadLine();
    NomeAluno = ValidarString(NomeAluno);

    Console.WriteLine("Digite a nota 1 do aluno: ");
    while (!decimal.TryParse(Console.ReadLine(), out notaAluno1) || notaAluno1 <= 0 || notaAluno1 > 10)
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

    Console.WriteLine("Digite a nota 2 do aluno: ");
    while (!decimal.TryParse(Console.ReadLine(), out notaAluno2) || notaAluno2 <= 0 || notaAluno2 > 10)
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

    Console.WriteLine("Digite a nota 3 do aluno: ");
    while (!decimal.TryParse(Console.ReadLine(), out notaAluno3) || notaAluno3 <= 0 || notaAluno3 > 10)
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

    mediaAluno = (notaAluno1 + notaAluno2 + notaAluno3) / 3;

    if (mediaAluno >= 7)
    {
        situacaoAluno = SituacaoAluno.Aprovado;
        quantidadeAlunoAprovados++;
    }
    else if (mediaAluno >= 5)
    {
        situacaoAluno = SituacaoAluno.Recuperacao;
        quantidadeAlunoRecuperacao++;
    }
    else
    {
        situacaoAluno = SituacaoAluno.Reprovado;
        quantidadeAlunoReprovados++;
    }

    listaAlunos.Add(NomeAluno);
    listaNotas1.Add(notaAluno1);
    listaNotas2.Add(notaAluno2);
    listaNotas3.Add(notaAluno3);
    listaMedia.Add(mediaAluno);
    listaSituacaoAluno.Add(situacaoAluno);

    Console.Clear();
}

Console.WriteLine("============= BOLETIM DA TURMA =====================");
for (int i = 0; i < ContarQuantidadeItensLista(listaAlunos); i++)
{
    Console.WriteLine($"Aluno: {listaAlunos[i]}");
    Console.WriteLine($"Nota 1: {listaNotas1[i]} | Nota 2: {listaNotas2[i]} | Nota 3: {listaNotas3[i]}");
    Console.WriteLine($"Média: {listaMedia[i]}");
    Console.WriteLine($"Situação: {listaSituacaoAluno[i]}");
    Console.WriteLine("---------------------------------");
}
Console.WriteLine($"Aprovados: {quantidadeAlunoAprovados}");
Console.WriteLine($"Recuperação: {quantidadeAlunoRecuperacao}");
Console.WriteLine($"Reprovados: {quantidadeAlunoReprovados}");

string ValidarString(string nome)
{
    while (string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");
        nome = Console.ReadLine();
    }
    return nome;
}

int ContarQuantidadeItensLista<T>(List<T> lista)
{
    int contador = 0;
    foreach (var valor in lista)
        contador++;

    return contador;
}

enum SituacaoAluno
{
    Aprovado = 1,
    Recuperacao = 2,
    Reprovado = 3,
}
