string nomeCliente = "";
string possuiCupom = "";
decimal quantidadeDescontoCupom = 0;
decimal descontoFormaPagamento = 0;
bool possuiCupomConvertido = false;
decimal valorCompra;
string pagamentoParcelado = "";
bool pagamentoParceladoConvertido = false;
int quantidadeParcelas = 0;
decimal valorDesconto = 0;
decimal valorTotal = 0;
decimal valorParcela = 0;
FormaPagamento formaPagamento;

Console.Clear();

while (true)
{
    Console.WriteLine("Digite o nome do cliente: ");
    nomeCliente = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(nomeCliente))
        Console.WriteLine("Nome invalido ou vazio");
    else
        break;

}

// while (string.IsNullOrEmpty(nomeCliente))
// {
//     System.Console.WriteLine("Nome não pode ser vazio");
//     nomeCliente = Console.ReadLine();
// }


Console.Clear();

Console.WriteLine("Digite o valor da compra: ");
while (!decimal.TryParse(Console.ReadLine(), out valorCompra) || valorCompra < 1)
    Console.WriteLine("Valor digitado invalido");

Console.Clear();

Console.WriteLine("Digite a opção de pagamento:\n 1 - PIX, 2 - Crédito, 3 - Debito, 4 - Dinheiro");
while (!FormaPagamento.TryParse(Console.ReadLine(), out formaPagamento))
    Console.WriteLine("Valor não pode ser convertido");

Console.Clear();

Console.WriteLine("Possui algum cupom: - sim / nao ");
while (true)
{
    possuiCupom = Console.ReadLine().ToLower();

    if (possuiCupom.Equals("sim") || possuiCupom.Equals("s"))
    {
        possuiCupomConvertido = true;
        break;
    }
    else if (possuiCupom.Equals("nao") || possuiCupom.Equals("n"))
    {
        possuiCupomConvertido = false;
        break;
    }
    else
        Console.WriteLine("Digite uma opcão valida");

}

if (possuiCupomConvertido)
    quantidadeDescontoCupom -= valorCompra * 0.10m;

switch (formaPagamento)
{
    case FormaPagamento.Dinheiro:
        descontoFormaPagamento -= valorCompra * 0.05m;
        break;

    case FormaPagamento.Pix:
        descontoFormaPagamento -= valorCompra * 0.03m;
        break;

    case FormaPagamento.Debito:
        descontoFormaPagamento = valorCompra * 0m;
        break;

    case FormaPagamento.Credito:
        descontoFormaPagamento += valorCompra * 0.05m;
        break;
}

valorDesconto = quantidadeDescontoCupom + descontoFormaPagamento;
valorTotal = valorCompra + valorDesconto;

if (formaPagamento.Equals(FormaPagamento.Credito))
{
    Console.WriteLine("O pagamento será efetuado a vista? - sim / nao");

    while (true)
    {
        pagamentoParcelado = Console.ReadLine().ToLower();

        if (pagamentoParcelado.Equals("sim") || pagamentoParcelado.Equals("s"))
        {
            pagamentoParceladoConvertido = true;
            break;
        }
        else if (pagamentoParcelado.Equals("nao") || pagamentoParcelado.Equals("n"))
        {
            pagamentoParceladoConvertido = false;
            break;
        }
        else
            Console.WriteLine("Digite uma opcão valida");
    }

    if (!pagamentoParceladoConvertido)
    {
        Console.WriteLine("Em quantas parcelas será efetuado a venda?: max: 12");
        while (!int.TryParse(Console.ReadLine(), out quantidadeParcelas) || quantidadeParcelas < 1 || quantidadeParcelas > 12)
            Console.WriteLine("A quantidade de parcelas é invalida ou não pode ser convertida");

        valorParcela = valorTotal / quantidadeParcelas;
    }
}

Console.WriteLine("=== COMPRA ONLINE ===");
Console.WriteLine($"Cliente: {nomeCliente}\n");
Console.WriteLine($"CALCULO");
Console.WriteLine($"Valor original: {valorCompra:C}");
Console.WriteLine($"Cupom: {(possuiCupomConvertido ? "Sim" : "Não")}");
Console.WriteLine($"Ajuste pagamento: {valorDesconto:C}");
Console.WriteLine($"Valor final: {valorTotal:C}");
Console.WriteLine($"Pagamento: {formaPagamento}");
Console.WriteLine($"Tipo: {(pagamentoParceladoConvertido ? "" : "À vista")}");
if (!pagamentoParceladoConvertido)
    Console.WriteLine($"Parcela: {valorParcela:C}");
enum FormaPagamento
{
    Pix = 1,
    Dinheiro = 4,
    Credito = 3,
    Debito = 2
}
