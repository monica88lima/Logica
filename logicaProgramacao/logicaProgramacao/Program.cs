// See https://aka.ms/new-console-template for more information
using logicaProgramacao;

Console.WriteLine("Hello, World!");
bool Exercicio20 = ValidParentheses.IsValid("([)]");
Console.WriteLine($"Exercicio 20: {Exercicio20}");
Exercicio20 = ValidParentheses.IsValid("()[]{}");
Console.WriteLine($"Exercicio 20: {Exercicio20}");
Exercicio20 = ValidParentheses.IsValid("([])");
Console.WriteLine($"Exercicio 20: {Exercicio20}");