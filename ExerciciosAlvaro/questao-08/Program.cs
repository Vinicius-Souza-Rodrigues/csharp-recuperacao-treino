List<decimal> listaValoresPedidos = [22.50m, 18.00m, 45.00m, 9.50m, 60.00m, 12.00m, 30.00m];

decimal valorTotal = 0m;
int quantidadProdutosPremium = 0;
decimal vendaMaisCara = 0m;
decimal vendaMaisBarata = 0m;
decimal vendaMedia = 0m;
int indice = 0;
ClassificacaoDia classificacaoDia;

listaValoresPedidos.ForEach(valor =>
{
    Console.WriteLine($"Venda {indice + 1}: {valor:C}\n");

    if (valor > vendaMaisCara)
        vendaMaisCara = valor;

    if (valor < vendaMaisBarata || vendaMaisBarata == 0)
        vendaMaisBarata = valor;

    valorTotal += valor;

    if (valor > 30)
        quantidadProdutosPremium++;
    indice++;
});

if (valorTotal >= 200)
    classificacaoDia = ClassificacaoDia.Otimo;
else if (valorTotal >= 120)
    classificacaoDia = ClassificacaoDia.Bom;
else if (valorTotal >= 60)
    classificacaoDia = ClassificacaoDia.Regular;
else
    classificacaoDia = ClassificacaoDia.Fraco;

Console.Write("=== RELATÓRIO DO DIA === ");
Console.Write($"Faturamento Total: {valorTotal:C} ");
if (quantidadProdutosPremium != 0)
    Console.Write($"Pedidos premium: {quantidadProdutosPremium} ");
Console.Write($"Maior Venda: {vendaMaisCara:C} ");
Console.Write($"Menor Venda: {vendaMaisBarata:C} ");
Console.Write($"Status do dia: {classificacaoDia} ");

enum ClassificacaoDia
{
    Otimo = 1,
    Bom = 2,
    Regular = 3,
    Fraco= 4,
}
