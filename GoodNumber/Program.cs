using static System.Console;
using static System.Convert;
using static System.Math;


int n, k,sum1=0,sum2=0;

string str1 = ReadLine();

var arr = str1.Split(" ");
n = ToInt32(arr[0]);
k = ToInt32(arr[1]);
int[] arr2 = new int[10];
for(int i = 0; i < n; i++)
{
    Array.Clear(arr2, 0, 10);
    string str2 = ReadLine();
    sum2 = 0;
    for(int j = 0; j < str2.Length; j++)
    {
        arr2[str2[j] - '0']++;
    }
    for(int l = 0; l <= k; l++)
    {
        if (arr2[l] > 0)
        {
            sum2++;
        }
    }
    if(sum2 == k + 1)
    {
        sum1++;
    }
   
}

WriteLine(sum1);





