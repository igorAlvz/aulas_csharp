

using ClassesEConstrutores.Modelos;


Leitor l1 = new Leitor("Igor", "alvesigorthiago@gmail.com",3);
Leitor l2 = new Leitor("Lucas", "Lucas@gmail.com",2);
Leitor l3 = new Leitor("Pedro", "marcos.outlook.com",1);
Leitor l4 = new Leitor("Andressa", "andressa@gmail.com",7);

Console.WriteLine(l1.ToString());
Console.WriteLine(l2.ToString());
Console.WriteLine(l3.ToString());
Console.WriteLine(l4.ToString());

public record class Multa
{

} 
