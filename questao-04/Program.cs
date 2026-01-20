int numero1 = int.Parse(Console.ReadLine());
int numero2 = int.Parse(Console.ReadLine());
int numero3 = int.Parse(Console.ReadLine());

if (numero3 > numero2)
    numero2 = numero3;

if (numero2 > numero1)
    numero1 = numero2;

Console.WriteLine($"O maior número é: {numero1}");
