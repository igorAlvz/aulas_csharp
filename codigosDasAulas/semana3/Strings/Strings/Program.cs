/*
 " ana souza ".Trim()	"ana souza"	Remove espaços do começo e do fim
"ana souza".ToUpper()	"ANA SOUZA"	Tudo em maiúsculas (ToLower() faz o contrário)
"ana souza".Length	9	Quantidade de caracteres (o espaço conta!)
 */


string nome = " ana souza  ";
Console.WriteLine(nome.Trim());
nome = nome.Trim().ToUpper();
Console.WriteLine(nome);


if (nome.Contains("SOUZA")) Console.WriteLine("Sim");
nome = nome.Replace("souza", "lima");

if (char.IsDigit('1')) Console.WriteLine("É um número");
if (!char.IsLetter('2')) Console.WriteLine("Não é uma letra.");


string textoEmBranco = "    ";

if (string.IsNullOrWhiteSpace(textoEmBranco)) Console.WriteLine("Texto em branco");