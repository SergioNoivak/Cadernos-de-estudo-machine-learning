using System;
using System.Collections.Generic;


namespace NeighborJoining
{

    class No
    {

       public string nome;
       public Dictionary<string, double> Adj;
       public No(string nome)
        {
            this.nome = nome;
            this.Adj = new Dictionary<string, double>();

        }

        public void addAresta(string noFinal,double peso)
        {
            this.Adj.Add(noFinal, peso);
        }

        public void exibir()
        {

            Console.Write("nome: " + this.nome + "\n Adj:");
            foreach (KeyValuePair<string, double> aresta in this.Adj)
            {
                Console.Write(" noFim: " + aresta.Key+",");
                Console.WriteLine(" peso: : " + aresta.Value+" ");
            }


        }

    }

    class Grafo
    {
        public Dictionary<string, No> vetor;


        public Grafo()
        {
            this.vetor = new Dictionary<string, No>();
        }
        
       public void exibir()
        {

            foreach (KeyValuePair<string, No> no in this.vetor)
            {

                Console.WriteLine("No de nome (" + no.Key + ") do vetor do Grafo");
                Console.WriteLine("_");
                no.Value.exibir();
                Console.WriteLine("_");

            }
            Console.WriteLine("Numero de pares: " + this.vetor.Count);
        }

    }
}
