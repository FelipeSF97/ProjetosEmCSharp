using CalculadoraExemplo.Models;

Calculadora calc = new Calculadora();

int num1, num2, ang;

Console.WriteLine("Qual operação você deseja fazer?");
Console.WriteLine("Digite:");
Console.WriteLine("[1] para soma");
Console.WriteLine("[2] para subtração");
Console.WriteLine("[3] para multiplicação");
Console.WriteLine("[4] para divisão");
Console.WriteLine("[5] para potência");
Console.WriteLine("[6] para seno");
Console.WriteLine("[7] para coseno");
Console.WriteLine("[8] para tangente");
Console.WriteLine("[9] para raiz quadrada");
string? option = Console.ReadLine();
if(option == "1" || option == "2" || option == "3" || option == "4" || option == "5"){
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToInt16(Console.ReadLine());
    calc.getX(num1);
    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToInt16(Console.ReadLine());
    calc.getY(num2);
    if(option == "1"){
        Console.WriteLine(calc.somar(num1, num2));
    }else if(option ==  "2"){
        Console.WriteLine(calc.subtrair(num1, num2));
    }else if(option ==  "3"){
        Console.WriteLine(calc.multiplicar(num1, num2));
    }else if(option ==  "4"){
        Console.WriteLine(calc.dividir(num1, num2));
    }else if(option ==  "5"){
        Console.WriteLine(calc.potencia(num1, num2));
    }
}else if(option == "6" || option == "7" || option == "8"){
    Console.WriteLine("Digite o ângulo: ");
    ang = Convert.ToInt16(Console.ReadLine());
    calc.getAngulo(ang);
    if(option == "6"){
        Console.WriteLine(calc.seno(ang));
    }else if(option == "7"){
        Console.WriteLine(calc.conseno(ang));
    }else if(option == "8"){
        Console.WriteLine(calc.tangente(ang));
    }
}else if(option == "9"){
    Console.WriteLine("Digite o número: ");
    num1 = Convert.ToInt16(Console.ReadLine());
    calc.getX(num1);
    Console.WriteLine(calc.raizQuadrada(num1));
}else{
    Console.WriteLine("Opção inválida!!!");
}