string nomeUsuario;
int idadeUsuario;
string emailUsuario = "";
char statusItem;
bool statusClienteAtivo = true;
bool emailPossuiArroba = false;
bool emailPossuiPonto = false;
int idadeMinima = 18;
int idadeMaxima = 120;
int quantidadeUsuariosAtivos = 0;
int quantidadeUsuariosInativos = 0;
int quantidadeUsuariosAcima30Anos = 0;
int quantidadeUsuarios;
int IdadeFiltradaEscolhida = 30;

List<string> listaNomeUsuario = [];
List<int> listaIdadeUsuario = [];
List<string> listaEmailUsuario = [];
List<string> listaStatusItem = [];

Console.WriteLine("Digite a quantidade de usuarios que serão digitados: ");
while (!int.TryParse(Console.ReadLine(), out quantidadeUsuarios) || quantidadeUsuarios <= 0)
    Console.WriteLine("A idade digitada é invalida ou não pode ser convertida");

for (int i = 0; i < quantidadeUsuarios; i++)
{
    Console.WriteLine("Digite o nome do cliente: ");
    nomeUsuario = Console.ReadLine();
    nomeUsuario = ValidarString(nomeUsuario);

    Console.WriteLine("Digite a idade do usuario: ");
    while (!int.TryParse(Console.ReadLine(), out idadeUsuario) || idadeUsuario < idadeMinima || idadeUsuario > idadeMaxima)
        Console.WriteLine("A idade digitada é invalida ou não pode ser convertida");

    if (idadeUsuario > IdadeFiltradaEscolhida)
        quantidadeUsuariosAcima30Anos++;

    while (!emailPossuiPonto || !emailPossuiArroba)
    {

        Console.WriteLine("Digite o email do cliente: ");
        emailUsuario = Console.ReadLine();
        emailUsuario = ValidarString(emailUsuario);
        emailPossuiPonto = false;
        emailPossuiArroba = false;

        foreach (char caractere in emailUsuario)
        {
            if (caractere == '@')
                emailPossuiArroba = true;

            if (caractere == '.')
                emailPossuiPonto = true;
        }

        if (!emailPossuiArroba || !emailPossuiPonto)
            Console.WriteLine("O valor digitado deve conter @ e .");
    }

    Console.WriteLine("Digite apenas o status do item, sendo 'a' para Ativo e 'i' para Inativo");
    while (!char.TryParse(Console.ReadLine().ToLower(), out statusItem) || ContemValorAouB(statusItem))
        Console.WriteLine("O valor digitado não é valido ou não pode ser convertido, tente novamente: ");

    if (statusItem == 'i')
    {
        statusClienteAtivo = false;
        quantidadeUsuariosInativos++;
    }
    else
        quantidadeUsuariosAtivos++;

    listaNomeUsuario.Add(nomeUsuario);
    listaIdadeUsuario.Add(idadeUsuario);
    listaEmailUsuario.Add(emailUsuario);
    listaStatusItem.Add(statusClienteAtivo ? "Ativado" : "Inativo");
}

for (int i = 0; i < ContarQuantidadeItensLista(listaNomeUsuario); i++)
{
    Console.WriteLine("=== USUÁRIOS CADASTRADOS ===");
    Console.WriteLine($"Nome: {listaNomeUsuario[i]}");
    Console.WriteLine($"Idade: {listaIdadeUsuario[i]}");
    Console.WriteLine($"Email: {listaEmailUsuario[i]}");
    Console.WriteLine($"Status: {listaStatusItem[i]}\n");
}
Console.WriteLine($"Usuários Ativos: {quantidadeUsuariosAtivos}");
Console.WriteLine($"Usuários Inativos: {quantidadeUsuariosInativos}");
Console.WriteLine($"Usuários acima de 30 anos: {quantidadeUsuariosAcima30Anos}");

string ValidarString(string nome)
{
    while (string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("O valor inserido é invalido ou não pode ser convertido, tente novamente: ");
        nome = Console.ReadLine();
    }
    return nome;
}

bool ContemValorAouB(char letra)
{
    if (letra == 'i' || letra == 'a')
        return false;
    else
        return true;
}

int ContarQuantidadeItensLista<T>(List<T> lista)
{
    int contador = 0;
    foreach (var valor in lista)
        contador++;

    return contador;
}
