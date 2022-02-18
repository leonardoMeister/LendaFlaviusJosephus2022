using System;
using System.Collections.Generic;

namespace LendaFlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero casos de teste: ");
            int casosTeste = Convert.ToInt32(Console.ReadLine());
            List<int> listaResultados = new List<int>();
            
            for (int x=0; x<casosTeste;x++)
            {
                string[] valores = Console.ReadLine().Split();

                int numeroPessoas = Convert.ToInt32(valores[0]);
                int tamanhoPulo = Convert.ToInt32(valores[1]);

                List<int> listaPessoas = new List<int>();

                for(int i = 0; i < numeroPessoas; i++)
                {
                    listaPessoas.Add((i)+1);
                }



                int matador = 0;
                int contadorFila = 0;

                while (1!=listaPessoas.Count)
                {
                    matador++;
                    contadorFila++;

                    if (matador == tamanhoPulo)
                    {
                        matador = 0;
                        listaPessoas.RemoveAt((contadorFila)-1);
                        contadorFila--;
                    }

                    if (contadorFila == listaPessoas.Count)
                    {
                        contadorFila = 0;
                    }

                    //listaPessoas.RemoveAt(contador*tamanhoPulo);
                }

                listaResultados.Add(listaPessoas[0]);
            }

            for (int x=0; x<listaResultados.Count; x++)
            {
                Console.WriteLine($"Caso {(x)+1}: {listaResultados[x]}");
            }
        }
    }
}
