//Написать программу, которая из имеющегося массива строк формирует 
//новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.

string[] CreateStringArray1(int size1)
{
    string[] array1 = new string[size1];
    int random1 = 0;
    int random2 = 0;
    string temp1 = string.Empty;
    string alphanum1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    for (int i1 = 0; i1 < size1; i1++)
    {
        random1 = new Random().Next(1, 6);
        for (int j1 = 0; j1 < random1; j1++)
        {
            random2 = new Random().Next(0, alphanum1.Length);
            temp1 = temp1 + alphanum1[random2];
        }
        array1[i1] = temp1;
        temp1 = string.Empty;
    }
    return array1;
}

string[] ManualStringInput2(int sizeManual2)
{
    string[] array2 = new string[sizeManual2];
    for (int i2 = 0; i2 < sizeManual2; i2++)
    {
        array2[i2] = Console.ReadLine()!;
    }
    return array2;
}

string[] CutArray3(string[] arrayOld3)
{
    int sizeOld3 = arrayOld3.Length;
    int sizeNew3 = 0;
    for (int i3 = 0; i3 < sizeOld3; i3++)
    {
        if (arrayOld3[i3].Length < 4) sizeNew3++;
    }
    string[] arrayNew3 = new string[sizeNew3];
    int iNew3 = 0;
    for (int iOld3 = 0; iOld3 < sizeOld3; iOld3++)
    {
        if (arrayOld3[iOld3].Length < 4)
        {
            arrayNew3[iNew3] = arrayOld3[iOld3];
            iNew3++;
        }
    }
    return arrayNew3;
}

void PrintArray4(string[] array4)
{
    int size4 = array4.Length;
    Console.WriteLine();
    for (int p = 0; p < size4; p++)
    {
        Console.Write($"{array4[p]};\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine("The program creates array of strings and returns only strings with length of 3 symbols or shorter.");
Console.WriteLine("Would you like to use random array? Y/N..");
string[] array0 = new string[0];
char char0 = Console.ReadLine()!.ToUpper()[0];
if (char0 == 'Y')
{
    int size0 = new Random().Next(3, 10);        //array size from 3 to 10 elements
    array0 = CreateStringArray1(size0);
}
else
{
    Console.WriteLine("Please input number of strings you intend to input..");
    bool check0 = int.TryParse(Console.ReadLine(), out int sizeManual0);
    if ((!check0) || ((sizeManual0 < 1) || (sizeManual0 > 10))) sizeManual0 = 10;     //if incorrect size input, array of 10 elements
    Console.WriteLine($"Now start your input of {sizeManual0} strings..");
    array0 = ManualStringInput2(sizeManual0);
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Your initial array of strings:");
Console.ResetColor();
PrintArray4(array0);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Result array is:");
Console.ResetColor();
string[] arrayNew0 = CutArray3(array0);
PrintArray4(arrayNew0);