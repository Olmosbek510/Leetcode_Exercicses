//1st Task
int lastSize(string str)
{
    int ctr = 0;
    var stop = false;
    for (int i = str.Length-1; i >=0 ; i--)
    {
        if (str[i] != ' ')
        {
            stop = true;
            ctr++;
            continue;
        }
        else if (stop)
            break;
    }
    return ctr;
}
//2nd Task
void mergingArrs(int n, int n1)
{
    int[] arr = new int[n];
    int[] arr1 = new int [n1];
    int[] arr2 = new int[n + n1];
    int p = 0;
    Console.WriteLine("Enter first array elements: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("arr["+(i+1)+"]: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        arr2[p] = arr[i];
        p++;
    }
    Console.WriteLine("Enter second array elements: ");
    for (int i = 0; i < n1; i++)
    {
        Console.Write("arr1["+(i+1)+"]: ");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
        arr2[p] = arr1[i];
        p++;
    }
    for (int i = 0; i < p; i++)
    {
        for (int j = i+1; j < p; j++)
        {
            if (arr2[j] < arr2[i])
            {
                int temp = arr2[i];
                arr2[i] = arr2[j];
                arr2[j] = temp;
            }
        }
    }
    for (int i = 0; i < p; i++)
    {
     Console.Write(arr2[i]+" ");   
    }
}
//3rd Task
int revNum(int n)
{
    int rem = 0, rev = 0,n1=Math.Abs(n);
    while (n1 != 0) {
        rem = n1 % 10;
        rev *= 10;
        rev += rem;
        n1 /= 10;
    }
    return n > 0 ? rev : -rev;
}
//4th Task
bool checkPal(int n)
{
    int temp = n, rev = 0, rem = 0;
    while (n > 0)
    {
        rem = n % 10;
        rev *= 10;
        rev += rem;
        n /= 10;
    }
    return temp == rev;
}
void PalsInRange(int first, int last)
{
    for (int i = first; i <= last; i++)
    {
        if (checkPal(i) == true)
        {
            Console.Write(i+" ");
        }
    }
}

    int choice;
do
{
Console.Write("Enter the task number: ");
int.TryParse(Console.ReadLine(), out choice);
switch (choice)
{
    case 1:
    {
        string str;
        Console.Write("Enter a string: ");
        str = Console.ReadLine();
        Console.WriteLine("The size of last word in {0}: " + lastSize(str), str);
    }
        break;
    case 2:
    {
        int n, n1;
        Console.Write("Enter the size of the first array: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter the size of the second array: ");
        int.TryParse(Console.ReadLine(), out n1);
        mergingArrs(n,n1);
    }
        break;
    case 3:
    {
        int n;
        Console.Write("Enter an integer: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.WriteLine("{0} -> {1}",n,revNum(n));
    }
        break;
    case 4:
    {
        int n, n1;
        Console.Write("Enter the starting number: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter the last number: ");
        int.TryParse(Console.ReadLine(), out n1);
        Console.Write("All palindrome numbers between {0} and {1} are: ",n,n1);
        PalsInRange(n,n1);
    }
        break;
}
} while (choice != 0);
