// Descrição do Projeto
// Vamos criar um programa que gerencie uma lista de notas de alunos e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
//2. Exibir as notas e calcular a média.
//3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).

double[] notas = new double[5];
double somaNotas = 0, qtdNotas = 0, media = 0;
int menu = 0;

while (menu != 4)
{
    Console.WriteLine("=== Gerenciador de Notas ===");
    Console.WriteLine("1. Adicionar aluno");
    if (qtdNotas != 0)
    {
        Console.WriteLine("2. Listar alunos");
        Console.WriteLine("3. Estatísticas");
    }
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    menu = int.Parse(Console.ReadLine());

    if (menu == 1)
    {
        try
        {
            for (int i = 0; i < notas.Length; i++)
            {

                do
                {
                    Console.WriteLine($"Digite a {i + 1}ª nota: ");
                    notas[i] = double.Parse(Console.ReadLine());

                    if (notas[i] >= 0 && notas[i] <= 10)
                    {
                        somaNotas = somaNotas + notas[i];
                        qtdNotas++;
                    }
                    else
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10");
                    }

                } while (notas[i] < 0 || notas[i] > 10);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Erro: Digite somente número!");
        }
    }
    else if (menu == 2)
    {
        Console.WriteLine("Você escolheu a opção 2.");
    }
    else if (menu == 3)
    {
        Console.Clear();
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"{i + 1}ª nota: {notas[i]}");
        }

        if (media >= 7.40)
        {
            Console.WriteLine($"A médias das notas é: {media}");
            Console.WriteLine("O aluno foi APROVADO! :)");
        }
        else
        {
            Console.WriteLine($"A médias das notas é: {media}");
            Console.WriteLine("O aluno foi REPROVADO!");
        }
        Thread.Sleep(10000);
    }
    else if (menu == 4)
    {
        Console.WriteLine("Você saiu do menu.");
    }
    else
    {
        Console.WriteLine("Escolha inválida, tente novamente.");
    }
}
