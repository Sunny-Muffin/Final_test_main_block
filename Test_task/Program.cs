// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string userInput = GetUserInput();
string[] arr = MakeArrayFromString(CountWords(userInput), userInput);
PrintArray(arr);
PrintArray(MakeNewArray(arr));

string GetUserInput()
{
    Console.Write($"Please enter words or symbols, separated by SPACE: ");
    string txtInput = Console.ReadLine();
    while(txtInput == null)
    {
        Console.WriteLine("Please enter at least some symbols: ");
        txtInput = Console.ReadLine();
    }
    return txtInput;
}

int CountWords(string input)
{
    int count = 1; // we consider that there is one word more than there are spaces
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

// Method below makes new array from elements, that have 3 or less symbols
string[] MakeNewArray(string[] array)
{
    int j = 0;
    int countWords = CountThreeSymbolWords(array);
    string[] newArray = new string[countWords];
    
    if (countWords == 0)
    {
        Console.WriteLine("There are no words with 3 or less symbols");
        return newArray;
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

int CountThreeSymbolWords(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
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