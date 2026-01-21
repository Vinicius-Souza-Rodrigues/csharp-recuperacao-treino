string nomeCliente = "";
decimal rendaMensal = 0m;
int scoreCredito = 0;
int scoreMinimo = 650;
decimal limiteCredito = 0m;
DateTime dataAtual = DateTime.Now;
DateTime dataInicio;
TimeSpan diferencaDataEmpregada = 0;

if (rendaMensal >= 4000 || (rendaMensal >= 2800 && diferencaDataEmpregada >= 6))
    limiteCredito = 0.40;

else if (rendaMensal >= 2000 && scoreCredito <= scoreMinimo && diferencaDataEmpregada >= 10)
    limiteCredito = 0.25;
    
else
    limiteCredito = 0;
