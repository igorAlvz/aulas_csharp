for (int i = 0; i < 10; i++)
{
    if (i == 3) continue; // pula o resta desta iteração e vai para próxima
    if (i == 7) break; // encerra o loop imediantamente;
    Console.Write(i + " ");
}
