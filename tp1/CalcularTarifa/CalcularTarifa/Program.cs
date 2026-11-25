//Contexto

//Com o ambiente validado, é hora de escrever a primeira lógica de negócio real. A equipe recebeu a tarefa de prototipar uma calculadora de tarifa para o estacionamento, que hoje calcula o valor devido de cabeça, de forma sujeita a erro, na hora de liberar o veículo.

//Tarefa

//Escreva um programa CalculadoraTarifa que declare uma variável int para o total de minutos que o veículo permaneceu estacionado e uma variável double para o valor cobrado por hora.
//Usando divisão inteira e o operador %, calcule quantas horas cheias e quantos minutos restantes correspondem ao total de minutos informado, e imprima esse resultado no formato "Xh Ymin".
//Calcule o valor a cobrar considerando que qualquer fração de hora iniciada é cobrada como hora cheia (ou seja, arredonde as horas para cima antes de multiplicar pelo valor da hora), sem usar bibliotecas prontas de arredondamento monetário.
//Compare o valor calculado com um teto diário fixo definido no código usando um operador relacional, e imprima se o valor calculated é maior, menor ou igual ao teto.

int totalMinutos = 190;
double valorHora = 3.50;
double valorACobrar = 0;
double tetoDiario = 50.50;

int horas = totalMinutos / 60;
int minutos = totalMinutos % 60;
int totalHoras = horas;

Console.WriteLine($"{horas}H {minutos}min");
if (minutos > 0) totalHoras++;

valorACobrar = (double) totalHoras * valorHora;

Console.WriteLine($"Valor a cobrar: R$ {valorACobrar:F2}");

if (valorACobrar > tetoDiario) Console.WriteLine($"Valor cobrado foi maior que o teto diário (Teto Diário = {tetoDiario})");
else if (valorACobrar < tetoDiario) Console.WriteLine($"Valor cobrado foi menor que o teto diário (Teto Diário = {tetoDiario})");
else Console.WriteLine($"Valor cobrado foi igual ao teto diário (Teto Diário = {tetoDiario})");