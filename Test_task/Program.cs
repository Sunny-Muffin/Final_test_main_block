// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string userInput = GetUserInput();
string[] arr = MakeArrayFromString(CountWords(userInput), userInput);
PrintArray(arr);
//Console.WriteLine($"There are {FindMoreThanZero(arr)} elements, greater, than 0");

string GetUserInput()
{
    Console.Write($"Please enter words or symbols, separated by SPACE: ");
    string txtInput = Console.ReadLine();
    return txtInput;
}

int CountWords(string input)
{
    int count = 1; // слов больше, чем пробелов на 1
    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

string[] MakeArrayFromString(int lenght, string input)
{
    string[] array = new string[lenght];
    int j = 0;
    string word = "";
    for (int i = 0; i < input.Length; i++)
    {
        
        if (input[i] == ' ')
        {
            array[j] = word;
            j++;
            word = "";
        }
        else if(i == (input.Length - 1))
        {
            word += input[i];
            array[j] = word;
        }
        else
        {
            word += input[i];
        }
    }
    return array;
}

int FindMoreThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}