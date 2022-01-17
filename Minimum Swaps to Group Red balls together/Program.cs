// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int minswap(String str)
{
    int n = str.Length;
    int left = 0;
    int right = n - 1;
    int rc = 0;
    int res = 0;
    for (int i = 0; i < n; i++)
    {
        if (str[i] == 'R')
            rc++;

    }
    while (left < right)
    {
        if (str[left] == 'R' && str[right] == 'R')
        {
            rc -= 2;
            res += right - left - 1 - rc;
            left++;
            right--;
        }
        else if (str[left] != 'R')
            left++;
        else
            right--;
    }

    return res;

}


String str = "RWWRWRRR";
int res = minswap(str);
Console.WriteLine(res);