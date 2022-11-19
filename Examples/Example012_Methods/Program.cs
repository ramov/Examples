// Виды методов:

// Вид 1
void Method1()
{
    Console.WriteLine("Автор Рашид Салимов");
}

// Method1(); 

// Вид 2
void Methode2(string msg)
{
    Console.WriteLine(msg);
}
// Methode2("Текст сообщение");

// Methode2(msg: "Текст сообщение");

void Methode21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Methode21(msg: "Текст", count: 4);
// Methode21(count: 4, msg: "Новый текст"); // если используем именованные аргументы, то не обязательно писать их по порядку

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}"); 
//     }
//     Console.WriteLine();
// }

//===== Работа с текстом
// Дан текст. В тексте нужно все пробелв заменить черточками,
// мвленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Яна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
    
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";  
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// Console.WriteLine(text);
// Console.WriteLine();
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();


// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
        
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);

// SelectionSort(arr);
// PrintArray(arr);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);