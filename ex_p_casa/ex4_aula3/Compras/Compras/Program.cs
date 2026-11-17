
double valorTotal = 0;
double maiorCompra = 0;

while (true)
{
    Console.Write("Digite o valor do produto (0 para sair): ");
    string entrada = Console.ReadLine();
    if (entrada == "0")
    {
        break;
    }
    else if (!double.TryParse(entrada, out double valorProduto))
    {
        Console.WriteLine("Valor inválido.");
        continue;
    }
    else { 
    if (valorProduto > maiorCompra)
        {
            maiorCompra = valorProduto;
        }
    valorTotal += valorProduto;
    }

    }
Console.WriteLine($"O valor das compras é: R$ {valorTotal:F2}");
Console.WriteLine($"O produto de maior valor é: R$ {maiorCompra:F2}");