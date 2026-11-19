int opcao;
do
{
    Console.WriteLine("1 - Continuar 0 - Sair");
    
        opcao = Convert.ToInt32(Console.ReadLine());

}
while (opcao != 0); // Atenção ao ponto e virgula no final;
                    