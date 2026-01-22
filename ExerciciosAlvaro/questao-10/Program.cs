string nomeFuncionario = "";
decimal salarioBruto = 0m;
decimal horasExtras = 0m;
decimal valorHoraExtra = 0m;
int valeTransporte = 0;
bool valeTransporteCovertido = false;
decimal calculoBruto = 0m;
decimal valorInss = 0m;
decimal valorValeTransporte = 0m;
decimal valorLiquido = 0m;
decimal valorTotalHorasExtras = 0m;

Console.WriteLine("Digite o nome do funcionario: ");
nomeFuncionario = Console.ReadLine();
while (string.IsNullOrEmpty(nomeFuncionario))
{
    Console.WriteLine("Nome não pode ser vazio");
    nomeFuncionario = Console.ReadLine();
}

Console.WriteLine("Digite o salário bruto: ");
while (!decimal.TryParse(Console.ReadLine(), out salarioBruto) || salarioBruto < 0)
    Console.WriteLine("valor invalido ou não pode ser convertido");

Console.WriteLine("Digite as horas extras trabalhadas: ");
while (!decimal.TryParse(Console.ReadLine(), out horasExtras) || horasExtras < 0)
    Console.WriteLine("valor invalido ou não pode ser convertido");

Console.WriteLine("Digite o valor da hora extra: ");
while (!decimal.TryParse(Console.ReadLine(), out valorHoraExtra) || valorHoraExtra < 0)
    Console.WriteLine("valor invalido ou não pode ser convertido");

Console.WriteLine("Existe vale transporte?: 1 - Sim | 2 - Não ");
while (!int.TryParse(Console.ReadLine(), out valeTransporte))
    Console.WriteLine("valor invalido ou não pode ser convertido");

valorTotalHorasExtras = horasExtras * valorHoraExtra;

if (valeTransporte == 1)
    valeTransporteCovertido = true;
else
    valeTransporteCovertido = false;

calculoBruto = salarioBruto + valorTotalHorasExtras;
  
valorInss = calculoBruto * 0.08m;

valorValeTransporte = calculoBruto * 0.06m;

valorLiquido = calculoBruto - valorInss - valorValeTransporte;


Console.WriteLine("=== FOLHA DE PAGAMENTO ===");
Console.WriteLine($"Bruto Total: {calculoBruto:C}");
Console.WriteLine($"Horas Extras: {horasExtras}");
Console.WriteLine($"valor horas extras: {valorHoraExtra:C}");
Console.WriteLine($"INSS: {valorInss:C}");
if (valeTransporteCovertido)
    Console.WriteLine($"Vale Transporte: {valorValeTransporte:C}");
Console.WriteLine($"Liquido a Receber: {valorLiquido:C}");
