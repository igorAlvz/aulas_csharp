string cidade = " rio de janeiro ";

string cidadeFormatada = cidade.Trim();

Console.WriteLine($"{cidadeFormatada.ToUpper()} tem {cidadeFormatada.Length} letras");
Console.WriteLine($"Antes da formatação a string tinha {cidade.Length} letras");