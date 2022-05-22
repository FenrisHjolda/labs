// 9. Отсортировать отрицательные элементы одномерного массива целых чисел по возрастанию. Сортировки: включением и расчёской.
// Входные данные: одномерный массив целых чисел.
// Выходные данные: отсортированный отрицательные элементы массива.

int[] unsortArr = new int[10];
int[] partSortArr = new int[10];
int[] revSortArr = new int[10];

Random rnd = new Random();

// initialize arrays function
void initializeArrays()
{
    // unsorted random array - несортированныый рандомный массив
    for (int i = 0; i < unsortArr.Length; i++)
        unsortArr[i] = rnd.Next(-10, -1);

    // partially sorted array - частично сортированный массив
    partSortArr = new int[10] { -8, -10, -6, -7, -9, -5, -4, -3, -2, -1 };

    // reverse sorted array with all neg numbers
    revSortArr = new int[10] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
}

// функция для вывода массива
static void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

// initialize arrays and test insertion and comb sort
void testOneArray(int[] arr)
{
    Console.WriteLine("Несортированный массив:");
    PrintArr(arr);
    Console.WriteLine("Массив, отсортированный включением:");
    InsertionSort(arr);
    initializeArrays();
    PrintArr(arr);
    Console.WriteLine("Массив, отсортированный расчёской:");
    CombSort(arr);
    PrintArr(arr);
}

    initializeArrays();
    testOneArray(unsortArr);
    testOneArray(partSortArr);
    testOneArray(revSortArr);

// insertion sort
static void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int j = i;
        while (j > 0 && arr[j - 1] > arr[j])
        {
            int temp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = temp;
            j--;
        }
    }
}

// comb sort - сортировка расческой
static void CombSort(int[] arr)
{
    int i = 0;
    int j = 0;
    int temp = 0;
    int gap = arr.Length;
    bool swapped = true;
    while (gap > 1 || swapped)
    {
        if (gap > 1)
            gap = (int)(gap / 1.247330950103979);
        i = 0;
        swapped = false;
        while (i + gap < arr.Length)
        {
            if (arr[i] < arr[i + gap])
            {
                temp = arr[i];
                arr[i] = arr[i + gap];
                arr[i + gap] = temp;
                swapped = true;
            }
            i++;
        }
    }
}
