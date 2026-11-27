
using ConsoleApp1;

Veiculo v1 = new Veiculo("ABC3K22", "Moto", DateTime.Now);
Veiculo v2 = new Veiculo("JLK4O21", "Carro");
Veiculo v3 = new Veiculo("CGB2L34", "Moto");

v1.VlrPago = 7.44m;
v2.VlrPago = 5.88m;
decimal valorV1Preservado = v1.VlrPago;
v3.VlrPago = -9.9m;
Console.WriteLine("Atribuindo valor negativo a V1");
v1.VlrPago = -3.50m;

Console.WriteLine($"Valor veículo: {v1.Placa} Antes da atribuição negativa R$ {valorV1Preservado}");
Console.WriteLine($"Valor veículo: {v1.Placa} Depois da atribuição negativa R$ {v1.VlrPago}");


if (valorV1Preservado == v1.VlrPago)
{   
    Console.WriteLine("Regra de validação funcionando. Valor permanece o mesmo");
}
else
{
    Console.WriteLine("Regra de validação falhou. Valor foi alterado");

}
Veiculo[] veiculos = {v1, v2, v3};

foreach(Veiculo veiculo in veiculos)
{
    Console.WriteLine(veiculo);
}