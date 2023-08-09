// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("04 Quicksort!");
var arr = new int[] { 1, 2, 3, 4, 10, 8, 6, 20, 15, 7};

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

#region QuickSort Ordenando
Console.WriteLine("==== QUICK SORT ===== ");
Console.WriteLine(string.Join(", ", QuickSort(arr)));

static IEnumerable<int> QuickSort(IEnumerable<int> list)
{
    if (!list.Any() || list.Count() < 2) return list;

    int pivo = list.First();
    IEnumerable<int> menores = list.Skip(1).Where(i => i <= pivo);
    IEnumerable<int> maiores = list.Skip(1).Where(i => i > pivo);
    return QuickSort(menores).Union(new List<int> { pivo }).Union(QuickSort(maiores));
}

#endregion

#region  Considerações
/*1 - QuickSort consiste em dividir o problema em problema menores
o base case de uma lista será uma lista vazia ou com apenas um item

2 - Escolha um pivo (o ideal é pegar um número central da lista)
Divide a lista em duas
lista maior com numeros maiores que o pivo
lista menor com numeros menores que o pivo

faça a união dessas listas com base na recursividade do quicksort 
o Union utiliza o pivo como numero central para a união dessas list*/
#endregion