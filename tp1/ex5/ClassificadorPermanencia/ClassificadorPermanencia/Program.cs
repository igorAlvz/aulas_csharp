//Contexto

//A gerência quer que o sistema classifique automaticamente cada veículo por tempo de permanência assim que ele sai, lendo o total de minutos informado pelo operador da cancela no terminal.

//Tarefa

//Escreva um programa ClassificadorPermanencia que declare uma variável para o total de minutos estacionado e leia esse valor digitado pelo usuário com Console.ReadLine() (convertendo para int).
//Use uma estrutura if/else para classificar a permanência em três categorias ("rotativa curta", "rotativa padrão", "diária"), com os limites em minutos definidos por você e justificados em um comentário no código.
//Trate no código a possibilidade de o usuário digitar um valor negativo, imprimindo uma mensagem de erro clara nesse caso. Use o debugger do Visual Studio para inspecionar o valor da variável de permanência em tempo de execução em pelo menos um dos cenários de teste.


// Rotativa curta 2 hr - Tempo definido com base na permânica média de pessoas que estaciona para fazer coisas do dia dia como pagar conta ou ir em um loja 
// Rotativa padrao mais de 2hr até no máximo 4hr - Tempo que leva em consideração pessoas que vao passear, ir ao cinema, ir no banco etc.
// Rotativa diaria - acima de 4 hrs - Tempo que leva em consideração pessoas que deixam o carro estacionado para ir ao trabalho, faculdade etc

Console.WriteLine("Estacionamento");
Console.Write("Digie o total de minutos estacionado: ");
string entradaMin = Console.ReadLine();

if(!int.TryParse(entradaMin, out int totalMin))
{
    Console.WriteLine("Entrada inválida. Digite Somente Número inteiro");
}
else
{
    if (totalMin < 0)
    {
        Console.WriteLine("ERRO: Não são aceito valores negativos.");
    } else if (totalMin <= 120)
    {
        Console.WriteLine("Rotativa Curta");
    } else if (totalMin <= 240)
    {
        Console.WriteLine("Rotativa Padrão");

    } else
    {
        Console.WriteLine("Rotativa Diária");
    }
    }