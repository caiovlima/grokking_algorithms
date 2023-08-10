using System;
using System.Collections.Generic;

Console.WriteLine("Hash Maps!");

#region Conveniencia
Console.WriteLine("====CONVENIENCIA=====");

var livroCaixa = new Dictionary<string, decimal>
{
    { "Energetico", 8.99m },
    { "Chocolatey", 2.00m }
};

livroCaixa.Add("Salgadinho", 5.99m);


foreach (var item in livroCaixa)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
#endregion

#region Checagem de votos
Console.WriteLine("====Checagem de Votos=====");
Dictionary<string, bool> listaDeVotos = new Dictionary<string, bool>();
ChecarVoto("Pam");
ChecarVoto("Tom");

static void ChecarVoto(string name) {
    if (listaDeVotos.ContainsKey(name)){
        Console.WriteLine(name + " Já Votou!");
    }
    else {
        Console.WriteLine(name + " Não Votou! Adicionado voto");
        listaDeVotos.Add(name, true);
    }
}



#endregion


using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static Dictionary<string, bool> _voted = new Dictionary<string, bool>();
        public static void Main(string[] args)
        {
            CheckVoter("tom");
            CheckVoter("mike");
            CheckVoter("mike");
        }

        private static void CheckVoter(string name)
        {
            if (_voted.ContainsKey(name))
            {
                Console.WriteLine("kick them out!");
            }
            else
            {
                _voted.Add(name, true);
                Console.WriteLine("let them vote!");
            }
        }
    }
}
