using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborJoining
{
    class GrafoFactory
    {


        public static Grafo construirGrafoDesconexo(List<List<double>> matrizDeDistancia, int opcao)
        {
            int ordem = Algoritmos.ordemMatrizQuadrada(matrizDeDistancia);
            Grafo grafo = new Grafo();

            switch (opcao)
            {
                case (int)Organizacao.letras:
                    char caracterLinha = 'a';
                    for (int i = 0; i < ordem; i++)
                    {
                        No noCorrente = new No("" + caracterLinha);
                        grafo.vetor.Add("" + caracterLinha, noCorrente);
                        caracterLinha = (char)((int)caracterLinha + 1);
                    }

                    break;


                case (int)Organizacao.numeros:
                    int numeroLinha = 0;
                    for (int i = 0; i < ordem; i++)
                    {
                        No noCorrente = new No("" + numeroLinha);
                        grafo.vetor.Add("" + numeroLinha, noCorrente);
                        numeroLinha++;
                    }
                    break;
            }

            return grafo;

        }


        public static Grafo construirGrafoPorMatrizDeDistancia(List<List<double>> matrizDeDistancia, int opcao)
        {
            int ordem = Algoritmos.ordemMatrizQuadrada(matrizDeDistancia);
            Grafo grafo = new Grafo();

            switch (opcao)
            {
                case (int)Organizacao.letras:
                    char caracterLinha = 'a';
                    for (int i = 0; i < ordem; i++)
                    {
                        No noCorrente = new No("" + caracterLinha);
                        char caracterColuna = 'a';
                        for (int j = 0; j < ordem; j++)
                        {
                            noCorrente.addAresta("" + caracterColuna, matrizDeDistancia[i][ j]);
                            caracterColuna = (char)((int)caracterColuna + 1);

                        }
                        grafo.vetor.Add("" + caracterLinha, noCorrente);
                        caracterLinha = (char)((int)caracterLinha + 1);
                    }

                    break;


                case (int)Organizacao.numeros:
                    int numeroLinha = 0;
                    for (int i = 0; i < ordem; i++)
                    {
                        No noCorrente = new No("" + numeroLinha);
                        int numeroColuna = 0;
                        for (int j = 0; j < ordem; j++)
                        {
                            noCorrente.addAresta("" + numeroColuna, matrizDeDistancia[i][ j]);
                            numeroColuna++;

                        }
                        grafo.vetor.Add("" + numeroLinha, noCorrente);
                        numeroLinha++;
                    }

                    break;

            }

            return grafo;


        }
    }
}
