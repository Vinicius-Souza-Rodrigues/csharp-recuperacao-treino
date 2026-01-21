string nomeCliente = "";
decimal consumoMes = 0m;
decimal valorBaseKWh = 0.74m;
decimal valorConsumido = 0m;
decimal valorDesconto = 0m;
decimal valorCustoExtra = 0m;
decimal valorFinal = 0m;
TipoBandeira tipoBandeira;

Console.Clear();

Console.Write("Digite o nome do cliente: ");
nomeCliente = Console.ReadLine();
while (string.IsNullOrEmpty(nomeCliente))
{
    Console.WriteLine("Nome não pode ser vazio");
    nomeCliente = Console.ReadLine();
}

Console.Clear();

Console.WriteLine("Qual o consumo de kWh por mês: ");
while (!decimal.TryParse(Console.ReadLine(), out consumoMes) || consumoMes < 1)
    Console.WriteLine("O valor nao pode ser convertido ou é invalido");

Console.Clear();

Console.WriteLine("Prezado cliente, este mês estamos operando com a Bandeira Amarela. Lembramos que a Bandeira Verde não gera custos extras; a Amarela gera uma taxa adicional de 5% sobre o valor consumido; e a Vermelha acarreta um adicional de 10%.");

valorConsumido = consumoMes * valorBaseKWh;

Console.WriteLine("Qual a bandeira trabalhada? \n 1 - bandeira amarela, 2 - bandeira verde, 3 - bandeira vermelha");
while(!TipoBandeira.TryParse(Console.ReadLine(), out tipoBandeira)) 
    Console.WriteLine("O valor digitado é invalido ou não pode ser convertido");

switch (tipoBandeira)
{
    case TipoBandeira.Amarela:
        valorCustoExtra += valorConsumido * 0.05m;
    break;

    case TipoBandeira.Verde:
        valorCustoExtra += valorConsumido * 0m;
    break;

    case TipoBandeira.Vermelha:
        valorCustoExtra += valorConsumido * 0.10m;
    break;
}

if (consumoMes < 200)
    valorDesconto = valorConsumido * 0.08m;

valorFinal = (valorConsumido + valorCustoExtra) - valorDesconto;

Console.Write("=== FATURA === ");
Console.Write($"Cliente: {nomeCliente} ");
Console.Write($"Subtotal: Bandeira: {tipoBandeira}: {valorConsumido:C} ");
Console.Write($"Valor do acréscimo: {valorCustoExtra:C} ");
Console.Write($"Valor do desconto: {valorDesconto:C}  ");
Console.Write($"Total a pagar: {valorFinal:C} ");

enum TipoBandeira
{
    Amarela = 1,
    Verde = 2,
    Vermelha = 3 
}
