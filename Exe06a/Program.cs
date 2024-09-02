// 1 - Criar uma variavel ou um vetor
// 2 - Criar um laço para percorrer o vetor
// 3 - para cada posição gerar um valor aleatorio
// 4 - Ordenar um vetor

using System.Buffers;

int tamanho = 1000;
int[] vetor = new int[tamanho];


// Gerando um vetor com valores aleatorios 
Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);
}

// Imprimir o vetor com valores sem ordenação
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

Console.WriteLine("\n");

// Ordenacao com funcao do C#
Array.Sort(vetor);

// Ordenação do vetor com bubble sort
/* bool troca = false;
do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        if(vetor[i] > vetor[i + 1])
        {   
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        }
    }
} while(troca); */

// Imprimir o vetor com valores com ordenação
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}