# simulacao-prova-1

Questão 1 – Cadastro de Produtos com Validação Completa

Uma loja de eletrônicos está cadastrando produtos no sistema. Cada produto possui nome, preço e quantidade em estoque. O sistema deve permitir o cadastro de 5 produtos, armazenando todas as informações em listas.

Regras de Validação

Nome do produto: não pode ser vazio nem conter números

Preço: deve ser maior que zero

Quantidade: deve ser um número inteiro maior ou igual a zero

Tarefas

Solicite os dados de 5 produtos

Armazene os nomes, preços e quantidades em listas separadas

Valide cada campo antes de aceitar o valor

Calcule:

Valor total em estoque

Produto mais caro

Produto com menor quantidade

Exiba um relatório completo

Saída Esperada
=== RELATÓRIO DE PRODUTOS ===
Produto 1: <nome> | R$ <preço> | <quantidade> unidades
...

Valor total em estoque: R$ <valor>
Produto mais caro: <nome>
Produto com menor estoque: <nome>

Questão 2 – Sistema de Avaliação de Alunos com Listas

Uma escola precisa processar as notas de uma turma com 6 alunos. Para cada aluno, o sistema deve registrar nome, nota 1, nota 2 e nota 3.

Regras de Validação

Nome: obrigatório, apenas letras

Notas: valores entre 0 e 10

Tarefas

Armazene os nomes e notas em listas

Calcule a média de cada aluno

Classifique o aluno:

Média ≥ 7: Aprovado

Média entre 5 e 6.9: Recuperação

Média < 5: Reprovado

Conte quantos alunos estão em cada situação

Exiba o relatório final

Saída Esperada
=== BOLETIM DA TURMA ===
Aluno: <nome>
Notas: <n1>, <n2>, <n3>
Média: <media>
Situação: <status>

Aprovados: <qtd>
Recuperação: <qtd>
Reprovados: <qtd>

Questão 3 – Controle de Vendas com Análise Estatística

Uma loja registrou 10 vendas durante o dia. O sistema deve armazenar os valores em uma lista e gerar um relatório completo.

Regras de Validação

Valor da venda deve ser maior que zero

Tarefas

Leia e valide os 10 valores

Calcule:

Total vendido

Média das vendas

Quantas vendas acima da média

Maior e menor venda

Classifique o dia:

Total > 2000: Excelente

Total entre 1200 e 1999: Bom

Total entre 600 e 1199: Regular

Total < 600: Fraco

Saída Esperada
=== RELATÓRIO DE VENDAS ===
Venda 1: R$ <valor>
...

Total vendido: R$ <total>
Média das vendas: R$ <media>
Vendas acima da média: <qtd>
Maior venda: R$ <maior>
Menor venda: R$ <menor>

Desempenho do dia: <classificação>

Questão 4 – Sistema de Pedidos com Múltiplas Listas

Um restaurante precisa registrar 5 pedidos. Cada pedido possui:

Nome do cliente

Valor do pedido

Forma de pagamento (1 – Dinheiro, 2 – PIX, 3 – Débito, 4 – Crédito)

Regras de Validação

Nome: obrigatório

Valor: maior que zero

Forma de pagamento: apenas opções válidas

Regras de Negócio

Dinheiro: desconto de 5%

PIX: desconto de 3%

Débito: sem desconto

Crédito: acréscimo de 5%

Tarefas

Armazene os dados em listas

Calcule o valor final de cada pedido

Conte quantos pedidos foram feitos por cada forma de pagamento

Exiba o relatório completo

Saída Esperada
=== RELATÓRIO DE PEDIDOS ===
Cliente: <nome>
Forma de Pagamento: <forma>
Valor Final: R$ <valor>

Pedidos em Dinheiro: <qtd>
Pedidos em PIX: <qtd>
Pedidos em Débito: <qtd>
Pedidos em Crédito: <qtd>

Questão 5 – Sistema Completo de Validação de Usuários

Um sistema precisa cadastrar 4 usuários, armazenando:

Nome

Idade

Email

Status (Ativo/Inativo)

Regras de Validação

Nome: obrigatório, apenas letras

Idade: entre 18 e 120

Email: deve conter @ e .

Status: aceitar apenas A (Ativo) ou I (Inativo)

Tarefas

Valide todos os campos

Armazene os dados em listas

Conte:

Quantos usuários ativos

Quantos usuários inativos

Quantos usuários maiores de 30 anos

Exiba o relatório final

Saída Esperada
=== USUÁRIOS CADASTRADOS ===
Nome: <nome>
Idade: <idade>
Email: <email>
Status: <Ativo/Inativo>

Usuários Ativos: <qtd>
Usuários Inativos: <qtd>
Usuários acima de 30 anos: <qtd>

tempo por questao

1 -- 28:35.43

2 -- 23:10.94

3 -- 22:18.33

4 -- 37:04.45

5 -- 56:05.59