int quantidadePedidos;
string nomeCliente;
decimal valorPedido;
int formaPagamentoOpcao;
decimal valorDesconto = 0;
decimal valorTotal;
int quantidadePagamentoDinheiro = 0;
int quantidadePagamentoPIX = 0;
int quantidadePagamentoCredito = 0;
int quantidadePagamentoDebito = 0;
FormaPagamento formaPagamento;

List<string> listaNomeProdutos = [];
List<FormaPagamento> listaFormaPagamento = [];
List<decimal> listaValorTotal = [];

Console.WriteLine("Digite a quantidade de vendas no dia: ");
while (!int.TryParse(Console.ReadLine(), out quantidadePedidos) || quantidadePedidos <= 0)
    Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");

for (int i = 0; i < quantidadePedidos; i++)
{
    Console.WriteLine("Digite o nome do produto: ");
    nomeCliente = Console.ReadLine();
    nomeCliente = ValidarString(nomeCliente);

    Console.WriteLine("Digite o valor do pedido: ");
    while (!decimal.TryParse(Console.ReadLine(), out valorPedido) || valorPedido <= 0)
        Console.WriteLine("o valor fornecido é invalido ou não pode ser convertido, tente novamente");

    Console.WriteLine("Digite o número referente a forma de pagamento: 1 - Dinheiro, 2 - PIX, 3 - Debito, 4 - Credito");
    while (!int.TryParse(Console.ReadLine(), out formaPagamentoOpcao) || formaPagamentoOpcao <= 0 || formaPagamentoOpcao > 4)
        Console.WriteLine("o valor fornecido é invalido ou não pode ser convertido");

    formaPagamento = (FormaPagamento)formaPagamentoOpcao;

    switch (formaPagamento)
    {
        case FormaPagamento.Dinheiro:
            valorDesconto = valorPedido * 0.05m;
            valorTotal = valorPedido - valorDesconto;
            quantidadePagamentoDinheiro++;
            break;

        case FormaPagamento.PIX:
            valorDesconto = valorPedido * 0.03m;
            valorTotal = valorPedido - valorDesconto;
            quantidadePagamentoPIX++;
            break;

        case FormaPagamento.Debito:
            valorDesconto = valorPedido * 0;
            valorTotal = valorPedido - valorDesconto;
            quantidadePagamentoDebito++;
            break;

        case FormaPagamento.Credito:
            valorDesconto = valorPedido * 0.05m;
            valorTotal = valorPedido + valorDesconto;
            quantidadePagamentoCredito++;
            break;
    }


    listaNomeProdutos.Add(nomeCliente);
    listaFormaPagamento.Add(formaPagamento);
    listaValorTotal.Add(valorTotal);
}

Console.WriteLine("============= RELATÓRIO DE PEDIDOS =============");
for (int i = 0; i < ContarQuantidadeItensLista(listaNomeProdutos); i++)
{
    Console.WriteLine($"Cliente: {listaNomeProdutos[i]}");
    Console.WriteLine($"Forma de Pagamento: {listaFormaPagamento[i]}");
    Console.WriteLine($"Valor Final: {listaValorTotal[i]:C}");
    Console.WriteLine("---------------------------------------------");
}
Console.WriteLine($"\nPedidos em Dinheiro: {quantidadePagamentoDinheiro}");
Console.WriteLine($"\nPedidos em PIX: {quantidadePagamentoPIX}");
Console.WriteLine($"\nPedidos em Debito: {quantidadePagamentoDebito}");
Console.WriteLine($"\nPedidos em Credito: {quantidadePagamentoCredito}");

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
enum FormaPagamento
{
    Dinheiro = 1,
    PIX = 2,
    Debito = 3,
    Credito = 4,
}
