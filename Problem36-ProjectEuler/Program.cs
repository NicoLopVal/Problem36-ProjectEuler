int binBase = 2;

double totalSum = 0;

long thisInt = BitConverter.DoubleToInt64Bits(3);

for (int i = 0; i< 1000000; i++)
{
    string binNumber = Convert.ToString(i, binBase);
    if (isPalindrome(i.ToString()) && isPalindrome(binNumber))
    {
        totalSum = totalSum + i;
    }
}

Console.WriteLine("The sum of all numbers, less than one million, which are palindromic in base 10 and base 2 is: " + totalSum);

bool isPalindrome(string strValue)
{
    bool isPalindrome = true;
    int j = strValue.Length - 1;
    for(int i = 0; i< strValue.Length; i++)
    {
        if (strValue[i] == strValue[j])
            j--;
        else
        {
            isPalindrome = false;
            break;
        }
        if (j <= i)
            break;
    }
    return isPalindrome;
}