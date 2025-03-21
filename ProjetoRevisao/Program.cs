// Descrição do Projeto
// Vamos criar um programa que gerencie uma lista de notas de alunos e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
//2. Exibir as notas e calcular a média.
//3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).

int[] notas = new int[5];
int somaNotas = 0, qtdNotas = 0;

for (int i = 0; i < notas.Length; i++)
{

    do
    {
        Console.WriteLine("Informe uma nota: ");
        notas[i] = int.Parse(Console.ReadLine());

        if (notas[i] >= 0 && notas[i] <= 10)
        {
            somaNotas = somaNotas + notas[i];
            qtdNotas++;
        } else
        {
            Console.WriteLine("Digite uma nota entre 0 e 10");
        }

    } while (notas[i] < 0 || notas[i] > 10);
}

int media = somaNotas / qtdNotas;
Console.WriteLine(media);
