// See https://aka.ms/new-console-template for more information
Console.WriteLine("02 Selection Sort");


var arr = new List<int> { 5, 3, 6, 2, 10 };
var arrInt = new int[]{ 5, 3, 6, 2, 10 };

Console.WriteLine("Lista Não Ordenada: " + arr.ToList());
Console.WriteLine("Lista Ordenada: " + string.Join(", ", SelectionSort(arr)));

Console.WriteLine("================================================================");
Console.WriteLine("Lista Ordenada com apenas um loop: " + string.Join(", ", SelectionSortOneLoop(arrInt)));




static int[] SelectionSort(List<int> arr)
{
    int[] newArr = new int[arr.Count];
    for (int i = 0; i < newArr.Length; i++)
    {
        var smallest = FindSmallest(arr);
        newArr[i] = arr[smallest];
        arr.RemoveAt(smallest);
    }
    return newArr;
}

static int FindSmallest(List<int> arr)
{
    var smallest = arr[0];
    var smallestIndex = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] < smallest)
        {
            smallest = arr[i];
            smallestIndex = i;
        }
    }
    return smallestIndex;
}

#region Other Methods
#region SelectionSort Using One Loop
static int[] SelectionSortOneLoop(int[] unorderedArray)
{
    for (var i = 0; i < unorderedArray.Length; i++)
    {
        var smallestIndex = i;

        for (var remainingIndex = i + 1; remainingIndex < unorderedArray.Length; remainingIndex++)
        {
            if (unorderedArray[remainingIndex] < unorderedArray[smallestIndex])
            {
                smallestIndex = remainingIndex;
            }
        }
        (unorderedArray[i], unorderedArray[smallestIndex]) = (unorderedArray[smallestIndex], unorderedArray[i]);
    }

    return unorderedArray;
}
#endregion

#region Selection Sort With Link
static IEnumerable<int> SelectionSortUsingLink(LinkedList<int> list)
{
    var minList = new LinkedList<int>();
    var maxList = new LinkedList<int>();

    while (list.Count != 0)
    {
        var min = list.Min();
        list.Remove(min);
        minList.AddLast(min);

        var max = list.Max();
        list.Remove(max);
        maxList.AddFirst(max);
    }

    return minList.Union(maxList);
}
#endregion
#endregion
