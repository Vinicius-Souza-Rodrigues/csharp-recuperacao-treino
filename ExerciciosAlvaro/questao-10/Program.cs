string nomeFuncionario;
decimal salarioBruto ;
decimal horasExtras;
decimal valorHoraExtra;
int valeTransporte;
bool valeTransporteCovertido = false;
decimal calculoBruto;
decimal valorInss;
decimal valorValeTransporte = 0;
decimal valorLiquido;
decimal valorTotalHorasExtras;

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


calculoBruto = salarioBruto + valorTotalHorasExtras;

valorInss = calculoBruto * 0.08m;

if (valeTransporte == 1) {
    valeTransporteCovertido = true;
    valorValeTransporte = calculoBruto * 0.06m;
}

valorLiquido = calculoBruto - valorInss - valorValeTransporte;


Console.WriteLine("=== FOLHA DE PAGAMENTO ===");
Console.WriteLine($"Bruto Total: {calculoBruto:C}");
Console.WriteLine($"Horas Extras: {horasExtras}");
Console.WriteLine($"valor horas extras: {valorHoraExtra:C}");
Console.WriteLine($"INSS: {valorInss:C}");
if (valeTransporteCovertido)
    Console.WriteLine($"Vale Transporte: {valorValeTransporte:C}");
Console.WriteLine($"Liquido a Receber: {valorLiquido:C}");
