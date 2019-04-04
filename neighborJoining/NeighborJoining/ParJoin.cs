using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborJoining
{
    class ParJoin
    {
       public  int inicio          ;
       public  int fim             ;
       public  double pesoMinimo   ;
       public double distanciaInicio;
       public double distanciaFim;
        
    

        public ParJoin()
        {
            this.inicio = this.fim = -1;
            this.pesoMinimo = Double.MaxValue;
            distanciaFim = distanciaInicio = -1;
        }

        public ParJoin(int inicio,int fim,double pesoMinimo)
        {
            this.inicio = inicio;
            this.fim       =fim       ;
            this.pesoMinimo=pesoMinimo;


        }


        public void exibir()
        {

            Console.WriteLine("{inicio: " + inicio + " ,fim: " + fim + " ,pesoMinimo: " + this.pesoMinimo+"}");


        }
    }
}
