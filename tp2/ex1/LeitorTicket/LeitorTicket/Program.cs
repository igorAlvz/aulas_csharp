

Console.Write("Digite o ticket no formato placa;horaEntrada;tipoVeiculo: ");
string? entradaTicket = Console.ReadLine()?.Trim();

if (string.IsNullOrWhiteSpace(entradaTicket))
{
    Console.WriteLine("ERRO: Entrada vazia.");
    return;
}


string[] partes = entradaTicket.Split(';');

if (partes.Length != 3)
{
    Console.WriteLine($"Erro: O formatado esperado é 3 campos separado por ; Mas recebi {partes.Length} partes");
    return;
} 
for(int i = 0; i < partes.Length; i++)
{
    if (string.IsNullOrWhiteSpace(partes[i])){
        if (i == 0){
            Console.WriteLine("Erro: Placa em branco");
            return;
            }
        else if (i == 1) {
            Console.WriteLine("Erro: Hora da entrada em branco");
            return;
            }
        else { 
            Console.WriteLine("Erro: Tipo do veículo em branco");
            return;
            }
        
    }
}

Console.WriteLine($"""
    Ticket Gravado Com Sucesso
    Placa: {partes[0]}
    Hora Entrada: {partes[1]}
    Tipo Veículo: {partes[2]}
    """);