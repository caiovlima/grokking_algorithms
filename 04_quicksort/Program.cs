// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("04 Quicksort!");
var arr = new int[] { 1, 2, 3, 4};

#region Loop Sum
Console.WriteLine("=====Loop Sum======");
Console.WriteLine(LoopSum(arr));

static int LoopSum(int[] listInt) {
    var sum = 0;
    foreach(var item in listInt) {
        sum = sum + item;
    };

    return sum;
}

#endregion

#region Recursive Sum 
Console.WriteLine("========= RECURSIVE SUM =========");
Console.WriteLine(RecursiveSum(arr));

static int RecursiveSum(IEnumerable<int> list)
{
    if (!list.Any()) return 0;

    return list.Take(1).First() + RecursiveSum(list.Skip(1));
}
#endregion