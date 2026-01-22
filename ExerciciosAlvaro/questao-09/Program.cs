List<string> listaDeTarefas = new List<string>();
string nomeTarefa = "";
int indice = 0;
int indiceTarefa = 0;

Console.WriteLine("Quantas tarefas serão adicionadas? ");
int quantidadeTarefas = ValidarInteiro();

for (int i = 0; i < quantidadeTarefas; i++)
{
    Console.WriteLine("Digite a tarefa que será realizada: ");
    nomeTarefa = ValidarString();

    listaDeTarefas.Add(nomeTarefa);
}

Console.Clear();

int opcaoEscolha = 0;

while (true)
{
    Console.WriteLine("Esqueceu alguma tarefa? | 1 - Sim , 2 - Não");
    while (!int.TryParse(Console.ReadLine(), out opcaoEscolha) || opcaoEscolha < 1 || opcaoEscolha > 2)
    Console.WriteLine("Valor inserido é invalido ou não pode ser convertido, tente novamente: ");


    if (opcaoEscolha == 1)
    {
        Console.WriteLine("Deseja adicionar qual tarefa? ");
        nomeTarefa = ValidarString();

        Console.WriteLine("Ddeseja adicionar em que indice a tarefa? ");
        indiceTarefa = ValidarInteiro();

        listaDeTarefas.Insert(indiceTarefa, nomeTarefa);
    } else
        break;
}

Console.WriteLine("=== SUA LISTA FINAL === ");
listaDeTarefas.ForEach(item =>
{
    Console.WriteLine($"{indice + 1}. {item}");
    indice++;
});

string ValidarString()
{
    string variavelTemporaria = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(variavelTemporaria))
        Console.WriteLine("Dado inserido invalido, valor não pode ser nulo");

    return variavelTemporaria;
}

int inteiroConvertido = 0;

int ValidarInteiro()
{
    while (!int.TryParse(Console.ReadLine(), out inteiroConvertido) || inteiroConvertido < 1)
        Console.WriteLine("O valor não pode ser convertido ou é invalido");

    return inteiroConvertido;
}
