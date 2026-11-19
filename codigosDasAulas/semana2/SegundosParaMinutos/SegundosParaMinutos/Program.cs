int totalSegundos = 135;
int minutos = totalSegundos / 60; // - quantos minutos cheios
int segundos = totalSegundos % 60; // 15 - o que sobrou

Console.WriteLine($"{minutos} min {segundos}s"); //2min 15s