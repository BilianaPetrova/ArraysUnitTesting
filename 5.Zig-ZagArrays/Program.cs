int n = int.Parse(Console.ReadLine());
int[] firstArray = new int[n];
int[] secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] twoNumbers = Console.ReadLine()
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();
    int firstNumber = twoNumbers[0];
    int secondNumber = twoNumbers[1];

    if (i % 2 == 0)
    {
        firstArray[i] = firstNumber;
        secondArray[i] = secondNumber;

    }
    else
    {
        firstArray[i] = secondNumber;
        secondArray[i] = firstNumber;
    }

}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));