string[] nomes = new string[8];

//nomes[0] = "Thalita Neves";
//nomes[1] = "Lia Mendes";

// OU

// nomes.Length serve para pegar a informação de quantidade da string
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("Informe o nome:");
    nomes[i] = Console.ReadLine();
}

// Listando com For
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

// Listando com Foreach (para cada)
foreach (var item in nomes)
{
    Console.WriteLine(item);
}


