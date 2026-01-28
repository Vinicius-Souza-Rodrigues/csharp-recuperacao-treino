int quantidadeVendas;
decimal valorVenda;
decimal valorTotal = 0;
decimal mediaVendas;
int quantidadeVendasAcimaMedia = 0;
decimal maiorVenda = 0;
decimal menorVenda = 0;
StatusTotal statusTotal;

List<decimal> listaValorVenda = [];

Console.WriteLine("Digite a quantidade de vendas no dia: ");
while (!int.TryParse(Console.ReadLine(), out quantidadeVendas) || quantidadeVendas <= 0)
    Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

for (int i = 0; i < quantidadeVendas; i++)
{
    Console.WriteLine("Digite o valor da vendas no dia: ");
    while (!decimal.TryParse(Console.ReadLine(), out valorVenda) || valorVenda <= 0)
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

    valorTotal += valorVenda;

    if (valorVenda > maiorVenda)
        maiorVenda = valorVenda;

    if (valorVenda < menorVenda || menorVenda == 0)
        menorVenda = valorVenda;

    listaValorVenda.Add(valorVenda);
}

mediaVendas = valorTotal / ContarQuantidadeItensLista(listaValorVenda);

foreach (int valorUnitarioItem in listaValorVenda)
{
    if (valorUnitarioItem > mediaVendas)
        quantidadeVendasAcimaMedia++;
}

if (valorTotal >= 2000)
    statusTotal = StatusTotal.Excelente;
else if (valorTotal >= 1200)
    statusTotal = StatusTotal.Bom;
else if (valorTotal >= 600)
    statusTotal = StatusTotal.Regular;
else
    statusTotal = StatusTotal.Fraco;

Console.WriteLine("============  RELATÓRIO DE VENDAS ============");
for (int i = 0; i < ContarQuantidadeItensLista(listaValorVenda); i++)
    Console.WriteLine($"Venda {i + 1}: {listaValorVenda[i]}");

Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine($"Total vendido: {valorTotal:C}");
Console.WriteLine($"Média das vendas: {mediaVendas:C}");
Console.WriteLine($"Vendas acima da média: {quantidadeVendasAcimaMedia}");
Console.WriteLine($"Maior venda: {maiorVenda:C}");
Console.WriteLine($"Menor venda: {menorVenda:C}\n");
Console.WriteLine($"Desempenho do dia: {statusTotal}");

int ContarQuantidadeItensLista<T>(List<T> lista)
{
    int contador = 0;
    foreach (var valor in lista)
        contador++;

    return contador;
}

enum StatusTotal

{
    Excelente = 1,
    Bom = 2,
    Regular = 3,
    Fraco = 4,
}
