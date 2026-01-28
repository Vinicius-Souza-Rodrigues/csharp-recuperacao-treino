int numeroItens;
string NomeProduto;
decimal precoProduto;
int quantidadeProduto;
decimal precoTotalEstoque = 0;
string produtoMaisCaro = "";
string produtoMenorQuantidade = "";
decimal produtoMaisCaroNumero = 0;
int produtoMenorQuantidadeNumero = 0;

List<string> listaNomeProdutos = [];
List<decimal> listaPrecoProdutos = [];
List<int> listaQuantidadeProduto = [];

Console.WriteLine("Quantos produto serão adicionados no estoque: ");
while (!int.TryParse(Console.ReadLine(), out numeroItens) || numeroItens <= 0)
    Console.WriteLine("o valor fornecido é invalido ou não pode ser convertido, tente novamente");

for (int i = 0; i < numeroItens; i++)
{
    Console.WriteLine("Digite o nome do produto: ");
    NomeProduto = Console.ReadLine();
    NomeProduto = ValidarString(NomeProduto);

    Console.Clear();

    Console.WriteLine("Digite o preço do produto: ");
    while (!decimal.TryParse(Console.ReadLine(), out precoProduto) || precoProduto <= 0)
        Console.WriteLine("o valor fornecido é invalido ou não pode ser convertido, tente novamente");

    Console.Clear();

    Console.WriteLine("Digite a quantidade do produto que sera adicionada no estoque: ");
    while (!int.TryParse(Console.ReadLine(), out quantidadeProduto) || quantidadeProduto <= 0)
        Console.WriteLine("o valor fornecido é invalido ou não pode ser convertido, tente novamente");

    Console.Clear();

    listaNomeProdutos.Add(NomeProduto);
    listaPrecoProdutos.Add(precoProduto);
    listaQuantidadeProduto.Add(quantidadeProduto);

    precoTotalEstoque += precoProduto * quantidadeProduto;

    if (precoProduto > produtoMaisCaroNumero || produtoMaisCaroNumero <= 0) 
    {
        produtoMaisCaro = listaNomeProdutos[i];
        produtoMaisCaroNumero = precoProduto;
    }

    if (quantidadeProduto < produtoMenorQuantidadeNumero || produtoMenorQuantidadeNumero <= 0)
    {
        produtoMenorQuantidade = listaNomeProdutos[i];
        produtoMenorQuantidadeNumero = quantidadeProduto;
    }
}

Console.WriteLine("=== RELATÓRIO DE PRODUTOS ===");
for (int i = 0; i < ContarQuantidadeItensLista(listaNomeProdutos); i++)
    Console.WriteLine($"Produto {i+1}: {listaNomeProdutos[i]} | {listaPrecoProdutos[i]:C} | {listaQuantidadeProduto[i]} unidades");

Console.WriteLine($"Valor total em estoque: {precoTotalEstoque:C}");
Console.WriteLine($"Produto mais caro: {produtoMaisCaro}");
Console.WriteLine($"Produto com menor estoque: {produtoMenorQuantidade}");

string ValidarString(string nome)
{
    while (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsNumber))
    {
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");
        nome = Console.ReadLine();
    }
    return nome;
}

int ContarQuantidadeItensLista<T> (List<T> lista)
{
    int contador = 0;
    foreach(var valor in lista)
        contador++;

    return contador;
}
