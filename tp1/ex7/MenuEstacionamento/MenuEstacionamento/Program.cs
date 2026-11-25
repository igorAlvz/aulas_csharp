namespace MenuEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = $"""
    === MENU ESTACIONAMENTO ===
    1 - Calcular Tarifa
    2 - Converter Duração (horas e minutos)
    3 - Classificar Permanência
    4 - Sair
    Digite o número da opção desejada: 
    """;

            Console.Write(menu);
            string opc = Console.ReadLine();
            while (opc != "4")
            {
                switch (opc)
                {
                    case "1":
                        CalcularTarifa();
                        break;
                    case "2":
                        ConverterHoras();
                        break;
                    case "3":
                        ClassificarPermanencia();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.Write(menu);
                opc = Console.ReadLine();

            }
        }

        static void CalcularTarifa()
        {
            double vlrHora = 3.50;
            double vlrCobrado = 0;

            Console.WriteLine("Vamos Calcular Tarifa");

            while (true)
            {
                int horasCobrada = 0;

                Console.Write("Digite o total de minutos (-1 para sair): ");
                string entradaMin = Console.ReadLine();
                if (!int.TryParse(entradaMin, out int totMin))
                {
                    Console.WriteLine("Valor inválido -> digite um número inteiro");
                }
                else if (totMin == -1)
                {
                    Console.WriteLine("Encerrando");
                    break;
                }
                else if (totMin <= 0)
                {
                    Console.WriteLine("O valor dever ser positivo");
                }
                else
                {
                    int horas = totMin / 60;
                    int min = totMin % 60;

                    if (min != 0)
                    {
                        horasCobrada++;
                    }

                    horasCobrada += horas;
                    vlrCobrado = horasCobrada * vlrHora;

                    Console.WriteLine($"Total a pagar: R$ {vlrCobrado:F2}");
                }

            }

            Console.WriteLine("Voltando ao menu...");
        }

        static void ConverterHoras()
        {
            while (true)
            {
                Console.Write("Digite a quantidade de minutos: ");
                string entradaMin = Console.ReadLine();
                if (!int.TryParse(entradaMin, out int totmin) || totmin <= 0)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    int horas = totmin / 60;
                    int mins = totmin % 60;
                    Console.WriteLine($"{horas}H {mins}min");
                    break;
                }
            }

        }

        static void ClassificarPermanencia()
        {
            int totRotativaC = 0;
            int totRotativaP = 0;
            int totRotativaD = 0;

            while (true)
            {
                Console.Write("Digite a permanência em minutos (-1 para sair): ");
                string entradaMin = Console.ReadLine();

                if (!int.TryParse(entradaMin, out int totMin))
                {
                    Console.WriteLine("Valor inválido");

                }
                else if (totMin == -1)
                {
                    Console.WriteLine("Finalizando..");
                    break;
                }
                else if (totMin <= 0)
                {
                    Console.WriteLine("Digite um valor positivo");

                }
                else if (totMin <= 120)
                {
                    Console.WriteLine("Rotativa curta");
                    totRotativaC++;

                }
                else if (totMin <= 240)
                {
                    Console.WriteLine("Rotativa Padrão");
                    totRotativaP++;
                }
                else
                {
                    Console.WriteLine("Rotativa Diária");
                    totRotativaD++;
                }
            }

            Console.WriteLine($"""
                === Relatório ===
                Total veículos: {totRotativaC + totRotativaD + totRotativaP}
                Rotativa curta: {totRotativaC}
                Rotativa padrão: {totRotativaP}
                Rotativa diária: {totRotativaD}
                """);
        }
    }
}
