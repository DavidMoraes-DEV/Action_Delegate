using System;
using DelegateAction.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace DelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * DELEGATE ACTION:
            - Representa um método void que recebe zero ou mais argumentos.
            - Possui 16 sobrecargas:
                - public delegate void Action();
                - public delegate void Action<in T>(T obj);
                - public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
                - public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
                - +12 sobrecargas mudando apenas a quantidade de tipos "T" e de argumentos.
            
            * PROBLEMA EXEMPLO:
            - Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10%.
            */

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; }); // A função .ForEach podemos dizer que é uma função funcional ela recebe um Action como parâmetro de entrada. Nesse caso na função lambda foi necessário colocar "{}" na função para indicar que essa função é do tipo void, ou seja, ela tem uma ação porém não irá retornar nada.
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
