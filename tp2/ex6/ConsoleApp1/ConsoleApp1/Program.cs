
using ConsoleApp1;

Veiculo v1 = new Veiculo("ABC1D20", "Carro", DateTime.Now);
Veiculo v2 = new Veiculo("BCD1F11", "Moto");
Veiculo v3 = new Veiculo("KLV2J09", "Moto");

Console.WriteLine($"Placa: {v1.Placa} - Tipo: {v1.Tipo} - Entrada: {v1.HoraEntrada}");
Console.WriteLine($"Placa: {v2.Placa} - Tipo: {v2.Tipo} - Entrada: {v2.HoraEntrada}");
Console.WriteLine($"Placa: {v3.Placa} - Tipo: {v3.Tipo} - Entrada: {v3.HoraEntrada}");