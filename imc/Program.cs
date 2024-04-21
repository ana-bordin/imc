// 6.faça um programa que leia o peso, altura e sexo e calcule o IMC informando a situação da pessoa;
/*
IMC = peso / altura^2
Menor que 18,5 - Baixo peso
De 18,5 a 24,9 - Peso normal
De 25 a 29,9 - Sobrepeso
De 30 a 34,9 - Obesidade grau I
De 35 a 39.9 - Obesidade grau II
Igual ou maior que 40 - Obesidade grau III
*/
int res = 0;
double altura, peso, imc;
string sexo;
bool valido;

Console.WriteLine("Calculadora IMC");

do
{
    altura = 0;
    peso = 0;
    imc = 0;
    sexo = null;
    valido = false; 

    while (altura <= 0 || altura > 2.60)
    {
        Console.WriteLine("Digite sua altura, EM METROS, usando virgula:");
        altura = double.Parse(Console.ReadLine());
    }

    while (peso <= 0)
    {
        Console.WriteLine("Digite seu peso em quilos, usando virgula:");
        peso = double.Parse(Console.ReadLine());
    }

    while (valido != true)
    {
        Console.WriteLine("Informe seu sexo com letra minuscula:\nf - feminino;\nm - masculino; \no - outro;");
        sexo = Console.ReadLine();
        if (sexo == "f" || sexo == "m" || sexo == "o")
        {
            valido = true;
        }
    }

    imc = peso / Math.Pow(altura, 2);

    if (imc <= 18.5)
    {
        Console.WriteLine($"Seu IMC é de: {imc},\nvocê está abaixo do peso;");
    }
    else if (imc > 18.5 && imc <= 24.9)
    {
        Console.WriteLine($"Seu IMC é de: {imc},\nvocê está no peso ideal;;");
    }
    else if (imc > 24.9 && imc <= 29.9)
    {
        Console.WriteLine($"Seu IMC é de: {imc},\nvocê está em sobrepeso;");
    }
    else if (imc > 29.9 && imc <= 34.9)
    {
        Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau I;");
    }
    else if (imc > 34.9 && imc <= 39.9)
    {
        Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau II;");
    }
    else
    {
        Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau III;");
    }

    Console.WriteLine("Deseja fazer outro IMC?\nPara continuar digite 0;\nPara parar digite qualquer outro número:");
    res = int.Parse(Console.ReadLine());
} while (res == 0)