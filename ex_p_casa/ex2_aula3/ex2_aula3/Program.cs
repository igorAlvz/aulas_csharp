
int totalDias = 200;
int semanas = 200 / 7;
int diasRestantes = 200 % 7;

Console.WriteLine($"{semanas} semanas {diasRestantes} dias");

int pessoas = 150;
int capacidadeVan = 15;
int vanNecessarias = pessoas / capacidadeVan;
int vansExtras = pessoas % capacidadeVan;


if (vansExtras > 0)
{
    vanNecessarias++;
}

Console.WriteLine($"Serão necessário {vanNecessarias} vans");

double orcamento =  950.50;
double vlrPorVan = 150.50;

double total = vlrPorVan * vanNecessarias;

if(total > orcamento)
{
    Console.WriteLine("O valor ficou acima do orçamento.");
}else if(total < orcamento)
{
    Console.WriteLine("O valor ficou abaixo do orçamento.");
}
else
{
    Console.WriteLine("O valor ficou igual do orçamento.");
}


double x = 2;
double y = 7;

Console.WriteLine(y / x);
int a = 7;
int b = 2;

Console.WriteLine((double) a / b);