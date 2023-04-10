/* Написать программу,которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше либо равна 3 символам.*/
void Print(string[] arr)
{
    int row = arr.Length;
    Console.Write("[");
    for (int i = 0; i < row; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.Write("]");
}

string[] MassCreate(int num, int k)
{
    Console.WriteLine($"write {num} strings");
    string[] NewMas = new string[num + 1];
    int l = 0;
    for (int i = 0; i < num; i++)
    {
        NewMas[i] = Console.ReadLine()!;
        if (NewMas[i] == "stop")
        {
            i = num;
        }
        else if (NewMas[i].Length <= k)
        {
            l = l + 1;
        }
    }
    NewMas[num] = l.ToString();
    return NewMas;
}

string[] MaxThreeSymMass(string[] mas, int num, int k)
{
    int row = int.Parse(mas[num]);
    string[] MasNew = new string[row];
    int j = 0;
    for (int i = 0; i < num; i++)
    {
        if (mas[i] != null && mas[i].Length <= k && mas[i] != "stop")
        {
            MasNew[j] = mas[i];
            j = j + 1;
        }
    }
    return MasNew;
}

Console.WriteLine("write the number of elements");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("output length");
int k1 = int.Parse(Console.ReadLine()!);
string[] mas = MassCreate(num, k1);
Console.WriteLine();
string[] mas1 = MaxThreeSymMass(mas, num, k1);
Print(mas1);
