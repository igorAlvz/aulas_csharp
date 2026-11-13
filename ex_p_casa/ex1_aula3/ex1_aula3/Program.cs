
int idade = 18; // Escolhio int pois nao existe idade com valor "Quebrado" e fica melhor caso preciso calcular, por isso também nao escolhi string
decimal saldoConta = 4000.90m; // Escolhi como decimal pois o professor disse que em sistemas financeiros é melhor para nao causar erros futuros
bool ehMatriculado = true;  // como so existe duas opções ou está ou nao está matriculado escolhi bool
int habitantesBrasil = 6000000; // como é impossível existir valores quebrados aqui optei por int
float mediaAulo = 7.4f; // como uma media pode ter valores quebrados mas nao preciso de muitas casa decimais para representar eu escolhi o float e nao o double

Console.WriteLine($"""
    === RELATÓRIO ===
    IDADE: {idade}
    Saldo: {saldoConta}
    Está matriculado: {ehMatriculado}
    Quantidades de habitantes no Brasil: {habitantesBrasil}
    Média do Aluno: {mediaAulo:F2}
    """);
