Console.Clear();

double nota1, nota2, nota3, nota4, notafinal;
string situacao;

Console.Write("Qual a primeira nota? ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual a segunda nota? ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual a terceira nota? ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual a quarta nota? ");
nota4 = Convert.ToDouble(Console.ReadLine());

notafinal = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine();

if (nota1 < 0 || nota1 > 10
 || nota2 < 0 || nota2 > 10
 || nota3 < 0 || nota3 > 10
 || nota4 < 0 || nota4 > 10)

 {

Console.WriteLine("Por favor, apenas digite números entre 0 e 10");

 }

 else

 {

 if (notafinal < 5)
    {
        situacao = "Reprovado";
    }

    else 

    if (notafinal > 6)

    {
        situacao = "Aprovado";
    }

    else

    {
    
        situacao = "Em recuperação";
    }

Console.WriteLine($"Sua média: {notafinal:N1}. Situação: {situacao}.");
 }
