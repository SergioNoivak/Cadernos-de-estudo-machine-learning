

import { Grafo } from './Grafo';
import{No} from "./No"
import * as $ from './jquery';

export class Agente{

    public grafoEstados:Grafo;

    constructor(grafoEstados:Grafo, noInicial:No){
        
        this.grafoEstados  = grafoEstados;

        this.grafoEstados.noInicio = noInicial
    
    }

    public _inicialize_single_source()
    {
        for (var key in this.grafoEstados.vetor) {      
            if (this.grafoEstados.vetor.hasOwnProperty(key)) {

                this.grafoEstados.vetor[key].d = Number.MAX_VALUE
                this.grafoEstados.vetor[key].pi = undefined
                this.grafoEstados.vetor[key].descoberto = false

            }
        }

         this.grafoEstados.noInicio.d = 0
  
  }


  public DFS_visit(){
        let contadorDescobertas =0;

        this._inicialize_single_source()
        let piCorrente = undefined;
        let stack =[];


        stack.push(this.grafoEstados.noInicio.nome);

        while(stack.length!=0){
            let v = stack[stack.length-1];
            stack.splice(stack.length-1,1);
            contadorDescobertas++;

            this.grafoEstados.vetor[v].d = contadorDescobertas

                if(!this.grafoEstados.vetor[v].descoberto){
                        
                this.grafoEstados.vetor[v].descoberto = true;
                
                
                for (var key in this.grafoEstados.vetor[v].Adj) {      
                    if (this.grafoEstados.vetor.hasOwnProperty(key)) {

                        if(!this.grafoEstados[key].descoberto){
                            stack.push(key)
                            this.grafoEstados[key].pi = v

                        }
                    }
                }

            }
            
        
        
        }




  }
  
  

}