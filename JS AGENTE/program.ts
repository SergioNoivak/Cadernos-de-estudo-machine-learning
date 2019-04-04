
import {Grafo} from "./Grafo"
import {No} from "./No"
import { Agente } from './Agente';







let grafo = new Grafo();


for(let i=0; i<5;i++){
    
    grafo.adicionarVetor(new No(i))
    
}

for(let i=0; i<5;i++)
{

    for(let j=0; j<5;j++)
    {
        grafo.vetor[i].adicionarAresta(grafo.vetor[j],1)    
        

    }
    
}





let a = new Agente(grafo,grafo.vetor[0]);



a.DFS_visit()




console.log(JSON.stringify(a.grafoEstados))


