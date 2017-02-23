using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ListsFromTheExtended
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        numbers = numbers.Where(x => x >= 0).ToList();
        var n = int.Parse(Console.ReadLine());
        while (numbers.Count > n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < numbers.Count; j++)
                {
                    if (j < numbers.Count - 1)
                    {
                        if (numbers[j] > numbers[j - 1] && numbers[j] > numbers[j + 1])
                        {
                            numbers[j]++;
                            if (numbers[j - 1] > 0)
                            {
                                numbers[j]++;
                                numbers[j - 1]--;
                            }
                            if (numbers[j + 1] > 0)
                            {
                                numbers[j + 1]--;
                            }
                            if (j < numbers.Count - 3)
                            {
                                if (numbers[j + 2] > numbers[j + 1] && numbers[j + 3] < numbers[j + 2])
                                {
                                    if (numbers[j + 1] > 0)
                                    {
                                        numbers[j + 1]--;
                                    }
                                }
                            }
                            j++;
                        }
                        else
                        {
                            numbers[j - 1]++;
                        }
                    }
                    else
                    {
                        numbers[j]++;
                    }
                }
            }
            numbers.RemoveAll(x => x <= n);
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
