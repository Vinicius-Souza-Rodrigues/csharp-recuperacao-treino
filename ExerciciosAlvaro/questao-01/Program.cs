string nomeProduto = "";
string precoUnitario = "";
string quantidadeProdutos = "";
string respostaPromocao = "";
string respostaPromocaoConvertido = "";

decimal precoUnitarioConvertido = 0m;
int quantidadeProdutosConvertido = 0;

decimal subtotal = 0m;
decimal freteAplicado = 35m;
decimal desconto = 0.12m;
bool promocaoProduto = false;
decimal precoDesconto = 0m;
decimal precoTotal = 0m;

while (true)
{
    Console.WriteLine("Digite o nome do produto: ");
    nomeProduto = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomeProduto))
        Console.WriteLine("Produto não pode possuir espaços ou ser nulo");
    else
        break;
}

while (true)
{
    Console.WriteLine("Digite o preço unitário do produto: ");
    precoUnitario = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(precoUnitario) 
    || !decimal.TryParse(precoUnitario, out precoUnitarioConvertido) 
    || precoUnitarioConvertido <= 0)
        Console.WriteLine("O preço nao pode ser convertido ou é invalido");
    else
        break;
}

while (true)
{
    Console.WriteLine("Digite a quantidade de produtos que será levado: ");
    quantidadeProdutos = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(quantidadeProdutos) 
    || !int.TryParse(quantidadeProdutos, out quantidadeProdutosConvertido) 
    || quantidadeProdutosConvertido <= 0)
        Console.WriteLine("Nao foi possivel converter ou o valor está invalido");
    else
        break;
}

while (true)
{
    Console.WriteLine("Digite 'sim' se o produto estiver em promoção ou 'nao' se nao estiver: ");
    respostaPromocao = Console.ReadLine().ToLower;

    if (respostaPromocao == "sim" || respostaPromocao == "s" || respostaPromocao == "ss")
    {
        promocaoProduto = true;
        break;
    }
    else if (respostaPromocao == "nao" || respostaPromocao == "n" || respostaPromocao == "nn")
    {
        promocaoProduto = false;
        break;
    }
    else
        Console.WriteLine("Digite uma opçao valida");
}

subtotal = precoUnitarioConvertido * quantidadeProdutosConvertido;

if (subtotal >= 800)
    freteAplicado = 0;

if (promocaoProduto)
    precoDesconto = subtotal * desconto;

precoTotal = subtotal - precoDesconto + freteAplicado;

Console.WriteLine("=== FECHAMENTO DE COMPRA ===");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço Unitário: {precoUnitarioConvertido:C}");
Console.WriteLine($"Quantidade: {quantidadeProdutosConvertido}");
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Promoção ativa: {promocaoProduto}");
if (precoDesconto)
    Console.WriteLine($"Desconto: {precoDesconto:C}");
Console.WriteLine($"Frete: {(freteAplicado == 0 ? "Grátis" : freteAplicado)}");
Console.WriteLine($"Valor Total: {precoTotal:C}");
