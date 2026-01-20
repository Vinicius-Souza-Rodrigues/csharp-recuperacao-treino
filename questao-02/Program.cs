int caragaHorariaPadrao = 160;
int cargaHorariaExtra = 0;
decimal valorFixoHorarioExtra = 25m;
string classificacaoDesempenho = "";
decimal taxaComissao = 0m;

Console.WriteLine("Digite o nome do vendedor: ");
string nomeVendedor = Console.ReadLine();
Console.WriteLine("Digite a quantidade de vendas: ");
int quantidadeVendasRealizadas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de faturamento bruto: ");
decimal quantidadeFaturamentoBruto = decimal.Parse(Console.ReadLine());
Console.WriteLine("Carga horaria trabalhada no mes: ");
int quantidadeHorasTrabalhadas = int.Parse(Console.ReadLine());

decimal valorMedioPorVenda = quantidadeFaturamentoBruto / quantidadeVendasRealizadas;

if (quantidadeHorasTrabalhadas > caragaHorariaPadrao)
    cargaHorariaExtra = quantidadeHorasTrabalhadas - caragaHorariaPadrao;

decimal valorTotalHorarioExtra = cargaHorariaExtra * valorFixoHorarioExtra;

if (quantidadeFaturamentoBruto >= 9000 && valorMedioPorVenda >= 500)
    classificacaoDesempenho = "Excelente";

else if (quantidadeFaturamentoBruto >= 7000)
    classificacaoDesempenho = "Bom";

else if (quantidadeFaturamentoBruto >= 4000)
    classificacaoDesempenho = "Regular";

else 
    classificacaoDesempenho = "Insatisfatoria";

if (classificacaoDesempenho == "Excelente")
    taxaComissao = 0.12m;
else if (classificacaoDesempenho == "Bom")
    taxaComissao = 0.08m;

else if (classificacaoDesempenho == "Regular")
    taxaComissao = 0.05m;

else
    taxaComissao = 0m;

decimal valorComissao = quantidadeFaturamentoBruto * taxaComissao;

decimal valorTotal = valorComissao + valorTotalHorarioExtra;

Console.WriteLine("=== RELATÓRIO DE DESEMPENHO DO VENDEDOR ===");
Console.WriteLine($"Vendedor: {nomeVendedor}");
Console.WriteLine();
Console.WriteLine("DADOS DE VENDAS");
Console.WriteLine($"Quantidade de Vendas: {quantidadeVendasRealizadas}");
Console.WriteLine($"Faturamento Bruto: {quantidadeFaturamentoBruto:C}");
Console.WriteLine($"Horas Trabalhadas: {quantidadeHorasTrabalhadas}");
Console.WriteLine($"Horas Extras: {cargaHorariaExtra}");
Console.WriteLine();
Console.WriteLine("CÁLCULOS");
Console.WriteLine($"Valor Médio por Venda: {valorMedioPorVenda:C}");
Console.WriteLine($"Total Horas Extras: {cargaHorariaExtra}");
Console.WriteLine($"Comissão: {valorComissao:C}");
Console.WriteLine();
Console.WriteLine("RESULTADO FINAL");
Console.WriteLine($"Classificação: {classificacaoDesempenho}");
Console.WriteLine($"Valor Total a Receber: {valorTotal:C}");
