static  bool ValidaCep(string cep)
{
    if (cep.Length != 9)
    {
        return false;
    }

    for (int i = 0; i < cep.Length; i++)
    {
        if (i == 5)
        {
            if (cep[i] != '-')
            {
                return false;
            }
        }

        else if (!char.IsDigit(cep[i]))
        {
            return false;
        }

    }

    return true;
}


Console.WriteLine($"O Cep 12345-678 é valido? {ValidaCep("12345-678")}");
Console.WriteLine($"O Cep 12345678 é valido? {ValidaCep("12345678")}");
Console.WriteLine($"O Cep 1234-5678 é valido? {ValidaCep("1234-5678")}");

