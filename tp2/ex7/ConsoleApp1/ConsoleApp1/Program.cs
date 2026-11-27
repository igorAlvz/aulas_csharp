

using ConsoleApp1;

Veiculo v1 = new Veiculo("ABC2D20", "Moto", new DateTime(2026,11,26,15,30,0));
Veiculo v2 = new Veiculo("JDK3P19", "Carro");
Veiculo v3 = new Veiculo("VGT9L14", "Carro", DateTime.Now);
Veiculo v4 = new Veiculo("KJD0K11", "Moto", new DateTime(2026,11,26,15,40,0));
Veiculo v5 = new Veiculo("BWD8N22", "Moto");

Veiculo[] veiculos = {v1,v2,v3,v4,v5};

foreach(Veiculo veiculo in veiculos)
{
    Console.WriteLine(veiculo);
}