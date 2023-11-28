//Вид 1 ничего не возвращают и ничего не принимают 
void Method1()
{
    Console.Write("Автор ...");
}
//Method1();











// Вид 2 ничего не возвращают но принимают какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
//Method21("Текс", 4);
//Method21(count:4, msg: "новый текст");








// Вид 3 ничего не принимает, но что-то возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);








// Вид 4 что-то принимают и что-то возвращают

//string Method4(int count, string text)
//{
//    int i = 0;
//                     // пустая строка
//    string result = string.Empty;
//    while (i < count)
//    {
//          result = result + text;
//       i++;
//    }
//return result;
//}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

// то же самое только цикл for

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
//Console.WriteLine(res);

// цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine ($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

//=========== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к", заменить большими "К",
// а большие "С", заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] это r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text,' ', '|');     // что на что меняем

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');           // что на что меняем
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С'); // нет больших С, решил заменить наоборот
Console.WriteLine(newText);


// упорядочить массив от минимального к максимальному
// найти позицию минимального элемента в неотсортированной части массива.
// произвести обмен этого значения со значением первой неосортированной позиции
// повторять пока есть неотсортированные элементы

int[] arr = { 1, 4, 6, 8, 7, 1, 2, 5, 7 };

void PrintArray(int[] array) // отдельный метод для вывода на экран
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length  - 1; i++)
    {
        int Minposition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[Minposition]) Minposition = j;
        }
        int temporary = array[i];
        array[i] = array[Minposition];
        array[Minposition] = temporary;
    }
}
SelectionSort(arr);

PrintArray(arr);




