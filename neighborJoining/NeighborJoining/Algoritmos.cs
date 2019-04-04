using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborJoining
{
    class Algoritmos
    {



        public static void adicionarNovoNo(List<List<double>> matrizDistancia, List<double> linhaNovoNo)
        {


            int i = 0;
            foreach(var linha in matrizDistancia)
            {
                linha.Insert(0, linhaNovoNo[i + 1]);
                i++;
            }

            matrizDistancia.Insert(0, linhaNovoNo);

            Algoritmos.imprimirMatriz(matrizDistancia);

        }


        public static void calcularDistanciaPar(List<List<double>> matrizDistancia,ParJoin par)
        {
            double distanciaInicio,distanciaFim;
            par.distanciaInicio = 0.5 * matrizDistancia[par.inicio][par.fim] + 1 / (2 * (matrizDistancia.Count - 2)*(calculoFatorDistanciaLinha(matrizDistancia,matrizDistancia.Count,par.inicio)-calculoFatorDistanciaLinha(matrizDistancia,matrizDistancia.Count,par.fim)));
            par.distanciaFim = matrizDistancia[par.inicio][par.fim] - par.distanciaInicio;

        }


        public static List<double> calcularDistanciaNaoPar(List<List<double>> matrizDistancia, ParJoin par)
        {
            List<double> linhaNovoNo = new List<double>();
            linhaNovoNo.Add(0.0);
            for(int i=0; i< matrizDistancia.Count;i++)
            {
                if (i != par.inicio && i != par.fim)
                {
                    double distancia = 0.5 * (matrizDistancia[par.inicio][i] + matrizDistancia[par.fim][i] - matrizDistancia[par.inicio][par.fim]);
                    linhaNovoNo.Add(distancia);
                }
            }
            return linhaNovoNo;
        }




        public static void removerPar(List<List<double>> matrizDistancia, ParJoin par)
        {
            imprimirMatriz(matrizDistancia);
            Console.WriteLine();

            var ponteiroElementoInicioLinha = matrizDistancia.ElementAt(par.inicio);
            var ponteiroElementoFimLinha = matrizDistancia.ElementAt(par.fim);

            matrizDistancia.Remove(ponteiroElementoInicioLinha);
            matrizDistancia.Remove(ponteiroElementoFimLinha);

            foreach (var linha in matrizDistancia)
            {
                var ponteiroElementoInicioColuna = linha.ElementAt(par.inicio);
                var ponteiroElementoFimColuna = linha.ElementAt(par.fim);

                linha.Remove(ponteiroElementoInicioColuna);
                linha.Remove(ponteiroElementoFimColuna);
            }



        }

        public static int ordemMatrizQuadrada(List<List<double>> matrizDistancia)
        {

            return Convert.ToInt32(Math.Sqrt(matrizDistancia.Count));
        }

        private static double calculoFatorDistanciaLinha(List<List<double>> matrizDistancia,int n, int linha)
        {
            double soma = 0;

            foreach(var elementoColuna in matrizDistancia[linha])
            {
                soma += elementoColuna;

            }

            
            return soma;

        }

        private static double calculoFatorDistanciaColuna(List<List<double>> matrizDistancia, int n, int coluna)
        {
            double soma = 0;
            for (int i = 0; i < n; i++)
                soma += matrizDistancia[i][coluna];
            return soma;

        }



        public static List<List<double>> calculoMatrizQ(List<List<double>> matrizDistancia)
        {
            int ordem =matrizDistancia.Count;

            Console.WriteLine(ordem);
            List<List<double>> matrizQ  = new List<List<double>>();

            for(int i = 0; i < ordem; i++)
            {
                List<double> linha = new List<double>();
                for (int j =0; j < ordem; j++)
                {

                linha.Add( (ordem - 2) * matrizDistancia[i][j] - calculoFatorDistanciaLinha(matrizDistancia, ordem, i) - calculoFatorDistanciaColuna(matrizDistancia, ordem, j));

                }
                matrizQ.Add(linha);
            }
            return matrizQ;
        }

        public static ParJoin parMinimo(List<List<double>> matrizQ)
        {
            int ordem = matrizQ.Count;
            ParJoin parjoin = new ParJoin();

            for (int i = 0; i < ordem; i++)
            {
                int j = i + 1;
                while (j < ordem)
                {
                    if (parjoin.pesoMinimo > matrizQ[i][ j])
                    {
                        parjoin.inicio = i;
                        parjoin.fim = j;
                        parjoin.pesoMinimo = matrizQ[i][ j];
                    }
                    j++;
                }
            }
            return parjoin;
        }


        public static void distanciaNovoParentesco(List<List<double>> matrizDistancia,int no,int antecessor)
        {
            
            //double distancia = 1/2*(matrizDistancia[])


        }



        public static void imprimirMatriz(List<List<double>> matriz)
        {


            foreach (var linha in matriz)
            {

                foreach (var x in linha)
                {

                    Console.Write(x + " ");

                }

                Console.WriteLine();

            }

        }



    }
}
