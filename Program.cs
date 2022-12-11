string[] ArrayTextThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

string[] strArray = CreateArray();
ShowArray(ArrayTextThree(strArray));

string[] CreateArray() 
{
  Console.Write("Enter the length of the array: ");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
  Console.WriteLine("Create an array: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Enter the value {i + 1} of the array element: ");
    array[i] = Console.ReadLine();
  }
  return array;
}

void ShowArray(string[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine($"Total elements <= 3 in array: {array.Length}");
}