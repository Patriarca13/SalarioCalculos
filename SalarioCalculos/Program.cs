using System;
using System.Globalization;
using SalarioCalculos;
class Program
{

    static void Main(string[] args)
    {
        Contas contas = new Contas();

        Console.Write("Qual é o seu salario base : ");
        contas.SalarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Qual o desconto do inss: ");
        contas.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Deseja adicionar um bônus percentual? (s/n)");
        char resp = char.Parse(Console.ReadLine());

        if (resp == 's' || resp == 'S')
        {
            Console.WriteLine("Qual a porcentagem do seu bônus: ");
            contas.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        else if (resp == 'n' || resp == 'N')
        {
            Console.WriteLine("Nenhum bônus percentual foi adicionado.");
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine("Quantas linhas  foram montadas esse mes: ");
        contas.StarPlus = int.Parse(Console.ReadLine());
        contas.Fx = int.Parse(Console.ReadLine());
        contas.X30 = int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine("O valor total em bonus foi de R$: " + contas.ValorTotal() + " e o salario total foi R$ : " +
                            contas.SalarioTotal().ToString("F2"));
        Console.WriteLine("O seu salario com o desconto do inss foi: " + contas.SalarioPercentual().ToString("F2"));
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("O seu salario com bônus foi  " + contas.SalarioComPercentual().ToString("F2"));
        Console.WriteLine("-----------------------------------------------------------------------------------------------");









    }




}