public static class Swap
{
    public static void SwapTwoElements<T>(ref T firstElement, ref T secondElement)
    {
        T temp = firstElement;
        firstElement = secondElement;
        secondElement = temp;
    }
}

