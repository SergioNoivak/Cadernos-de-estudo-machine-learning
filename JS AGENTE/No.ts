import { Grafo } from './Grafo';

export class No{

        public Adj;
        public nome
        public descoberto

        
        constructor(nome=-1){
            this.Adj = {}
            this.nome = nome
            this.descoberto = false   
        }
        public adicionarAresta(fim:No,peso:number){

           if(!this.Adj[fim.nome]) 
            this.Adj[fim.nome] = peso;
        }

    


        
    
      
        
}