namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> ints = new List<int>(){1, 3, 5, 7, 9};

            Console.WriteLine("The position array contains number 3 is: "+binary_search(ints, 3));
            Console.WriteLine("The position array contains number -1 is: " + binary_search(ints, -1));

        }

        private static int? binary_search(List<int> my_list, int item) {
            int low = 0;
            int high = my_list.Count - 1;

            while(low <= high) {
                int mid = (low + high) / 2;
                int kick = my_list[mid];

                if (kick == item) return mid;
                if (kick > item) high = mid + 1;
                else {
                    low = mid + 1;
                }
            }

            return null;
        }
    }
}

#region Exercícios
    /*1.1 - Suponha que você tenha uma lista com 128 nomes e esteja fazendo uma pesquisa binária. Qual seria o número 
    máximo de etapas que você levaria para encontrar o nome desejado ? 
    Resposta: 7, pois log2 128 = 7... são 7 "divisões" pela metade que chegamos a um único número.

    Se dobrarmos a lista ? Seria 8. Pois log2 256 = 8*/
#endregion
