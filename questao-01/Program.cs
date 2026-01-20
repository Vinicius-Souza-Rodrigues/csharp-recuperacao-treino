decimal salarioBase = 3200m;
decimal salarioFinal = 0m;
int horasTrabalhadasBase = 160;
int horasTrabalhadasExtras = 0;
string nivelProdutividade = "";
string classificacaoDesempenho = "";

decimal bonusSalario = 0m;
decimal totalHorasExtras = 0m;

Console.WriteLine("Digite o nome do cliente: ");
string nomeFuncionario = Console.ReadLine();
Console.WriteLine("Digite a quantidade de horas trabalhads: ");
int quantidadeHorasTrabalhadas = int.Parse(Console.ReadLine());
Console.WriteLine("Quantidade de dias trabalhados: ");
int quantidadeDiasTrabalhados = int.Parse(Console.ReadLine());

decimal valorHoraNormal = salarioBase / horasTrabalhadasBase ;
decimal valorHoraExtra =  valorHoraNormal * 1.5m;
decimal mediaDiariaHoras = (decimal)quantidadeHorasTrabalhadas / quantidadeDiasTrabalhados;

if (quantidadeHorasTrabalhadas > 160)
    horasTrabalhadasExtras = quantidadeHorasTrabalhadas - 160;

if (mediaDiariaHoras >= 8)
    nivelProdutividade = "Alta";

else if (mediaDiariaHoras >= 6)
    nivelProdutividade = "Media";

else if (mediaDiariaHoras < 6)
    nivelProdutividade = "Baixo";

if (nivelProdutividade == "Alta" && horasTrabalhadasExtras <= 10)
    classificacaoDesempenho = "Excelente";

else if (nivelProdutividade == "Alta" && horasTrabalhadasExtras > 10)
    classificacaoDesempenho = "Boa";

else if (nivelProdutividade == "Media")
    classificacaoDesempenho = "Regular";

else
    classificacaoDesempenho = "Insatisfatoria";

if (classificacaoDesempenho == "Excelente") 
    bonusSalario = salarioBase * 0.20m;
else if (classificacaoDesempenho == "Boa")
    bonusSalario = salarioBase * 0.10m;
else if (classificacaoDesempenho == "Regular")
    bonusSalario = salarioBase * 0.05m;
else
    bonusSalario = 0m;

totalHorasExtras = horasTrabalhadasExtras * valorHoraExtra;
salarioFinal = salarioBase + bonusSalario + totalHorasExtras;

Console.WriteLine("=== AVALIAÇÃO DE DESEMPENHO ===");
Console.WriteLine($"Funcionário: {nomeFuncionario}");
Console.WriteLine();
Console.WriteLine("DADOS DE TRABALHO");
Console.WriteLine($"Dias Trabalhados: {quantidadeDiasTrabalhados}");
Console.WriteLine($"Horas Trabalhadas: {quantidadeHorasTrabalhadas}");
Console.WriteLine($"Horas Extras: {horasTrabalhadasExtras}");
Console.WriteLine();
Console.WriteLine("CÁLCULOS");
Console.WriteLine($"Valor Hora Normal: {valorHoraNormal:C}");
Console.WriteLine($"Valor Hora Extra: {valorHoraExtra:C}");
Console.WriteLine($"Média Diária de Horas: {mediaDiariaHoras}");
Console.WriteLine();
Console.WriteLine("RESULTADOS");
Console.WriteLine($"Produtividade: {nivelProdutividade}");
Console.WriteLine($"Classificação: {classificacaoDesempenho}");
Console.WriteLine($"Bônus: {bonusSalario:C}");
Console.WriteLine();
Console.WriteLine("SALÁRIO FINAL");
Console.WriteLine($"Salário Base: {salarioBase:C}");
Console.WriteLine($"Salário Final: {salarioFinal:C}");
