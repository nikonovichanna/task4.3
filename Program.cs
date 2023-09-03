
int length = Promt("Длина массива: ");
int[] arrey = GenereteArrey(length);
PrintArrey(arrey);

int Promt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result =int.Parse(readInput);
    return result;
}

int[] GenereteArrey(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 90);
    }
    return result;
}

void PrintArrey(int[] arrey)
{
    System.Console.Write("[");

    foreach (int i in arrey) 
    {
        System.Console.Write($"{i} ");
    }
    System.Console.Write("]");
}
