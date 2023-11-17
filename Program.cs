Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("\n--Genética Mendeliana--");
Console.ResetColor();

string alelo1, alelo2, alelo2alelo1, alelo2alelo2;
string cruzamento11, cruzamento12, cruzamento21, cruzamento22;
string descricaoAA, descricaoAa, descricaoaa;
double percentualAA, percentualAa, percentualaa;

    Console.WriteLine("Digite os alelos do primeiro indivíduo (AA,Aa ou aa): ");
       string individuo1 = NormalizaAlelo(Console.ReadLine()!.Trim().Substring(0, 2));
    
    Console.WriteLine("\nDigite os alelos do segundo indivíduo (AA,Aa ou aa): ");
    string individuo2 = NormalizaAlelo(Console.ReadLine()!.Trim().Substring(0, 2));

    Console.WriteLine("\nEscolha o tipo de dominância (1 para completa, 2 para incompleta): ");
      string dominancia = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

    if (dominancia != "1" && dominancia != "2")
    {
    Console.WriteLine("Tipo de dominância inválido.");
    return;
    }
// Separação dos individuos 
alelo1 = individuo1.Substring(0, 1);
alelo2 = individuo1.Substring(1, 1);
alelo2alelo1 = individuo2.Substring(0, 1);
alelo2alelo2 = individuo2.Substring(1, 1);

// Classificação dos cruzamentos dos alelos 
cruzamento11 = NormalizaAlelo($"{alelo1}{alelo2alelo1}");
cruzamento12 = NormalizaAlelo($"{alelo1}{alelo2alelo2}");
cruzamento21 = NormalizaAlelo($"{alelo2}{alelo2alelo1}");
cruzamento22 = NormalizaAlelo($"{alelo2}{alelo2alelo2}");

// Conta do percentual médio 
percentualAA = 100 * (
    (cruzamento11 == "AA" ? 1 : 0) +
    (cruzamento12 == "AA" ? 1 : 0) +
    (cruzamento21 == "AA" ? 1 : 0) +
    (cruzamento22 == "AA" ? 1 : 0)
) / 4;

percentualAa = 100 * (
    (cruzamento11 == "Aa" ? 1 : 0) +
    (cruzamento12 == "Aa" ? 1 : 0) +
    (cruzamento21 == "Aa" ? 1 : 0) +
    (cruzamento22 == "Aa" ? 1 : 0)
) / 4;

percentualaa = 100 * (
    (cruzamento11 == "aa" ? 1 : 0) +
    (cruzamento12 == "aa" ? 1 : 0) +
    (cruzamento21 == "aa" ? 1 : 0) +
    (cruzamento22 == "aa" ? 1 : 0)
) / 4;


    if (dominancia == "C")
    {
    descricaoAA = "não apresenta a característica recessiva";
    descricaoAa = "não apresenta a característica recessiva";
    descricaoaa = "apresenta a característica recessiva";
    }
else
{
    descricaoAA = "apresenta a característica de `A`";
    descricaoAa = "apresenta característica distinta de `A` e de `a`";
    descricaoaa = "apresenta a característica de `a`";
}
// exibir os percentuais
Console.WriteLine();
Console.WriteLine($"AA: {percentualAA,3}% - {descricaoAA}");
Console.WriteLine($"Aa: {percentualAa,3}% - {descricaoAa}");
Console.WriteLine($"aa: {percentualaa,3}% - {descricaoaa}");


string NormalizaAlelo(string alelo)
{
    string alelo1 = alelo.Substring(0, 1);
    string alelo2 = alelo.Substring(1, 1);

    if (alelo1 == "a")
    {
        string auxiliar = alelo1;
        alelo1 = alelo2;
        alelo2 = auxiliar;
    }

    return $"{alelo1}{alelo2}";
}