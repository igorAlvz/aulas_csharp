static int MaiorDosTres(int a, int b, int c)
{

    int[] vetor = { a, b, c };
    int maior = vetor[0];


    for(int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] > maior) maior = vetor[i];
    }

    return maior;
}

Console.WriteLine($"Dentre os números 9, 5, 10 o maior é {MaiorDosTres(9, 5, 10)}");