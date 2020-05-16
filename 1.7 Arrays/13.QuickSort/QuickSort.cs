using System;

class QuickSort
{
    static void Main()
    {
        string[] array = { "sagdfsg", "aaareeerg", "wwewfreg", "bfdbghfr", "slkfjoir" };
        Console.WriteLine(String.Join(",", array));
        Quicksort(array, 0, array.Length - 1);
        Console.WriteLine(String.Join(",", array));
        Console.Read();
    }

    static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];
        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                IComparable tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;
                i++;
                j--;
            }
        }
        if (left < j)
        {
            Quicksort(elements, left, j);
        }
        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}

