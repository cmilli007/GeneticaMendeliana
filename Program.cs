using System;
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os alelos do primeiro indivíduo (A ou a): ");
        char alelo1 = char.ToUpper(Console.ReadKey().KeyChar);
 
        Console.WriteLine("\nDigite os alelos do segundo indivíduo (A ou a): ");
        char alelo2 = char.ToUpper(Console.ReadKey().KeyChar);
 
        Console.WriteLine("\nEscolha o tipo de dominância (1 para completa, 2 para incompleta): ");
        int dominanciaType = int.Parse(Console.ReadLine());
 
        double probabilidade = CalcularProbabilidade(alelo1, alelo2, dominanciaType);
 
        Console.WriteLine($"\nA probabilidade da característica se manifestar nos descendentes é: {probabilidade:P}");
    }
 
    static double CalcularProbabilidade(char alelo1, char alelo2, int dominanciaType)
    {
        if (dominanciaType == 1)
        {
            // Dominância completa
            if ((alelo1 == 'A' && alelo2 == 'a') || (alelo1 == 'a' && alelo2 == 'A'))
            {
                return 0.0; // Característica só ocorre em indivíduos aa
            }
            else
            {
                return 1.0; // Característica ocorre em todos os descendentes
            }
        }
        else if (dominanciaType == 2)
        {
            // Dominância incompleta
            if (alelo1 == 'A' && alelo2 == 'a' || alelo1 == 'a' && alelo2 == 'A')
            {
                return 0.5; // Característica ocorre em 50% dos descendentes (Aa)
            }
            else if ((alelo1 == 'A' && alelo2 == 'A') || (alelo1 == 'a' && alelo2 == 'a'))
            {
                return 0.0; // Característica só ocorre em indivíduos aa ou AA
            }
            else
            {
                return 1.0; // Característica ocorre em todos os descendentes (Aa)
            }
        }
        else
        {
            Console.WriteLine("Opção inválida para tipo de dominância.");
            return 0.0;
        }
    }
}