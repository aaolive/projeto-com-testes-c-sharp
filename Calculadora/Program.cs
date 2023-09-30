using Calculadora.Services;

CalculadoraCodigo calc =new CalculadoraCodigo();

int valor1 = 12;
int valor2 = 11;

Console.WriteLine($"Soma do valores {valor1} e {valor2}: {calc.Somar(valor1,valor2 )}");