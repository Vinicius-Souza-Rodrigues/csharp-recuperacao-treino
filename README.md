Questão 6 – Controle de Desempenho de Funcionário

Uma empresa de tecnologia realiza avaliações mensais de desempenho de seus funcionários para definir bônus e feedbacks internos. O sistema recebe dados básicos de produtividade e precisa calcular corretamente os indicadores de desempenho, garantindo clareza e precisão nos resultados apresentados.

O funcionário avaliado neste mês é Carlos Pereira. Ele trabalhou 22 dias no mês, realizou 176 horas trabalhadas, recebeu 8 horas extras, e possui um salário base mensal de R$ 3.200,00.

A empresa possui regras claras para pagamento de horas extras, cálculo de produtividade e classificação de desempenho.

Regras do Sistema
1. Cálculo de Valor Hora

A jornada mensal padrão é de 160 horas

Valor da hora normal = salário base / 160

Hora extra vale 50% a mais que a hora normal

2. Produtividade

Média diária de horas = horas trabalhadas / dias trabalhados

Se média ≥ 8 horas → produtividade Alta

Se média ≥ 6 horas → produtividade Média

Se média < 6 horas → produtividade Baixa

3. Classificação de Desempenho

Se produtividade Alta e horas extras ≤ 10 → Excelente

Se produtividade Alta e horas extras > 10 → Boa

Se produtividade Média → Regular

Se produtividade Baixa → Insatisfatória

4. Bônus

Excelente → bônus de 20% do salário base

Boa → bônus de 10% do salário base

Regular → bônus de 5% do salário base

Insatisfatória → sem bônus

Tarefas

Declare e inicialize todas as variáveis com nomes descritivos

Calcule:

Valor da hora normal

Valor da hora extra

Total recebido por horas extras

Média diária de horas trabalhadas

Valor do bônus (se houver)

Determine produtividade e classificação de desempenho

Calcule o salário final (salário base + horas extras + bônus)

Exiba todas as informações de forma clara e bem formatada

Saída Esperada
=== AVALIAÇÃO DE DESEMPENHO ===
Funcionário: Carlos Pereira

DADOS DE TRABALHO
Dias Trabalhados: <valor>
Horas Trabalhadas: <valor>
Horas Extras: <valor>

CÁLCULOS
Valor Hora Normal: R$ <valor>
Valor Hora Extra: R$ <valor>
Total Horas Extras: R$ <valor>
Média Diária de Horas: <valor>

RESULTADOS
Produtividade: <Alta/Média/Baixa>
Classificação: <Excelente/Boa/Regular/Insatisfatória>
Bônus: R$ <valor>

SALÁRIO FINAL
Salário Base: R$ <valor>
Salário Final: R$ <valor>


---------------------------------------------------------------------------------------------------

Questão 7 – Avaliação de Desempenho de Vendas do Vendedor

Uma loja de eletrodomésticos avalia mensalmente o desempenho de seus vendedores para definir comissões e classificação de desempenho. O sistema recebe informações básicas sobre as vendas realizadas e deve calcular corretamente os valores e exibir um relatório completo.

O vendedor avaliado neste mês é Mariana Costa.
Ela realizou 18 vendas, totalizando R$ 9.600,00 em faturamento bruto.
A carga de trabalho mensal considerada padrão é de 160 horas, e Mariana trabalhou 168 horas no mês.

Regras do Sistema
1. Cálculo de Valor Médio por Venda

Valor médio = faturamento bruto / quantidade de vendas

2. Horas Extras

Horas extras = horas trabalhadas − 160

Cada hora extra gera um adicional fixo de R$ 25,00

3. Classificação de Desempenho

Excelente

Faturamento ≥ R$ 9.000 E valor médio por venda ≥ R$ 500

Bom

Faturamento ≥ R$ 7.000

Regular

Faturamento ≥ R$ 4.000

Insatisfatório

Faturamento < R$ 4.000

(A primeira regra válida deve ser aplicada)

4. Comissão

Excelente → comissão de 12% sobre o faturamento

Bom → comissão de 8%

Regular → comissão de 5%

Insatisfatório → sem comissão

Tarefas

Declare e inicialize todas as variáveis com nomes descritivos

Calcule:

Valor médio por venda

Total recebido por horas extras

Valor da comissão

Determine a classificação de desempenho

Calcule o valor final a receber:

comissão + valor horas extras

Exiba todas as informações de forma clara e bem formatada

Saída Esperada
=== RELATÓRIO DE DESEMPENHO DO VENDEDOR ===
Vendedor: <nome>

DADOS DE VENDAS
Quantidade de Vendas: <valor>
Faturamento Bruto: R$ <valor>
Horas Trabalhadas: <valor>
Horas Extras: <valor>

CÁLCULOS
Valor Médio por Venda: R$ <valor>
Total Horas Extras: R$ <valor>
Comissão: R$ <valor>

RESULTADO FINAL
Classificação: <Excelente/Bom/Regular/Insatisfatório>
Valor Total a Receber: R$ <valor>

---------------------------------------------------------------------------------------------------

🧠 QUESTÃO – PROVA DE RECUPERAÇÃO (NÍVEL DIFÍCIL)

Uma empresa deseja desenvolver um sistema que avalie o desempenho mensal de seus funcionários vendedores.

O sistema deve permitir o cadastro de N vendedores, onde N é informado pelo usuário.

🔹 Para cada vendedor, o sistema deve solicitar:

Nome do vendedor

Quantidade de dias trabalhados no mês

Quantidade total de horas trabalhadas

Quantidade de vendas realizadas

Faturamento bruto mensal

🔹 Regras de cálculo
1️⃣ Jornada de trabalho

Carga horária padrão: 160 horas

Hora extra: R$ 25,00 por hora excedente

2️⃣ Média diária de horas
média diária = horas trabalhadas / dias trabalhados


≥ 8 → Produtividade Alta

≥ 6 → Produtividade Média

< 6 → Produtividade Baixa

3️⃣ Classificação de desempenho

A classificação depende da produtividade e do faturamento:

Produtividade	Faturamento	Classificação
Alta	≥ 9000	Excelente
Alta	≥ 7000	Boa
Média	≥ 4000	Regular
Qualquer	< 4000	Insatisfatória
4️⃣ Comissão

Excelente → 12%

Boa → 8%

Regular → 5%

Insatisfatória → 0%

5️⃣ Valor total a receber
total = comissão + valor horas extras

🔹 O programa DEVE:

Utilizar for para cadastrar os vendedores

Utilizar List<T> para armazenar:

nomes

classificação

valor total a receber

Calcular tudo dentro do laço

Exibir ao final um relatório com todos os vendedores

📌 RELATÓRIO FINAL (OBRIGATÓRIO)
=== RELATÓRIO GERAL ===
Vendedor: João
Classificação: Excelente
Total a Receber: R$ xxxx,xx

Vendedor: Maria
Classificação: Regular
Total a Receber: R$ xxxx,xx