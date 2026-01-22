string nomeCliente = "";
decimal rendaMensal = 0m;
int scoreCredito = 0;
int scoreMinimo = 650;
decimal limiteCredito = 0m;
bool statusCliente = false;
DateTime dataAtual = DateTime.Today;
DateTime dataInicio;
int diferencaDataEmpregada;


Console.WriteLine("Digite o nome do cliente: ");
nomeCliente = Console.ReadLine();
while (string.IsNullOrEmpty(nomeCliente))
{
    Console.WriteLine("Nome não pode ser vazio");
    nomeCliente = Console.ReadLine();
}

Console.Clear();

Console.WriteLine("Digite a renda mensal do cliente: ");
while (!decimal.TryParse(Console.ReadLine(), out rendaMensal) || rendaMensal < 1)
    Console.WriteLine("Renda mensal não pode ser convertida ou o valor esa incorreto");

Console.Clear();

Console.WriteLine("Digite o número de score que o cliente possui: ");
while (!int.TryParse(Console.ReadLine(), out scoreCredito) || scoreCredito < 1)
    Console.WriteLine("Renda mensal não pode ser convertida ou o valor esa incorreto");

Console.Clear();

Console.WriteLine("Digite a data em que o cliente começou: ");
while (!DateTime.TryParse(Console.ReadLine(), out dataInicio) || dataInicio >= dataAtual)
    Console.WriteLine("O valor digitado é invalido ou não pode ser convertido");

Console.Clear();


diferencaDataEmpregada = (dataAtual.Year - dataInicio.Year) * 12 + (dataAtual.Month - dataInicio.Month);

if (rendaMensal >= 4000 || (rendaMensal >= 2800 && diferencaDataEmpregada >= 6)) {
    limiteCredito = rendaMensal * 0.40m;
    statusCliente = true;
}
else if (rendaMensal >= 2000 && scoreCredito <= scoreMinimo && diferencaDataEmpregada >= 10) {
    limiteCredito = rendaMensal * 0.25m;
    statusCliente = true;
}
else
    limiteCredito = 0m;

Console.Write("=== ANÁLISE DE CRÉDITO === ");
Console.Write($"Cliente: {nomeCliente} ");
Console.Write($"Renda Mensal: {rendaMensal:C} ");
Console.Write($"Score: {scoreCredito} ");
Console.Write($"Tempo de Emprego: {diferencaDataEmpregada:d} meses ");
Console.Write($"Status: {(statusCliente ? "Aprovado" : "Reprovado")} ");
Console.Write($"Limite de Crédito: {(limiteCredito == 0 ? "Não possui limite de créditos" : limiteCredito):C} ");
