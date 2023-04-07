/* Написать программу,которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше либо равна 3 символам.*/
void Print (string[] arr)
{
    int row = arr.Length;
    Console.Write("[");
    for (int i=0; i<row; i++)
    {
            Console.Write($" {arr[i]} ");
    } 
    Console.Write("]");
}

string[] MassCreate(int num)
{
    Console.WriteLine($"write {num} strings");
    string[] new_mas = new string [num+1];
    int l = 0;
    for (int i=0; i<num; i++)
    {
        new_mas[i]=Console.ReadLine()!;
        if (new_mas[i]=="stop")
        {
            i=num;
        }
        if (new_mas[i].Length<=3)
        {
            l=l+1;
        }
    }
    new_mas[num]=l.ToString();
    return new_mas;
}

string[] MaxThreeSymMass(string[] mas,int num)
{
    int row = int.Parse(mas[num]);
    string[] mas_new = new string [row];
    int j=0;
    for (int i=0; i<num; i++)
    {
        if(mas[i].Length <=3)
        {
            mas_new[j]=mas[i];
            j=j+1;
        }
    } 
    return mas_new;
}

Console.WriteLine("rite the number of elements");
int num = int.Parse(Console.ReadLine()!);
string[] mas = MassCreate(num);
Console.WriteLine("");
string[] mas1 = MaxThreeSymMass(mas,num);
Print(mas1);
