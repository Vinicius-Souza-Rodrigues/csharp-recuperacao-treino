List<string> listaItensNome = ["Mouse", "Teclado", "Monitor", "Cabo HDMI", "Cadeira"];
List<int> listaItensQuantidades = [10, 6, 4, 18, 5];

string quantidadeItem = "";
string nomeProduto = "";

int quantidadeItensEstoqueBaixo = 0;
bool existeWebcam = false;
int quantidadeItemConvertido = 0;

Console.WriteLine("=== ESTOQUE INICIAL ===");
ListarItens();

Console.WriteLine("=== OPERAÇÕES ===");

while (true)
{
    Console.WriteLine("Digite o nome do produto que vai ser adicionado: ");
    nomeProduto = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomeProduto))
        Console.WriteLine("O nome inserido não pode ser convertido ou é invalido");
    else
        break;
}

while (true)
{
    Console.WriteLine($"Digite a quantidade do {nomeProduto} que vai ser adicionado: ");
    quantidadeItem = Console.ReadLine();

    if (!int.TryParse(quantidadeItem, out quantidadeItemConvertido) || quantidadeItemConvertido < 1)
        Console.WriteLine("O valor não pode ser convertido ou o numero inserido é invalido");
    else
        break;
}

bool itemExisteNaLista = true;

for (int x = 0; x < listaItensNome.Count; x++)
{
    if (listaItensNome[x] == nomeProduto) {
        listaItensQuantidades[x] += quantidadeItemConvertido;
        Console.WriteLine("Produto ja existe e vai ser atualizado");
    }
    else
        itemExisteNaLista = false;
}

if (itemExisteNaLista)
{
    listaItensNome.Add(nomeProduto);
    listaItensQuantidades.Add(quantidadeItemConvertido);
}

Console.WriteLine($"Adicionado: {nomeProduto} ({quantidadeItemConvertido})");

while (true)
{
    Console.WriteLine("Digite o nome do produto que vai ser atualizado: ");
    nomeProduto = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomeProduto))
        Console.WriteLine("O nome inserido não pode ser convertido ou é invalido");
    else
        break;
}

while(true)
{
    Console.WriteLine("Digite a quantidade de itens: ");
    quantidadeItem = Console.ReadLine();

    if (!int.TryParse(quantidadeItem, out quantidadeItemConvertido) || quantidadeItemConvertido < 1)
        Console.WriteLine("O valor não pode ser convertido ou o numero inserido é invalido");
    else
        break;
}

for (int x = 0; x < listaItensNome.Count; x++)
{
    if (listaItensNome[x] == nomeProduto)
        listaItensQuantidades[x] += quantidadeItemConvertido;
    else
        itemExisteNaLista = false;
}

if (!itemExisteNaLista)
    Console.WriteLine($"{nomeProduto} foi procurado e n foi achado");

Console.WriteLine($"Atualizado: {nomeProduto} ({quantidadeItemConvertido})");

while (true)
{
    Console.WriteLine("Digite o nome do produto que vai ser verificado: ");
    nomeProduto = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomeProduto))
        Console.WriteLine("O nome inserido não pode ser convertido ou é invalido");
    else
        break;
}

if (listaItensNome.Contains(nomeProduto))
    existeWebcam = true;
else
    existeWebcam = false;

Console.WriteLine($"Existe Webcam?: {(existeWebcam? "Sim" : "Não")}");

for(int i = 0; i < listaItensNome.Count; i++)
{
    if (listaItensQuantidades[i] <= 8)
        quantidadeItensEstoqueBaixo++;
}

Console.WriteLine($"Estoque baixo (<8): {quantidadeItensEstoqueBaixo}");

while (true)
{
    Console.WriteLine("Digite o nome do produto que vai ser excluido: ");
    nomeProduto = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomeProduto))
        Console.WriteLine("O nome inserido não pode ser convertido ou é invalido");
    else
        break;
}


for (int i = 0; i < listaItensNome.Count; i++)
{
    if (listaItensNome[i] == nomeProduto) {
        listaItensNome.RemoveAt(i);
        listaItensQuantidades.RemoveAt(i);
    }
}

Console.WriteLine($"Removido: {nomeProduto}");

Console.WriteLine("=== ESTOQUE FINAL ===");
ListarItens();

Console.WriteLine($"Total de produtos: {listaItensNome.Count}");

void ListarItens()
{
    for (int i = 0; i < listaItensNome.Count; i++)
    {
        Console.WriteLine($"Produto {i + 1}: {listaItensNome[i]}");
        Console.WriteLine($"Quantidade: {listaItensQuantidades[i]}\n");
    }
}
