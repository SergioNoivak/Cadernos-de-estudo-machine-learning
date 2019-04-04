
import {No} from "./No"

export class Grafo{

      public  vetor
      public noInicio    

        constructor(){
          this.vetor = {}
        this.noInicio= undefined

        }

        public adicionarVetor(no:No):void{

                this.vetor[no.nome] = no;
        }
    



}