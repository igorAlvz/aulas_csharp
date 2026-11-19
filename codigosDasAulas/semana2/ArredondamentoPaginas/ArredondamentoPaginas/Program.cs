int paginas = 23;
int paginasPorFolha = 10;
double precoPorFolha = 0.35;

int folhas = paginas / paginasPorFolha; // 2 folhas cheias
if(paginas % paginasPorFolha > 0) // sobrou alguma página
{
    folhas = folhas + 1; // então precisa de mais u
}


double valor = folhas * precoPorFolha;
Console.WriteLine($"{folhas} folhas, R$ {valor:F2}");