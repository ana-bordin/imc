// 6.faça um programa que leia o peso, altura e sexo e calcule o IMC informando a situação da pessoa;
/*
IMC = peso / altura^2

mulher
Menor que 19,1 - Baixo peso
De 19,1 a 25,8 - Peso normal
De 25,8 a 27,3 - Sobrepeso
De 27,3 a 31,1 - Obesidade I
De 31,1 a 40 - Obesidade II
Igual ou maior que 40 - Obesidade grau III

homem
Menor que 20,7 - Baixo peso
De 20,7 a 26,4 - Peso normal
De 26,4 a 27,8 - Sobrepeso
De 27,8 a 32,3 - Obesidade I
De 32,3 a 40 - Obesidade II
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
        Console.WriteLine("Informe seu sexo com letra minuscula:\nf - feminino;\nm - masculino;");
        sexo = Console.ReadLine();
        if (sexo == "f" || sexo == "m")
        {
            valido = true;
        }
    }
    // 0.00 -> formatar
    imc = peso / Math.Pow(altura, 2);
    if (sexo == "f")
    {
        if (imc <= 19.1)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está abaixo do peso;");
        }
        else if (imc > 19.1 && imc <= 25.8)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está no peso ideal;;");
        }
        else if (imc > 25.8 && imc <= 27.3)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está em sobrepeso;");
        }
        else if (imc > 27.3 && imc <= 31.1)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau I;");
        }
        else if (imc > 31.1 && imc <= 40)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau II;");
        }
        else
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau III;");
        }
    }
    if (sexo == "m")
    {
        if (imc <= 20.7)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está abaixo do peso;");
        }
        else if (imc > 20.7 && imc <= 26.4)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está no peso ideal;;");
        }
        else if (imc > 26.4 && imc <= 27.8)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está em sobrepeso;");
        }
        else if (imc > 27.8 && imc <= 32.3)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau I;");
        }
        else if (imc > 32.3 && imc <= 40)
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau II;");
        }
        else
        {
            Console.WriteLine($"Seu IMC é de: {imc},\nvocê está com obesidade grau III;");
        }
    }

    Console.WriteLine("Deseja fazer outro IMC?\nPara continuar digite 0;\nPara parar digite qualquer outro número:");
    res = int.Parse(Console.ReadLine());

} while (res == 0);